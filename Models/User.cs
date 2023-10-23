using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ThetaShop.Models
{
    public partial class User
    {
        public int Id { get; set; }
        public string UserName { get; set; } = null!;
        [StringLength(8)]
        public string Password { get; set; } = null!;
        [Required]
        public string Email { get; set; } = null!;
       
        public string? Role { get; set; }
        public int? RetryAttempts { get; set; }
        public bool? IsActivated { get; set; }
        public bool? IsLocked { get; set; }
        public DateTime? DeactivatedDateTime { get; set; }
        public DateTime? LockedDateTime { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? LastLogin { get; set; }
        public string? SecretQuestion { get; set; }
        public string? SecretAnwser { get; set; }
    }
}
