using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace EFCOREEMPLOYEECRUD.Models
{
    // inherits the DbContext class from entiyi framework core
    // dependency injection for Dbcontext of the type EmployeeContext
    // should be done in startup.cs

    // previous code public class EmployeeContext:DbContext
    // changed to IdentityDbContext in order use identity
    // from the inheritance chnain IdentityDbContext also inherits from DbContext, so no need to state it explicitly
    public class EmployeeContext:DbContext
    {
        // constructor for this class
        // db provider such as sql, mysql, postgresql, etc are supported by efcore
        public EmployeeContext(DbContextOptions<EmployeeContext> options):base(options)
        {

        }
         
        // add the Employee.cs file to this class
        public DbSet<Employee>Employees { get; set; }
    }
}
