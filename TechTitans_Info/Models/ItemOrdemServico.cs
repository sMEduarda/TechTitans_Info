using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TechTitans_Info.Models
{
    [Table("ItensOrdemServico")]
    public class ItemOrdemServico
    {
        [Key]
        public int Id { get; set; }

        public int OrdemServicoId { get; set; }
        [ForeignKey("OrdemServicoId")]
        public OrdemServico OrdemServico { get; set; }

        public int MaterialId { get; set; }
        [ForeignKey("MaterialId")]
        public Material Material { get; set; }

        public int QuantidadeUsada { get; set; } = 1;
        public decimal ValorUnitario { get; set; }
    }
}