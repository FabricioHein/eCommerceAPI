using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace eCommerce.Models
{
    [Table("pedidos")]
    public class Pedido
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public DateTime Data { get; set; }

        [Required]
        public decimal Total { get; set; }

        [Required]
        public int UsuarioId { get; set; }
        public Usuario Usuario { get; set; }

        public int EnderecoEntregaId { get; set; }
        public EnderecoEntrega EnderecoEntrega { get; set; }

        public ICollection<ItemPedido> Itens { get; set; }
    }
}
