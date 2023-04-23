using System;
using System.Collections.Generic;

namespace Photon.Service.VPN.Models;

public partial class User
{
    public int Id { get; set; }

    public string Username { get; set; } = null!;

    public string Password { get; set; } = null!;

    public Guid? Token { get; set; }

    public string Name { get; set; } = null!;

    public string Surname { get; set; } = null!;

    public string Address { get; set; } = null!;

    public string Phone { get; set; } = null!;

    public string Email { get; set; } = null!;

    public bool Active { get; set; }

    public int? CountryId { get; set; }

    public int GroupId { get; set; }

    public int? LanguageId { get; set; }

    public DateTime Created { get; set; }

    public DateTime Modified { get; set; }

    public int? TimezoneId { get; set; }

    public virtual ICollection<PermanentUserLog> PermanentUserLogs { get; } = new List<PermanentUserLog>();

    public virtual ICollection<UsersAccess> UsersAccesses { get; } = new List<UsersAccess>();
}
