using System.Reflection.Metadata;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorPagesCuisine.Models;
using RazorPagesDestination.Models;
namespace RazorPagesCanada.Pages;

public class DestDetailsModel : PageModel
{
    private readonly ILogger<DestDetailsModel> _logger;
    public  readonly DataBaseContext _db ;
    public Destination destination ; 
    public List<string> gallery ;

    public DestDetailsModel(ILogger<DestDetailsModel> logger , DataBaseContext db)
    {
        _logger = logger;
        _db = db;
    }

    public void OnGet(string destinationid)
    {
        destination  = _db.Destinations.FirstOrDefault(c => c.id.ToString() == destinationid);
        gallery = destination.GalletyAddress.Split("|").ToList();
    }
}
