namespace Photon.Service.VPN.Pages
{
    public class IndexPage : RegularView
    {
        public const string TITLE = "Dashbord";
        public const string ICON = "fas fa-tachometer-alt";
        public const float ORDER = 1;

        public override string PageTitle => TITLE;
    }
}
