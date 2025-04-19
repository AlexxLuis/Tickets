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

namespace Tickets
{
    public partial class FormCadastro : Form
    {
        public FormCadastro()
        {
            InitializeComponent();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            string nome = txtNome.Text.Trim();
            string cpf = txtCpf.Text.Trim();

            if (string.IsNullOrWhiteSpace(nome) || string.IsNullOrWhiteSpace(cpf))
            {
                MessageBox.Show("Os campos Nome e CPF são obrigatórios.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (var context = new AppDbContext())
            {
                var funcionario = new Funcionario
                {
                    Nome = nome,
                    Cpf = cpf,
                    Situacao = "A", // Ativo por padrão
                    DataAlteracao = DateTime.Now
                };

                context.Funcionarios.Add(funcionario);
                context.SaveChanges();
            }

            MessageBox.Show("Funcionário salvo com sucesso!");
            LimparCampos();
        }

        private void LimparCampos()
        {
            txtCpf.Clear();
            txtNome.Clear();
            txtNome.Focus();
        }

        private void FormCadastro_Load(object sender, EventArgs e)
        {

        }

       
    }
}
