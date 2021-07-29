using BarberShop.Models.Contacts;
using BarberShop.Models.HomePageDescr;
using BarberShop.Models.ServicesAndPrice;
using Microsoft.EntityFrameworkCore;

namespace BarberShop.Context
{
    public class BarberShopDB : DbContext
    {
        public BarberShopDB(DbContextOptions<BarberShopDB> options) 
            :base(options)
        {

        }
        public DbSet<Service> Service { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<HomePageDescription> HomePageDescriptions { get; set; }
    }
}
