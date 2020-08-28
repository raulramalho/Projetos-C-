namespace Loja.Telas
{
    partial class CadCliente
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
            this.picCadFunc = new System.Windows.Forms.PictureBox();
            this.lblCadCliente = new System.Windows.Forms.Label();
            this.txtNomeCli = new System.Windows.Forms.TextBox();
            this.lblCpfCli = new System.Windows.Forms.Label();
            this.lblNomeCli = new System.Windows.Forms.Label();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.btnCadastrarFunc = new System.Windows.Forms.Button();
            this.lblCodCli = new System.Windows.Forms.Label();
            this.txtCodCli = new System.Windows.Forms.TextBox();
            this.mskCpfCli = new System.Windows.Forms.MaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.picCadFunc)).BeginInit();
            this.SuspendLayout();
            // 
            // picCadFunc
            // 
            this.picCadFunc.BackColor = System.Drawing.Color.Navy;
            this.picCadFunc.Location = new System.Drawing.Point(2, -2);
            this.picCadFunc.Name = "picCadFunc";
            this.picCadFunc.Size = new System.Drawing.Size(1348, 50);
            this.picCadFunc.TabIndex = 1;
            this.picCadFunc.TabStop = false;
            // 
            // lblCadCliente
            // 
            this.lblCadCliente.AutoSize = true;
            this.lblCadCliente.BackColor = System.Drawing.Color.Navy;
            this.lblCadCliente.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCadCliente.ForeColor = System.Drawing.Color.White;
            this.lblCadCliente.Location = new System.Drawing.Point(515, 9);
            this.lblCadCliente.Name = "lblCadCliente";
            this.lblCadCliente.Size = new System.Drawing.Size(238, 22);
            this.lblCadCliente.TabIndex = 2;
            this.lblCadCliente.Text = "CADASTRO DE CLIENTE";
            // 
            // txtNomeCli
            // 
            this.txtNomeCli.BackColor = System.Drawing.Color.Navy;
            this.txtNomeCli.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomeCli.ForeColor = System.Drawing.Color.White;
            this.txtNomeCli.Location = new System.Drawing.Point(579, 171);
            this.txtNomeCli.Multiline = true;
            this.txtNomeCli.Name = "txtNomeCli";
            this.txtNomeCli.Size = new System.Drawing.Size(342, 32);
            this.txtNomeCli.TabIndex = 11;
            // 
            // lblCpfCli
            // 
            this.lblCpfCli.AutoSize = true;
            this.lblCpfCli.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCpfCli.ForeColor = System.Drawing.Color.Navy;
            this.lblCpfCli.Location = new System.Drawing.Point(342, 230);
            this.lblCpfCli.Name = "lblCpfCli";
            this.lblCpfCli.Size = new System.Drawing.Size(48, 19);
            this.lblCpfCli.TabIndex = 9;
            this.lblCpfCli.Text = "CPF:";
            // 
            // lblNomeCli
            // 
            this.lblNomeCli.AutoSize = true;
            this.lblNomeCli.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeCli.ForeColor = System.Drawing.Color.Navy;
            this.lblNomeCli.Location = new System.Drawing.Point(342, 171);
            this.lblNomeCli.Name = "lblNomeCli";
            this.lblNomeCli.Size = new System.Drawing.Size(165, 19);
            this.lblNomeCli.TabIndex = 8;
            this.lblNomeCli.Text = "NOME DO CLIENTE:";
            // 
            // btnVoltar
            // 
            this.btnVoltar.BackColor = System.Drawing.Color.Navy;
            this.btnVoltar.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVoltar.ForeColor = System.Drawing.Color.White;
            this.btnVoltar.Location = new System.Drawing.Point(937, 585);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(136, 48);
            this.btnVoltar.TabIndex = 15;
            this.btnVoltar.Text = "VOLTAR";
            this.btnVoltar.UseVisualStyleBackColor = false;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // btnCadastrarFunc
            // 
            this.btnCadastrarFunc.BackColor = System.Drawing.Color.Navy;
            this.btnCadastrarFunc.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrarFunc.ForeColor = System.Drawing.Color.White;
            this.btnCadastrarFunc.Location = new System.Drawing.Point(735, 585);
            this.btnCadastrarFunc.Name = "btnCadastrarFunc";
            this.btnCadastrarFunc.Size = new System.Drawing.Size(146, 48);
            this.btnCadastrarFunc.TabIndex = 14;
            this.btnCadastrarFunc.Text = "CADASTRAR";
            this.btnCadastrarFunc.UseVisualStyleBackColor = false;
            this.btnCadastrarFunc.Click += new System.EventHandler(this.btnCadastrarFunc_Click);
            // 
            // lblCodCli
            // 
            this.lblCodCli.AutoSize = true;
            this.lblCodCli.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodCli.ForeColor = System.Drawing.Color.Navy;
            this.lblCodCli.Location = new System.Drawing.Point(342, 128);
            this.lblCodCli.Name = "lblCodCli";
            this.lblCodCli.Size = new System.Drawing.Size(153, 19);
            this.lblCodCli.TabIndex = 16;
            this.lblCodCli.Text = "CODIGO CLIENTE:";
            // 
            // txtCodCli
            // 
            this.txtCodCli.BackColor = System.Drawing.Color.Navy;
            this.txtCodCli.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodCli.ForeColor = System.Drawing.Color.White;
            this.txtCodCli.Location = new System.Drawing.Point(579, 115);
            this.txtCodCli.Multiline = true;
            this.txtCodCli.Name = "txtCodCli";
            this.txtCodCli.Size = new System.Drawing.Size(146, 32);
            this.txtCodCli.TabIndex = 17;
            // 
            // mskCpfCli
            // 
            this.mskCpfCli.BackColor = System.Drawing.Color.Navy;
            this.mskCpfCli.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mskCpfCli.ForeColor = System.Drawing.Color.White;
            this.mskCpfCli.Location = new System.Drawing.Point(579, 231);
            this.mskCpfCli.Mask = "000,000,000-00";
            this.mskCpfCli.Name = "mskCpfCli";
            this.mskCpfCli.Size = new System.Drawing.Size(125, 26);
            this.mskCpfCli.TabIndex = 18;
            // 
            // CadCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1350, 729);
            this.Controls.Add(this.mskCpfCli);
            this.Controls.Add(this.txtCodCli);
            this.Controls.Add(this.lblCodCli);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.btnCadastrarFunc);
            this.Controls.Add(this.txtNomeCli);
            this.Controls.Add(this.lblCpfCli);
            this.Controls.Add(this.lblNomeCli);
            this.Controls.Add(this.lblCadCliente);
            this.Controls.Add(this.picCadFunc);
            this.Name = "CadCliente";
            this.Text = "CadCliente";
            ((System.ComponentModel.ISupportInitialize)(this.picCadFunc)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picCadFunc;
        private System.Windows.Forms.Label lblCadCliente;
        private System.Windows.Forms.TextBox txtNomeCli;
        private System.Windows.Forms.Label lblCpfCli;
        private System.Windows.Forms.Label lblNomeCli;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.Button btnCadastrarFunc;
        private System.Windows.Forms.Label lblCodCli;
        private System.Windows.Forms.TextBox txtCodCli;
        private System.Windows.Forms.MaskedTextBox mskCpfCli;
    }
}