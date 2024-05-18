using System;
using System.Collections.Generic;

namespace UE.DBParcial20240121200164_2.DOMAIN.Core.Entities;

public partial class Movie
{
    public int Id { get; set; }

    public string? Title { get; set; }

    public string? Genre { get; set; }

    public string? ReleaseYear { get; set; }
}
