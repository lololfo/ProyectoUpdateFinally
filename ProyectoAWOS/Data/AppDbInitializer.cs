using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using ProyectoAWOS.Data.Model;
using System.Linq;

namespace ProyectoAWOS.Data
{
    public class AppDbInitializer
    {
        public static void Seed(IApplicationBuilder applicationBuilder) 
        {
            using(var serviceScope = applicationBuilder.ApplicationServices.CreateScope()) 
            {
                var context = serviceScope.ServiceProvider.GetService<AppDbContext>();

                if (!context.Cryptos.Any())
                {
                    context.Cryptos.AddRange(new Crypto()
                    {
                        NombreCrypto = "Bitcoin",
                        DesCrypto = "The best of the word",
                        Precio = 5000,
                    },
                    new Crypto()
                    {
                        NombreCrypto = "Etherium",
                        DesCrypto = "The price es alto",
                        Precio = 3000,
                    });
                    context.SaveChanges();
                }
                if (!context.Usuarios.Any())
                {
                    context.Usuarios.AddRange(new Usuarios()
                    {
                        NombreUsuario = "Juan",
                        TelUsuario = "6441583574",
                        password = "12345678",
                    },
                    new Usuarios()
                    { 
                        NombreUsuario = "Karim",
                        TelUsuario = "6442574709",
                        password= "Password",
                    });
                }
                if (!context.Divisas.Any())
                {
                    context.Divisas.AddRange(new Divisas() 
                    {
                        TipoDivisa = "Dollar",
                        Costo = 1,
                        CryptoId= 1,
                    },
                    new Divisas
                    {
                        TipoDivisa = "Euro",
                        Costo = 1.23,
                        CryptoId= 2,
                    });
                }
                if(!context.CryptoUsuario.Any())
                {
                    context.CryptoUsuario.AddRange(new CryptoUsuario()
                    { 
                        CryptoId = 1,
                        UsuariosId = 1,
                    },
                    new CryptoUsuario()
                    {
                        CryptoId = 2,
                        UsuariosId = 2,
                    });
                }
            }
        }
    }
}
