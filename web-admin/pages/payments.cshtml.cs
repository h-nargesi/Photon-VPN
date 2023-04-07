namespace Photon.Service.VPN.Pages;

public class PaymentsPage : RegularView
{
    public const string TITLE = "Payments";
    public const string ICON = "fas fa-money-check";
    public const float ORDER = 3;

    public override string PageTitle => TITLE;
    public override string EditPage => string.Empty;
}
