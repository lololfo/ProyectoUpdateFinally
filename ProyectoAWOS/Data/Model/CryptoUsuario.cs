namespace ProyectoAWOS.Data.Model
{
    public class CryptoUsuario
    {
        public int Id { get; set; }
        public int CryptoId { get; set; }
        public Crypto Crypto { get; set; }
        public int UsuariosId { get; set; }
        public Usuarios Usuarios { get; set; }
    }
}
