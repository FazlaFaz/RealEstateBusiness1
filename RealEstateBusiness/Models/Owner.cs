using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace RealEstateBusiness.Models
{
    [Table("Owner_tbl")]
    public class Owner
    {
        [Key]
        public String OwnerNo { get; set; }

        public String Fname { get; set; }

        public String Lname { get; set; }

        [DataType(DataType.MultilineText)]
        public String Address { get; set; }

        public String TelNo { get; set; }
    }
}