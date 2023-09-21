using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorPagesAccommodation.Models;
using RazorPagesBooking.Models;
using RazorPagesCuisine.Models;
namespace RazorPagesCanada.Pages;

public class BookingModel : PageModel
{
    
    private readonly ILogger<BookingModel> _logger;
    public List<Accommodation> accommodations ;
    public  readonly DataBaseContext _db ;
    public string accid ; 

    [BindProperty]
    public string acc  {get;set;}
    [BindProperty]
    public string name {get;set;}
    [BindProperty]
    public string email {get;set;}
    [BindProperty]
    public string phonenumber {get;set;}
    [BindProperty]

    public string  checkin {get;set;}
[BindProperty]
    public string checkout {get;set;}
[BindProperty]
    public string guests {get;set;}

    public Bookinig bookinig {get;set;}

    public BookingModel(ILogger<BookingModel> logger , DataBaseContext db)
    {
        _logger = logger;
        _db = db;
    }

    public void OnGet(string accid)
    {
        this.accid = accid ; 

    }
    public void OnPost(){
        bookinig = new Bookinig(name , email  , checkin , checkout , guests ,acc);
        _db.bookings.Add(bookinig);
        _db.SaveChanges();

    }
}
