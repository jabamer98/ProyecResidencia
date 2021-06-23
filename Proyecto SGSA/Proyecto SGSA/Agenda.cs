using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using MaterialSkin;
using MaterialSkin.Controls;
using System.Data.SqlClient;
using System.Diagnostics;

namespace Proyecto_SGSA
{
    public partial class Agenda : MaterialForm
    {
        public Agenda()
        {
          
            InitializeComponent();
            autocompletar();
            registroApagado();
            horaCompleta();

            MaterialSkinManager materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;

            materialSkinManager.ColorScheme = new ColorScheme(
                Primary.Blue400, Primary.Blue500,
                Primary.Blue500, Accent.LightBlue200,
                TextShade.WHITE);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            menu menu = new menu();
            menu.Show();
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

        private void Agenda_Load(object sender, EventArgs e)
        {
      
        



        }

        private void btnbuscar_Click(object sender, EventArgs e)
        {
            string buscarPorNombre = "SELECT * FROM SOCIOS WHERE Nombre = '" + txtbuscar.Text + "'";
            dtasocios.DataSource = bd.SelectDataTable(buscarPorNombre);
            
        

        }

        SqlConnection con=new SqlConnection(@"Data Source=SQL5092.site4now.net;Initial Catalog=db_a758a9_sgsa;User Id=db_a758a9_sgsa_admin;Password=sgsa1234");
        DataTable datos = new DataTable();

        void autocompletar()
        {
            AutoCompleteStringCollection lista = new AutoCompleteStringCollection();
            SqlDataAdapter adaptador = new SqlDataAdapter("SELECT * FROM Socios", con);

            adaptador.Fill(datos);
            for (int i = 0; i < datos.Rows.Count; i++)
            {
                lista.Add(datos.Rows[i]["Nombre"].ToString());
            }
            txtbuscar.AutoCompleteCustomSource = lista;
        }

        private void btnprogramar_Click(object sender, EventArgs e)
        {
            

            string consultar = "SELECT CONVERT(varchar,getdate(),23) as [Fecha] FROM Eventos WHERE Fecha ='" + lblhoraprogr.Text + "'";

            if (string.IsNullOrWhiteSpace(textBox1.Text))
            {
                MessageBox.Show("No ha colocado un sitio para la cita o no ha colocado ubicación", "Campos vacíos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            borrarMensajesError();
            if(validaCampos())
            {
                if(label6.Text == textBox3.Text && label9.Text == label8.Text)
                {
                    MessageBox.Show("Esta fecha ya esta programada");
                }
                else
                {

                    string agregar = "INSERT INTO Eventos (Evento,Fecha,Hora,Socio,Estatus,Ubicacion) VALUES (@evento,@fecha,@hora,@socio,@estatus,@ubicacion)";
                    con.Open();
                    SqlCommand comando = new SqlCommand(agregar, con);
                    comando.Parameters.AddWithValue("@evento", textBox1.Text);
                    comando.Parameters.AddWithValue("@fecha", monthCalendar1.SelectionRange.Start.ToString("yyyy-MM-dd"));
                    comando.Parameters.AddWithValue("@hora", label8.Text);
                    comando.Parameters.AddWithValue("@socio", textBox2.Text);
                    comando.Parameters.AddWithValue("@estatus", "Programado");
                    comando.Parameters.AddWithValue("@ubicacion", txtsitio.Text);
                    comando.ExecuteNonQuery();
                    MessageBox.Show("Agregado correctamente");
                    con.Close();

                    while (dtasocios.RowCount > 1)
                    {
                        dtasocios.Rows.Remove(dtasocios.CurrentRow);
                    }

                    Limpiar limpiar = new Limpiar();
                    limpiar.BorrarCampos(this);

                    registroApagado();
                }

            }

            //string consultar = bd.selectstring("SELECT * FROM Eventos WHERE Socio = '" + txtbuscar.Text + "'");


          

        }
        DataTable busquedaxFecha = new DataTable();
        DataTable busquedaxHora = new DataTable();
        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            //DateTime fecha = dateTimePicker1.Value;
            //lblhoraprogr.Text = fecha.Date.ToShortDateString();



        }

        private void dtasocios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            registroEncendido();
            DataGridViewRow fila = dtasocios.Rows[e.RowIndex];
            lblnombre.Text = Convert.ToString(fila.Cells[3].Value);
            lblApaterno.Text = Convert.ToString(fila.Cells[1].Value);
            lblAmaterno.Text = Convert.ToString(fila.Cells[2].Value);
            nombreCompleto();
            
        }
        /*Con los metodos de registro apagado y registro encendido lo que se hace es habilitar y deshabiliar el boton
         de programar la cita*/
        private void registroApagado()
        {
            btnprogramar.Enabled = false;
        }
        private void registroEncendido()
        {
            btnprogramar.Enabled = true;
        }

        private void nombreCompleto()
        {
            string nombre = lblnombre.Text;
            string apaterno = lblApaterno.Text;
            string amaterno = lblAmaterno.Text;
            textBox2.Text = nombre + " " + apaterno + " " + amaterno;
        }

        private void horaCompleta()
        {
            string hora = cboxhoras.Text;
            string minutos = cboxminutos.Text;
            string ampm = cboxAMPM.Text;
            label8.Text = hora + ":" + minutos + " " + ampm;

        }

        bool validaCampos()
        {
            bool valido = true;
            if (textBox1.Text == "")
            {
                valido = false;
                errorProvider1.SetError(textBox1, "Ingrese un evento para continuar");
            }
            if (txtsitio.Text == "")
            {
                valido = false;
                errorProvider1.SetError(txtsitio, "Ingrese un sitio para continuar");
            }

            return valido;
        }

        void borrarMensajesError()
        {
            errorProvider1.SetError(textBox1, "");
            errorProvider1.SetError(txtsitio, "");
        }

        private void monthCalendar1_DateSelected(object sender, DateRangeEventArgs e)
        {


            buscandoportiempo();
            lblhoraprogr.Text = monthCalendar1.SelectionRange.Start.ToString("yyyy/MM/dd");
            string buscarFecha = "SELECT Fecha, CONVERT(varchar(10),getdate(),23) FROM Eventos WHERE Fecha ='" + lblhoraprogr.Text + "'";
            SqlDataAdapter adaptador = new SqlDataAdapter(buscarFecha, con);
            SqlCommand command = new SqlCommand(buscarFecha, con);
            var ds = new DataSet();
            adaptador.Fill(ds);
            dtafechas.ReadOnly = true;
            dtafechas.DataSource = ds.Tables[0];
            dtafechas.Columns[0].DefaultCellStyle.Format = "yyyy/MM/dd";
            adaptador.Fill(busquedaxFecha);
            con.Open();
            label6.Text = Convert.ToString(command.ExecuteScalar());
            //textBox3.Text = Convert.ToString(command.ExecuteScalar());

            SqlDataReader dr = null;
            SqlCommand cmd = new SqlCommand("SELECT Fecha, CONVERT(varchar(10),getdate(),23) FROM Eventos WHERE Fecha ='" + lblhoraprogr.Text + "'",con);
            
            try
            {
                dr = cmd.ExecuteReader();

                if (dr.Read() == true)
                {
                    MessageBox.Show("Tiene citas pendientes este dia");
                    if (label6.Text == textBox3.Text)
                {
                    
                }
                    textBox3.Text = dr["fecha"].ToString();
                }
                else
                {
                    MessageBox.Show("Día libre");
                }
            }
            catch
            {
                MessageBox.Show("error en el sql");
            }



            con.Close();
        }
         
            
        

        

        private void dtafechas_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dtafechas.Columns[e.ColumnIndex].Name.Equals(0))
            {
                DateTime dateValue;
                if (DateTime.TryParse((String)e.Value, out dateValue))
                {
                    e.Value = dateValue.ToString("yyyy-MM-dd");
                }
            }
        }

        private void cboxAMPM_SelectedIndexChanged(object sender, EventArgs e)
        {
            horaCompleta();
            buscandoportiempo();
        }

        private void cboxminutos_SelectedIndexChanged(object sender, EventArgs e)
        {
            horaCompleta();
            buscandoportiempo();
        }

        private void cboxhoras_SelectedIndexChanged(object sender, EventArgs e)
        {
            horaCompleta();
            buscandoportiempo();
        }

        private void buscandoportiempo()
        {
            string buscarHora = "SELECT Hora FROM Eventos WHERE Hora = '" + label8.Text + "'";
            SqlDataAdapter adaptador2 = new SqlDataAdapter(buscarHora, con);
            SqlCommand comando2 = new SqlCommand(buscarHora, con);
            var ds2 = new DataSet();
            adaptador2.Fill(ds2);
            dtahoras.ReadOnly = true;
            dtahoras.DataSource = ds2.Tables[0];
            adaptador2.Fill(busquedaxHora);
            con.Open();
            label9.Text = Convert.ToString(comando2.ExecuteScalar());
            con.Close();
        }

      
    }
}
