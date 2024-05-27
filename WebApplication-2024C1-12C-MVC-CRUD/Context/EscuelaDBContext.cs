using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication_2024C1_12C_MVC_CRUD.Models;
using System.Collections.Generic;

namespace WebApplication_2024C1_12C_MVC_CRUD.Context
{
    public class EscuelaDBContext : DbContext
    {
        public EscuelaDBContext(DbContextOptions<EscuelaDBContext> options) : base(options)
        {
        }
        public DbSet<Estudiante> Estudiantes { get; set; }
    }
}
