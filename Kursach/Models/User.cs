using System;
using Microsoft.AspNetCore.Identity;

namespace Kursach.Models
{
    public class User : IdentityUser
    {
        public string Name { get; set; }
        public StatusType Status { get; set; }
    }

    public enum StatusType
    {
        Unblocked,
        Blocked
    }
}