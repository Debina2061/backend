using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Net.Http.Headers;

namespace Wandermate_backend.Models
{
    public class Hotelinfo
    {
        [Key]
        public int Id{get; set;}
        public String Details{get; set;}=String.Empty;

        [ForeignKey("Hotel")]

        public int Hotelid {get; set;}

//navigation property
        public Hotel? Hotel {get; set;}
    }
}