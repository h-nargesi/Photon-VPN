using System.Buffers.Binary;
using System.Security.Cryptography;
using System.Text;

namespace Photon.Service.VPN.App;

public class TokenService
{
    private const string password = "7&5P(gTf4Gh(C5(*", token_title = "x-token";

    public class TokenServer
    {
        private HashSet<Guid> requests_guid = new(), requests_guid_1024 = new();

        public async Task<int> CheckHttpRequest(HttpRequestMessage request)
        {
            if (!request.Headers.Contains(token_title))
            {
                throw new Exception("Bad request token (without token)");
            }

            var token = request.Headers.GetValues(token_title).FirstOrDefault();

            if (string.IsNullOrWhiteSpace(token))
            {
                throw new Exception("Bad request token (empty token)");
            }

            var token_item = DecryptToken(token).Split(',');

            var guid = Guid.Parse(token_item[0]);
            if (requests_guid.Contains(guid) || requests_guid_1024.Contains(guid))
            {
                throw new Exception($"Bad request token (guid: {guid})");
            }
            else
            {
                requests_guid.Add(guid);
                if (requests_guid.Count > 1024)
                {
                    requests_guid_1024 = requests_guid;
                    requests_guid = new HashSet<Guid>();
                }
            }

            if (token_item[2] != request.RequestUri?.ToString())
            {
                throw new Exception($"Bad request token (url: {request.RequestUri}/{token_item[2]})");
            }

            var content = request.Content == null ? string.Empty : await request.Content.ReadAsStringAsync();
            content = HashSha256(content);

            if (token_item[3] != content)
            {
                throw new Exception($"Bad request token (content: \n{token_item[3]}\n{content})");
            }

            return int.Parse(token_item[1]);
        }

    }

    public class TokenClient
    {
        public void SignHttpRequest(HttpRequestMessage request, int user_id)
        {
            var guid = Guid.NewGuid().ToString();
            var url = request.RequestUri?.ToString() ?? string.Empty;
            var data = request.Content?.ToString() ?? string.Empty;

            var token = string.Join(",", guid, user_id, url, HashSha256(data));
            request.Headers.Add(token_title, EncryptToken(token));
        }
    }

    private static string EncryptToken(string token)
    {
        // Get bytes of plaintext/password string
        var key_bytes = GetPasswordInBytes();
        var plain_bytes = Encoding.UTF8.GetBytes(token);

        // Get parameter sizes
        var nonce_size = AesGcm.NonceByteSizes.MaxSize;
        var tag_size = AesGcm.TagByteSizes.MaxSize;
        var cipher_size = plain_bytes.Length;

        // We write everything into one big array for easier encoding
        var encrypted_data_length = 4 + nonce_size + 4 + tag_size + cipher_size;
        var encrypted_data = encrypted_data_length < 1024 ? stackalloc byte[encrypted_data_length] : new byte[encrypted_data_length].AsSpan();

        // Copy parameters
        BinaryPrimitives.WriteInt32LittleEndian(encrypted_data[..4], nonce_size);
        BinaryPrimitives.WriteInt32LittleEndian(encrypted_data.Slice(4 + nonce_size, 4), tag_size);
        var nonce = encrypted_data.Slice(4, nonce_size);
        var tag = encrypted_data.Slice(4 + nonce_size + 4, tag_size);
        var cipher_bytes = encrypted_data.Slice(4 + nonce_size + 4 + tag_size, cipher_size);

        // Generate secure nonce
        RandomNumberGenerator.Fill(nonce);

        // Encrypt
        using var aes = new AesGcm(key_bytes);
        aes.Encrypt(nonce, plain_bytes.AsSpan(), cipher_bytes, tag);

        return Convert.ToBase64String(encrypted_data);
    }

    private static string DecryptToken(string cipher)
    {
        // Decode
        var encrypted_data = Convert.FromBase64String(cipher).AsSpan();

        // Extract parameter sizes
        var nonce_size = BinaryPrimitives.ReadInt32LittleEndian(encrypted_data[..4]);
        var tag_size = BinaryPrimitives.ReadInt32LittleEndian(encrypted_data.Slice(4 + nonce_size, 4));
        var cipher_size = encrypted_data.Length - 4 - nonce_size - 4 - tag_size;

        // Extract parameters
        var key_bytes = GetPasswordInBytes();
        var nonce = encrypted_data.Slice(4, nonce_size);
        var tag = encrypted_data.Slice(4 + nonce_size + 4, tag_size);
        var cipher_bytes = encrypted_data.Slice(4 + nonce_size + 4 + tag_size, cipher_size);

        // Decrypt
        var plain_bytes = cipher_size < 1024 ? stackalloc byte[cipher_size] : new byte[cipher_size];
        using var aes = new AesGcm(key_bytes);
        aes.Decrypt(nonce, cipher_bytes, tag, plain_bytes);

        // Convert plain bytes back into string
        return Encoding.UTF8.GetString(plain_bytes);
    }

    private static string HashSha256(string text)
    {
        using var sha256 = SHA256.Create();
        var plain_text = Encoding.UTF8.GetBytes(text);
        var hash_value = sha256.ComputeHash(plain_text);
        return Encoding.UTF8.GetString(hash_value);
    }

    private static byte[] GetPasswordInBytes()
    {
        return Encoding.UTF8.GetBytes(password + DateTime.Now.Date.ToString("yyyy/mm/dd"));
    }
}
