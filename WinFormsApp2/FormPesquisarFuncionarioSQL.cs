using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using Microsoft.EntityFrameworkCore;
using Tickets.Data;

namespace Tickets
{
    public partial class FormPesquisarFuncionarioSQL : Form
    {
        private readonly AppDbContext _context = new AppDbContext();
        private readonly IRecebeDadosFuncionario _formPrincipal;

        public FormPesquisarFuncionarioSQL(IRecebeDadosFuncionario formPrincipal)
        {
            InitializeComponent();
            _formPrincipal = formPrincipal;
        }

        private void FormPesquisarFuncionarioSQL_Load(object sender, EventArgs e)
        {
            AtualizarGrid();
        }

        private void txtPesquisa_TextChanged(object sender, EventArgs e)
        {
            AtualizarGrid();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            AtualizarGrid();
        }

        private void AtualizarGrid()
        {
            string termo = txtPesquisa.Text.Trim();

            var resultado = _context.Funcionarios
                .FromSqlRaw("SELECT f.Id, f.Nome, f.Cpf, " +
                            "CASE WHEN f.Situacao = 'A' THEN 'Ativo' ELSE 'Inativo' END AS Situacao, " +
                            "f.DataAlteracao " +
                            "FROM Funcionarios f " +
                            "WHERE f.Cpf LIKE {0} OR f.Nome LIKE {0}", "%" + termo + "%")
                .ToList();

            dgvFuncionarios.DataSource = resultado;

            
            if (dgvFuncionarios.Columns.Contains("DataAlteracao"))
            {
                dgvFuncionarios.Columns["DataAlteracao"].Visible = false;
            }
        }



        private void dgvFuncionarios_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var row = dgvFuncionarios.Rows[e.RowIndex];
                string id = row.Cells["Id"].Value.ToString();
                string nome = row.Cells["Nome"].Value.ToString();
                string cpf = row.Cells["Cpf"].Value.ToString();
                string situacao = row.Cells["Situacao"].Value.ToString();

                _formPrincipal.PreencherDadosFuncionario(id, nome, cpf, situacao);

                this.Close();
            }
        }

        private void dgvFuncionarios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
