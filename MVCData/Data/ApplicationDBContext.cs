using MVCData.Models;
using Microsoft.EntityFrameworkCore;
using MVCData.ViewModels;
using System.Reflection.Emit;
using MVCData.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace MVCData.Data
{
    public class ApplicationDBContext :IdentityDbContext<ApplicationUser>
    {
        public ApplicationDBContext()
        {

        }
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options)
            :base(options)
        {

        }


        public DbSet<Person> People => Set<Person>();

        public DbSet<City> Cities => Set<City>();

        public DbSet<Country> Countries => Set<Country>();

      

        protected override void OnModelCreating(ModelBuilder modelbuilder)
        {
            base.OnModelCreating(modelbuilder);

            // country
            modelbuilder.Entity<Country>().HasData(new Country { ID = 1, Name = "China" });
            modelbuilder.Entity<Country>().HasData(new Country { ID = 2, Name = "USA" });
            modelbuilder.Entity<Country>().HasData(new Country { ID = 3, Name = "Sweden" });

            // City
            modelbuilder.Entity<City>().HasData(new { ID = 1, Name = "Peking", CountryID = 1 });
            modelbuilder.Entity<City>().HasData(new { ID = 2, Name = "NewYork", CountryID = 2 });
            modelbuilder.Entity<City>().HasData(new { ID = 3, Name = "Gothenburg", CountryID = 3 });

           


            modelbuilder.Entity<Person>().HasData(new { ID = 1, Name = "Tony", Phone = "123289",CityID = 1 });
       
            modelbuilder.Entity<Person>().HasData(new { ID = 2, Name = "Tony Stark", Phone = "12345", CityID = 2 });
            modelbuilder.Entity<Person>().HasData(new { ID = 3, Name = "Captain America", Phone = "3213213", CityID = 2 });
            modelbuilder.Entity<Person>().HasData(new { ID = 4, Name = "KrallLexicon", Phone = "78998554", CityID = 3 });


            string adminRoleId = Guid.NewGuid().ToString();
            string userRoleId = Guid.NewGuid().ToString();
            string userId = Guid.NewGuid().ToString();

            modelbuilder.Entity<IdentityRole>().HasData(
               new IdentityRole
               {
                   Id = adminRoleId,
                   Name = "Admin",
                   NormalizedName = "ADMIN"
               });
            modelbuilder.Entity<IdentityRole>().HasData(
              new IdentityRole
              {
                  Id = userRoleId,
                  Name = "User",
                  NormalizedName = "USER"
              });

            PasswordHasher<ApplicationUser> hasher = new PasswordHasher<ApplicationUser>();

            modelbuilder.Entity<ApplicationUser>().HasData(new ApplicationUser
            {
                Id = userId,
                Email = "admin@admin.com",
                NormalizedEmail = "ADMIN@ADMIN.COM",
                UserName = "admin@admin.com",
                NormalizedUserName = "ADMIN@ADMIN.COM",
                FirstName = "Admin",
                LastName = "Adminsson",
                DateOfBirth = "20221209",
                PasswordHash = hasher.HashPassword(null, "password")
            });

            modelbuilder.Entity<IdentityUserRole<string>>().HasData(new IdentityUserRole<string>
            {
                RoleId = adminRoleId,
                UserId = userId
            });



        }
    }
}
