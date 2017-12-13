using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace GVB.Models
{
    [Table("CattleType")]
    public class CattleType
    {

            [Key]
            [DisplayName("Cattle Type")]
            public int CattleTypeID { get; set; }

            [DisplayName("Cattle Type Description")]
            [Required(ErrorMessage = "Cattle type description required")]
            public String CattleTypeDesc { get; set; }


        }
}