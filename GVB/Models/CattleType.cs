using System;
using System.Collections.Generic;
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
            [DatabaseGenerated(DatabaseGeneratedOption.None)]
            public int CattleTypeID { get; set; }
            public String CattleTypeDesc { get; set; }


        }
}