using eCommerceAPI.Database;
using eCommerceAPI.Interface;

namespace eCommerceAPI.Repositories
{

    public class PedidoRepository : IPedidoRepository
    {
        private readonly eCommerceContext _context;

        public PedidoRepository(eCommerceContext context)
        {
            _context = context;
        }
        public List<Pedido> Get()
        {
            return _context.Pedidos.ToList();
        }
        public Pedido Get(int id)
        {
            return _context.Pedidos.Find(id);
        }

        public void Add(Pedido pedido)
        {
            _context.Add(pedido);
            _context.SaveChanges();
        }

        public void Update(Pedido pedido)
        {
            _context.Update(pedido);
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            var pedido = Get(id);
            if (pedido != null)
            {
                _context.Remove(pedido);
                _context.SaveChanges();
            }
        }

        
    }
}
