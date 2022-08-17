namespace Enum
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnMostrarEnum = new System.Windows.Forms.Button();
            this.lblMostarEnum = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(261, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(278, 46);
            this.label1.TabIndex = 0;
            this.label1.Text = "USANDO ENUM";
            // 
            // btnMostrarEnum
            // 
            this.btnMostrarEnum.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnMostrarEnum.Location = new System.Drawing.Point(291, 282);
            this.btnMostrarEnum.Name = "btnMostrarEnum";
            this.btnMostrarEnum.Size = new System.Drawing.Size(161, 102);
            this.btnMostrarEnum.TabIndex = 1;
            this.btnMostrarEnum.Text = "MOSTRAR ENUM";
            this.btnMostrarEnum.UseVisualStyleBackColor = true;
            this.btnMostrarEnum.Click += new System.EventHandler(this.btnMostrarEnum_Click);
            // 
            // lblMostarEnum
            // 
            this.lblMostarEnum.AutoSize = true;
            this.lblMostarEnum.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblMostarEnum.Location = new System.Drawing.Point(12, 151);
            this.lblMostarEnum.Name = "lblMostarEnum";
            this.lblMostarEnum.Size = new System.Drawing.Size(101, 32);
            this.lblMostarEnum.TabIndex = 2;
            this.lblMostarEnum.Text = "Enum:   ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblMostarEnum);
            this.Controls.Add(this.btnMostrarEnum);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Button btnMostrarEnum;
        private Label lblMostarEnum;
    }
}