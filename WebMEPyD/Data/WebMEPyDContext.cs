using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WebMEPyD.Model;

namespace WebMEPyD.Data
{
    public class WebMEPyDContext : DbContext
    {
        public WebMEPyDContext (DbContextOptions<WebMEPyDContext> options)
            : base(options)
        {
        }

        public DbSet<WebMEPyD.Model.Compañia>? Compañia { get; set; }

        public DbSet<WebMEPyD.Model.Empleado>? Empleado { get; set; }
    }
}
