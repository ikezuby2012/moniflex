using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MoniFlex.Models
{
    public partial class Wallet
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public string Id { get; set; }
        public string UserId { get; set; }
        [ForeignKey(nameof(UserId))]
        [ValidateNever]
        public User user { get; set; }

        [JsonProperty("previous_balance")]
        public int? prevBalance { get; set; } = 0;

        public int? balance { get; set; } = 0;

        [JsonProperty("created_at")]
        public DateOnly? Date { get; set; } = DateOnly.FromDateTime(DateTime.UtcNow);

        [JsonProperty("updated_at")]
        public DateTime? UpdatedAt { get; set; } = DateTime.UtcNow;
    }
}
