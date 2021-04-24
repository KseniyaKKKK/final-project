using System;
using Microsoft.AspNetCore.Identity;

namespace Kursach.Models
{
    public class User : IdentityUser
    {
        public string Name { get; set; }
    }
}