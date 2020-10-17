using System;
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

        public String Ptype { get; set; }

        public int Rooms { get; set; }

        [ForeignKey("Owner_tbl")]
        public String OwnerNoRef { get; set; }

        [ForeignKey("Staff_tbl")]
        public String StaffNoRef { get; set; }

        [ForeignKey("Branch_tbl")]
        public String BranchNoRef { get; set; }

        public int rent1 { get; set; }
    }
}