using System;
using System.Collections.Generic;
using System.ComponentModel;
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
        public int CattleID { get; set; }

        [Required]
        [DisplayName("Cattle Number")]
        public String CattleNumber { get; set; }

        [Required]
        [DisplayName("Deceased Date")]
        public DateTime DeceasedDate { get; set; }

        [Required]
        [ForeignKey("Dairy")]
        public virtual int DairyID { get; set; }
        public virtual Dairy Dairy { get; set; }

        [Required]
        [ForeignKey("Feedlot")]
        public virtual int FeedlotID { get; set; }
        public virtual Feedlot Feedlot { get; set; }

        [Required]
        [ForeignKey("Employee")]
        public virtual int EmployeeID { get; set; }
        public virtual Employee Employee { get; set; }


  
    }
}