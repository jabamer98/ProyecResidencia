using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;
using System.IO;
using System.Data.SqlClient;
using System.Diagnostics;


namespace Proyecto_SGSA
{
    public partial class HistorialCitas : MaterialForm
    {
        public HistorialCitas()
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

        private void button1_MouseMove(object sender, MouseEventArgs e)
        {
            button1.BackColor = Color.LightSkyBlue;
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            button1.BackColor = Color.SteelBlue;
        }

        BaseDeDatos bd = new BaseDeDatos();
        SqlConnection con = new SqlConnection(@"Data Source=SQL5092.site4now.net;Initial Catalog=db_a758a9_sgsa;User Id=db_a758a9_sgsa_admin;Password=sgsa1234");
        DataTable datos = new DataTable();
        private void monthCalendar1_DateSelected(object sender, DateRangeEventArgs e)
        {
            /*DateTime fecha = Convert.ToDateTime(monthCalendar1.SelectionEnd.ToShortDateString());
           label1.Text = fecha.ToString();*/

            /*this.label1.Text = "Date Selected: Start = " +
                e.Start.ToShortDateString() + " : End = " + e.End.ToShortDateString();*/

            //label1.Text = e.Start.ToShortDateString();
            label1.Text = monthCalendar1.SelectionRange.Start.ToString("yyyy-MM-dd");

            string buscarporFecha = "SELECT Evento,Hora,Socio,Estatus,Ubicacion, CONVERT(varchar,getdate(),23) as [Fecha] FROM Eventos WHERE Fecha ='" + label1.Text + "'";
            SqlDataAdapter adaptador = new SqlDataAdapter(buscarporFecha, con);
            SqlCommand comando = new SqlCommand(buscarporFecha, con);
            var ds = new DataSet();
            adaptador.Fill(ds);
            dataeventos.ReadOnly = true;
            dataeventos.DataSource = ds.Tables[0];

            adaptador.Fill(datos);


        }

        private void button2_Click(object sender, EventArgs e)
        {
            /*string buscarporFecha = "SELECT * FROM Eventos WHERE Fecha = '" + label1.Text  + "'";
            dataeventos.DataSource = bd.SelectDataTable(buscarporFecha);


            string buscarporFecha = "SELECT Evento,Hora,Socio,Estatus,Ubicacion, CONVERT(varchar,getdate(),23) as [Fecha] FROM Eventos WHERE Fecha ='" + label1.Text + "'";
            SqlDataAdapter adaptador = new SqlDataAdapter(buscarporFecha, con);
            SqlCommand comando = new SqlCommand(buscarporFecha, con);
            var ds = new DataSet();
            adaptador.Fill(ds);
            dataeventos.ReadOnly = true;
            dataeventos.DataSource = ds.Tables[0];
           
            adaptador.Fill(datos);*/
        }
    }
}
