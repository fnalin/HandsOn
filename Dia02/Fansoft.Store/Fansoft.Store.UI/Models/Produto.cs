using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Fansoft.Store.UI.Models
{
    [Table("Produto")]
    public class Produto : Entity
    {

        [Column(TypeName = "varchar(100)"), Required(ErrorMessage ="Campo obrigatório")]
        public string Nome { get; set; }

        [Column(TypeName = "money")]
        public decimal Valor { get; set; }

        public int TipoProdutoId { get; set; }

        [ForeignKey(nameof(TipoProdutoId))]
        public virtual TipoProduto TipoProduto { get; set; }
    }
}
