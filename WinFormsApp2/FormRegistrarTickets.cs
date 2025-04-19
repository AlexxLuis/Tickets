using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tickets.Data;
using Tickets.Models;

namespace Tickets
{
    public partial class FormRegistrarTickets : Form, IRecebeDadosFuncionario
    {
        private readonly AppDbContext _context = new AppDbContext();
        public FormRegistrarTickets()
        {
            InitializeComponent();
        }
        public void PreencherDadosFuncionario(string Id,string nome, string cpf,string situacao)
        {   txtId.ReadOnly = true;
            txtNome.Text = nome;
            txtCpf.Text = cpf;
            txtId.Text = Id;
        }

        private void FormRegistrarTickets_Load(object sender, EventArgs e)
        {
            txtId.ReadOnly = true;
            txtId.Enabled = false;
        }

        private void txtCpfFuncionario_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNomeFuncionario_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            string cpfOuNome = txtCpf.Text.Trim();
            string nome = txtNome.Text.Trim();

            if (string.IsNullOrWhiteSpace(cpfOuNome) || string.IsNullOrWhiteSpace(txtQtdTickets.Text))
            {
                MessageBox.Show("Preencha o CPF ou Nome e a quantidade de tickets.");
                return;
            }

            if (!int.TryParse(txtQtdTickets.Text, out int qtdTickets) || qtdTickets <= 0)
            {
                MessageBox.Show("Quantidade de tickets inválida.");
                return;
            }

            var funcionario = _context.Funcionarios
                .FirstOrDefault(f => f.Cpf == cpfOuNome || f.Nome.Contains(cpfOuNome));

            if (funcionario == null)
            {
                MessageBox.Show("Funcionário não encontrado.");
                return;
            }

            if (funcionario.Situacao != "A")
            {
                MessageBox.Show("Não é permitido registrar tickets para funcionários inativos.");
                return;
            }

            var ticket = new Ticket
            {
                FuncionarioId = funcionario.Id,
                Quantidade = qtdTickets
            };

            _context.Tickets.Add(ticket);
            _context.SaveChanges();

            MessageBox.Show("Tickets registrados com sucesso!");

            txtId.Text = "";
            txtCpf.Text = "";
            txtNome.Text = "";
            txtQtdTickets.Text = "";
        }


        private void txtIdFuncionario_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            var form = new FormPesquisarFuncionarioSQL(this);
            form.ShowDialog();
        }
        public void CarregarDadosFuncionario(int id, string cpf, string nome)
        {
            txtId.Text = id.ToString();
            txtCpf.Text = cpf;
            txtNome.Text = nome;
        }

    }
}
