namespace Loja.Telas
{
    partial class Pedido
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
            this.txtCodPedido = new System.Windows.Forms.TextBox();
            this.lblCodPedido = new System.Windows.Forms.Label();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.btnCadastrarFunc = new System.Windows.Forms.Button();
            this.txtValorPedido = new System.Windows.Forms.TextBox();
            this.lblValorPedido = new System.Windows.Forms.Label();
            this.lblPedido = new System.Windows.Forms.Label();
            this.picCadFunc = new System.Windows.Forms.PictureBox();
            this.txtCodClientePedido = new System.Windows.Forms.TextBox();
            this.lblCodCliPed = new System.Windows.Forms.Label();
            this.txtCodProdPedido = new System.Windows.Forms.TextBox();
            this.lblCodProdutoPed = new System.Windows.Forms.Label();
            this.txtQuantPedido = new System.Windows.Forms.TextBox();
            this.lblQuantPedido = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picCadFunc)).BeginInit();
            this.SuspendLayout();
            // 
            // txtCodPedido
            // 
            this.txtCodPedido.BackColor = System.Drawing.Color.Navy;
            this.txtCodPedido.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodPedido.ForeColor = System.Drawing.Color.White;
            this.txtCodPedido.Location = new System.Drawing.Point(546, 138);
            this.txtCodPedido.Multiline = true;
            this.txtCodPedido.Name = "txtCodPedido";
            this.txtCodPedido.Size = new System.Drawing.Size(141, 32);
            this.txtCodPedido.TabIndex = 29;
            // 
            // lblCodPedido
            // 
            this.lblCodPedido.AutoSize = true;
            this.lblCodPedido.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodPedido.ForeColor = System.Drawing.Color.Navy;
            this.lblCodPedido.Location = new System.Drawing.Point(320, 141);
            this.lblCodPedido.Name = "lblCodPedido";
            this.lblCodPedido.Size = new System.Drawing.Size(145, 19);
            this.lblCodPedido.TabIndex = 28;
            this.lblCodPedido.Text = "CODIGO PEDIDO:";
            // 
            // btnVoltar
            // 
            this.btnVoltar.BackColor = System.Drawing.Color.Navy;
            this.btnVoltar.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVoltar.ForeColor = System.Drawing.Color.White;
            this.btnVoltar.Location = new System.Drawing.Point(904, 545);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(136, 48);
            this.btnVoltar.TabIndex = 27;
            this.btnVoltar.Text = "VOLTAR";
            this.btnVoltar.UseVisualStyleBackColor = false;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // btnCadastrarFunc
            // 
            this.btnCadastrarFunc.BackColor = System.Drawing.Color.Navy;
            this.btnCadastrarFunc.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrarFunc.ForeColor = System.Drawing.Color.White;
            this.btnCadastrarFunc.Location = new System.Drawing.Point(702, 545);
            this.btnCadastrarFunc.Name = "btnCadastrarFunc";
            this.btnCadastrarFunc.Size = new System.Drawing.Size(146, 48);
            this.btnCadastrarFunc.TabIndex = 26;
            this.btnCadastrarFunc.Text = "CADASTRAR";
            this.btnCadastrarFunc.UseVisualStyleBackColor = false;
            this.btnCadastrarFunc.Click += new System.EventHandler(this.btnCadastrarFunc_Click);
            // 
            // txtValorPedido
            // 
            this.txtValorPedido.BackColor = System.Drawing.Color.Navy;
            this.txtValorPedido.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValorPedido.ForeColor = System.Drawing.Color.White;
            this.txtValorPedido.Location = new System.Drawing.Point(546, 336);
            this.txtValorPedido.Multiline = true;
            this.txtValorPedido.Name = "txtValorPedido";
            this.txtValorPedido.Size = new System.Drawing.Size(176, 32);
            this.txtValorPedido.TabIndex = 25;
            // 
            // lblValorPedido
            // 
            this.lblValorPedido.AutoSize = true;
            this.lblValorPedido.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValorPedido.ForeColor = System.Drawing.Color.Navy;
            this.lblValorPedido.Location = new System.Drawing.Point(320, 339);
            this.lblValorPedido.Name = "lblValorPedido";
            this.lblValorPedido.Size = new System.Drawing.Size(70, 19);
            this.lblValorPedido.TabIndex = 24;
            this.lblValorPedido.Text = "VALOR:";
            // 
            // lblPedido
            // 
            this.lblPedido.AutoSize = true;
            this.lblPedido.BackColor = System.Drawing.Color.Navy;
            this.lblPedido.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPedido.ForeColor = System.Drawing.Color.White;
            this.lblPedido.Location = new System.Drawing.Point(542, 17);
            this.lblPedido.Name = "lblPedido";
            this.lblPedido.Size = new System.Drawing.Size(84, 22);
            this.lblPedido.TabIndex = 23;
            this.lblPedido.Text = "PEDIDO";
            // 
            // picCadFunc
            // 
            this.picCadFunc.BackColor = System.Drawing.Color.Navy;
            this.picCadFunc.Location = new System.Drawing.Point(1, 0);
            this.picCadFunc.Name = "picCadFunc";
            this.picCadFunc.Size = new System.Drawing.Size(1348, 50);
            this.picCadFunc.TabIndex = 22;
            this.picCadFunc.TabStop = false;
            // 
            // txtCodClientePedido
            // 
            this.txtCodClientePedido.BackColor = System.Drawing.Color.Navy;
            this.txtCodClientePedido.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodClientePedido.ForeColor = System.Drawing.Color.White;
            this.txtCodClientePedido.Location = new System.Drawing.Point(546, 276);
            this.txtCodClientePedido.Multiline = true;
            this.txtCodClientePedido.Name = "txtCodClientePedido";
            this.txtCodClientePedido.Size = new System.Drawing.Size(141, 32);
            this.txtCodClientePedido.TabIndex = 31;
            // 
            // lblCodCliPed
            // 
            this.lblCodCliPed.AutoSize = true;
            this.lblCodCliPed.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodCliPed.ForeColor = System.Drawing.Color.Navy;
            this.lblCodCliPed.Location = new System.Drawing.Point(320, 276);
            this.lblCodCliPed.Name = "lblCodCliPed";
            this.lblCodCliPed.Size = new System.Drawing.Size(153, 19);
            this.lblCodCliPed.TabIndex = 30;
            this.lblCodCliPed.Text = "CODIGO CLIENTE:";
            // 
            // txtCodProdPedido
            // 
            this.txtCodProdPedido.BackColor = System.Drawing.Color.Navy;
            this.txtCodProdPedido.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodProdPedido.ForeColor = System.Drawing.Color.White;
            this.txtCodProdPedido.Location = new System.Drawing.Point(546, 208);
            this.txtCodProdPedido.Multiline = true;
            this.txtCodProdPedido.Name = "txtCodProdPedido";
            this.txtCodProdPedido.Size = new System.Drawing.Size(141, 32);
            this.txtCodProdPedido.TabIndex = 33;
            // 
            // lblCodProdutoPed
            // 
            this.lblCodProdutoPed.AutoSize = true;
            this.lblCodProdutoPed.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodProdutoPed.ForeColor = System.Drawing.Color.Navy;
            this.lblCodProdutoPed.Location = new System.Drawing.Point(320, 211);
            this.lblCodProdutoPed.Name = "lblCodProdutoPed";
            this.lblCodProdutoPed.Size = new System.Drawing.Size(164, 19);
            this.lblCodProdutoPed.TabIndex = 32;
            this.lblCodProdutoPed.Text = "CODIGO PRODUTO:";
            // 
            // txtQuantPedido
            // 
            this.txtQuantPedido.BackColor = System.Drawing.Color.Navy;
            this.txtQuantPedido.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQuantPedido.ForeColor = System.Drawing.Color.White;
            this.txtQuantPedido.Location = new System.Drawing.Point(546, 392);
            this.txtQuantPedido.Multiline = true;
            this.txtQuantPedido.Name = "txtQuantPedido";
            this.txtQuantPedido.Size = new System.Drawing.Size(190, 32);
            this.txtQuantPedido.TabIndex = 35;
            // 
            // lblQuantPedido
            // 
            this.lblQuantPedido.AutoSize = true;
            this.lblQuantPedido.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuantPedido.ForeColor = System.Drawing.Color.Navy;
            this.lblQuantPedido.Location = new System.Drawing.Point(320, 405);
            this.lblQuantPedido.Name = "lblQuantPedido";
            this.lblQuantPedido.Size = new System.Drawing.Size(122, 19);
            this.lblQuantPedido.TabIndex = 34;
            this.lblQuantPedido.Text = "QUANTIDADE:";
            // 
            // Pedido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1350, 729);
            this.Controls.Add(this.txtQuantPedido);
            this.Controls.Add(this.lblQuantPedido);
            this.Controls.Add(this.txtCodProdPedido);
            this.Controls.Add(this.lblCodProdutoPed);
            this.Controls.Add(this.txtCodClientePedido);
            this.Controls.Add(this.lblCodCliPed);
            this.Controls.Add(this.txtCodPedido);
            this.Controls.Add(this.lblCodPedido);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.btnCadastrarFunc);
            this.Controls.Add(this.txtValorPedido);
            this.Controls.Add(this.lblValorPedido);
            this.Controls.Add(this.lblPedido);
            this.Controls.Add(this.picCadFunc);
            this.Name = "Pedido";
            this.Text = "Pedido";
            ((System.ComponentModel.ISupportInitialize)(this.picCadFunc)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCodPedido;
        private System.Windows.Forms.Label lblCodPedido;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.Button btnCadastrarFunc;
        private System.Windows.Forms.TextBox txtValorPedido;
        private System.Windows.Forms.Label lblValorPedido;
        private System.Windows.Forms.Label lblPedido;
        private System.Windows.Forms.PictureBox picCadFunc;
        private System.Windows.Forms.TextBox txtCodClientePedido;
        private System.Windows.Forms.Label lblCodCliPed;
        private System.Windows.Forms.TextBox txtCodProdPedido;
        private System.Windows.Forms.Label lblCodProdutoPed;
        private System.Windows.Forms.TextBox txtQuantPedido;
        private System.Windows.Forms.Label lblQuantPedido;
    }
}