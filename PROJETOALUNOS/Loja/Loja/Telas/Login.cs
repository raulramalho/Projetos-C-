using Loja.Telas;
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


namespace Loja
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void chbVisualizarSenha_CheckedChanged(object sender, EventArgs e)
        {
            // Visuaaiza ou oculta a senha

            if(chbVisualizarSenha.Checked)
            {
                // mostrar senha
                txtSenha.PasswordChar = '\0';
            }
            else
            {
                //esconder senha

                txtSenha.PasswordChar = '*';
            }
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            string conn_string = (@"Data Source=WELLNOTE\MSSQLSERVER1; Initial Catalog= BDLOJA ; User ID=sa ; Password=1234567");
            SqlConnection con = new SqlConnection(conn_string);

            con.Open();
            DataTable dados = new DataTable();
            SqlDataAdapter Da = new SqlDataAdapter("SELECT * FROM  FUNCIONARIO WHERE USUARIO=@USER AND SENHA =@SENHA ", con);
            Da.SelectCommand.Parameters.AddWithValue("@USER", txtUsuario.Text);
            Da.SelectCommand.Parameters.AddWithValue("@SENHA", txtSenha.Text);
            Da.Fill(dados);
            con.Close();

            if(dados.Rows.Count == 0)
            {
                MessageBox.Show("Usuario/Senha Inválidos");
            }
            else
            {
                MessageBox.Show("Seja Bem Vindo ao Sistema !!!");

                MenuPrincipal menu = new MenuPrincipal();
                menu.Show();
                this.Hide();

            }
            // limpando os campos 
            txtUsuario.Text = "";
            txtSenha.Text = "";
        }
    }
}
