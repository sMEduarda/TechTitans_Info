using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TechTitans_Info.Models
{
    [Table("Materiais")]
    public class Material
    {
        [Key]
        public int Id { get; set; }
        public string Nome { get; set; } = "";
        public string Tipo { get; set; } = "";
        public string Descricao { get; set; } = "";
        public decimal Valor { get; set; }
        public int QuantidadeDisponivel { get; set; }

        public virtual ICollection<ItemOrdemServico> ItensOS { get; set; } = new HashSet<ItemOrdemServico>();
    }
}