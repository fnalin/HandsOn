using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Fansoft.Store.UI.Models
{
    [Table("TipoProduto")]
    public class TipoProduto:Entity
    {
        [Column(TypeName = "varchar(100)"), Required]
        public string Nome { get; set; }

        public virtual ICollection<Produto> Produtos { get; set; } = new List<Produto>();
    }
}
