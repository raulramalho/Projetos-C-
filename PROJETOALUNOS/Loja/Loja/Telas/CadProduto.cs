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
    public partial class CadProduto : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=WELLNOTE\MSSQLSERVER1; Initial Catalog= BDLOJA ; User ID=sa ; Password=1234567");
        SqlCommand comando = new SqlCommand();
        public CadProduto()
        {
            InitializeComponent();
            comando.Connection = con;
        }

        private void btnCadastrarFunc_Click(object sender, EventArgs e)
        {
            con.Open();
            comando.CommandText = "INSERT INTO PRODUTO(COD_PRODUTO,NOME_PRODUTO) VALUES ('" + txtCodProd.Text + "','" + txtNomeProd.Text + "')";
            comando.ExecuteNonQuery();
            con.Close();


            txtCodProd.Text = "";
            txtNomeProd.Text = "";


            MessageBox.Show("Cadastro Efetuado com Sucesso!!!");
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Hide();
            MenuPrincipal menu = new MenuPrincipal();
            menu.Closed += (s, args) => this.Close();
        }
    }
}
