using RazorPagesCanada.Models;

namespace RazorPagesContact.Models;

public class Contact
{
     
    public int id {get;set;}
public string name{get;set;}

public string email{get;set;}
public string subject{get;set;}

public string message{get;set;}
  public Contact(string name, string email, string subject, string message)
        {
            this.name = name;
           this.email = email;
            this.subject = subject;
            this.message = message;
        }



}