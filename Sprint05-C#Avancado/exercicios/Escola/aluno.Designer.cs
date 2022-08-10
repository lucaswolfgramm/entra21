namespace Escola
{
    partial class aluno
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
            this.groupBoxResultado = new System.Windows.Forms.GroupBox();
            this.lblResultado = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.lblEndereco = new System.Windows.Forms.Label();
            this.lblNotaUm = new System.Windows.Forms.Label();
            this.lblNotaDois = new System.Windows.Forms.Label();
            this.lblNotaTres = new System.Windows.Forms.Label();
            this.groupBoxNotas = new System.Windows.Forms.GroupBox();
            this.txtNotaTres = new System.Windows.Forms.TextBox();
            this.txtNotaDois = new System.Windows.Forms.TextBox();
            this.txtNotaUm = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtEndereco = new System.Windows.Forms.TextBox();
            this.lblDataNasc = new System.Windows.Forms.Label();
            this.datePickerDataNasc = new System.Windows.Forms.DateTimePicker();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblSituacao = new System.Windows.Forms.Label();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.groupBoxResultado.SuspendLayout();
            this.groupBoxNotas.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxResultado
            // 
            this.groupBoxResultado.Controls.Add(this.lblResultado);
            this.groupBoxResultado.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBoxResultado.Location = new System.Drawing.Point(12, 395);
            this.groupBoxResultado.Name = "groupBoxResultado";
            this.groupBoxResultado.Size = new System.Drawing.Size(586, 234);
            this.groupBoxResultado.TabIndex = 0;
            this.groupBoxResultado.TabStop = false;
            this.groupBoxResultado.Text = "Resultado";
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Location = new System.Drawing.Point(22, 39);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(0, 21);
            this.lblResultado.TabIndex = 0;
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblNome.Location = new System.Drawing.Point(30, 43);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(56, 21);
            this.lblNome.TabIndex = 1;
            this.lblNome.Text = "Nome:";
            // 
            // lblEndereco
            // 
            this.lblEndereco.AutoSize = true;
            this.lblEndereco.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblEndereco.Location = new System.Drawing.Point(30, 81);
            this.lblEndereco.Name = "lblEndereco";
            this.lblEndereco.Size = new System.Drawing.Size(77, 21);
            this.lblEndereco.TabIndex = 2;
            this.lblEndereco.Text = "Endereço:";
            // 
            // lblNotaUm
            // 
            this.lblNotaUm.AutoSize = true;
            this.lblNotaUm.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblNotaUm.Location = new System.Drawing.Point(19, 16);
            this.lblNotaUm.Name = "lblNotaUm";
            this.lblNotaUm.Size = new System.Drawing.Size(60, 21);
            this.lblNotaUm.TabIndex = 3;
            this.lblNotaUm.Text = "Nota 1:";
            // 
            // lblNotaDois
            // 
            this.lblNotaDois.AutoSize = true;
            this.lblNotaDois.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblNotaDois.Location = new System.Drawing.Point(19, 52);
            this.lblNotaDois.Name = "lblNotaDois";
            this.lblNotaDois.Size = new System.Drawing.Size(60, 21);
            this.lblNotaDois.TabIndex = 4;
            this.lblNotaDois.Text = "Nota 2:";
            // 
            // lblNotaTres
            // 
            this.lblNotaTres.AutoSize = true;
            this.lblNotaTres.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblNotaTres.Location = new System.Drawing.Point(19, 91);
            this.lblNotaTres.Name = "lblNotaTres";
            this.lblNotaTres.Size = new System.Drawing.Size(60, 21);
            this.lblNotaTres.TabIndex = 5;
            this.lblNotaTres.Text = "Nota 3:";
            // 
            // groupBoxNotas
            // 
            this.groupBoxNotas.Controls.Add(this.txtNotaTres);
            this.groupBoxNotas.Controls.Add(this.txtNotaDois);
            this.groupBoxNotas.Controls.Add(this.txtNotaUm);
            this.groupBoxNotas.Controls.Add(this.lblNotaDois);
            this.groupBoxNotas.Controls.Add(this.lblNotaUm);
            this.groupBoxNotas.Controls.Add(this.lblNotaTres);
            this.groupBoxNotas.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBoxNotas.Location = new System.Drawing.Point(30, 148);
            this.groupBoxNotas.Name = "groupBoxNotas";
            this.groupBoxNotas.Size = new System.Drawing.Size(357, 123);
            this.groupBoxNotas.TabIndex = 7;
            this.groupBoxNotas.TabStop = false;
            this.groupBoxNotas.Text = "Notas";
            // 
            // txtNotaTres
            // 
            this.txtNotaTres.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtNotaTres.Location = new System.Drawing.Point(97, 88);
            this.txtNotaTres.Name = "txtNotaTres";
            this.txtNotaTres.Size = new System.Drawing.Size(247, 29);
            this.txtNotaTres.TabIndex = 12;
            this.txtNotaTres.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNota_KeyPress);
            // 
            // txtNotaDois
            // 
            this.txtNotaDois.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtNotaDois.Location = new System.Drawing.Point(97, 52);
            this.txtNotaDois.Name = "txtNotaDois";
            this.txtNotaDois.Size = new System.Drawing.Size(247, 29);
            this.txtNotaDois.TabIndex = 11;
            this.txtNotaDois.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNota_KeyPress);
            // 
            // txtNotaUm
            // 
            this.txtNotaUm.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtNotaUm.Location = new System.Drawing.Point(97, 13);
            this.txtNotaUm.Name = "txtNotaUm";
            this.txtNotaUm.Size = new System.Drawing.Size(247, 29);
            this.txtNotaUm.TabIndex = 10;
            this.txtNotaUm.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNota_KeyPress);
            // 
            // txtNome
            // 
            this.txtNome.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtNome.Location = new System.Drawing.Point(127, 43);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(247, 29);
            this.txtNome.TabIndex = 8;
            // 
            // txtEndereco
            // 
            this.txtEndereco.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtEndereco.Location = new System.Drawing.Point(127, 80);
            this.txtEndereco.Name = "txtEndereco";
            this.txtEndereco.Size = new System.Drawing.Size(247, 29);
            this.txtEndereco.TabIndex = 9;
            // 
            // lblDataNasc
            // 
            this.lblDataNasc.AutoSize = true;
            this.lblDataNasc.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblDataNasc.Location = new System.Drawing.Point(30, 121);
            this.lblDataNasc.Name = "lblDataNasc";
            this.lblDataNasc.Size = new System.Drawing.Size(86, 21);
            this.lblDataNasc.TabIndex = 6;
            this.lblDataNasc.Text = "Data Nasc.:";
            // 
            // datePickerDataNasc
            // 
            this.datePickerDataNasc.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.datePickerDataNasc.Location = new System.Drawing.Point(127, 116);
            this.datePickerDataNasc.Name = "datePickerDataNasc";
            this.datePickerDataNasc.Size = new System.Drawing.Size(247, 23);
            this.datePickerDataNasc.TabIndex = 11;
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCadastrar.Location = new System.Drawing.Point(49, 325);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(118, 40);
            this.btnCadastrar.TabIndex = 12;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(143, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(283, 25);
            this.label1.TabIndex = 14;
            this.label1.Text = "EXEMPLO DE CLASSE - ALUNO";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel1.Controls.Add(this.lblSituacao);
            this.panel1.Location = new System.Drawing.Point(398, 278);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 100);
            this.panel1.TabIndex = 15;
            // 
            // lblSituacao
            // 
            this.lblSituacao.AutoSize = true;
            this.lblSituacao.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblSituacao.Location = new System.Drawing.Point(3, 40);
            this.lblSituacao.Name = "lblSituacao";
            this.lblSituacao.Size = new System.Drawing.Size(85, 21);
            this.lblSituacao.TabIndex = 0;
            this.lblSituacao.Text = "Situação: ...";
            // 
            // btnCalcular
            // 
            this.btnCalcular.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCalcular.Location = new System.Drawing.Point(256, 325);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(118, 40);
            this.btnCalcular.TabIndex = 16;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // aluno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(610, 641);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.datePickerDataNasc);
            this.Controls.Add(this.txtEndereco);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.groupBoxNotas);
            this.Controls.Add(this.lblDataNasc);
            this.Controls.Add(this.lblEndereco);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.groupBoxResultado);
            this.Name = "aluno";
            this.Text = "Form1";
            this.groupBoxResultado.ResumeLayout(false);
            this.groupBoxResultado.PerformLayout();
            this.groupBoxNotas.ResumeLayout(false);
            this.groupBoxNotas.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private GroupBox groupBoxResultado;
        private Label lblNome;
        private Label lblEndereco;
        private Label lblNotaUm;
        private Label lblNotaDois;
        private Label lblNotaTres;
        private GroupBox groupBoxNotas;
        private TextBox txtNotaTres;
        private TextBox txtNotaDois;
        private TextBox txtNotaUm;
        private TextBox txtNome;
        private TextBox txtEndereco;
        private Label lblDataNasc;
        private Label lblResultado;
        private DateTimePicker datePickerDataNasc;
        private Button btnCadastrar;
        private Label label1;
        private Panel panel1;
        private Label lblSituacao;
        private Button btnCalcular;
    }
}