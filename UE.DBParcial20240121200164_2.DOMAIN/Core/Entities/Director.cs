using System;
using System.Collections.Generic;

namespace UE.DBParcial20240121200164_2.DOMAIN.Core.Entities;

public partial class Director
{
    public int Id { get; set; }

    public string? FullName { get; set; }

    public string? Country { get; set; }

    public string? Biography { get; set; }
}
