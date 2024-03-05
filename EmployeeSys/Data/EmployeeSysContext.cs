using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using EmployeeSys.Models;

namespace EmployeeSys.Data
{
    public class EmployeeSysContext : DbContext
    {
        public EmployeeSysContext (DbContextOptions<EmployeeSysContext> options)
            : base(options)
        {
        }

        public DbSet<EmployeeSys.Models.Employee> Employee { get; set; } = default!;
    }
}
