using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Net.Http.Headers;
using Wandermate_backend.Models;


namespace Wandermate_backend.Data
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions  dbContextOptions)
        :base (dbContextOptions){
        }
        public DbSet<Hotel> Hotel{get;set;}
        public DbSet<Travel> Travel{get;set;}
        public object HotelReview { get; internal set; }
    }     
}