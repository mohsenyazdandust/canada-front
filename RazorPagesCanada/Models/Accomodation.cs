using RazorPagesCanada.Models;
using RazorPagesDestination.Models;

namespace RazorPagesAccommodation.Models;

public class Accommodation
{
public int id {get;set;}
public string name{get;set;}

public string description{get;set;}
public string priceRange{get;set;}
public Destination destination{get;set;}

public string pictureAddress {get;set;}

public int starRating{get;set;}


}