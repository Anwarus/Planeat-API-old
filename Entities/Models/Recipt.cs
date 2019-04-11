using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities.Models
{
    [Table("Recipts")]
    public class Recipt
    {
        [Key]
        public int ReciptId { get; set; }

        [Required]
        public string Name { get; set; }

    }
}
