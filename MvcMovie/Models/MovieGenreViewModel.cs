using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;

namespace MvcMovie.Models;

public class MovieGenreViewModel
{
    public List<Movie>? Movies { get; set; }
    public SelectList? Genres { get; set; }
    public string? MovieGenre { get; set; }
    public string? SearchString { get; set; }
}

public class MovieFilterViewModel
{
    public List<Movie>? Movies { get; set; }
    public SelectList? Genres { get; set; }    
    public int? FilterYear { get; set; } // Year filter
    public string? SearchString { get; set; }

}