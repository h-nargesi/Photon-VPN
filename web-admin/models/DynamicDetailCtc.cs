using System;
using System.Collections.Generic;

namespace Photon.Service.VPN.Models;

public partial class DynamicDetailCtc
{
    public int Id { get; set; }

    public int? DynamicDetailId { get; set; }

    public bool ConnectCheck { get; set; }

    public string ConnectUsername { get; set; } = null!;

    public string ConnectSuffix { get; set; } = null!;

    public int ConnectDelay { get; set; }

    public bool ConnectOnly { get; set; }

    public bool CustInfoCheck { get; set; }

    public int CiResupplyInterval { get; set; }

    public bool CiFirstName { get; set; }

    public bool CiFirstNameRequired { get; set; }

    public bool CiLastName { get; set; }

    public bool CiLastNameRequired { get; set; }

    public bool CiEmail { get; set; }

    public bool CiEmailRequired { get; set; }

    public bool CiEmailOptIn { get; set; }

    public string CiEmailOptInTxt { get; set; } = null!;

    public bool CiGender { get; set; }

    public bool CiGenderRequired { get; set; }

    public bool CiBirthday { get; set; }

    public bool CiBirthdayRequired { get; set; }

    public bool CiCompany { get; set; }

    public bool CiCompanyRequired { get; set; }

    public bool CiAddress { get; set; }

    public bool CiAddressRequired { get; set; }

    public bool CiCity { get; set; }

    public bool CiCityRequired { get; set; }

    public bool CiCountry { get; set; }

    public bool CiCountryRequired { get; set; }

    public bool CiPhone { get; set; }

    public bool CiPhoneRequired { get; set; }

    public bool CiPhoneOptIn { get; set; }

    public string CiPhoneOptInTxt { get; set; } = null!;

    public bool CiRoom { get; set; }

    public bool CiRoomRequired { get; set; }

    public bool CiCustom1 { get; set; }

    public bool CiCustom1Required { get; set; }

    public string CiCustom1Txt { get; set; } = null!;

    public bool CiCustom2 { get; set; }

    public bool CiCustom2Required { get; set; }

    public string CiCustom2Txt { get; set; } = null!;

    public bool CiCustom3 { get; set; }

    public bool CiCustom3Required { get; set; }

    public string CiCustom3Txt { get; set; } = null!;

    public DateTime Created { get; set; }

    public DateTime Modified { get; set; }

    public bool CiPhoneOtp { get; set; }

    public bool CiEmailOtp { get; set; }
}
