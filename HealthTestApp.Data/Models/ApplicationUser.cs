using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace HealthTestApp.Data.Models;

// Add profile data for application users by adding properties to the ApplicationUser class
public class ApplicationUser : IdentityUser<Guid>
{
    public ApplicationUser()
    {
        Id = Guid.NewGuid();
    }

    [Required]
    [Comment("The user's profile picture")]
    // The profile picture is required because every user must have one 
    // If the user doesn't have a profile picture, a default profile picture will be used
    public required string ProfilePicture { get; set; }

    [Required]
    [Comment("When was the user created")]
    public DateTime CreatedOn { get; set; } = DateTime.Now;

    [Required]
    [Comment("When did the user last log in")]
    public DateTime LastLogin { get; set; }
}

