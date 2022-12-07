using ProyectoAWOS.Data.Model;

namespace ProyectoAWOS.Data.ViewModels
{
    public class DivisasVM
    {
        public string TipoDivisa { get; set; }
        public double Costo { get; set; }
        public int CryptoId { get; set; }
        public Crypto Crypto { get; set; }
    }
}
