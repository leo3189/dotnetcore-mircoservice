﻿namespace IdentityApi.Models
{
    public class ApplicationUser : IdentityUser 
    {
        [Required]
        public string Name { get; set; }
        [Required]
        public string LastName { get; set; }
    }
}
