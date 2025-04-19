namespace Tickets
{
    partial class FormRegistrarTickets
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
            txtId = new TextBox();
            txtQtdTickets = new TextBox();
            txtNome = new TextBox();
            txtCpf = new TextBox();
            btnSalvar = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            btnPesquisar = new Button();
            label5 = new Label();
            SuspendLayout();
            // 
            // txtId
            // 
            txtId.Enabled = false;
            txtId.Location = new Point(41, 99);
            txtId.Name = "txtId";
            txtId.Size = new Size(45, 23);
            txtId.TabIndex = 0;
            txtId.TextChanged += txtIdFuncionario_TextChanged;
            // 
            // txtQtdTickets
            // 
            txtQtdTickets.Location = new Point(92, 162);
            txtQtdTickets.Name = "txtQtdTickets";
            txtQtdTickets.Size = new Size(100, 23);
            txtQtdTickets.TabIndex = 1;
            // 
            // txtNome
            // 
            txtNome.Location = new Point(92, 99);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(100, 23);
            txtNome.TabIndex = 2;
            txtNome.TextChanged += txtNomeFuncionario_TextChanged;
            // 
            // txtCpf
            // 
            txtCpf.Location = new Point(198, 99);
            txtCpf.Name = "txtCpf";
            txtCpf.Size = new Size(100, 23);
            txtCpf.TabIndex = 3;
            txtCpf.TextChanged += txtCpfFuncionario_TextChanged;
            // 
            // btnSalvar
            // 
            btnSalvar.Location = new Point(198, 162);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(75, 23);
            btnSalvar.TabIndex = 4;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = true;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(54, 81);
            label1.Name = "label1";
            label1.Size = new Size(17, 15);
            label1.TabIndex = 5;
            label1.Text = "Id";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(120, 81);
            label2.Name = "label2";
            label2.Size = new Size(40, 15);
            label2.TabIndex = 6;
            label2.Text = "Nome";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(235, 81);
            label3.Name = "label3";
            label3.Size = new Size(28, 15);
            label3.TabIndex = 7;
            label3.Text = "CPF";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(119, 144);
            label4.Name = "label4";
            label4.Size = new Size(43, 15);
            label4.TabIndex = 8;
            label4.Text = "Tickets";
            // 
            // btnPesquisar
            // 
            btnPesquisar.Location = new Point(304, 99);
            btnPesquisar.Name = "btnPesquisar";
            btnPesquisar.Size = new Size(75, 23);
            btnPesquisar.TabIndex = 9;
            btnPesquisar.Text = "Pesquisar";
            btnPesquisar.UseVisualStyleBackColor = true;
            btnPesquisar.Click += btnPesquisar_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial Rounded MT Bold", 20.25F);
            label5.Location = new Point(54, 9);
            label5.Name = "label5";
            label5.Size = new Size(279, 32);
            label5.TabIndex = 10;
            label5.Text = "Cadastro de Tickets";
            // 
            // FormRegistrarTickets
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(397, 250);
            Controls.Add(label5);
            Controls.Add(btnPesquisar);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnSalvar);
            Controls.Add(txtCpf);
            Controls.Add(txtNome);
            Controls.Add(txtQtdTickets);
            Controls.Add(txtId);
            Name = "FormRegistrarTickets";
            Text = "Cadastro de Tickets";
            Load += FormRegistrarTickets_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtId;
        private TextBox txtQtdTickets;
        private TextBox txtNome;
        private TextBox txtCpf;
        private Button btnSalvar;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button btnPesquisar;
        private Label label5;
    }
}