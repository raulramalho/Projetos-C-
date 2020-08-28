namespace Loja.Telas
{
    partial class CadProduto
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
            this.lblCadProduto = new System.Windows.Forms.Label();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.btnCadastrarFunc = new System.Windows.Forms.Button();
            this.txtNomeProd = new System.Windows.Forms.TextBox();
            this.lblNomeProd = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCodProd = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.picCadFunc)).BeginInit();
            this.SuspendLayout();
            // 
            // picCadFunc
            // 
            this.picCadFunc.BackColor = System.Drawing.Color.Navy;
            this.picCadFunc.Location = new System.Drawing.Point(2, 2);
            this.picCadFunc.Name = "picCadFunc";
            this.picCadFunc.Size = new System.Drawing.Size(1348, 50);
            this.picCadFunc.TabIndex = 2;
            this.picCadFunc.TabStop = false;
            // 
            // lblCadProduto
            // 
            this.lblCadProduto.AutoSize = true;
            this.lblCadProduto.BackColor = System.Drawing.Color.Navy;
            this.lblCadProduto.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCadProduto.ForeColor = System.Drawing.Color.White;
            this.lblCadProduto.Location = new System.Drawing.Point(543, 19);
            this.lblCadProduto.Name = "lblCadProduto";
            this.lblCadProduto.Size = new System.Drawing.Size(251, 22);
            this.lblCadProduto.TabIndex = 3;
            this.lblCadProduto.Text = "CADASTRO DE PRODUTO";
            // 
            // btnVoltar
            // 
            this.btnVoltar.BackColor = System.Drawing.Color.Navy;
            this.btnVoltar.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVoltar.ForeColor = System.Drawing.Color.White;
            this.btnVoltar.Location = new System.Drawing.Point(905, 547);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(136, 48);
            this.btnVoltar.TabIndex = 19;
            this.btnVoltar.Text = "VOLTAR";
            this.btnVoltar.UseVisualStyleBackColor = false;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // btnCadastrarFunc
            // 
            this.btnCadastrarFunc.BackColor = System.Drawing.Color.Navy;
            this.btnCadastrarFunc.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrarFunc.ForeColor = System.Drawing.Color.White;
            this.btnCadastrarFunc.Location = new System.Drawing.Point(703, 547);
            this.btnCadastrarFunc.Name = "btnCadastrarFunc";
            this.btnCadastrarFunc.Size = new System.Drawing.Size(146, 48);
            this.btnCadastrarFunc.TabIndex = 18;
            this.btnCadastrarFunc.Text = "CADASTRAR";
            this.btnCadastrarFunc.UseVisualStyleBackColor = false;
            this.btnCadastrarFunc.Click += new System.EventHandler(this.btnCadastrarFunc_Click);
            // 
            // txtNomeProd
            // 
            this.txtNomeProd.BackColor = System.Drawing.Color.Navy;
            this.txtNomeProd.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomeProd.ForeColor = System.Drawing.Color.White;
            this.txtNomeProd.Location = new System.Drawing.Point(547, 221);
            this.txtNomeProd.Multiline = true;
            this.txtNomeProd.Name = "txtNomeProd";
            this.txtNomeProd.Size = new System.Drawing.Size(342, 32);
            this.txtNomeProd.TabIndex = 17;
            // 
            // lblNomeProd
            // 
            this.lblNomeProd.AutoSize = true;
            this.lblNomeProd.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeProd.ForeColor = System.Drawing.Color.Navy;
            this.lblNomeProd.Location = new System.Drawing.Point(321, 224);
            this.lblNomeProd.Name = "lblNomeProd";
            this.lblNomeProd.Size = new System.Drawing.Size(176, 19);
            this.lblNomeProd.TabIndex = 16;
            this.lblNomeProd.Text = "NOME DO PRODUTO:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Navy;
            this.label1.Location = new System.Drawing.Point(321, 143);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 19);
            this.label1.TabIndex = 20;
            this.label1.Text = "CODIGO PRODUTO:";
            // 
            // txtCodProd
            // 
            this.txtCodProd.BackColor = System.Drawing.Color.Navy;
            this.txtCodProd.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodProd.ForeColor = System.Drawing.Color.White;
            this.txtCodProd.Location = new System.Drawing.Point(547, 140);
            this.txtCodProd.Multiline = true;
            this.txtCodProd.Name = "txtCodProd";
            this.txtCodProd.Size = new System.Drawing.Size(141, 32);
            this.txtCodProd.TabIndex = 21;
            // 
            // CadProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1350, 729);
            this.Controls.Add(this.txtCodProd);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.btnCadastrarFunc);
            this.Controls.Add(this.txtNomeProd);
            this.Controls.Add(this.lblNomeProd);
            this.Controls.Add(this.lblCadProduto);
            this.Controls.Add(this.picCadFunc);
            this.Name = "CadProduto";
            this.Text = "CadProduto";
            ((System.ComponentModel.ISupportInitialize)(this.picCadFunc)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picCadFunc;
        private System.Windows.Forms.Label lblCadProduto;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.Button btnCadastrarFunc;
        private System.Windows.Forms.TextBox txtNomeProd;
        private System.Windows.Forms.Label lblNomeProd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCodProd;
    }
}