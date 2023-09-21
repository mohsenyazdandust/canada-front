using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorPagesAccommodation.Models;
using RazorPagesCuisine.Models;
using RazorPagesDestination.Models;
namespace RazorPagesCanada.Pages;

public class AccommodationModel : PageModel
{
    private readonly ILogger<AccommodationModel> _logger;
    public  readonly DataBaseContext _db ;
    public List<Accommodation> accList;

    public AccommodationModel(ILogger<AccommodationModel> logger , DataBaseContext db)
    {
        _logger = logger;
        _db = db;
    }

   public void OnGet(string destinationid)
    {
        IQueryable<Accommodation> accommodationsQuery = _db.Accommodations;

       if (!string.IsNullOrEmpty(destinationid))
    {
        accList =accommodationsQuery.Where(c => c.destination.id.ToString()==destinationid).ToList();
    }
            

      

        
    }
}
