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
    public partial class CadFuncionario : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=WELLNOTE\MSSQLSERVER1; Initial Catalog= BDLOJA ; User ID=sa ; Password=1234567");
        SqlCommand comando = new SqlCommand();

        public CadFuncionario()
        {
            InitializeComponent();
            comando.Connection = con;
        }

        private void btnCadastrarFunc_Click(object sender, EventArgs e)
        {
            con.Open();
            comando.CommandText= "INSERT INTO FUNCIONARIO(NOME_FUNCIONARIO,USUARIO,SENHA) VALUES ('"+ txtNomeFunc.Text+"','"+ txtUsuarioFunc.Text+"','"+txtSenhaFunc+"')";
            comando.ExecuteNonQuery();
            con.Close();

            txtNomeFunc.Text = "";
            txtUsuarioFunc.Text = "";
            txtSenhaFunc.Text = "";

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
