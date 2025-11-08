using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TechTitans_Info.Models
{
    [Table("StatusOS")]
    public class StatusOS
    {
        [Key]
        public int Id { get; set; }
        public string Nome { get; set; } = "";
    }
}