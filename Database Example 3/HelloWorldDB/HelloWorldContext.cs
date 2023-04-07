using Database_Example_3.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
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
       



        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<Persons>(entity =>

        {

            entity.HasKey(e => e.PersonID);

            entity.Property(e => e.LastName).IsRequired();

            entity.Property(e => e.FirstName).IsRequired();

            entity.Property(e => e.Address).IsRequired();

            entity.Property(e => e.City).IsRequired();


          //  modelBuilder.Entity<Persons>()
          //.Property(p => p.PersonID)
          //.ValueGeneratedOnAdd()
          //.HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

        });



        }


    }

}
