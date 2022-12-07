using ProyectoAWOS.Data.Model;
using ProyectoAWOS.Data.ViewModels;
using System.Collections.Generic;
using System.Linq;

namespace ProyectoAWOS.Data.Services
{
    public class DivisasService
    {
        private AppDbContext _context;
        public DivisasService(AppDbContext context)
        {
            _context = context;
        }
        //Metodo que nos permite agregar una nueva crypto
        public void AddDivisas(DivisasVM divisas)
        {
            var _divisas = new Divisas()
            {
                TipoDivisa = divisas.TipoDivisa,
                Costo = divisas.Costo,
                CryptoId = divisas.CryptoId
            };
            _context.Divisas.Add(_divisas);
            _context.SaveChanges();
        }
        //Metodo que nos permite visualizar todos los registros en la tabla cryptos
        public List<Divisas> GetAllDivisas() => _context.Divisas.ToList();
        //Meodo que nos permite ver un registro dado el ID de la tabla cryptos
        public Divisas GetDivisasById(int divisasid) => _context.Divisas.FirstOrDefault(n => n.Id == divisasid);
        //Metodo que nos permite editaar una crypto en la tabla crypto
        public Divisas UpdateDivisasById(int divisasid, DivisasVM divisas)
        {
            var _divisas = _context.Divisas.FirstOrDefault(n => n.Id == divisasid);
            if (_divisas != null)
            {
                _divisas.TipoDivisa = divisas.TipoDivisa;
                _divisas.Costo = divisas.Costo;
                _divisas.CryptoId = divisas.CryptoId;

                _context.SaveChanges();
            }
            return _divisas;
        }
        //Metodo que nos permite eliminar una crypto mediante el Id
        public void DeleteDivisasById(int divisasid)
        {
            var _divisas = _context.Divisas.FirstOrDefault(n => n.Id == divisasid);
            if (_divisas != null)
            {
                _context.Divisas.Remove(_divisas);
                _context.SaveChanges();
            }
        }
    }
}
