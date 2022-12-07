using Microsoft.EntityFrameworkCore;
using ProyectoAWOS.Data.Model;
using System;
using System.Security.Cryptography.X509Certificates;

namespace ProyectoAWOS.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options):base(options)
        {
            
        }
        public DbSet<Crypto> Cryptos { get; set; }
        public DbSet<Divisas> Divisas { get; set; }
        public DbSet<Usuarios> Usuarios { get; set; }
        public DbSet<CryptoUsuario> CryptoUsuario { get; set;}
    }
}
