﻿using System;
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
            
            //string consultar = bd.selectstring("SELECT * FROM Eventos WHERE Socio = '" + txtbuscar.Text + "'");
            string agregar = "INSERT INTO Eventos (Evento,Fecha,Hora,Socio,Estatus,Ubicacion) VALUES (@evento,@fecha,@hora,@socio,@estatus,@ubicacion)";
            con.Open();
            SqlCommand comando = new SqlCommand(agregar, con);
            comando.Parameters.AddWithValue("@evento", textBox1.Text);
            comando.Parameters.AddWithValue("@fecha", dateTimePicker1.Value);
            comando.Parameters.AddWithValue("@hora", dateTimePicker2.Value);
            comando.Parameters.AddWithValue("@socio", txtbuscar.Text);
            comando.Parameters.AddWithValue("@estatus", "Programado");
            comando.Parameters.AddWithValue("@ubicacion", txtsitio.Text);
            comando.ExecuteNonQuery();
            MessageBox.Show("Agregado correctamente");

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            DateTime fecha = dateTimePicker1.Value;
            lblfecha.Text = fecha.ToString();
        }
    }
}
