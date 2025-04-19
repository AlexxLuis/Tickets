using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.EntityFrameworkCore;
using Tickets.Data;

namespace Tickets
{
    public partial class FormMain : Form
    {
        private readonly AppDbContext _context = new AppDbContext();
        public FormMain()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var form = new FormCadastro();
            form.ShowDialog();
        }

        private void btnListarFuncionarios_Click(object sender, EventArgs e)
        {
            var form = new FormListagemFuncionarios();
            form.ShowDialog();
        }

        private void btnCadastroTickets_Click(object sender, EventArgs e)
        {
            var form = new FormEditarCadastro();
            form.ShowDialog();
        }

        private void btnGerarRelatorio_Click(object sender, EventArgs e)
        {
            try
            {
                using (var folderDialog = new FolderBrowserDialog())
                {
                    folderDialog.Description = "Selecione a pasta para salvar o relatório";

                    if (folderDialog.ShowDialog() == DialogResult.OK)
                    {
                        string pastaSelecionada = folderDialog.SelectedPath;
                        string caminhoArquivo = Path.Combine(pastaSelecionada, "RelatorioFuncionarios.csv");

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
                                                          TotalTickets = g.Sum(t => t != null ? t.Quantidade : 0)
                                                      }).ToList();

                        using (StreamWriter sw = new StreamWriter(caminhoArquivo))
                        {
                            sw.WriteLine("Id,Nome,Cpf,Situacao,TotalTickets");

                            foreach (var funcionario in funcionariosComTickets)
                            {
                                sw.WriteLine($"{funcionario.Id},{funcionario.Nome},{funcionario.Cpf},{funcionario.Situacao},{funcionario.TotalTickets}");
                            }
                        }

                        MessageBox.Show($"Relatório salvo em:\n{caminhoArquivo}", "Relatório gerado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao gerar o relatório: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRegistrarTickets_Click(object sender, EventArgs e)
        {
            var form = new FormRegistrarTickets();
            form.ShowDialog();
        }
        private string GenerateTicketCode()
        {
            return Guid.NewGuid().ToString("N").Substring(0, 8);
        }

        private void FormMain_Load(object sender, EventArgs e)
        {

        }
    }
}
