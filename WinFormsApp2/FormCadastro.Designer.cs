namespace Tickets
{
    partial class FormCadastro
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
            txtNome = new TextBox();
            txtCpf = new TextBox();
            labelName = new Label();
            LabelCpf = new Label();
            label3 = new Label();
            btnSalvar = new Button();
            SuspendLayout();
            // 
            // txtNome
            // 
            txtNome.Location = new Point(66, 104);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(100, 23);
            txtNome.TabIndex = 0;
            // 
            // txtCpf
            // 
            txtCpf.Location = new Point(195, 104);
            txtCpf.Name = "txtCpf";
            txtCpf.Size = new Size(100, 23);
            txtCpf.TabIndex = 1;
            // 
            // labelName
            // 
            labelName.AutoSize = true;
            labelName.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelName.Location = new Point(89, 81);
            labelName.Name = "labelName";
            labelName.Size = new Size(50, 18);
            labelName.TabIndex = 2;
            labelName.Text = "Nome";
            // 
            // LabelCpf
            // 
            LabelCpf.AutoSize = true;
            LabelCpf.Font = new Font("Arial", 12F);
            LabelCpf.Location = new Point(225, 81);
            LabelCpf.Name = "LabelCpf";
            LabelCpf.Size = new Size(41, 18);
            LabelCpf.TabIndex = 3;
            LabelCpf.Text = "CPF";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial Rounded MT Bold", 20.25F);
            label3.Location = new Point(12, 9);
            label3.Name = "label3";
            label3.Size = new Size(352, 32);
            label3.TabIndex = 4;
            label3.Text = "Cadastro de Funcionarios";
            // 
            // btnSalvar
            // 
            btnSalvar.Location = new Point(139, 171);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(75, 23);
            btnSalvar.TabIndex = 5;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = true;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // FormCadastro
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(381, 229);
            Controls.Add(btnSalvar);
            Controls.Add(label3);
            Controls.Add(LabelCpf);
            Controls.Add(labelName);
            Controls.Add(txtCpf);
            Controls.Add(txtNome);
            Name = "FormCadastro";
            Text = "Cadastro de Funcionarios";
            Load += FormCadastro_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNome;
        private TextBox txtCpf;
        private Label labelName;
        private Label LabelCpf;
        private Label label3;
        private Button btnSalvar;
    }
}