using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace GVB.Models
{
    [Table("Cattle")]
    public class Cattle
    {
        [Key]
        public int CattleID { get; set; }
        [DisplayName("Cattle Number")]
        public String CattleNumber { get; set; }

        [Required(ErrorMessage = "Please select a dairy")]
        [ForeignKey("Dairy")]
        public virtual int DairyID { get; set; }
        public virtual Dairy Dairy { get; set; }

        [Required(ErrorMessage = "Please select a feedlot")]
        [ForeignKey("Feedlot")]
        public virtual int FeedlotID { get; set; }
        public virtual Feedlot Feedlot { get; set; }

        [DisplayName("Breed")]
        [ForeignKey("CattleType")] 
        public virtual int CattleTypeID { get; set; }
        public virtual CattleType CattleType { get; set; }

        [Required(ErrorMessage = "Please select date received")]
        [DisplayName("Date Recieved")]
        [DataType(DataType.Date)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/MM/yyyy}")]
        public virtual DateTime DateRecieved { get; set; }

    }
    
}