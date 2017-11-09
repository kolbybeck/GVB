﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
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
        [Required]
        [DisplayName("Dairy ID")]
        public int dairyID { get; set; }

        [Required]
        [DisplayName("Dairy Name")]
        public String dName { get; set; }

        [Required]
        [DisplayName("Address")]
        public String dAddress { get; set; }

        [Required]
        [DisplayName("City")]
        public String dCity { get; set; }

        [Required]
        [DisplayName("State")]
        public String dState { get; set; }

        [Required]
        [DisplayName("Zip")]
        public int dZip { get; set; }

        [Required]
        [DisplayName("Phone")]
        public String dPhone { get; set; }

}
}