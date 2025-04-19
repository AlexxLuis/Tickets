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
    public partial class FormEditarCadastro : Form, IRecebeDadosFuncionario
    {
        private readonly AppDbContext _context = new AppDbContext();
        public FormEditarCadastro()
        {
            InitializeComponent();
        }
        public void PreencherDadosFuncionario(string Id, string nome, string cpf, string situacao)
        {

            txtNome.Text = nome;
            txtCpf.Text = cpf;
            cbSituacao.Text = situacao;
        }

        private void cbSituacao_Click(object sender, EventArgs e)
        {

        }

        private void FormEditarCadastro_Load(object sender, EventArgs e)
        {

            cbSituacao.Items.Add("Ativo");
            cbSituacao.Items.Add("Inativo");
            cbSituacao.SelectedIndex = -1;
        }


        private void btnGravar_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(txtNome.Text) || string.IsNullOrWhiteSpace(txtCpf.Text) || cbSituacao.SelectedIndex == -1)
            {
                MessageBox.Show("Por favor, preencha todos os campos obrigatórios.");
                return;
            }

            string nome = txtNome.Text.Trim();
            string cpf = txtCpf.Text.Trim();
            string situacao = cbSituacao.SelectedItem.ToString().Trim() == "Ativo" ? "A" : "I";

            try
            {
                var funcionario = _context.Funcionarios.FirstOrDefault(f => f.Cpf == cpf);

                if (funcionario == null)
                {
                    DialogResult resultado = MessageBox.Show(
                        "Funcionário não encontrado.\nDeseja cadastrar este novo funcionário?",
                        "Funcionário não encontrado",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question
                    );

                    if (resultado == DialogResult.Yes)
                    {
                        funcionario = new Funcionario
                        {
                            Nome = nome,
                            Cpf = cpf,
                            Situacao = situacao,
                            DataAlteracao = DateTime.Now
                        };

                        _context.Funcionarios.Add(funcionario);

                        var duplicados = _context.Funcionarios
                            .Where(f => f.Nome == nome && f.Cpf != cpf && f.Situacao == "A")
                            .ToList();

                        foreach (var dup in duplicados)
                        {
                            dup.Situacao = "I";
                            dup.DataAlteracao = DateTime.Now;
                        }

                        _context.SaveChanges();

                        if (duplicados.Any())
                        {
                            MessageBox.Show($"Novo funcionário cadastrado.\n{duplicados.Count} cadastro(s) com o mesmo nome foram inativados.");
                        }
                        else
                        {
                            MessageBox.Show("Funcionário cadastrado com sucesso!");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Cadastro cancelado. Verifique os dados informados.");
                        return;
                    }
                }
                else
                {
                    funcionario.Nome = nome;
                    funcionario.Situacao = situacao;
                    funcionario.DataAlteracao = DateTime.Now;
                    _context.SaveChanges();

                    MessageBox.Show("Funcionário atualizado com sucesso!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao salvar funcionário: " + ex.Message);
            }

            txtNome.Clear();
            txtCpf.Clear();
            cbSituacao.SelectedIndex = -1;
            txtNome.Focus();
        }





        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            var form = new FormPesquisarFuncionarioSQL(this);
            form.ShowDialog();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Label3_Click(object sender, EventArgs e)
        {

        }

        /* public void PreencherDadosFuncionario(string nome, string cpf, string situacao)
         {
             txtNome.Text = nome;
             txtCpf.Text = cpf;
             cbSituacao.SelectedItem = situacao == "A" ? "Ativo" : "Inativo";
         }*/

    }
}


