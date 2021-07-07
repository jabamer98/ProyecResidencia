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

    public partial class HistorialAgenda : MaterialForm
    {
        public HistorialAgenda()
        {

            InitializeComponent();
            btnactualizarapagado();
            btneditarapagado();
            calendarioMODapagado();
            apagartxt();

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

        private void btnactualizarencendido()
        {
            btnactualizar.Enabled = true;
        }
        private void btnactualizarapagado()
        {
            btnactualizar.Enabled = false;
        }

        private void btneditarencendido()
        {
            btneditar.Enabled = true;
        }

        private void btneditarapagado()
        {
            btneditar.Enabled = false;
        }

        private void apagaretiquetas()
        {
            lblevento.Visible = false;
            lblhora.Enabled = false;
            lblnombrecompleto.Visible = false;
            lblubicacion.Visible = false;
        }
        private void encenderetiquetas()
        {
            lblevento.Visible = true;
            lblhora.Visible = true;
            lblnombrecompleto.Visible = true;
            lblubicacion.Visible = true;
        }
        private void apagartxt()
        {
            txtevento.Visible = false;
            txtnombresocio.Visible = false;
            txtubicacion.Visible = false;
            cmboxhora.Visible = false;
            cmboxminutos.Visible = false;
            cmboxampm.Visible = false;
            label11.Visible = false;
            lblhoranueva.Visible = false;
            label12.Visible = false;
            lblfechanueva.Visible = false;
        }
        private void encendertxt()
        {
            txtevento.Visible = true;
            txtnombresocio.Visible = true;
            txtubicacion.Visible = true;
            cmboxhora.Visible = true;
            cmboxminutos.Visible = true;
            cmboxampm.Visible = true;
            label11.Visible = true;
            lblhoranueva.Visible = true;
            label12.Visible = true;
            lblfechanueva.Visible = true;
        }
        private void calendarioMODapagado()
        {
            layoutCalModificado.Visible = false;
        }
        private void calendarioMODencendido()
        {
            layoutCalModificado.Visible = true;
        }

        private void horaCompleta()
        {
            string hora = cmboxhora.Text;
            string minutos = cmboxminutos.Text;
            string ampm = cmboxampm.Text;
            lblhoranueva.Text = hora + ":" + minutos + " " + ampm;
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
            dataeventos.Enabled = true;
            string buscarporFecha = "SELECT ID,NombreSocio,Evento,Hora,Ubicacion,Estatus, CONVERT(varchar,getdate(),23) as [Fecha] FROM Eventos WHERE Fecha ='" + label1.Text + "'";
            SqlDataAdapter adaptador = new SqlDataAdapter(buscarporFecha, con);
            SqlCommand comando = new SqlCommand(buscarporFecha, con);
            var ds = new DataSet();
            adaptador.Fill(ds);
            dataeventos.ReadOnly = true;
            dataeventos.DataSource = ds.Tables[0];

            adaptador.Fill(datos);

            btnactualizarapagado();
            calendarioMODapagado();
            apagartxt();




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

        private void button1_Click(object sender, EventArgs e)
        {
            menu menu = new menu();
            menu.Show();
        }



        private void btneliminar_Click(object sender, EventArgs e)
        {
            con.Open();
            int flag = 0;
            string cadena = "DELETE FROM Eventos WHERE ID = '" + lblIDEvento.Text + "'"; // string cadena = "DELETE FROM Eventos WHERE Evento = '" + lblevento.Text + "'";
            if (MessageBox.Show("¿Está seguro de eliminar la cita permanentemente", "¿Esta seguro?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                SqlCommand comando = new SqlCommand(cadena, con);
                flag = comando.ExecuteNonQuery();

                if (flag == 1)
                {
                    MessageBox.Show("El registro se borro correctamente");
                    calendarioMODapagado();
                    apagartxt();
                }
                else
                {
                    MessageBox.Show("No se encontro a la persona");
                }
                dataeventos.DataSource = bd.SelectDataTable("SELECT ID,NombreSocio,Evento,Hora,Ubicacion,Estatus FROM Eventos WHERE Fecha ='" + label1.Text + "'");
            }
            else
            {
                dataeventos.DataSource = bd.SelectDataTable("SELECT ID,NombreSocio,Evento,Hora,Ubicacion,Estatus FROM Eventos WHERE Fecha ='" + label1.Text + "'");
            }
            con.Close();
        }

        private void dataeventos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dataeventos.Enabled = true;
            if (e.RowIndex >= 0)
            {
                encenderetiquetas();
                DataGridViewRow fila = dataeventos.Rows[e.RowIndex];
                lblIDEvento.Text = Convert.ToString(fila.Cells[0].Value);
                lblnombrecompleto.Text = Convert.ToString(fila.Cells[1].Value);
                lblhora.Text = Convert.ToString(fila.Cells[3].Value);
                lblfecha.Text = Convert.ToString(fila.Cells[6].Value);
                lblevento.Text = Convert.ToString(fila.Cells[2].Value);
                lblubicacion.Text = Convert.ToString(fila.Cells[4].Value);

                txtnombresocio.Text = Convert.ToString(fila.Cells[1].Value);
                txtevento.Text = Convert.ToString(fila.Cells[2].Value);
                txtubicacion.Text = Convert.ToString(fila.Cells[4].Value);

                //lblfechanueva.Text = Convert.ToString(fila.Cells[5].Value);
                lblhoranueva.Text = Convert.ToString(fila.Cells[3].Value);
            }

            if (string.IsNullOrWhiteSpace(lblnombrecompleto.Text))
            {
                btneditarapagado();
                dataeventos.DataSource = bd.SelectDataTable("SELECT ID,NombreSocio,Evento,Hora,Ubicacion,Estatus CONVERT(varchar,getdate(),23) as [Fecha] FROM Eventos WHERE Fecha ='" + label1.Text + "'");
                encenderetiquetas();
               
            }
            else
            {
                btneditarencendido();
               // dataeventos.DataSource = bd.SelectDataTable("SELECT ID,NombreSocio,Evento,Hora,Ubicacion,Estatus CONVERT(varchar,getdate(),23) as [Fecha] FROM Eventos WHERE Fecha ='" + label1.Text + "'");
              
            }
            

        }

        private void btneditar_Click(object sender, EventArgs e)
        {
            btnactualizarencendido();
            apagaretiquetas();
            calendarioMODencendido();
            encendertxt();
            btneditar.Enabled = false;
            if(btneditar.Enabled == false)
            {
                dataeventos.Enabled = false;
            }
        }

        private void cmboxhora_SelectedIndexChanged(object sender, EventArgs e)
        {
            horaCompleta();
            buscandoportiempo();
        }

        private void cmboxminutos_SelectedIndexChanged(object sender, EventArgs e)
        {
            horaCompleta();
            buscandoportiempo();
        }

        private void cmboxampm_SelectedIndexChanged(object sender, EventArgs e)
        {
            horaCompleta();
            buscandoportiempo();
        }

        DataTable busquedaxhora = new DataTable();
        DataTable busquedaxfecha = new DataTable();
        private void buscandoportiempo()
        {
            con.Open();
            string buscarHora = "SELECT Hora FROM Eventos WHERE Hora = '" + lblhoranueva.Text + "'";
            SqlDataAdapter adaptador = new SqlDataAdapter(buscarHora, con);
            SqlCommand comando = new SqlCommand(buscarHora, con);
            var ds = new DataSet();
            adaptador.Fill(ds);
            dtahoranueva.ReadOnly = true;
            dtahoranueva.DataSource = ds.Tables[0];
            adaptador.Fill(busquedaxhora);
            
            lblbusquedahora.Text = Convert.ToString(comando.ExecuteScalar());
            con.Close();
            
        }


        private void monthCalendar2_DateSelected(object sender, DateRangeEventArgs e)
        {
            buscandoportiempo();
            lblfechanueva.Text = monthCalendar2.SelectionRange.Start.ToString("yyyy-MM-dd");
            string buscarfecha = "SELECT Fecha, CONVERT(varchar(10),getdate(),23) FROM Eventos WHERE Fecha ='" + lblfechanueva.Text + "'";
            SqlDataAdapter adaptador2 = new SqlDataAdapter(buscarfecha, con);
            SqlCommand comandofech = new SqlCommand(buscarfecha, con);
            var ds2 = new DataSet();
            adaptador2.Fill(ds2);
            dtafechasnuevas.ReadOnly = true;
            dtafechasnuevas.DataSource = ds2.Tables[0];
            dtafechasnuevas.Columns[0].DefaultCellStyle.Format = "yyyy-MM-dd";
            adaptador2.Fill(busquedaxfecha);
            con.Open();
            lblbusquedafecha.Text = Convert.ToString(comandofech.ExecuteScalar());
            
            SqlDataReader dr = null;
            SqlCommand cmd = new SqlCommand("SELECT Fecha, CONVERT(varchar(10),getdate(),23) FROM Eventos WHERE Fecha ='" + lblfechanueva.Text + "'", con);

            try
            {
                dr = cmd.ExecuteReader();

                if (dr.Read()==true)
                {
                    MessageBox.Show("Tiene citas pendientes este dia");
                    if (lblbusquedafecha.Text == lblfechacomprobacion.Text)
                    {

                    }
                    lblfechacomprobacion.Text = dr["fecha"].ToString();

                }
                else
                {
                    MessageBox.Show("Dia libre");
                }
            }
            catch
            {
                MessageBox.Show("Error en el sql");
            }
            con.Close();
        }

        private void btnactualizar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Está seguro de modificar el registro?","Está seguro?",MessageBoxButtons.YesNo,MessageBoxIcon.Question)== DialogResult.Yes)
            {
                
                if(label1.Text==lblfechanueva.Text && lblbusquedahora.Text == lblhoranueva.Text)
                {
                    MessageBox.Show("Esta fecha ya está programada");
                }
                else
                {
                    try
                    {
                       
                        //string fecha = lblfechanueva.Text.Trim();
                        string actualizar = "UPDATE Eventos SET NombreSocio = @nombresocio, Evento = @evento, Fecha = @fecha, Hora = @hora, Ubicacion = @ubicacion, Estatus = @estatus WHERE ID = @id";
                        con.Open();
                        SqlCommand comando = new SqlCommand(actualizar, con);
                        comando.Parameters.AddWithValue("@id", lblIDEvento.Text);
                        comando.Parameters.AddWithValue("@nombresocio", txtnombresocio.Text);
                        comando.Parameters.AddWithValue("@evento", txtevento.Text);
                        comando.Parameters.AddWithValue("@fecha", Convert.ToDateTime(lblfechanueva.Text));
                        comando.Parameters.AddWithValue("@hora", lblhoranueva.Text);
                        comando.Parameters.AddWithValue("@ubicacion", txtubicacion.Text);
                        comando.Parameters.AddWithValue("@estatus", "Programado");
                        comando.ExecuteNonQuery();
                        con.Close();
                        MessageBox.Show("Registro actualizado correctamente");
                        dataeventos.DataSource = bd.SelectDataTable("SELECT ID,NombreSocio,Evento,Fecha,Hora,Ubicacion,Estatus  FROM Eventos WHERE Fecha ='" + label1.Text + "'");
                        calendarioMODapagado();
                        apagartxt();
                    }
                    catch
                    {
                        MessageBox.Show("Error al actualizar, Revise su fecha y hora nuevas o seleccione la misma hora y fecha anteriores");
                    }
                }

                

            }

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
