using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoniFlex.Models
{
    [Index(nameof(User.Email), IsUnique = true)]
    public partial class User : IdentityUser
    {
        [Required]
        [JsonProperty("name")]
        [StringLength(maximumLength: 40, ErrorMessage = "name is too long")]
        public string Name { get; set; }

        [JsonProperty("address")]
        public string? Address { get; set; }

        [JsonProperty("verified_nin")]
        public bool? VerifiedNIN {  get; set; } = false;
        [JsonProperty("verified_bvn")]
        public bool? VerifiedBVN { get; set; } = false;

        public DateTime? passwordChangedAt { get; set; }

        public string? passwordResetToken { get; set; }

        public bool? active { get; set; } = true;

        [Required]
        public string refCode { get; set; }

        [JsonProperty("created_at")]
        public DateOnly? CreatedAt { get; set; } = DateOnly.FromDateTime(DateTime.UtcNow);

        [JsonProperty("updated_at")]
        public DateTime? UpdatedAt { get; set; } = DateTime.UtcNow;
    }
}
