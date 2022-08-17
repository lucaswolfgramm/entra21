namespace Tupla
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
            this.btnMostrarTupla = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblTupla = new System.Windows.Forms.Label();
            this.btnAlterarTupla = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNum2 = new System.Windows.Forms.TextBox();
            this.txtNum1 = new System.Windows.Forms.TextBox();
            this.btnMostrar2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnMostrarTupla
            // 
            this.btnMostrarTupla.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnMostrarTupla.Location = new System.Drawing.Point(51, 287);
            this.btnMostrarTupla.Name = "btnMostrarTupla";
            this.btnMostrarTupla.Size = new System.Drawing.Size(210, 110);
            this.btnMostrarTupla.TabIndex = 0;
            this.btnMostrarTupla.Text = "MOSTRAR TUPLA";
            this.btnMostrarTupla.UseVisualStyleBackColor = true;
            this.btnMostrarTupla.Click += new System.EventHandler(this.btnMostrarTupla_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(284, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 37);
            this.label1.TabIndex = 1;
            this.label1.Text = "TUPLA";
            // 
            // lblTupla
            // 
            this.lblTupla.AutoSize = true;
            this.lblTupla.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTupla.Location = new System.Drawing.Point(98, 163);
            this.lblTupla.Name = "lblTupla";
            this.lblTupla.Size = new System.Drawing.Size(94, 37);
            this.lblTupla.TabIndex = 2;
            this.lblTupla.Text = "Tupla:";
            // 
            // btnAlterarTupla
            // 
            this.btnAlterarTupla.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAlterarTupla.Location = new System.Drawing.Point(328, 287);
            this.btnAlterarTupla.Name = "btnAlterarTupla";
            this.btnAlterarTupla.Size = new System.Drawing.Size(210, 110);
            this.btnAlterarTupla.TabIndex = 3;
            this.btnAlterarTupla.Text = "ALTERAR TUPLA";
            this.btnAlterarTupla.UseVisualStyleBackColor = true;
            this.btnAlterarTupla.Click += new System.EventHandler(this.btnAlterarTupla_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(508, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 37);
            this.label2.TabIndex = 4;
            this.label2.Text = "Num1:";
            this.label2.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(508, 183);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 37);
            this.label3.TabIndex = 5;
            this.label3.Text = "Num2:";
            this.label3.Visible = false;
            // 
            // txtNum2
            // 
            this.txtNum2.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtNum2.Location = new System.Drawing.Point(610, 183);
            this.txtNum2.Name = "txtNum2";
            this.txtNum2.Size = new System.Drawing.Size(125, 43);
            this.txtNum2.TabIndex = 6;
            this.txtNum2.Visible = false;
            // 
            // txtNum1
            // 
            this.txtNum1.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtNum1.Location = new System.Drawing.Point(610, 125);
            this.txtNum1.Name = "txtNum1";
            this.txtNum1.Size = new System.Drawing.Size(125, 43);
            this.txtNum1.TabIndex = 7;
            this.txtNum1.Visible = false;
            // 
            // btnMostrar2
            // 
            this.btnMostrar2.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnMostrar2.Location = new System.Drawing.Point(569, 287);
            this.btnMostrar2.Name = "btnMostrar2";
            this.btnMostrar2.Size = new System.Drawing.Size(210, 110);
            this.btnMostrar2.TabIndex = 8;
            this.btnMostrar2.Text = "MOSTRAR TUPLAS 2";
            this.btnMostrar2.UseVisualStyleBackColor = true;
            this.btnMostrar2.Visible = false;
            this.btnMostrar2.Click += new System.EventHandler(this.btnMostrar2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnMostrar2);
            this.Controls.Add(this.txtNum1);
            this.Controls.Add(this.txtNum2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnAlterarTupla);
            this.Controls.Add(this.lblTupla);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnMostrarTupla);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnMostrarTupla;
        private Label label1;
        private Label lblTupla;
        private Button btnAlterarTupla;
        private Label label2;
        private Label label3;
        private TextBox txtNum2;
        private TextBox txtNum1;
        private Button btnMostrar2;
    }
}