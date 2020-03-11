using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
namespace SeminarInvites.Models
{
    public class GuestContextdb : DbContext
    {
       // public GuestContextdb() : base("ProductContext") { }

        public DbSet<GuestResponse> GuestResponses{ get; set; }
    }
}