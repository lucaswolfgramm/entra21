namespace exercicios_exemplo
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
            this.labelIdade = new System.Windows.Forms.Label();
            this.txbIdade = new System.Windows.Forms.TextBox();
            this.txbResultado = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.btnVerificar = new System.Windows.Forms.Button();
            this.panelBackground = new System.Windows.Forms.Panel();
            this.panelBackground.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelIdade
            // 
            this.labelIdade.AutoSize = true;
            this.labelIdade.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelIdade.Location = new System.Drawing.Point(41, 52);
            this.labelIdade.Name = "labelIdade";
            this.labelIdade.Size = new System.Drawing.Size(138, 21);
            this.labelIdade.TabIndex = 0;
            this.labelIdade.Text = "Informe sua Idade:";
            // 
            // txbIdade
            // 
            this.txbIdade.Location = new System.Drawing.Point(178, 54);
            this.txbIdade.Multiline = true;
            this.txbIdade.Name = "txbIdade";
            this.txbIdade.Size = new System.Drawing.Size(158, 23);
            this.txbIdade.TabIndex = 1;
            this.txbIdade.TextChanged += new System.EventHandler(this.txbIdade_TextChanged);
            // 
            // txbResultado
            // 
            this.txbResultado.AutoSize = true;
            this.txbResultado.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txbResultado.Location = new System.Drawing.Point(145, 224);
            this.txbResultado.Name = "txbResultado";
            this.txbResultado.Size = new System.Drawing.Size(24, 25);
            this.txbResultado.TabIndex = 2;
            this.txbResultado.Text = "...";
            // 
            // progressBar1
            // 
            this.progressBar1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.progressBar1.Location = new System.Drawing.Point(130, 131);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(218, 30);
            this.progressBar1.TabIndex = 3;
            this.progressBar1.Value = 1;
            this.progressBar1.Visible = false;
            // 
            // btnVerificar
            // 
            this.btnVerificar.Enabled = false;
            this.btnVerificar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnVerificar.Location = new System.Drawing.Point(196, 167);
            this.btnVerificar.Name = "btnVerificar";
            this.btnVerificar.Size = new System.Drawing.Size(90, 32);
            this.btnVerificar.TabIndex = 4;
            this.btnVerificar.Text = "Verificar";
            this.btnVerificar.UseVisualStyleBackColor = true;
            this.btnVerificar.Click += new System.EventHandler(this.btnVerificar_Click);
            // 
            // panelBackground
            // 
            this.panelBackground.Controls.Add(this.progressBar1);
            this.panelBackground.Location = new System.Drawing.Point(0, 0);
            this.panelBackground.Name = "panelBackground";
            this.panelBackground.Size = new System.Drawing.Size(469, 275);
            this.panelBackground.TabIndex = 5;
            this.panelBackground.Visible = false;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(469, 274);
            this.Controls.Add(this.btnVerificar);
            this.Controls.Add(this.txbResultado);
            this.Controls.Add(this.txbIdade);
            this.Controls.Add(this.labelIdade);
            this.Controls.Add(this.panelBackground);
            this.Name = "Form2";
            this.Text = "Form2";
            this.panelBackground.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label labelIdade;
        private TextBox txbIdade;
        private Label txbResultado;
        private ProgressBar progressBar1;
        private Button btnVerificar;
        private Panel panelBackground;
    }
}