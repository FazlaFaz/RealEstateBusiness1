using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace RealEstateBusiness.Models
{
    public class EstateContext:DbContext
    {
        public DbSet<Branch> Branches { get; set; }

        public DbSet<Owner> Owners { get; set; }

        public DbSet<Rent> Rents { get; set; }

        public DbSet<Staff> Staffs { get; set; }
    }
}