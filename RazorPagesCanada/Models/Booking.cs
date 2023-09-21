using RazorPagesCanada.Models;

namespace RazorPagesBooking.Models;

public class Bookinig
{
    public int id {get;set;}
    public string name{get;set;}
    public string email{get;set;}
    public string checkin{get;set;}
    public string checkout{get;set;}
    public string guests{get;set;}

    public string acc {get;set;}
    
    


    public Bookinig(string name, string email, string checkin, string checkout, string guests ,string acc)
    {
        this.name = name;
        this.email = email;
        this.checkin = checkin;
        this.checkout = checkout;
        this.guests = guests;
        this.acc = acc;
    }




}