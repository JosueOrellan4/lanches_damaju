using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lanches_damaju
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            CadProdutos form = new CadProdutos();
            form.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Gerenciamento_Produtos form = new Gerenciamento_Produtos();
            form.ShowDialog();
        }

        private void Menu_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Gerenciamento_Clientes form = new Gerenciamento_Clientes();
            form.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CadClientes form = new CadClientes();
            form.ShowDialog();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
