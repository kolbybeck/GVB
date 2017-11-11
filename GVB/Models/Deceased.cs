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

        [Required(ErrorMessage = "Cattle number required")]
        [DisplayName("Cattle Number")]
        public String CattleNumber { get; set; }

        [Required(ErrorMessage = "Deceased date required")]
        [DisplayName("Deceased Date")]
        [DataType(DataType.Date)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime DeceasedDate { get; set; }

        [Required(ErrorMessage = "Please select a dairy")]
        [ForeignKey("Dairy")]
        public virtual int DairyID { get; set; }
        public virtual Dairy Dairy { get; set; }

        [Required]
        [ForeignKey("Feedlot")]
        public virtual int FeedlotID { get; set; }
        public virtual Feedlot Feedlot { get; set; }

        [Required(ErrorMessage = "Please select an employee")]
        [ForeignKey("Employee")]
        public virtual int EmployeeID { get; set; }
        public virtual Employee Employee { get; set; }


  
    }
}