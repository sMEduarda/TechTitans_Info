using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TechTitans_Info.Models
{
    [Table("TiposEquipamento")]
    public class TipoEquipamento
    {
        [Key]
        public int Id { get; set; }
        public string Nome { get; set; } = "";
    }
}