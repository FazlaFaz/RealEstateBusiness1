﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace RealEstateBusiness.Models
{
    [Table("Rent_tbl")]
    public class Rent
    {
        [Key]
        public String PropertyNo { get; set; }

        public String Street { get; set; }

        public String City { get; set; }

        [Display(Name = "Property Type")]
        public String Ptype { get; set; }

        public int Rooms { get; set; }

        [ForeignKey("Owner")]
        public String OwnerNoRef { get; set; }

        [ForeignKey("Staff")]
        public String StaffNoRef { get; set; }

        [ForeignKey("Branch")]
        public String BranchNoRef { get; set; }

        [Display(Name = "Rent")]
        public int rent1 { get; set; }

        public Owner Owner { get; set; }

        public Staff Staff { get; set; }

        public Branch Branch { get; set; }

    }
}