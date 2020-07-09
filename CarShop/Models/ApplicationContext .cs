using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarShop.Models
{
    public class ApplicationContext : DbContext
    {
        public DbSet<Admin> Admin { get; set; }
        public DbSet<CarMaker> CarMakers { get; set; }
        public DbSet<CarModel> CarModels { get; set; }
        public ApplicationContext(DbContextOptions<ApplicationContext> options)
            : base(options)
        {
        }
    }
}
