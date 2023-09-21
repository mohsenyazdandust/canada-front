using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorPagesCanada.Models;
using RazorPagesReview.Models;
using RazorPagesCuisine.Models;
namespace RazorPagesCanada.Pages;

public class ResturantModel : PageModel
{
    private readonly ILogger<ResturantModel> _logger;
    public  readonly DataBaseContext _db ;
    public List<Resturant> resturantList;

    public ResturantModel(ILogger<ResturantModel> logger , DataBaseContext db)
    {
        _logger = logger;
        _db = db;
    }

    public void OnGet(string cuisineId)
    {
        IQueryable<Resturant> resturantsQuery = _db.Resturants;

       if (!string.IsNullOrEmpty(cuisineId))
    {
        resturantsQuery = resturantsQuery.Where(r => r.relatedCuisines.Any(c => c.id.ToString() ==cuisineId));
    }
            
        resturantList = resturantsQuery.ToList();

            foreach (var restaurant in resturantList)
        {
            restaurant.reviews = _db.Reviews.Where(r => r.resturant == restaurant).ToList();
        }

        
    }
}
