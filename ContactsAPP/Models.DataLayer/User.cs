using System;
using System.Collections.Generic;

namespace ContactsAPP.Models.DataLayer;

public partial class User
{
    public int Id { get; set; }

    public string? Username { get; set; }

    public string? Password { get; set; }

    public virtual ICollection<Person> People { get; set; } = new List<Person>();
}
