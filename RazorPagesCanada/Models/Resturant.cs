using Microsoft.Net.Http.Headers;
using RazorPagesCuisine.Models;
using RazorPagesReview.Models;

namespace RazorPagesCanada.Models
{
    public class Resturant
    {
        public int id {get;set;}
        public string name {get; set ;}

        public string location {get;set;}

        public string CuisineType {get;set;}

        public  List<Review> reviews {get;set;}

        public List<Cuisine> relatedCuisines {get ; set;}

        public string photoAddress{get;set;}
    }
}