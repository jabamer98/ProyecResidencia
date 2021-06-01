using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Diagnostics;

namespace Proyecto_SGSA
{
    public partial class Pagos : Form
    {
        Conversion c = new Conversion();

        public Pagos()
        {
            InitializeComponent();
            autocompletar();
        }

        BaseDeDatos bd = new BaseDeDatos();


        private void Pagos_Load(object sender, EventArgs e)
        {
            dgvPagoss.DataSource = bd.SelectDataTable("select * from Socios");
        }

        //metodo que hace la busqueda por CURP
        BaseDeDatos bdt = new BaseDeDatos();

        private void btnbuscar_Click(object sender, EventArgs e)
        {
            string buscarPorCURP = "SELECT * FROM Socios WHERE CURP = '" + txtBuscar.Text + "'";
            dgvPagoss.DataSource = bdt.SelectDataTable(buscarPorCURP);
        }


        //metodo que autocompleta el textbox donde se ingresa el CURP
        SqlConnection con=new SqlConnection(@"Data Source=SQL5071.site4now.net;Initial Catalog=DB_A7241D_sgsa;User Id=DB_A7241D_sgsa_admin;Password=sgsa1234");
        DataTable datos = new DataTable();
        void autocompletar()
        {
            AutoCompleteStringCollection lista = new AutoCompleteStringCollection();
            SqlDataAdapter adaptador = new SqlDataAdapter("SELECT * FROM Socios", con);
            adaptador.Fill(datos);
            for (int i = 0; i < datos.Rows.Count; i++)
            {
                lista.Add(datos.Rows[i]["CURP"].ToString());
            }

            txtBuscar.AutoCompleteCustomSource = lista;
        }

        private void txtbuscar_TextChanged(object sender, EventArgs e)
        {

        }

        private void dgvPagoss_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow fila = dgvPagoss.Rows[e.RowIndex];
            textBoxNombreS.Text = Convert.ToString(fila.Cells[3].Value);
            textBoxApellidoPS.Text = Convert.ToString(fila.Cells[1].Value);
            textBoxApellidoMS.Text = Convert.ToString(fila.Cells[2].Value);
            textBoxDomicilio.Text = Convert.ToString(fila.Cells[6].Value);
            textBoxColonia.Text = Convert.ToString(fila.Cells[7].Value);
            textBoxPoblacion.Text = Convert.ToString(fila.Cells[8].Value);
            textBoxTelefono.Text = Convert.ToString(fila.Cells[9].Value);
            textBoxNamePredio.Text = Convert.ToString(fila.Cells[10].Value);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            menu menu = new menu();
            menu.Show();
        }

        private void textBoxnombresoc_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxtel_TextChanged(object sender, EventArgs e)
        {

        }

        //Metodo que llama a clase conversion y convierte de numeros a letras, se pone .ToLower para poner en minusculas
        private void buttonConvLetra_Click(object sender, EventArgs e)
        {
            textBoxCantidadLetra.Text = c.enletras(textBoxCantidadNumero.Text);
        }

        
    }
}
