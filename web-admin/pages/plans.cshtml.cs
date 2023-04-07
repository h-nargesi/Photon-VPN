namespace Photon.Service.VPN.Pages;

public class PlansPage : RegularView
{
    public const string TITLE = "Plans";
    public const string ICON = "fas fa-cubes";
    public const float ORDER = 4;

    public override string PageTitle => TITLE;
    public override string EditPage => "/plans";
}
