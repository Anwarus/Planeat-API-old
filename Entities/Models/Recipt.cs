using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities.Models
{
    [Table("Recipts")]
    public class Recipt
    {
        [Key]
        [Column("ReciptId")]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

    }
}
