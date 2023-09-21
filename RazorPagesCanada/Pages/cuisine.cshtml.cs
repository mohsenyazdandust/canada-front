using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorPagesCuisine.Models;
namespace RazorPagesCanada.Pages;

public class CuisineModel : PageModel
{
    private readonly ILogger<CuisineModel> _logger;
    public  readonly DataBaseContext _db ;
    public List<Cuisine> cuisineList;

    public CuisineModel(ILogger<CuisineModel> logger , DataBaseContext db)
    {
        _logger = logger;
        _db = db;
    }

    public void OnGet()
    {
            cuisineList = _db.Cuisines.ToList();
    }
}
