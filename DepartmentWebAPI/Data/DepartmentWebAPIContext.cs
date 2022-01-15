using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using DepartmentWebAPI.Model;

namespace DepartmentWebAPI.Data
{
    public class DepartmentWebAPIContext : DbContext
    {
        public DepartmentWebAPIContext (DbContextOptions<DepartmentWebAPIContext> options)
            : base(options)
        {
        }

        public DbSet<DepartmentWebAPI.Model.Department> Department { get; set; }
    }
}
