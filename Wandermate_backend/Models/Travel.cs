using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Wandermate_backend.Models
{
    [Table("Travel")]
    public class Travel
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public decimal Price { get; set; }
        public List<string> Image { get; set; } = new List<string>();
        public string Description { get; set; } = string.Empty;
        public int Rating { get; set; }
        public bool FreeCancellation { get; set; }
        public bool Reservation { get; set; }
    }
}
