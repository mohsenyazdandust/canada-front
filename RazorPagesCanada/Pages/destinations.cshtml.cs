using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorPagesDestination.Models;
namespace RazorPagesCanada.Pages;

public class DestinationsModel : PageModel
{
    private readonly ILogger<DestinationsModel> _logger;
    private readonly DataBaseContext _db ; 
    public List<Destination> destinations;
    public DestinationsModel(ILogger<DestinationsModel> logger , DataBaseContext db)
    {
        _logger = logger;
        _db = db;
    }

  public void OnGet(string searchTerm )
{
    IQueryable<Destination> destinationsQuery = _db.Destinations;

    if (!string.IsNullOrEmpty(searchTerm))
    {
        destinationsQuery = destinationsQuery.Where(c => c.name.Contains(searchTerm)|| c.regions.Contains(searchTerm)||
        c.activities.Contains(searchTerm));
    }
    destinations = destinationsQuery.ToList();
}

}
