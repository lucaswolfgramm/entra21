namespace meu_projeto
{
    partial class Form2
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
            this.buttonSalvar = new System.Windows.Forms.Button();
            this.buttonSair = new System.Windows.Forms.Button();
            this.inputNome = new System.Windows.Forms.TextBox();
            this.labelNome = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.imagemCliente = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonForm3 = new System.Windows.Forms.Button();
            this.buttonForm2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.imagemCliente)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonSalvar
            // 
            this.buttonSalvar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonSalvar.Location = new System.Drawing.Point(111, 396);
            this.buttonSalvar.Name = "buttonSalvar";
            this.buttonSalvar.Size = new System.Drawing.Size(78, 30);
            this.buttonSalvar.TabIndex = 0;
            this.buttonSalvar.Text = "Salvar";
            this.buttonSalvar.UseVisualStyleBackColor = true;
            // 
            // buttonSair
            // 
            this.buttonSair.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonSair.Location = new System.Drawing.Point(19, 396);
            this.buttonSair.Name = "buttonSair";
            this.buttonSair.Size = new System.Drawing.Size(86, 30);
            this.buttonSair.TabIndex = 1;
            this.buttonSair.Text = "Sair";
            this.buttonSair.UseVisualStyleBackColor = true;
            this.buttonSair.Click += new System.EventHandler(this.buttonSair_Click);
            // 
            // inputNome
            // 
            this.inputNome.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.inputNome.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.inputNome.Location = new System.Drawing.Point(85, 55);
            this.inputNome.Name = "inputNome";
            this.inputNome.Size = new System.Drawing.Size(230, 27);
            this.inputNome.TabIndex = 9;
            // 
            // labelNome
            // 
            this.labelNome.AutoSize = true;
            this.labelNome.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelNome.Location = new System.Drawing.Point(26, 57);
            this.labelNome.Name = "labelNome";
            this.labelNome.Size = new System.Drawing.Size(53, 21);
            this.labelNome.TabIndex = 8;
            this.labelNome.Text = "Nome";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(7, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(216, 28);
            this.label1.TabIndex = 7;
            this.label1.Text = "Cadastro de automóvel";
            // 
            // imagemCliente
            // 
            this.imagemCliente.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.imagemCliente.Image = global::meu_projeto.Properties.Resources.Icone_carro_Png;
            this.imagemCliente.Location = new System.Drawing.Point(42, 15);
            this.imagemCliente.Name = "imagemCliente";
            this.imagemCliente.Size = new System.Drawing.Size(123, 134);
            this.imagemCliente.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imagemCliente.TabIndex = 5;
            this.imagemCliente.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.buttonSalvar);
            this.panel1.Controls.Add(this.imagemCliente);
            this.panel1.Controls.Add(this.buttonSair);
            this.panel1.Location = new System.Drawing.Point(594, 6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 438);
            this.panel1.TabIndex = 10;
            // 
            // buttonForm3
            // 
            this.buttonForm3.Location = new System.Drawing.Point(393, 409);
            this.buttonForm3.Name = "buttonForm3";
            this.buttonForm3.Size = new System.Drawing.Size(75, 23);
            this.buttonForm3.TabIndex = 12;
            this.buttonForm3.Text = "Form3";
            this.buttonForm3.UseVisualStyleBackColor = true;
            this.buttonForm3.Click += new System.EventHandler(this.buttonForm3_Click);
            // 
            // buttonForm2
            // 
            this.buttonForm2.Location = new System.Drawing.Point(487, 409);
            this.buttonForm2.Name = "buttonForm2";
            this.buttonForm2.Size = new System.Drawing.Size(75, 23);
            this.buttonForm2.TabIndex = 11;
            this.buttonForm2.Text = "Form1";
            this.buttonForm2.UseVisualStyleBackColor = true;
            this.buttonForm2.Click += new System.EventHandler(this.buttonForm2_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonForm3);
            this.Controls.Add(this.buttonForm2);
            this.Controls.Add(this.inputNome);
            this.Controls.Add(this.labelNome);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Name = "Form2";
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.imagemCliente)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button buttonSalvar;
        private Button buttonSair;
        private TextBox inputNome;
        private Label labelNome;
        private Label label1;
        private PictureBox imagemCliente;
        private Panel panel1;
        private Button buttonForm3;
        private Button buttonForm2;
    }
}