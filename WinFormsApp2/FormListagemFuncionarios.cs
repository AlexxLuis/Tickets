using System;
using System.Linq;
using System.Windows.Forms;
using Tickets.Data;

namespace Tickets
{
    public partial class FormListagemFuncionarios : Form
    {
        private readonly AppDbContext _context = new AppDbContext();

        public FormListagemFuncionarios()
        {
            InitializeComponent();
            this.Load += FormListagemFuncionarios_Load;
        }

        private void FormListagemFuncionarios_Load(object sender, EventArgs e)
        {
            var funcionariosComTickets = (from f in _context.Funcionarios
                                          join t in _context.Tickets on f.Id equals t.FuncionarioId into tickets
                                          from ticket in tickets.DefaultIfEmpty()
                                          group ticket by new { f.Id, f.Nome, f.Cpf, f.Situacao } into g
                                          select new
                                          {
                                              g.Key.Id,
                                              g.Key.Nome,
                                              g.Key.Cpf,
                                              Situacao = g.Key.Situacao == "A" ? "Ativo" : "Inativo",
                                              TotalTickets = g.Sum(ticket => ticket.Quantidade)
                                          }).ToList();


            dataGridView1.DataSource = funcionariosComTickets;
        }
    }
}
