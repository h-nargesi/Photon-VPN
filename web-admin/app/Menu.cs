namespace Photon.Service.VPN.Basical
{
    public class Menu
    {
        public Dictionary<string, Menu> items { get; } = new Dictionary<string, Menu>();

        public Menu(string title)
        {
            Title = title;
        }

        public string Title { get; private set; }
        public string? Icon { get; private set; }
        public string? Url { get; private set; }
        public float Order { get; private set; } = 100;

        public IEnumerable<Menu> Items
        {
            get => items.Values.OrderBy(c => c.Order).ThenBy(c => c.Title).ToArray();
        }
        public int ItemsCount => items.Count;

        public void GetSubPages(string page, IEnumerable<string> path)
        {
            var point = path.First();
            path = path.Skip(1);

            if (!items.TryGetValue(point, out var item))
            {
                items.Add(point, item = new Menu(point));
            }

            if (path.Count() > 0)
            {
                item.GetSubPages(page, path);
            }
            else if (item.Url == null)
            {
                item.Url = page;

                var type = Type.GetType($"Photon.Service.VPN.Pages.{point}Page");
                if (type == null)
                {
                    return;
                }

                item.Title = type.GetField("TITLE")?.GetValue(null)?.ToString() ?? item.Title;
                item.Icon = type.GetField("ICON")?.GetValue(null)?.ToString();
                item.Order = (float?)type.GetField("ORDER")?.GetValue(null) ?? item.Order;
            }
        }
    }
}