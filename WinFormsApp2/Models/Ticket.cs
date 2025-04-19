using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Tickets.Models
{
    public class Ticket
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public int FuncionarioId { get; set; }

        [Required]
        public int Quantidade { get; set; }

        [ForeignKey("FuncionarioId")]
        public Funcionario Funcionario { get; set; }

        [Required]
        public string Situacao { get; set; } = "A";

        [Required]
        [MaxLength(1)]
        public DateTime DataModificacao { get; set; } = DateTime.Now;

    }
}