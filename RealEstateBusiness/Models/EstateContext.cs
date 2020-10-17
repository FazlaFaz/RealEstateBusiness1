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


    }
}