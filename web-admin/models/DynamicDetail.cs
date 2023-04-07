using System;
using System.Collections.Generic;

namespace Photon.Service.VPN.Models;

public partial class DynamicDetail
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string IconFileName { get; set; } = null!;

    public string Phone { get; set; } = null!;

    public string Fax { get; set; } = null!;

    public string Cell { get; set; } = null!;

    public string Email { get; set; } = null!;

    public string Url { get; set; } = null!;

    public string StreetNo { get; set; } = null!;

    public string Street { get; set; } = null!;

    public string TownSuburb { get; set; } = null!;

    public string City { get; set; } = null!;

    public string Country { get; set; } = null!;

    public double? Lat { get; set; }

    public double? Lon { get; set; }

    public int? CloudId { get; set; }

    public bool TCCheck { get; set; }

    public string TCUrl { get; set; } = null!;

    public bool RedirectCheck { get; set; }

    public string RedirectUrl { get; set; } = null!;

    public bool SlideshowCheck { get; set; }

    public int SecondsPerSlide { get; set; }

    public bool ConnectCheck { get; set; }

    public string ConnectUsername { get; set; } = null!;

    public string ConnectSuffix { get; set; } = null!;

    public int ConnectDelay { get; set; }

    public bool ConnectOnly { get; set; }

    public DateTime Created { get; set; }

    public DateTime Modified { get; set; }

    public bool? UserLoginCheck { get; set; }

    public bool VoucherLoginCheck { get; set; }

    public bool AutoSuffixCheck { get; set; }

    public string AutoSuffix { get; set; } = null!;

    public bool? UsageShowCheck { get; set; }

    public int UsageRefreshInterval { get; set; }

    public string Theme { get; set; } = null!;

    public bool RegisterUsers { get; set; }

    public bool LostPassword { get; set; }

    public bool SocialEnable { get; set; }

    public int? SocialTempPermanentUserId { get; set; }

    public string CoovaDesktopUrl { get; set; } = null!;

    public string CoovaMobileUrl { get; set; } = null!;

    public string MikrotikDesktopUrl { get; set; } = null!;

    public string MikrotikMobileUrl { get; set; } = null!;

    public string DefaultLanguage { get; set; } = null!;

    public int? RealmId { get; set; }

    public int? ProfileId { get; set; }

    public bool RegAutoSuffixCheck { get; set; }

    public string RegAutoSuffix { get; set; } = null!;

    public bool RegMacCheck { get; set; }

    public bool RegAutoAdd { get; set; }

    public bool RegEmail { get; set; }

    public bool? SlideshowEnforceWatching { get; set; }

    public int SlideshowEnforceSeconds { get; set; }

    public string AvailableLanguages { get; set; } = null!;

    public bool CtcRequireEmail { get; set; }

    public int CtcResupplyEmailInterval { get; set; }

    public int ShowScreenDelay { get; set; }

    public bool? ShowLogo { get; set; }

    public bool? ShowName { get; set; }

    public string NameColour { get; set; } = null!;

    public string? LostPasswordMethod { get; set; }

    public bool CtcPhoneOptIn { get; set; }

    public string CtcPhoneOptInTxt { get; set; } = null!;

    public bool CtcEmailOptIn { get; set; }

    public string CtcEmailOptInTxt { get; set; } = null!;

    public bool ChilliJsonUnavailable { get; set; }

    public bool ChilliUseChap { get; set; }

    public bool RegOtpSms { get; set; }

    public bool RegOtpEmail { get; set; }
}
