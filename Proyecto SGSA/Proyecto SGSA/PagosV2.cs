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
    public partial class PagosV2 : MaterialForm
    {
        public PagosV2()
        {
            InitializeComponent();

            MaterialSkinManager materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;

            materialSkinManager.ColorScheme = new ColorScheme(
                Primary.Blue400, Primary.Blue500,
                Primary.Blue500, Accent.LightBlue200,
                TextShade.WHITE);
        }

        BaseDeDatos bd = new BaseDeDatos();

        private void PagosV2_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dB_A7241D_sgsaDataSet.Socios' Puede moverla o quitarla según sea necesario.
            this.sociosTableAdapter.Fill(this.dB_A7241D_sgsaDataSet.Socios);

        }

        private void materialFlatButton1_Click(object sender, EventArgs e)
        {
            string buscarporCurp = "SELECT * FROM Socios WHERE CURP = '" + txtbuscar.Text + "'";
            dgvPagos.DataSource = bd.SelectDataTable(buscarporCurp);
        }

        SqlConnection con = new SqlConnection(@"Data Source=SQL5071.site4now.net;Initial Catalog=DB_A7241D_sgsa;User Id=DB_A7241D_sgsa_admin;Password=sgsa1234");
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
           
        }
    }
}
