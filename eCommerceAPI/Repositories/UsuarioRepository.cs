using eCommerce.Models;
using eCommerceAPI.Interface;

namespace eCommerceAPI.Repositories
{
    public class UsuarioRepository : IUsuarioRepository
    {
        public static List<Usuario> _db = new List<Usuario>();
        public List<Usuario> Get()
        {
            return _db;
        }

        public Usuario Get(int id)
        {
            return _db.Find( x => x.Id == id );
        }

        public void add(Usuario usuario)
        {
             _db.Add(usuario);            
        }
        public void update(Usuario usuario)
        {
            _db.Remove(Get(usuario.Id));
            _db.Add(usuario);

        }
        public void delete(int id)
        {
            _db.Remove(Get(id));

        }
       
       
    }
}
