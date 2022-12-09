using Microsoft.AspNetCore.Identity;

namespace MVCData.Models
{
    public class ApplicationUser : IdentityUser
    {

        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string DateOfBirth { get; set; }

    }
}
