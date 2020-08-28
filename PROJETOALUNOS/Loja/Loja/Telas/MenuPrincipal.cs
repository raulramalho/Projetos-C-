using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Loja.Telas
{
    public partial class MenuPrincipal : Form
    {
        public MenuPrincipal()
        {
            InitializeComponent();
        }

        private void fUNCIONARIOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // chamando uma tela 
            CadFuncionario funcionario = new CadFuncionario();
            funcionario.Show();
        }

        private void cLIENTEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CadCliente cliente = new CadCliente();
            cliente.Show();
        }

        private void pRODUTOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CadProduto produto = new CadProduto();
            produto.Show();
        }

        private void pEDIDOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Pedido pedi = new Pedido();
            pedi.Show();
        }

        private void cONSULTAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Consulta consult = new Consulta();
            consult.Show();
        }

        private void lOGOFFToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

            if
                (MessageBox.Show("Deseja sair do sistema ?", "Mensagem do sistema",
            MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }


        }
    }
}
