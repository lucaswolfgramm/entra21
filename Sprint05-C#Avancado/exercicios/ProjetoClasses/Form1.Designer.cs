namespace ProjetoClasses
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSair = new System.Windows.Forms.Button();
            this.maskedTxtLimiteCredito = new System.Windows.Forms.MaskedTextBox();
            this.maskedTxtContato = new System.Windows.Forms.MaskedTextBox();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.labelDataNasc = new System.Windows.Forms.Label();
            this.datePickerNasc = new System.Windows.Forms.DateTimePicker();
            this.labelNumCartao = new System.Windows.Forms.Label();
            this.txtNumCartao = new System.Windows.Forms.TextBox();
            this.labelLimiteCredito = new System.Windows.Forms.Label();
            this.labelContato = new System.Windows.Forms.Label();
            this.txtEndereco = new System.Windows.Forms.TextBox();
            this.labelEndereco = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.labelNome = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnSair);
            this.groupBox1.Controls.Add(this.maskedTxtLimiteCredito);
            this.groupBox1.Controls.Add(this.maskedTxtContato);
            this.groupBox1.Controls.Add(this.btnCadastrar);
            this.groupBox1.Controls.Add(this.labelDataNasc);
            this.groupBox1.Controls.Add(this.datePickerNasc);
            this.groupBox1.Controls.Add(this.labelNumCartao);
            this.groupBox1.Controls.Add(this.txtNumCartao);
            this.groupBox1.Controls.Add(this.labelLimiteCredito);
            this.groupBox1.Controls.Add(this.labelContato);
            this.groupBox1.Controls.Add(this.txtEndereco);
            this.groupBox1.Controls.Add(this.labelEndereco);
            this.groupBox1.Controls.Add(this.txtNome);
            this.groupBox1.Controls.Add(this.labelNome);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(494, 438);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Classe Cliente";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(423, 397);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(65, 35);
            this.btnSair.TabIndex = 18;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // maskedTxtLimiteCredito
            // 
            this.maskedTxtLimiteCredito.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.maskedTxtLimiteCredito.ImeMode = System.Windows.Forms.ImeMode.On;
            this.maskedTxtLimiteCredito.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Insert;
            this.maskedTxtLimiteCredito.Location = new System.Drawing.Point(159, 235);
            this.maskedTxtLimiteCredito.Mask = "$ 00000000.00";
            this.maskedTxtLimiteCredito.Name = "maskedTxtLimiteCredito";
            this.maskedTxtLimiteCredito.Size = new System.Drawing.Size(320, 31);
            this.maskedTxtLimiteCredito.TabIndex = 17;
            this.maskedTxtLimiteCredito.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // maskedTxtContato
            // 
            this.maskedTxtContato.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.maskedTxtContato.Location = new System.Drawing.Point(159, 142);
            this.maskedTxtContato.Mask = "(99) 0000-0000";
            this.maskedTxtContato.Name = "maskedTxtContato";
            this.maskedTxtContato.Size = new System.Drawing.Size(320, 31);
            this.maskedTxtContato.TabIndex = 16;
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Location = new System.Drawing.Point(170, 362);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(141, 43);
            this.btnCadastrar.TabIndex = 14;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // labelDataNasc
            // 
            this.labelDataNasc.AutoSize = true;
            this.labelDataNasc.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelDataNasc.Location = new System.Drawing.Point(6, 193);
            this.labelDataNasc.Name = "labelDataNasc";
            this.labelDataNasc.Size = new System.Drawing.Size(129, 21);
            this.labelDataNasc.TabIndex = 13;
            this.labelDataNasc.Text = "Data nascimento:";
            // 
            // datePickerNasc
            // 
            this.datePickerNasc.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.datePickerNasc.Location = new System.Drawing.Point(159, 190);
            this.datePickerNasc.Name = "datePickerNasc";
            this.datePickerNasc.Size = new System.Drawing.Size(320, 29);
            this.datePickerNasc.TabIndex = 12;
            this.datePickerNasc.ValueChanged += new System.EventHandler(this.datePickerNasc_ValueChanged);
            // 
            // labelNumCartao
            // 
            this.labelNumCartao.AutoSize = true;
            this.labelNumCartao.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelNumCartao.Location = new System.Drawing.Point(6, 281);
            this.labelNumCartao.Name = "labelNumCartao";
            this.labelNumCartao.Size = new System.Drawing.Size(104, 21);
            this.labelNumCartao.TabIndex = 10;
            this.labelNumCartao.Text = "Nº do Cartão:";
            // 
            // txtNumCartao
            // 
            this.txtNumCartao.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtNumCartao.Location = new System.Drawing.Point(159, 277);
            this.txtNumCartao.Name = "txtNumCartao";
            this.txtNumCartao.Size = new System.Drawing.Size(320, 29);
            this.txtNumCartao.TabIndex = 9;
            this.txtNumCartao.TextChanged += new System.EventHandler(this.txtNumCartao_TextChanged);
            this.txtNumCartao.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNumCartao_KeyPress);
            // 
            // labelLimiteCredito
            // 
            this.labelLimiteCredito.AutoSize = true;
            this.labelLimiteCredito.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelLimiteCredito.Location = new System.Drawing.Point(6, 239);
            this.labelLimiteCredito.Name = "labelLimiteCredito";
            this.labelLimiteCredito.Size = new System.Drawing.Size(132, 21);
            this.labelLimiteCredito.TabIndex = 8;
            this.labelLimiteCredito.Text = "Limite de Crédito:";
            // 
            // labelContato
            // 
            this.labelContato.AutoSize = true;
            this.labelContato.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelContato.Location = new System.Drawing.Point(6, 146);
            this.labelContato.Name = "labelContato";
            this.labelContato.Size = new System.Drawing.Size(68, 21);
            this.labelContato.TabIndex = 4;
            this.labelContato.Text = "Contato:";
            // 
            // txtEndereco
            // 
            this.txtEndereco.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtEndereco.Location = new System.Drawing.Point(159, 99);
            this.txtEndereco.Name = "txtEndereco";
            this.txtEndereco.Size = new System.Drawing.Size(320, 29);
            this.txtEndereco.TabIndex = 3;
            // 
            // labelEndereco
            // 
            this.labelEndereco.AutoSize = true;
            this.labelEndereco.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelEndereco.Location = new System.Drawing.Point(6, 103);
            this.labelEndereco.Name = "labelEndereco";
            this.labelEndereco.Size = new System.Drawing.Size(77, 21);
            this.labelEndereco.TabIndex = 2;
            this.labelEndereco.Text = "Endereço:";
            // 
            // txtNome
            // 
            this.txtNome.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtNome.Location = new System.Drawing.Point(159, 55);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(320, 29);
            this.txtNome.TabIndex = 1;
            // 
            // labelNome
            // 
            this.labelNome.AutoSize = true;
            this.labelNome.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelNome.Location = new System.Drawing.Point(6, 57);
            this.labelNome.Name = "labelNome";
            this.labelNome.Size = new System.Drawing.Size(56, 21);
            this.labelNome.TabIndex = 0;
            this.labelNome.Text = "Nome:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(518, 462);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private GroupBox groupBox1;
        private TextBox txtNome;
        private Label labelNome;
        private Label labelEndereco;
        private Label labelContato;
        private TextBox txtEndereco;
        private Label labelLimiteCredito;
        private DateTimePicker datePickerNasc;
        private Label labelNumCartao;
        private TextBox txtNumCartao;
        private Button btnCadastrar;
        private Label labelDataNasc;
        private MaskedTextBox maskedTxtContato;
        private MaskedTextBox maskedTxtLimiteCredito;
        private Button btnSair;
    }
}