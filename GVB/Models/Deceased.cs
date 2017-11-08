using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace GVB.Models
{
    [Table("Deceased")]
    public class Deceased
    {
        
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int DeceasedID { get; set; }
        public DateTime DeceasedDate { get; set; }

        [ForeignKey("Cattle")]
        public virtual int CattleID { get; set; }

        [Required]
        [ForeignKey("Cattle")]
        public virtual string CattleNumber { get; set; }

        [ForeignKey("Dairy")]
        public virtual int DairyID { get; set; }

        [ForeignKey("Feedlot")]
        public virtual int feedlotID { get; set; }


        [ForeignKey("Employee")]
        public virtual int EmployeeID { get; set; }
    }
}