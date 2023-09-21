using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RazorPagesCuisine.Models;

namespace RazorPagesCanada;

public class AboutModel : PageModel
{
    private readonly ILogger<AboutModel> _logger;
    public  readonly DataBaseContext _db ;
    public List<Cuisine> cuisineList;

    public AboutModel(ILogger<AboutModel> logger , DataBaseContext  db)
    {
        _logger = logger;
        _db = db ;
    }

    public void OnGet()
    {
       cuisineList = _db.Cuisines.ToList();
    }
}
