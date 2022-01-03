using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace apitest4.Models
{
    public class CRUDContext: DbContext
    {   
        public CRUDContext(DbContextOptions<CRUDContext>options) : base(options)
        {

        }
        public DbSet<Bus> Buses { get; set; }
        public DbSet<Parada> Paradas { get; set; }
        public DbSet<Reporte> Reportes { get; set; }
        public DbSet<Resena> Resenas { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }
    }
}

