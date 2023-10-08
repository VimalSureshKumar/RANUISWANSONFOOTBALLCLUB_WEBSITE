using Microsoft.AspNetCore.Components.Forms;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;

namespace RANUISWANSONFOOTBALLCLUB_WEBSITE.Data
{
    public class User : IdentityUser
    {
        [NotMapped]
        public required string FirstName { get; set; }
        [NotMapped]
        public required string LastName { get; set; }
    }
}