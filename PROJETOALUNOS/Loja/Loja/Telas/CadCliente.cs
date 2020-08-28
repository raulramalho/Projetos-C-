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
    public partial class CadCliente : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=WELLNOTE\MSSQLSERVER1; Initial Catalog= BDLOJA ; User ID=sa ; Password=1234567");
        SqlCommand comando = new SqlCommand();
        public CadCliente()
        {
            InitializeComponent();
            comando.Connection = con;
        }

        private void btnCadastrarFunc_Click(object sender, EventArgs e)
        {
            con.Open();
            comando.CommandText = "INSERT INTO CLIENTE(COD_CLIENTE,NOME_CLIENTE,CPF) VALUES ('" + txtCodCli.Text + "','" + txtNomeCli.Text + "','" + mskCpfCli.Text + "')";
            comando.ExecuteNonQuery();
            con.Close();

            txtCodCli.Text = "";
            txtNomeCli.Text = "";
            mskCpfCli.Text = "";

            MessageBox.Show("Cadastro Efetuado com Sucesso !!!");
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Hide();
            MenuPrincipal menu = new MenuPrincipal();
            menu.Closed += (s, args) => this.Close();
        }
    }
}
