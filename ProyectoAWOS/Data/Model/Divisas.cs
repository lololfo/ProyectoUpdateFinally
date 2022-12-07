namespace ProyectoAWOS.Data.Model
{
    public class Divisas
    {
        public int Id { get; set; }
        public string TipoDivisa { get; set; }
        public double Costo { get; set; }
        public int CryptoId { get; set; }
        public Crypto Crypto { get; set; }
    }
}
