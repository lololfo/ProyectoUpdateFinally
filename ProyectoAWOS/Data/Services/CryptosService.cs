using Microsoft.AspNetCore.Mvc;
using ProyectoAWOS.Data.Model;
using ProyectoAWOS.Data.ViewModels;
using System.Collections.Generic;
using System.Linq;

namespace ProyectoAWOS.Data.Services
{
    public class CryptosService
    {
        private AppDbContext _context;
        public CryptosService(AppDbContext context)
        {
            _context = context;
        }
        //Metodo que nos permite agregar una nueva crypto
        public void AddCryptos(CryptosVM crypto)
        {
            var _crypto = new Crypto()
            {
                NombreCrypto = crypto.NombreCrypto,
                DesCrypto = crypto.DesCrypto,
                Precio = crypto.Precio
            };
            _context.Cryptos.Add(_crypto);
            _context.SaveChanges();
        }
        //Metodo que nos permite visualizar todos los registros en la tabla cryptos
        public List<Crypto> GetAllCryptos() => _context.Cryptos.ToList();
        //Meodo que nos permite ver un registro dado el ID de la tabla cryptos
        public Crypto GetCryptosById(int cryptoid) => _context.Cryptos.FirstOrDefault(n => n.Id == cryptoid);
        //Metodo que nos permite editaar una crypto en la tabla crypto
        public Crypto UpdateCryptoById(int cryptoid, CryptosVM crypto) 
        {
            var _crypto = _context.Cryptos.FirstOrDefault(n => n.Id == cryptoid);
            if(_crypto != null ) 
            {
                _crypto.NombreCrypto = crypto.NombreCrypto;
                _crypto.DesCrypto = crypto.DesCrypto;
                _crypto.Precio = crypto.Precio;

                _context.SaveChanges();    
            }
            return _crypto;
        }
        //Metodo que nos permite eliminar una crypto mediante el Id
        public void DeleteCryptoById(int cryptoid)
        {
            var _crypto = _context.Cryptos.FirstOrDefault(n => n.Id==cryptoid);
            if(_crypto != null ) 
            {
                _context.Cryptos.Remove(_crypto);
                _context.SaveChanges();
            }
        }
        
    }
}
