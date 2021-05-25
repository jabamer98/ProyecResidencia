using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_SGSA
{
    public partial class menusocios : Form
    {
        public menusocios()
        {
            InitializeComponent();
        }

        private void menusocios_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           AltaSocios altasocio = new AltaSocios();
           altasocio.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            menu frm = new menu();
            frm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();

            BuscarSocioParaModificar buscarSocioParaModificar = new BuscarSocioParaModificar();
            buscarSocioParaModificar.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
    }
}
