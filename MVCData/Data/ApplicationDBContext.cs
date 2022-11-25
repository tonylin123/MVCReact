using MVCData.Models;
using Microsoft.EntityFrameworkCore;
using MVCData.ViewModels;

namespace MVCData.Data
{
    public class ApplicationDBContext :DbContext
    {
        public ApplicationDBContext()
        {

        }
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options)
            :base(options)
        {

        }

        public DbSet<Person> People { get; set; }
       

        protected override void OnModelCreating(ModelBuilder modelbuilder)
        {
            base.OnModelCreating(modelbuilder);

            var personId = Guid.NewGuid().ToString();

            modelbuilder.Entity<Person>().HasData(new Person { Id = personId, Name = "Jake Paul", Phone = "123289", City = "ManCity" });
            modelbuilder.Entity<Person>().HasData(new Person { Id = Guid.NewGuid().ToString(), Name = "Tony Stark", Phone = "12345", City = "Gothenburg" });
            modelbuilder.Entity<Person>().HasData(new Person { Id = Guid.NewGuid().ToString(), Name = "Captain America", Phone = "3213213", City = "NewYork" });






        }
    }
}
