using ProyectoAWOS.Data.Model;

namespace ProyectoAWOS.Data.ViewModels
{
    public class UsuarioCryptoVM
    {
        public int CryptoId { get; set; }
        public Crypto Crypto { get; set; }
        public int UsuariosId { get; set; }
        public Usuarios Usuarios { get; set; }
    }
}
