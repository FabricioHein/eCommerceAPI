using System.ComponentModel.DataAnnotations.Schema;

namespace eCommerce.Models
{
    [Table("departamento")]
    public class Departamento
    {
        public int Id { get; set; }
        public string Nome { get; set; } = null!;

        public ICollection<Usuario>? Usuarios { get; set; }
    }
}
