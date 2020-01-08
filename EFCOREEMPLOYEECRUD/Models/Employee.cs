using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace EFCOREEMPLOYEECRUD.Models
{
    // this class should rep the database table
    public class Employee
        // corresponding table name has to be plural of this class - Employees
    {
        // to add this class to db model, it has to be 
        //added to EmployeeContext class
        // database fields
        // EFCORE sets this field as primary key
        [Key]
        public int EmployeeId { get; set; }
        [Column(TypeName ="nvarchar(250)")]
        [Required(ErrorMessage ="This field is required")]
        [DisplayName("Full Name")]
        public string FullName { get; set; }
        [Column(TypeName = "varchar(10)")]
        [DisplayName("Employee Code")]
        public string EmpCode { get; set; }
        [Column(TypeName = "varchar(100)")]
        
        public string Position { get; set; }
        [Column(TypeName = "varchar(100)")]
        [DisplayName("Office Location")]
        public string OfficeLocation { get; set; }


    }
}
