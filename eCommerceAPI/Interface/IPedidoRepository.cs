namespace eCommerceAPI.Interface
{
    public interface IPedidoRepository
    {
        List<Pedido> Get();
        Pedido Get(int id);
        void Add(Pedido pedido);
        void Update(Pedido pedido);
        void Delete(int id);
    }
}
