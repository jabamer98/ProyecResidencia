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
    public partial class MenuExpedientes : Form
    {
        public MenuExpedientes()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();

            DocumentosDePredios documentosDePredios = new DocumentosDePredios();
            documentosDePredios.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();

            Expedientes expedientes = new Expedientes();
            expedientes.Show();
        }
    }
}
