﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace RealEstateBusiness.Models
{
    [Table("Staff_tbl")]
    public class Staff
    {
        [Key]
        public String StaffNo { get; set; }

        [Display(Name = "First Name")]
        public String Fname { get; set; }

        [Display(Name = "Last Name")]
        public String Lname { get; set; }

        public String Position { get; set; }

        [Column(TypeName = "Date")]
        [DataType(DataType.Date)]

        public DateTime DOB { get; set; }

        [DataType(DataType.Currency)]
        public int Salary { get; set; }

        [ForeignKey("Branch")]
        public String BranchNoRef { get; set; }

        public Branch Branch { get; set; }


    }
}