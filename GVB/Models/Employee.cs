using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace GVB.Models
{
    [Table("Employee")]
    public class Employee
    {

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int EmployeeID { get; set; }
        public String EmpFname { get; set; }
        public String EmpLname { get; set; }
        public String EmpPhone { get; set; }

        [ForeignKey("Roles")]
        public virtual int RoleID{ get; set; }
        public virtual Roles Roles{ get; set; }
    }
}