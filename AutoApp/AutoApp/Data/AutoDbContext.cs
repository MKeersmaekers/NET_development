using AutoApp.Models;
using Microsoft.EntityFrameworkCore;

namespace AutoApp.Data
{
    public class AutoDbContext : DbContext
    {
        //CONSTRUCTOR, NEEMT OVER VAN BASE OPTIONS
        public AutoDbContext(DbContextOptions<AutoDbContext> options) : base(options) 
        {

        }
        public DbSet<Auto> Autos { get; set; }
        public DbSet<Merk> Merken { get; set; }


    }
}
