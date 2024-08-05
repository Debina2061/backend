using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Wandermate_backend.Models
{
    [Table("Hotel")]
    public class Hotel
    {
        [Key]
        public int Id{get; set;}
        public String Name{get; set;}=String.Empty;
        public decimal Price{get; set;}
        public List<string> Image{get; set;}= new List<string>();
        public string Description {get; set;}=String.Empty;
         public int Rating {get; set;}

          public bool FreeCancellation{get; set;}
          public bool Reservation{get; set;}

public Hotelinfo ?Hotelinfo{get; set;}
public List<Hotelreview> Hotelreviews{get; set;}= new List<Hotelreview>();
        public object ReserveNow { get; internal set; }
    }
}