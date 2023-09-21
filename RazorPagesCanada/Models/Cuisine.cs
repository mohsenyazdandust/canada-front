using System.ComponentModel.DataAnnotations;
using RazorPagesCanada.Models;
namespace RazorPagesCuisine.Models;
public class Cuisine
{
    public int id { get; set; }
    public string title { get; set; }
    public string description { get; set; }
    public string preparation  { get; set; }
    public string culturalSignificance {get;set;}
    public string pictureAddress {get;set;}

    public List<Resturant> recommandedResturants {get;set;}
}