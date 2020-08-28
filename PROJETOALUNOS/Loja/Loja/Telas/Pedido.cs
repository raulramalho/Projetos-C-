using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Loja.Telas
{
    public partial class Pedido : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=WELLNOTE\MSSQLSERVER1; Initial Catalog= BDLOJA ; User ID=sa ; Password=1234567");
        SqlCommand comando = new SqlCommand();
        public Pedido()
        {
            InitializeComponent();
            comando.Connection = con;
        }

        private void btnCadastrarFunc_Click(object sender, EventArgs e)
        {
            con.Open();
            comando.CommandText = "INSERT INTO PEDIDO(COD_PEDIDO,VALOR,QUANTIDADE,FK_COD_PRODUTO,FK_COD_CLIENTE) VALUES ('" + txtCodClientePedido.Text + "','" + txtValorPedido.Text + "','"+txtQuantPedido.Text+"','"+txtCodProdPedido.Text+"','"+txtCodClientePedido.Text+"')";
            comando.ExecuteNonQuery();
            con.Close();

            txtCodPedido.Text = "";
            txtCodClientePedido.Text = "";
            txtCodProdPedido.Text = "";
            txtQuantPedido.Text = "";
            txtValorPedido.Text = "";

            MessageBox.Show("Pedido realizado com sucesso !!!");
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Hide();
            MenuPrincipal menu = new MenuPrincipal();
            menu.Closed += (s, args) => this.Close();
        }
    }
}
