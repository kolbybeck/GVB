﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace GVB.Models
{
    [Table("Feedlot")]
    public class Feedlot
    {
        [Key]
        [Required]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int feedlotID { get; set; }

        [Required]
        [DisplayName("Feedlot Name")]
        public String fName { get; set; }
    }
}