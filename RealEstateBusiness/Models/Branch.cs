﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace RealEstateBusiness.Models
{
    [Table("Branch_tbl")]
    public class Branch
    {
        [Key]
        public String BranchNo { get; set; }

        public String Street { get; set; }

        public String City { get; set; }

        public String PostCode { get; set; }
    }
}