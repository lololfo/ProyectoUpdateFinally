using Microsoft.EntityFrameworkCore.Storage.ValueConversion.Internal;

namespace ProyectoAWOS.Data.Model
{
    public class Usuarios
    {
        public int Id { get; set; }
        public string NombreUsuario { get; set; }
        public string TelUsuario { get; set;}
        public string password { get; set; }
    }
}
