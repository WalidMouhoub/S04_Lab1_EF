using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;

namespace ZombieParty.Models
{
    public class HuntingLog
    {
        [Key]
        public int Id { get; set; }
        [StringLength(25, MinimumLength = 5)]
        public string Title { get; set; }
        [MaxLength(255)]
        public string Description { get; set; }

        [ValidateNever]
        public List<Zombie>? Zombies { get; set; }
    }
}
