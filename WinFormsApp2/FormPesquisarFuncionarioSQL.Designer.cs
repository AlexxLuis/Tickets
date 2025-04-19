namespace Tickets
{
    partial class FormPesquisarFuncionarioSQL
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtPesquisa = new TextBox();
            btnPesquisar = new Button();
            dgvFuncionarios = new DataGridView();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvFuncionarios).BeginInit();
            SuspendLayout();
            // 
            // txtPesquisa
            // 
            txtPesquisa.Location = new Point(203, 83);
            txtPesquisa.Name = "txtPesquisa";
            txtPesquisa.Size = new Size(182, 23);
            txtPesquisa.TabIndex = 0;
            txtPesquisa.TextChanged += txtPesquisa_TextChanged;
            // 
            // btnPesquisar
            // 
            btnPesquisar.Location = new Point(391, 83);
            btnPesquisar.Name = "btnPesquisar";
            btnPesquisar.Size = new Size(75, 23);
            btnPesquisar.TabIndex = 1;
            btnPesquisar.Text = "Pesquisar";
            btnPesquisar.UseVisualStyleBackColor = true;
            btnPesquisar.Click += btnPesquisar_Click;
            // 
            // dgvFuncionarios
            // 
            dgvFuncionarios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvFuncionarios.Location = new Point(53, 139);
            dgvFuncionarios.Name = "dgvFuncionarios";
            dgvFuncionarios.Size = new Size(712, 284);
            dgvFuncionarios.TabIndex = 2;
            dgvFuncionarios.CellContentClick += dgvFuncionarios_CellContentClick;
            dgvFuncionarios.CellDoubleClick += dgvFuncionarios_CellDoubleClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 12F);
            label1.Location = new Point(277, 62);
            label1.Name = "label1";
            label1.Size = new Size(41, 18);
            label1.TabIndex = 3;
            label1.Text = "CPF";
            // 
            // FormPesquisarFuncionarioSQL
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(dgvFuncionarios);
            Controls.Add(btnPesquisar);
            Controls.Add(txtPesquisa);
            Name = "FormPesquisarFuncionarioSQL";
            Text = "PesquisarFuncionarioSQL";
            Load += FormPesquisarFuncionarioSQL_Load;
            ((System.ComponentModel.ISupportInitialize)dgvFuncionarios).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtPesquisa;
        private Button btnPesquisar;
        private DataGridView dgvFuncionarios;
        private Label label1;
    }
}
