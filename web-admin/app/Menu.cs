using Serilog;

namespace Photon.Service.VPN.Basical
{
    public class Menu
    {
        private readonly string name;
        private string? title;
        public Dictionary<string, Menu> items { get; } = new Dictionary<string, Menu>();

        public Menu(string name, string? title = null)
        {
            this.name = name;
            this.title = title;
        }

        public string Title => title ?? name;
        public string? Icon { get; private set; }
        public string? Url { get; private set; }
        public float Order { get; private set; } = 100;

        public IEnumerable<Menu> Items
        {
            get => items.Values.OrderBy(c => c.Order).ThenBy(c => c.Title).ToArray();
        }
        public int ItemsCount => items.Count;

        public void AddChild(string link, IEnumerable<string> path)
        {
            var name = path.First();
            path = path.Skip(1);

            if (!items.TryGetValue(name, out var item))
            {
                items.Add(name, item = new Menu(name));
            }

            if (path.Count() > 0)
            {
                item.AddChild(link, path);
            }
            else
            {
                if (Url != null)
                {
                    AddList();
                }

                if (item.Url == null)
                {
                    item.SetLink(link);
                }
            }
        }

        private void AddList()
        {
            if (items.ContainsKey("list"))
            {
                return;
            }

            items.Add("list", new Menu(name, "List")
            {
                Url = Url,
                Icon = "fas fa-list",
                Order = 0,
            });
        }

        private void SetLink(string link)
        {
            var type = Type.GetType($"Photon.Service.VPN.Pages.{name}Page");
            if (type == null)
            {
                return;
            }

            var show_in_menu = (bool?)type.GetField("SHOW_IN_MENU")?.GetValue(null) ?? true;
            if (!show_in_menu)
            {
                return;
            }

            Url = link;

            title = type.GetField("TITLE")?.GetValue(null)?.ToString() ?? title;
            Icon = type.GetField("ICON")?.GetValue(null)?.ToString();
            Order = (float?)type.GetField("ORDER")?.GetValue(null) ?? Order;
        }
    }
}