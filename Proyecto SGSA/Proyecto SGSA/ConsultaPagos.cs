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
using System.Drawing.Printing;
using System.IO;

namespace Proyecto_SGSA
{
    public partial class ConsultaPagos : MaterialForm
    {

        public ConsultaPagos()
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

        }

        //metodo que hace la busqueda por CURP
        BaseDeDatos bdt = new BaseDeDatos();
        
        
        private void btnbuscar_Click(object sender, EventArgs e)
        {
            mostrarPaneldata(paneldata);
            string buscarPorCURP = "SELECT DetallePago.Folio,CURP,CantidadAños,Años,Costo,Fecha FROM DetallePago inner join Pagos on DetallePago.Folio=Pagos.Folio WHERE CURP = '" + txtBuscar.Text + "'";
            dgvPagos.DataSource = bdt.SelectDataTable(buscarPorCURP);

            
        }


        //metodo que autocompleta el textbox donde se ingresa el CURP
        SqlConnection con=new SqlConnection(@"Data Source=SQL5092.site4now.net;Initial Catalog=db_a758a9_sgsa;User Id=db_a758a9_sgsa_admin;Password=sgsa1234");
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

        private void dgvPagos_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
             /*DataGridViewRow fila = dgvPagos.Rows[e.RowIndex];
             textBoxCURP.Text = Convert.ToString(fila.Cells[0].Value);
             textBoxNombreS.Text = Convert.ToString(fila.Cells[3].Value);
             textBoxApellidoPS.Text = Convert.ToString(fila.Cells[1].Value);
             textBoxApellidoMS.Text = Convert.ToString(fila.Cells[2].Value);
             textBoxNamePredio.Text = Convert.ToString(fila.Cells[10].Value);*/

        }
        
        private void dgvPago_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

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
        

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void cmbNoAñosPagar_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmbInstalledPrinters_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtBuscar_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void lblFecha_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Pagos pagos = new Pagos();
            pagos.Show();
        }
    }
}
