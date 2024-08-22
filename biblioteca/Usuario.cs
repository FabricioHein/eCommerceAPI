using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace eCommerce.Models
{
    [Table("usuario")]
    public class Usuario
    {
        public string email;

        public int Id { get; set; }

        [MaxLength(100)]
        public string Nome { get; set; } = null!;

        [MaxLength(100)]
        public string Email { get; set; } = null!;

        [MaxLength(20)]
        public string? Sexo { get; set; }

        [MaxLength(20)]
        public string? RG { get; set; }

        [Required]
        public string CPF { get; set; } = null!;

        [MaxLength(20)]
        public string? Situacao { get; set; }

        [Required]
        [MaxLength(100)]
        public string Password { get; set; } = null!;

        public DateTimeOffset? DataCadastro { get; set; }

        [MaxLength(20)]
        public string? Telefone { get; set; }

        public Contato? Contato { get; set; }

        public ICollection<EnderecoEntrega>? EnderecoEntrega { get; set; }

        public ICollection<Departamento>? Departamentos { get; set; }
        public ICollection<Pedido>? Pedidos { get; set; }

    }
}
