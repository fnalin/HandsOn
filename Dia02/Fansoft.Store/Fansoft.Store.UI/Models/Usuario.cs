using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Fansoft.Store.UI.Models
{
    [Table("Usuario")]
    public class Usuario:Entity
    {
        [Column(TypeName = "varchar(100)"), Required(ErrorMessage = "Campo obrigatório")]
        public string Nome { get; set; }

        [Column(TypeName = "varchar(100)"), Required(ErrorMessage = "Campo obrigatório")]
        public string Email { get; set; }

        [Column(TypeName = "varchar(50)"), Required(ErrorMessage = "Campo obrigatório")]
        public string  Senha { get; set; }
    }
}
