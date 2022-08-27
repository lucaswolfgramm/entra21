using System.Data;

namespace list1
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

        Form1 form1 = new Form1();

        string connectionString = @"Server=.\sqlexpress;Database=bdcadastro;Trusted_Connection=True;";
        bool novo;

        public void frmCadastroCliente()
        {
            InitializeComponent();
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tsbNovo = new System.Windows.Forms.PictureBox();
            this.tsbSalvar = new System.Windows.Forms.PictureBox();
            this.tsbCancelar = new System.Windows.Forms.PictureBox();
            this.tsbExcluir = new System.Windows.Forms.PictureBox();
            this.tsbBuscar = new System.Windows.Forms.PictureBox();
            this.tsbBuscaPorId = new System.Windows.Forms.Label();
            this.tstId = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtEndereco = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtBairro = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtCidade = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtUf = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.mskCEP = new System.Windows.Forms.MaskedTextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.mskTelefone = new System.Windows.Forms.MaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.tsbNovo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tsbSalvar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tsbCancelar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tsbExcluir)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tsbBuscar)).BeginInit();
            this.SuspendLayout();
            // 
            // tsbNovo
            // 
            this.tsbNovo.Image = ((System.Drawing.Image)(resources.GetObject("tsbNovo.Image")));
            this.tsbNovo.Location = new System.Drawing.Point(12, 10);
            this.tsbNovo.Name = "tsbNovo";
            this.tsbNovo.Size = new System.Drawing.Size(24, 29);
            this.tsbNovo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.tsbNovo.TabIndex = 0;
            this.tsbNovo.TabStop = false;
            this.tsbNovo.Tag = "Novo";
            // 
            // tsbSalvar
            // 
            this.tsbSalvar.ErrorImage = ((System.Drawing.Image)(resources.GetObject("tsbSalvar.ErrorImage")));
            this.tsbSalvar.Image = ((System.Drawing.Image)(resources.GetObject("tsbSalvar.Image")));
            this.tsbSalvar.Location = new System.Drawing.Point(42, 12);
            this.tsbSalvar.Name = "tsbSalvar";
            this.tsbSalvar.Size = new System.Drawing.Size(24, 27);
            this.tsbSalvar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.tsbSalvar.TabIndex = 1;
            this.tsbSalvar.TabStop = false;
            // 
            // tsbCancelar
            // 
            this.tsbCancelar.ErrorImage = ((System.Drawing.Image)(resources.GetObject("tsbCancelar.ErrorImage")));
            this.tsbCancelar.Image = ((System.Drawing.Image)(resources.GetObject("tsbCancelar.Image")));
            this.tsbCancelar.Location = new System.Drawing.Point(72, 12);
            this.tsbCancelar.Name = "tsbCancelar";
            this.tsbCancelar.Size = new System.Drawing.Size(24, 27);
            this.tsbCancelar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.tsbCancelar.TabIndex = 2;
            this.tsbCancelar.TabStop = false;
            // 
            // tsbExcluir
            // 
            this.tsbExcluir.Image = ((System.Drawing.Image)(resources.GetObject("tsbExcluir.Image")));
            this.tsbExcluir.Location = new System.Drawing.Point(102, 12);
            this.tsbExcluir.Name = "tsbExcluir";
            this.tsbExcluir.Size = new System.Drawing.Size(24, 27);
            this.tsbExcluir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.tsbExcluir.TabIndex = 3;
            this.tsbExcluir.TabStop = false;
            // 
            // tsbBuscar
            // 
            this.tsbBuscar.Image = ((System.Drawing.Image)(resources.GetObject("tsbBuscar.Image")));
            this.tsbBuscar.Location = new System.Drawing.Point(472, 12);
            this.tsbBuscar.Name = "tsbBuscar";
            this.tsbBuscar.Size = new System.Drawing.Size(24, 27);
            this.tsbBuscar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.tsbBuscar.TabIndex = 4;
            this.tsbBuscar.TabStop = false;
            // 
            // tsbBuscaPorId
            // 
            this.tsbBuscaPorId.AutoSize = true;
            this.tsbBuscaPorId.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tsbBuscaPorId.Location = new System.Drawing.Point(132, 12);
            this.tsbBuscaPorId.Name = "tsbBuscaPorId";
            this.tsbBuscaPorId.Size = new System.Drawing.Size(139, 25);
            this.tsbBuscaPorId.TabIndex = 5;
            this.tsbBuscaPorId.Text = "| Buscar por ID:";
            // 
            // tstId
            // 
            this.tstId.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tstId.Location = new System.Drawing.Point(266, 9);
            this.tstId.Name = "tstId";
            this.tstId.Size = new System.Drawing.Size(200, 32);
            this.tstId.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(21, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 25);
            this.label2.TabIndex = 7;
            this.label2.Text = "ID:";
            // 
            // txtId
            // 
            this.txtId.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtId.Location = new System.Drawing.Point(21, 82);
            this.txtId.Name = "txtId";
            this.txtId.ReadOnly = true;
            this.txtId.Size = new System.Drawing.Size(117, 32);
            this.txtId.TabIndex = 8;
            // 
            // txtNome
            // 
            this.txtNome.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNome.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtNome.Location = new System.Drawing.Point(154, 82);
            this.txtNome.MaxLength = 50;
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(611, 32);
            this.txtNome.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(154, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 25);
            this.label3.TabIndex = 9;
            this.label3.Text = "Nome:";
            // 
            // txtEndereco
            // 
            this.txtEndereco.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtEndereco.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtEndereco.Location = new System.Drawing.Point(21, 155);
            this.txtEndereco.MaxLength = 50;
            this.txtEndereco.Name = "txtEndereco";
            this.txtEndereco.Size = new System.Drawing.Size(744, 32);
            this.txtEndereco.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(21, 127);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 25);
            this.label4.TabIndex = 11;
            this.label4.Text = "Endereço:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(21, 197);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 25);
            this.label5.TabIndex = 13;
            this.label5.Text = "CEP:";
            // 
            // txtBairro
            // 
            this.txtBairro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtBairro.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtBairro.Location = new System.Drawing.Point(154, 225);
            this.txtBairro.MaxLength = 50;
            this.txtBairro.Name = "txtBairro";
            this.txtBairro.Size = new System.Drawing.Size(251, 32);
            this.txtBairro.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(154, 197);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 25);
            this.label6.TabIndex = 14;
            this.label6.Text = "Bairro:";
            // 
            // txtCidade
            // 
            this.txtCidade.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCidade.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtCidade.Location = new System.Drawing.Point(411, 225);
            this.txtCidade.MaxLength = 50;
            this.txtCidade.Name = "txtCidade";
            this.txtCidade.Size = new System.Drawing.Size(251, 32);
            this.txtCidade.TabIndex = 17;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(411, 197);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 25);
            this.label7.TabIndex = 16;
            this.label7.Text = "Cidade:";
            // 
            // txtUf
            // 
            this.txtUf.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtUf.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtUf.Location = new System.Drawing.Point(668, 225);
            this.txtUf.MaxLength = 2;
            this.txtUf.Name = "txtUf";
            this.txtUf.Size = new System.Drawing.Size(97, 32);
            this.txtUf.TabIndex = 19;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(668, 197);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(38, 25);
            this.label8.TabIndex = 18;
            this.label8.Text = "UF:";
            // 
            // mskCEP
            // 
            this.mskCEP.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.mskCEP.Location = new System.Drawing.Point(21, 225);
            this.mskCEP.Mask = "00000-999";
            this.mskCEP.Name = "mskCEP";
            this.mskCEP.Size = new System.Drawing.Size(117, 32);
            this.mskCEP.TabIndex = 20;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(21, 274);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(87, 25);
            this.label9.TabIndex = 21;
            this.label9.Text = "Telefone:";
            // 
            // mskTelefone
            // 
            this.mskTelefone.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.mskTelefone.Location = new System.Drawing.Point(21, 311);
            this.mskTelefone.Mask = "(99) 0000-0000";
            this.mskTelefone.Name = "mskTelefone";
            this.mskTelefone.Size = new System.Drawing.Size(200, 32);
            this.mskTelefone.TabIndex = 22;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.mskTelefone);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.mskCEP);
            this.Controls.Add(this.txtUf);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtCidade);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtBairro);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtEndereco);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tstId);
            this.Controls.Add(this.tsbBuscaPorId);
            this.Controls.Add(this.tsbBuscar);
            this.Controls.Add(this.tsbExcluir);
            this.Controls.Add(this.tsbCancelar);
            this.Controls.Add(this.tsbSalvar);
            this.Controls.Add(this.tsbNovo);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.tsbNovo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tsbSalvar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tsbCancelar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tsbExcluir)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tsbBuscar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox tsbNovo;
        private PictureBox tsbSalvar;
        private PictureBox tsbCancelar;
        private PictureBox tsbExcluir;
        private PictureBox tsbBuscar;
        private Label tsbBuscaPorId;
        private TextBox tstId;
        private Label label2;
        private TextBox txtId;
        private TextBox txtNome;
        private Label label3;
        private TextBox txtEndereco;
        private Label label4;
        private Label label5;
        private TextBox txtBairro;
        private Label label6;
        private TextBox txtCidade;
        private Label label7;
        private TextBox txtUf;
        private Label label8;
        private MaskedTextBox mskCEP;
        private Label label9;
        private MaskedTextBox mskTelefone;

        private void frmCadastroCliente_Load(object sender, EventArgs e)
        {
            tsbNovo.Enabled = true;
            tsbSalvar.Enabled = false;
            tsbCancelar.Enabled = false;
            tsbExcluir.Enabled = false;
            tstId.Enabled = true;
            tsbBuscar.Enabled = true;
            txtNome.Enabled = false;
            txtEndereco.Enabled = false;
            mskCEP.Enabled = false;
            txtBairro.Enabled = false;
            txtCidade.Enabled = false;
            txtUf.Enabled = false;
            mskTelefone.Enabled = false;
        }

        private void tsbNovo_Click(object sender, EventArgs e) {
            tsbNovo.Enabled = false;
            tsbSalvar.Enabled = true;
            tsbCancelar.Enabled = true;
            tsbExcluir.Enabled = false;
            tstId.Enabled = false;
            tsbBuscar.Enabled = false;
            txtNome.Enabled = true;
            txtEndereco.Enabled = true;
            mskCEP.Enabled = true;
            txtBairro.Enabled = true;
            txtCidade.Enabled = true;
            txtUf.Enabled = true;
            mskTelefone.Enabled = true;
            txtNome.Focus();
            novo = true;
        }

        private void tsbSalvar_Click(object sender, EventArgs e)
        {
            if (novo)
            {
                string sql = "INSERT INTO CLIENTE(NOME,ENDERECO,CEP,BAIRRO,CIDADE,UF,TELEFONE) " +
                    "VALUES ('" + txtNome.Text + "', '" + txtEndereco.Text + "', '" + mskCEP.Text + "', '"
                    + txtBairro.Text + "', '" + txtCidade.Text + "', '" + txtUf.Text + "', '"
                    + mskTelefone.Text + "')";
                SqlConnection con = new SqlConnection(connectionString);
                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.CommandType = CommandType.Text;
                con.Open();
                try {
                    int i = cmd.ExecuteNonQuery();
                    if (i > 0) MessageBox.Show("Cadastro realizado com sucesso!");
                } catch (Exception ex) {
                    MessageBox.Show("Erro: " + ex.ToString());
                } finally {
                    con.Close();
                }
            }
            else
            {
                string sql = "UPDATE CLIENTE SET NOME='" + txtNome.Text + "',ENDERECO='" + txtEndereco.Text
                    + "', " + "CEP='" + mskCEP.Text + "', BAIRRO='" + txtBairro.Text + "',CIDADE='"
                    + txtCidade.Text + "', " + "UF='" + txtUf.Text + "', TELEFONE='" + mskTelefone.Text
                    + "' WHERE ID="
                    + txtId.Text";SqlConnection con = new SqlConnection(connectionString);SqlCommand cmd = new SqlCommand(sql, con);cmd.CommandType = CommandType.Text;con.Open();
                try {
                    int i = cmd.ExecuteNonQuery();
                    if (i > 0) MessageBox.Show("Cadastro atualizado com sucesso!");
                } catch (Exception ex) { MessageBox.Show("Erro: " + ex.ToString());
                } finally {
                    con.Close();
                }
            }
            tsbNovo.Enabled = true; tsbSalvar.Enabled = false; tsbCancelar.Enabled = false; tsbExcluir.Enabled = false; tstId.Enabled = true; tsbBuscar.Enabled = true; txtNome.Enabled = false; txtEndereco.Enabled = false; mskCep.Enabled = false; txtBairro.Enabled = false; txtCidade.Enabled = false; txtUf.Enabled = false; mskTelefone.Enabled = false; txtId.Text = ""; txtNome.Text = ""; txtEndereco.Text = ""; mskCep.Text = ""; txtBairro.Text = ""; txtCidade.Text = ""; txtUf.Text = "";

        }

        private void tsbCancelar_Click(object sender, EventArgs e) {
            tsbNovo.Enabled = true;
            tsbSalvar.Enabled = false;
            tsbCancelar.Enabled = false;
            tsbExcluir.Enabled = false;
            tstId.Enabled = true;
            tsbBuscar.Enabled = true;
            txtNome.Enabled = false;
            txtEndereco.Enabled = false;
            mskCEP.Enabled = false;
            txtBairro.Enabled = false;
            txtCidade.Enabled = false;
            txtUf.Enabled = false;
            mskTelefone.Enabled = false;
            txtId.Text = "";
            txtNome.Text = "";
            txtEndereco.Text = "";
            mskCEP.Text = "";
            txtBairro.Text = "";
            txtCidade.Text = "";
            txtUf.Text = "";
            mskTelefone.Text = "";
        }
        private void tsbExcluir_Click(object sender, EventArgs e)
        {
            string sql = "DELETE FROM CLIENTE WHERE ID=" + txtId.Text;
            SqlConnection con = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.CommandType = CommandType.Text; con.Open();
            try { int i = cmd.ExecuteNonQuery();
                if (i > 0) MessageBox.Show("Registro excluído com sucesso!");
            } catch (Exception ex) {
                MessageBox.Show("Erro: " + ex.ToString());
            } finally {
                con.Close();
            }
            tsbNovo.Enabled = true;
            tsbSalvar.Enabled = false;
            tsbCancelar.Enabled = false;
            tsbExcluir.Enabled = false;
            tstId.Enabled = true;
            tsbBuscar.Enabled = true;
            txtNome.Enabled = false;
            txtEndereco.Enabled = false;
            mskCEP.Enabled = false;
            txtBairro.Enabled = false;
            txtCidade.Enabled = false;
            txtUf.Enabled = false;
            mskTelefone.Enabled = false;
            txtId.Text = "";
            txtNome.Text = "";
            txtEndereco.Text = "";

        }

        private void tsbBuscar_Click(object sender, EventArgs e)
        {
            string sql = "SELECT * FROM CLIENTE WHERE ID=" + tstId.Text; 
            SqlConnection con = new SqlConnection(connectionString); 
            SqlCommand cmd = new SqlCommand(sql, con); 
            cmd.CommandType = CommandType.Text; 
            SqlDataReader reader; con.Open(); try
            {
                reader = cmd.ExecuteReader(); if (reader.Read())
                {
                    tsbNovo.Enabled = false; tsbSalvar.Enabled = true; tsbCancelar.Enabled = true; tsbExcluir.Enabled = true; tstId.Enabled = false; tsbBuscar.Enabled = false; txtNome.Enabled = true; txtEndereco.Enabled = true; mskCep.Enabled = true; txtBairro.Enabled = true;
                    txtCidade.Enabled = true; txtUf.Enabled = true; mskTelefone.Enabled = true; txtNome.Focus(); txtId.Text = reader[0].ToString(); txtNome.Text = reader[1].ToString(); txtEndereco.Text = reader[2].ToString(); mskCep.Text = reader[3].ToString(); txtBairro.Text = reader[4].ToString(); txtCidade.Text = reader[5].ToString(); txtUf.Text = reader[6].ToString(); mskTelefone.Text = reader[7].ToString(); novo = false;
                }
                else
                {
                    MessageBox.Show("Nenhum registro encontrado com o Idinformado!");
                }
            }
            catch (Exception ex) { 
                MessageBox.Show("Erro: " + ex.ToString()); 
            } finally { 
                con.Close(); 
            }
            tstId.Text = "";
        }

        internal class SqlCommand
        {
            private string sql;
            private SqlConnection con;

            public SqlCommand(string sql, SqlConnection con)
            {
                this.sql = sql;
                this.con = con;
            }

            public CommandType CommandType { get; internal set; }

            internal SqlDataReader ExecuteReader()
            {
                throw new NotImplementedException();
            }
        }
    }
}