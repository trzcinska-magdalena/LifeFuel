using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LifeFuel.Models
{
    public class ApplicationUser : IdentityUser
    {
        [InverseProperty("User")]
        public UserProfile UserProfile { get; set; } = null!;
    }
}
