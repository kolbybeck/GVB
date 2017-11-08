using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace GVB.Models
{
    [Table("Dairy")]
    public class Dairy
    {
        
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int dairyID { get; set; }
        public String dName { get; set; }

    }
}