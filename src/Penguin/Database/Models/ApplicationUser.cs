using Microsoft.AspNetCore.Identity;
using System;

namespace Penguin.Database.Models
{
    public class ApplicationUser : IdentityUser
    {
        public Guid ExternalId { get; set; } = Guid.NewGuid();
    }
}