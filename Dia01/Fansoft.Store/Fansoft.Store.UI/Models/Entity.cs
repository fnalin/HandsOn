using System;
using System.ComponentModel.DataAnnotations;

namespace Fansoft.Store.UI.Models
{
    public class Entity
    {
        [Key]
        public int Id { get; set; }

        public DateTime DataCriacao { get; set; } = DateTime.Now;
    }
}
