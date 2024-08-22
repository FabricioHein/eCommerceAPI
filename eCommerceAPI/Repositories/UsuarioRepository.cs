using eCommerceAPI.Database;
using eCommerceAPI.Interface;

namespace eCommerceAPI.Repositories
{
    public class UsuarioRepository : IUsuarioRepository
    {
        private readonly eCommerceContext _context;

        public UsuarioRepository(eCommerceContext context)
        {
            _context = context;
        }

        public List<Usuario> Get()
        {
            return _context.Usuarios.ToList();
        }

        public Usuario Get(int id)
        {
            return _context.Usuarios.Find(id);
        }

        public void Add(Usuario usuario)
        {
            _context.Add(usuario);
            _context.SaveChanges();
        }

        public void Update(Usuario usuario)
        {
            _context.Update(usuario);
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            var usuario = Get(id);
            if (usuario != null)
            {
                _context.Remove(usuario);
                _context.SaveChanges();
            }
        }
    }
}
