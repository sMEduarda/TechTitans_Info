using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TechTitans_Info.Models
{
    [Table("OrdensServico")]
    public class OrdemServico
    {
        [Key]
        public int Id { get; set; }

        public string Solicitante { get; set; } = "";
        public string Responsavel { get; set; } = "";
        public string Telefone { get; set; } = "";
        public string Email { get; set; } = "";

        public int TipoEquipamentoId { get; set; }
        [ForeignKey("TipoEquipamentoId")]
        public TipoEquipamento TipoEquipamento { get; set; }

        public string Marca { get; set; } = "";
        public string Serie { get; set; } = "";
        public DateTime DataAbertura { get; set; } = DateTime.Now;
        public string DescricaoProblema { get; set; } = "";

        public int PrioridadeId { get; set; }
        [ForeignKey("PrioridadeId")]
        public Prioridade Prioridade { get; set; }

        public int StatusId { get; set; } = 1;
        [ForeignKey("StatusId")]
        public StatusOS Status { get; set; }

        // NOVOS CAMPOS PARA FECHAMENTO
        public decimal? ValorMaoDeObra { get; set; } = 0;
        public decimal? ValorTotalPecas { get; set; } = 0;
        public decimal? ValorTotal { get; set; } = 0;
        public DateTime? DataFechamento { get; set; }

        public virtual ICollection<ItemOrdemServico> Itens { get; set; } = new HashSet<ItemOrdemServico>();
    }
}