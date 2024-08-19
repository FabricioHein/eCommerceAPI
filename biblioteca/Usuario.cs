using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eCommerce.Models
{
    public class Usuario
    {

        public int Id { get; set; }
        public string Nome { get; set; } = null!;    
        public string Email { get; set; } = null!;

        public string? Sexo { get; set; }
        public string? RG { get; set; }
        public string CPF { get; set; } = null!;

        public string? Situacao { get; set; }
        public string? NomeMae { get; set; }

        public DateTimeOffset?  DataCadastro { get; set; }

        //Usuario.contato
        public Contato? Contato { get; set; }

        //Usuario.EnderecoEntrega[0]
        public ICollection<EnderecoEntrega>? EnderecoEntrega {  get; set; }
        public ICollection<Departamento>? Departamentos { get; set; }




    }
}
