using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;

namespace ZombieParty.Models
{
    public class Zombie
    {
        [Key]
        public int Id { get; set; }

        [StringLength(20,MinimumLength = 5)]
        public string Name { get; set; }

        [Display(Name = "ZombieType")]
        [ForeignKey("ZombieType")]
        public int ZombieTypeId { get; set; }

        [ValidateNever]
        public ZombieType? ZombieType { get; set; }

        [Range(1,20)]
        public int Point { get; set; }

        [MaxLength(255)]
        public string ShortDesc { get; set; }

        [ValidateNever]
        public List<HuntingLog> HuntingLogs { get; set; }

        
    }
}
