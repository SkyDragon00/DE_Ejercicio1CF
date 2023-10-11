using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using DE_Ejercicio1CF.Models;

namespace DE_Ejercicio1CF.Data
{
    public class DE_Ejercicio1CFContext : DbContext
    {
        public DE_Ejercicio1CFContext (DbContextOptions<DE_Ejercicio1CFContext> options)
            : base(options)
        {
        }

        public DbSet<DE_Ejercicio1CF.Models.Burger> Burger { get; set; } = default!;
    }
}
