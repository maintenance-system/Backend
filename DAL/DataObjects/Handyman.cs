using System;
using System.Collections.Generic;

namespace DAL.DataObjects;

public partial class Handyman
{
    public int Id { get; set; }

    public string FirstName { get; set; } = null!;

    public string LastName { get; set; } = null!;

    public int City { get; set; }

    public string PhoneNumber { get; set; } = null!;

    public string EmailAddress { get; set; } = null!;

    public string PasswordLogin { get; set; } = null!;

    public virtual City CityNavigation { get; set; } = null!;
}
