using Microsoft.EntityFrameworkCore;
using RazorPagesAccommodation.Models;
using RazorPagesBooking.Models;
using RazorPagesCanada.Models;
using RazorPagesContact.Models;
using RazorPagesCuisine.Models;
using RazorPagesDestination.Models;
using RazorPagesReview.Models;

namespace RazorPagesCanada
{
    public class DataBaseContext : DbContext
    {
            public DataBaseContext(DbContextOptions<DataBaseContext> options) : base(options)
    {
    }
        public DbSet<Cuisine> Cuisines { get; set; }
        public DbSet<Resturant> Resturants { get; set; }
        public DbSet<Destination> Destinations { get; set; }

        public DbSet<Review> Reviews {get;set;}

        public DbSet<Accommodation> Accommodations {get;set;}

        public DbSet<Contact> contacts {get;set;}

        public DbSet<Bookinig> bookings {get;set;}

        
        

       
    }
}