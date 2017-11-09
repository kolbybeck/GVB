using System;
using System.Collections.Generic;
using System.ComponentModel;
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
        [Required]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [DisplayName("Employee ID")]
        public int EmployeeID { get; set; }

        [Required]
        [DisplayName("Employee First Name")]
        public String EmpFname { get; set; }

        [Required]
        [DisplayName("Employee Last Name")]
        public String EmpLname { get; set; }

        [Required]
        [DisplayName("Phone")]
        public String EmpPhone { get; set; }

        [Required]
        [DisplayName("Role")]
        [ForeignKey("Roles")]
        public virtual int RoleID{ get; set; }
        public virtual Roles Roles{ get; set; }
    }
}