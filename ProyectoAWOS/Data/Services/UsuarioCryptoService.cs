using ProyectoAWOS.Data.Model;
using ProyectoAWOS.Data.ViewModels;
using System.Collections.Generic;
using System.Linq;

namespace ProyectoAWOS.Data.Services
{
    public class UsuarioCryptoService
    {
        private AppDbContext _context;
        public UsuarioCryptoService(AppDbContext context)
        {
            _context = context;
        }
        //Metodo que nos permite agregar un nuevo CryptoUsuario
        public void AddCrypos(UsuarioCryptoVM usuariocrypto)
        {
            var _usuariocrypto = new CryptoUsuario()
            {
                CryptoId = usuariocrypto.CryptoId,
                UsuariosId = usuariocrypto.UsuariosId,
            };
            _context.CryptoUsuario.Add(_usuariocrypto);
            _context.SaveChanges();
        }
        //Metodo que nos permite visualizar todos los registros en la tabla cryptos
        public List<CryptoUsuario> GetAllCrypoUsuario() => _context.CryptoUsuario.ToList();
        //Meodo que nos permite ver un registro dado el ID de la tabla cryptos
        public CryptoUsuario GetCryptoUsuarioById(int cryptousuarioid) => _context.CryptoUsuario.FirstOrDefault(n => n.Id == cryptousuarioid);
        //Metodo que nos permite editaar una crypto en la tabla crypto
        public CryptoUsuario UpdateCryptoUsuarioById(int cryptousuarioid, UsuarioCryptoVM cryptousuario)
        {
            var _cryptousuario = _context.CryptoUsuario.FirstOrDefault(n => n.Id == cryptousuarioid);
            if (_cryptousuario != null)
            {
                _cryptousuario.CryptoId = cryptousuario.CryptoId;
                _cryptousuario.UsuariosId = cryptousuario.UsuariosId;

                _context.SaveChanges();
            }
            return _cryptousuario;
        }
        //Metodo que nos permite eliminar una crypto mediante el Id
        public void DeleteUsuarioCryptoById(int cryptousuarioid)
        {
            var _cryptousuario = _context.CryptoUsuario.FirstOrDefault(n => n.Id == cryptousuarioid);
            if (_cryptousuario != null)
            {
                _context.CryptoUsuario.Remove(_cryptousuario);
                _context.SaveChanges();
            }
        }
    }
}
