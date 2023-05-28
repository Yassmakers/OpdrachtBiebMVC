using BiebWebApp.Models;
using Microsoft.AspNetCore.Identity;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;

namespace BiebWebApp.Models
{
    public class User : IdentityUser<int>
    {
        public string Name { get; set; }
        public UserType Type { get; set; } // UserType enum
    }
}
