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
    public partial class menu : Form
    {
        public menu()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();

            menusocios menusocio = new menusocios();
            menusocio.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();

            MenuExpedientes expedientes = new MenuExpedientes();
            expedientes.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();

            Pagos pagos = new Pagos();
            pagos.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();

            Agenda agenda = new Agenda();
            agenda.Show();
        }
    }
}
