using System.ComponentModel.DataAnnotations.Schema;

namespace eCommerce.Models
{
    [Table("endereco_entrega")]
    public class EnderecoEntrega
    {
        public int Id { get; set; }

        public int UsuarioId { get; set; }
        public string Rua { get; set; } = null!;
        public string CEP { get; set; } = null!;
        public string Cidade { get; set; } = null!;
        public string Bairro { get; set; } = null!;
        public string? Numero { get; set; }
        public string? Complemento { get; set; }
        public Usuario? Usuario { get; set; }

    }
}
