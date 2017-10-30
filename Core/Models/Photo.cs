using System.ComponentModel.DataAnnotations;

namespace ng4_asp.net_core_2.Core.Models
{
    public class Photo
    {
        public int Id { get; set; }
        [Required]
        [StringLength(255)]
        public string FileName { get; set; }
    }
}