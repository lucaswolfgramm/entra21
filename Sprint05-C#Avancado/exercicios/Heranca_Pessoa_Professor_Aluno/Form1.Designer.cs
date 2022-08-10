namespace Heranca_Pessoa_Professor_Aluno
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblMatricula = new System.Windows.Forms.Label();
            this.txtMatricula = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.lblMedia = new System.Windows.Forms.Label();
            this.lblSalario = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioBtnAluno = new System.Windows.Forms.RadioButton();
            this.radioBtnProfessor = new System.Windows.Forms.RadioButton();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.txtMedia = new System.Windows.Forms.MaskedTextBox();
            this.txtSalario = new System.Windows.Forms.MaskedTextBox();
            this.groupBoxNotas = new System.Windows.Forms.GroupBox();
            this.txtNotaTres = new System.Windows.Forms.MaskedTextBox();
            this.txtNotaDois = new System.Windows.Forms.MaskedTextBox();
            this.txtNotaUm = new System.Windows.Forms.MaskedTextBox();
            this.lblNotaTres = new System.Windows.Forms.Label();
            this.lblNotaDois = new System.Windows.Forms.Label();
            this.lblNotaUm = new System.Windows.Forms.Label();
            this.txtCPF = new System.Windows.Forms.MaskedTextBox();
            this.lblCPF = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBoxNotas.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblMatricula
            // 
            this.lblMatricula.AutoSize = true;
            this.lblMatricula.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblMatricula.Location = new System.Drawing.Point(47, 161);
            this.lblMatricula.Name = "lblMatricula";
            this.lblMatricula.Size = new System.Drawing.Size(78, 21);
            this.lblMatricula.TabIndex = 0;
            this.lblMatricula.Text = "Matrícula:";
            // 
            // txtMatricula
            // 
            this.txtMatricula.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtMatricula.Location = new System.Drawing.Point(131, 158);
            this.txtMatricula.Name = "txtMatricula";
            this.txtMatricula.Size = new System.Drawing.Size(237, 29);
            this.txtMatricula.TabIndex = 1;
            // 
            // txtNome
            // 
            this.txtNome.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtNome.Location = new System.Drawing.Point(131, 193);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(237, 29);
            this.txtNome.TabIndex = 3;
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblNome.Location = new System.Drawing.Point(47, 196);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(56, 21);
            this.lblNome.TabIndex = 2;
            this.lblNome.Text = "Nome:";
            // 
            // lblMedia
            // 
            this.lblMedia.AutoSize = true;
            this.lblMedia.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblMedia.Location = new System.Drawing.Point(268, 314);
            this.lblMedia.Name = "lblMedia";
            this.lblMedia.Size = new System.Drawing.Size(56, 21);
            this.lblMedia.TabIndex = 4;
            this.lblMedia.Text = "Média:";
            this.lblMedia.Visible = false;
            // 
            // lblSalario
            // 
            this.lblSalario.AutoSize = true;
            this.lblSalario.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblSalario.Location = new System.Drawing.Point(47, 266);
            this.lblSalario.Name = "lblSalario";
            this.lblSalario.Size = new System.Drawing.Size(61, 21);
            this.lblSalario.TabIndex = 6;
            this.lblSalario.Text = "Salário:";
            this.lblSalario.Visible = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioBtnAluno);
            this.groupBox1.Controls.Add(this.radioBtnProfessor);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.Location = new System.Drawing.Point(48, 36);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(320, 106);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Deseja cadastrar?";
            // 
            // radioBtnAluno
            // 
            this.radioBtnAluno.AutoSize = true;
            this.radioBtnAluno.Location = new System.Drawing.Point(14, 63);
            this.radioBtnAluno.Name = "radioBtnAluno";
            this.radioBtnAluno.Size = new System.Drawing.Size(69, 25);
            this.radioBtnAluno.TabIndex = 1;
            this.radioBtnAluno.TabStop = true;
            this.radioBtnAluno.Text = "Aluno";
            this.radioBtnAluno.UseVisualStyleBackColor = true;
            this.radioBtnAluno.Click += new System.EventHandler(this.radioBtnAluno_Click);
            // 
            // radioBtnProfessor
            // 
            this.radioBtnProfessor.AutoSize = true;
            this.radioBtnProfessor.Location = new System.Drawing.Point(14, 32);
            this.radioBtnProfessor.Name = "radioBtnProfessor";
            this.radioBtnProfessor.Size = new System.Drawing.Size(94, 25);
            this.radioBtnProfessor.TabIndex = 0;
            this.radioBtnProfessor.TabStop = true;
            this.radioBtnProfessor.Text = "Professor";
            this.radioBtnProfessor.UseVisualStyleBackColor = true;
            this.radioBtnProfessor.Click += new System.EventHandler(this.radioBtnProfessor_Click);
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Enabled = false;
            this.btnCadastrar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCadastrar.Location = new System.Drawing.Point(176, 427);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(259, 34);
            this.btnCadastrar.TabIndex = 9;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // txtMedia
            // 
            this.txtMedia.Enabled = false;
            this.txtMedia.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtMedia.Location = new System.Drawing.Point(268, 338);
            this.txtMedia.Name = "txtMedia";
            this.txtMedia.Size = new System.Drawing.Size(100, 29);
            this.txtMedia.TabIndex = 10;
            this.txtMedia.Visible = false;
            // 
            // txtSalario
            // 
            this.txtSalario.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtSalario.Location = new System.Drawing.Point(131, 266);
            this.txtSalario.Mask = "$ #######.00";
            this.txtSalario.Name = "txtSalario";
            this.txtSalario.Size = new System.Drawing.Size(237, 29);
            this.txtSalario.TabIndex = 11;
            this.txtSalario.Visible = false;
            // 
            // groupBoxNotas
            // 
            this.groupBoxNotas.Controls.Add(this.txtNotaTres);
            this.groupBoxNotas.Controls.Add(this.txtNotaDois);
            this.groupBoxNotas.Controls.Add(this.txtNotaUm);
            this.groupBoxNotas.Controls.Add(this.lblNotaTres);
            this.groupBoxNotas.Controls.Add(this.lblNotaDois);
            this.groupBoxNotas.Controls.Add(this.lblNotaUm);
            this.groupBoxNotas.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBoxNotas.Location = new System.Drawing.Point(47, 301);
            this.groupBoxNotas.Name = "groupBoxNotas";
            this.groupBoxNotas.Size = new System.Drawing.Size(200, 120);
            this.groupBoxNotas.TabIndex = 12;
            this.groupBoxNotas.TabStop = false;
            this.groupBoxNotas.Text = "Notas";
            this.groupBoxNotas.Visible = false;
            // 
            // txtNotaTres
            // 
            this.txtNotaTres.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtNotaTres.Location = new System.Drawing.Point(76, 89);
            this.txtNotaTres.Mask = "##.##";
            this.txtNotaTres.Name = "txtNotaTres";
            this.txtNotaTres.Size = new System.Drawing.Size(118, 25);
            this.txtNotaTres.TabIndex = 22;
            // 
            // txtNotaDois
            // 
            this.txtNotaDois.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtNotaDois.Location = new System.Drawing.Point(76, 56);
            this.txtNotaDois.Mask = "##.##";
            this.txtNotaDois.Name = "txtNotaDois";
            this.txtNotaDois.Size = new System.Drawing.Size(118, 25);
            this.txtNotaDois.TabIndex = 21;
            // 
            // txtNotaUm
            // 
            this.txtNotaUm.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtNotaUm.Location = new System.Drawing.Point(76, 25);
            this.txtNotaUm.Mask = "##.##";
            this.txtNotaUm.Name = "txtNotaUm";
            this.txtNotaUm.Size = new System.Drawing.Size(118, 25);
            this.txtNotaUm.TabIndex = 20;
            this.txtNotaUm.Leave += new System.EventHandler(this.txtNotaUm_Leave);
            // 
            // lblNotaTres
            // 
            this.lblNotaTres.AutoSize = true;
            this.lblNotaTres.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblNotaTres.Location = new System.Drawing.Point(7, 91);
            this.lblNotaTres.Name = "lblNotaTres";
            this.lblNotaTres.Size = new System.Drawing.Size(54, 19);
            this.lblNotaTres.TabIndex = 19;
            this.lblNotaTres.Text = "Nota 3:";
            // 
            // lblNotaDois
            // 
            this.lblNotaDois.AutoSize = true;
            this.lblNotaDois.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblNotaDois.Location = new System.Drawing.Point(7, 59);
            this.lblNotaDois.Name = "lblNotaDois";
            this.lblNotaDois.Size = new System.Drawing.Size(54, 19);
            this.lblNotaDois.TabIndex = 17;
            this.lblNotaDois.Text = "Nota 2:";
            // 
            // lblNotaUm
            // 
            this.lblNotaUm.AutoSize = true;
            this.lblNotaUm.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblNotaUm.Location = new System.Drawing.Point(7, 28);
            this.lblNotaUm.Name = "lblNotaUm";
            this.lblNotaUm.Size = new System.Drawing.Size(54, 19);
            this.lblNotaUm.TabIndex = 15;
            this.lblNotaUm.Text = "Nota 1:";
            // 
            // txtCPF
            // 
            this.txtCPF.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtCPF.Location = new System.Drawing.Point(131, 229);
            this.txtCPF.Mask = "###,###,###-##";
            this.txtCPF.Name = "txtCPF";
            this.txtCPF.Size = new System.Drawing.Size(237, 29);
            this.txtCPF.TabIndex = 14;
            this.txtCPF.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.txtCPF.Leave += new System.EventHandler(this.txtCPF_Leave);
            // 
            // lblCPF
            // 
            this.lblCPF.AutoSize = true;
            this.lblCPF.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCPF.Location = new System.Drawing.Point(47, 229);
            this.lblCPF.Name = "lblCPF";
            this.lblCPF.Size = new System.Drawing.Size(40, 21);
            this.lblCPF.TabIndex = 13;
            this.lblCPF.Text = "CPF:";
            this.lblCPF.UseWaitCursor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(597, 473);
            this.Controls.Add(this.txtCPF);
            this.Controls.Add(this.lblCPF);
            this.Controls.Add(this.groupBoxNotas);
            this.Controls.Add(this.txtSalario);
            this.Controls.Add(this.txtMedia);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblSalario);
            this.Controls.Add(this.lblMedia);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.txtMatricula);
            this.Controls.Add(this.lblMatricula);
            this.Name = "Form1";
            this.Text = "Exemplo de Herança";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBoxNotas.ResumeLayout(false);
            this.groupBoxNotas.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblMatricula;
        private TextBox txtMatricula;
        private TextBox txtNome;
        private Label lblNome;
        private Label lblMedia;
        private Label lblSalario;
        private GroupBox groupBox1;
        private RadioButton radioBtnAluno;
        private RadioButton radioBtnProfessor;
        private Button btnCadastrar;
        private MaskedTextBox txtMedia;
        private MaskedTextBox txtSalario;
        private GroupBox groupBoxNotas;
        private MaskedTextBox txtCPF;
        private Label lblCPF;
        private MaskedTextBox txtNotaTres;
        private MaskedTextBox txtNotaDois;
        private MaskedTextBox txtNotaUm;
        private Label lblNotaTres;
        private Label lblNotaDois;
        private Label lblNotaUm;
    }
}