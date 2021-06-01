using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Diagnostics;
using MaterialSkin;
using MaterialSkin.Controls;

namespace Proyecto_SGSA
{
    public partial class Pagos : MaterialForm
    {
        public Pagos()
        {
            InitializeComponent();
            personalizarDiseño();
            autocompletar();

            MaterialSkinManager materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;

            materialSkinManager.ColorScheme = new ColorScheme(
                Primary.Blue400, Primary.Blue500,
                Primary.Blue500, Accent.LightBlue200,
                TextShade.WHITE);
        }

        BaseDeDatos bd = new BaseDeDatos();

   
        

        private void Pagos_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dB_A7241D_sgsaDataSet.Socios' Puede moverla o quitarla según sea necesario.
            dgvpagos.DataSource = bd.SelectDataTable("select * from Socios");
           // this.sociosTableAdapter.Fill(this.dB_A7241D_sgsaDataSet.Socios);
            

        }
        //metodo que hace la busqueda por CURP
        BaseDeDatos bdt = new BaseDeDatos();

        private void btnbuscar_Click(object sender, EventArgs e)
        {
            mostrarPaneldata(paneldata);
            string buscarporCurp = "SELECT * FROM Socios WHERE CURP = '" + txtBuscar.Text + "'";
            dgvpagos.DataSource = bdt.SelectDataTable(buscarporCurp);
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

        private void dgvpagos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow fila = dgvpagos.Rows[e.RowIndex];
            textBoxnombresoc.Text = Convert.ToString(fila.Cells[2].Value);
            textBoxtel.Text = Convert.ToString(fila.Cells[4].Value);
            textBoxdomicilio.Text = Convert.ToString(fila.Cells[3].Value);
            textBoxpredio.Text = Convert.ToString(fila.Cells[5].Value);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            menu menu = new menu();
            menu.Show();
        }

        private void txtBuscar_Enter(object sender, EventArgs e)
        {
            if (txtBuscar.Text == "Por CURP")
            {
                txtBuscar.Text = "";
                txtBuscar.ForeColor = Color.Black;
            }
        }

        private void txtBuscar_Leave(object sender, EventArgs e)
        {
            if (txtBuscar.Text == "")
            {
                txtBuscar.Text = "Por CURP";
                txtBuscar.ForeColor = Color.Silver;
            }
        }

        private void materialFlatButton1_Click(object sender, EventArgs e)
        {
            this.Hide();
            menu menu = new menu();
            menu.Show();
        }

        private void personalizarDiseño()
        {
            paneldata.Visible = false;
        }

        private void mostrarPaneldata(Panel Submenu)
        {
            if (Submenu.Visible == false)
            {
                Submenu.Visible = true;
            }
            else
                Submenu.Visible = false;
        }
    }
}
