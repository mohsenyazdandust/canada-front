using System.ComponentModel.DataAnnotations;
using RazorPagesAccommodation.Models;
using RazorPagesCanada.Models;
namespace RazorPagesDestination.Models;

 public class Destination
{
   
    
    public int id { get; set; }
    public string name { get; set; }
    public string description { get; set; }
    public string moreDetails { get; set; }
    public string pictureAddress {get;set;}
    public string activities {get;set;}
    public string regions {get;set;}

    public List<Accommodation> accommodations{get;set;}

    public String GalletyAddress {get;set;}

    
}
