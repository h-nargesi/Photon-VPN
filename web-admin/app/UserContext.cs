
using Microsoft.EntityFrameworkCore;

namespace Photon.Service.VPN.Models;

public class UsersContext : DbContext
{
    public UsersContext() : base()
    {
    }

    public DbSet<PermanentUser>? PermanentUser { get; set; }
}