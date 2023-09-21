using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorPagesContact.Models;
using RazorPagesCuisine.Models;
namespace RazorPagesCanada.Pages;

public class ContactModel : PageModel
{
    private readonly ILogger<ContactModel> _logger;
    public  readonly DataBaseContext _db ;

    [BindProperty]
    public string name {get;set;}
    [BindProperty]
    public string email {get;set;}
    [BindProperty]
    public string subject {get;set;}
    [BindProperty]
    public string message {get;set;}

    public Contact contact {get;set;}

    public ContactModel(ILogger<ContactModel> logger , DataBaseContext db)
    {
        _logger = logger;
        _db = db;
    }

    public void OnGet()
    {
    }

       public  void OnPost()
        {
            contact = new Contact(name , email , subject , message); 
            _db.Add(contact);
            _db.SaveChanges();
            
    

        }
}
