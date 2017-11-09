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
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CattleID { get; set; }

        [Required]
        [DisplayName("Cattle Number")]
        public String CattleNumber { get; set; }

        [Required]
        [ForeignKey("Dairy")]
        public virtual int DairyID { get; set; }
        public virtual Dairy Dairy { get; set; }

        [Required]
        [ForeignKey("Feedlot")]
        public virtual int FeedlotID { get; set; }
        public virtual Feedlot Feedlot { get; set; }

        [Required]
        [DisplayName("Breed")]
        [ForeignKey("CattleType")] 
        public virtual int CattleTypeID { get; set; }
        public virtual CattleType CattleType { get; set; }

        [Required]
        [DisplayName("Date Recieved")]
        public virtual DateTime DateRecieved { get; set; }

    }
    
}