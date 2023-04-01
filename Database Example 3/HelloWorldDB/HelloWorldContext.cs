using Database_Example_3.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database_Example_3.HelloWorldDB
{
   public class HelloWorldContext : DbContext
    {
        public HelloWorldContext()
        {
        }

        public HelloWorldContext(DbContextOptions<HelloWorldContext> options)
        : base(options)
        {
        }

  

        public DbSet<Persons> Persons { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    => optionsBuilder.UseSqlServer("Server=.;Database=HelloWorld;persist security info=True;Integrated Security=True;TrustServerCertificate=True");
        //("Server=192.168.0.10;Database=HRRAv3_ge-next_preprod;persist security info=True;user id=mzirakashvili;password=maR1Z!;TrustServerCertificate=True");



        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<Persons>(entity =>

        {

            entity.HasKey(e => e.PersonID);

            entity.Property(e => e.LastName).IsRequired();

            entity.Property(e => e.FirstName).IsRequired();

            entity.Property(e => e.Address).IsRequired();

            entity.Property(e => e.City).IsRequired();

        });



        }


    }

}
