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
    public partial class Consulta : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=WELLNOTE\MSSQLSERVER1; Initial Catalog= BDLOJA ; User ID=sa ; Password=1234567");
        SqlCommand comando = new SqlCommand();
        public Consulta()
        {
            InitializeComponent();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Hide();
            MenuPrincipal menu = new MenuPrincipal();
            menu.Closed += (s, args) => this.Close();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            SqlDataAdapter Da = new SqlDataAdapter("", con);

            if(txtConsultaCli.Text =="")
            {
                Da.SelectCommand.CommandText = "SELECT * FROM CLIENTE";
                DataTable Dt = new DataTable();
                Da.Fill(Dt);
                dataGridView1.DataSource = Dt;
                con.Close();

            }
            else
            {
                Da.SelectCommand.CommandText = "SELECT * FROM CLIENTE WHERE COD_CLIENTE ='"+txtConsultaCli.Text+"'";
                DataTable Dt = new DataTable();
                Da.Fill(Dt);
                dataGridView1.DataSource = Dt;
                con.Close();
            }

        }
    }
}
