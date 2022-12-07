using ProyectoAWOS.Data.Model;
using ProyectoAWOS.Data.ViewModels;
using System.Collections.Generic;
using System.Linq;

namespace ProyectoAWOS.Data.Services
{
    public class UsuariosService
    {
        private AppDbContext _context;
        public UsuariosService(AppDbContext context)
        {
            _context = context;
        }
        //Metodo que nos permite agregar una nueva crypto
        public void AddUsuarios(UsuarioVM usuario)
        {
            var _usuario = new Usuarios()
            {
                NombreUsuario = usuario.NombreUsuario,
                TelUsuario = usuario.TelUsuario,
                password = usuario.password
            };
            _context.Usuarios.Add(_usuario);
            _context.SaveChanges();
        }
        //Metodo que nos permite visualizar todos los registros en la tabla cryptos
        public List<Usuarios> GetAllUsuarios() => _context.Usuarios.ToList();
        //Meodo que nos permite ver un registro dado el ID de la tabla cryptos
        public Usuarios GetUsuarioById(int usuarioid) => _context.Usuarios.FirstOrDefault(n => n.Id == usuarioid);
        //Metodo que nos permite editaar una crypto en la tabla crypto
        public Usuarios UpdateUsuarioById(int usuarioid, UsuarioVM usuario)
        {
            var _usuario = _context.Usuarios.FirstOrDefault(n => n.Id == usuarioid);
            if (_usuario != null)
            {
                _usuario.NombreUsuario = usuario.NombreUsuario;
                _usuario.TelUsuario= usuario.TelUsuario;
                _usuario.password= usuario.password;

                _context.SaveChanges();
            }
            return _usuario;
        }
        //Metodo que nos permite eliminar una crypto mediante el Id
        public void DeleteUsuarioById(int usuarioid)
        {
            var _usuario = _context.Usuarios.FirstOrDefault(n => n.Id == usuarioid);
            if (_usuario != null)
            {
                _context.Usuarios.Remove(_usuario);
                _context.SaveChanges();
            }
        }
    }
}
