using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace GestionViajesCaisabanda.Models
{
    public class ViajesContext : DbContext
    {
        public ViajesContext(DbContextOptions<ViajesContext> options) : base(options) { }

        // Aquí definimos las tablas que pidió la foto
        public DbSet<Destino> Destinos { get; set; }
        public DbSet<Turista> Turistas { get; set; }
    }
}