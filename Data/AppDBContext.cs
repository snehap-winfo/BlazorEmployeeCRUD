using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using BlazorEmployeeCRUD.Models;

namespace BlazorEmployeeCRUD.Data
{
    public class AppDBContext : DbContext
    {
        public AppDBContext (DbContextOptions<AppDBContext> options)
            : base(options)
        {
        }

        public DbSet<Employee> Employee { get; set; } = default!;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Employee>().Property(e=>e.Id).UseIdentityAlwaysColumn().HasIdentityOptions(startValue:100,incrementBy:1);

            modelBuilder.Entity<Employee>().Property(e => e.Status).HasDefaultValue(true).ValueGeneratedOnAdd();

            modelBuilder.Entity<Employee>().Property(e => e.DOB).HasColumnType("date");
        }
    }
}
