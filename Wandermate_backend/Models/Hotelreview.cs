using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Wandermate_backend.Models
{
    public class Hotelreview
    {
        [Key]
        public int ReviewId{get; set;}
        public int Rating{get; set;}
        public String ReviewText{get; set;}=String.Empty;

        public DateTime CreatedOn{get; set;} =DateTime.UtcNow;

        public int? HotelId {get; set;}
        public Hotel? Hotel {get; set;}
    }
}