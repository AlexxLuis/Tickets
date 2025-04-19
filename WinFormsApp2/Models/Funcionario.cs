using Tickets.Models;

public class Funcionario
{
    public int Id { get; set; }
    public string Nome { get; set; }
    public string Cpf { get; set; }
    public string Situacao { get; set; }
    public DateTime DataAlteracao { get; set; }

    public List<Ticket> Tickets { get; set; }
}
