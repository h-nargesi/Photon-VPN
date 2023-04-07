namespace Photon.Service.VPN.Pages
{
    public class UsersPage : RegularView
    {
        public const string TITLE = "Users";
        public const string ICON = "fa fa-users";
        public const float ORDER = 2;

        public override string PageTitle => TITLE;
        public override string EditPage => "/profile";
    }
}
