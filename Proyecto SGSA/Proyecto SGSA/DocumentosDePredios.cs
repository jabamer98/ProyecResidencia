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
    public partial class DocumentosDePredios : MaterialForm
    {
        public DocumentosDePredios()
        {
            InitializeComponent();

            MaterialSkinManager materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;

            materialSkinManager.ColorScheme = new ColorScheme(
                Primary.Blue400, Primary.Blue500,
                Primary.Blue500, Accent.LightBlue200,
                TextShade.WHITE);
            autocompletar();
        }

        BaseDeDatos bd = new BaseDeDatos();

        //Al abrir la ventana va a mostrar el contenido de la tabla socios
        private void BuscarSocioParaModificar_Load(object sender, EventArgs e)
        {
            dgvRegistros.DataSource = bd.SelectDataTable("select * from Socios");

        }

        //Metodo que hace la busqueda por CURP
        BaseDeDatos bdt = new BaseDeDatos();
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string buscarPorCURP = "SELECT * FROM Socios WHERE CURP = '" + txtBuscar.Text + "'";
            dgvRegistros.DataSource = bdt.SelectDataTable(buscarPorCURP);

        }

        //Metodo que llena los texbox automaticamente al hacer clic en la curp
        BaseDeDatos db = new BaseDeDatos();
        private void dgvRegistro_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow fila = dgvRegistros.Rows[e.RowIndex];
            textBox1CURP.Text = Convert.ToString(fila.Cells[0].Value);
            textBox2Paterno.Text = Convert.ToString(fila.Cells[1].Value);
            textBox3Materno.Text = Convert.ToString(fila.Cells[2].Value);
            textBox4Nombre.Text = Convert.ToString(fila.Cells[3].Value);
            textBox5FNacimiento.Text = Convert.ToString(fila.Cells[4].Value);
            textBox6Edad.Text = Convert.ToString(fila.Cells[5].Value);
            textBox7Domicilio.Text = Convert.ToString(fila.Cells[6].Value);
            textBoxColonia.Text = Convert.ToString(fila.Cells[7].Value);
            textBoxPoblacion.Text = Convert.ToString(fila.Cells[8].Value);
            textBox8Telefono.Text = Convert.ToString(fila.Cells[9].Value);
            textBox9NamePredios.Text = Convert.ToString(fila.Cells[10].Value);
        }

        //Metodo que actualiza los datos del Usuario
        BaseDeDatos database = new BaseDeDatos();
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string fecha = textBox5FNacimiento.Text.Trim();
                string actualizar = "UPDATE Socios SET APaterno = @apaterno, AMaterno = @amaterno, Nombre = @nombre, FNacimiento = @fnacimiento, " +
                    "Edad = @edad, Domicilio = @domicilio, Colonia = @colonia, CiudadOPoblacion = @ciudadopoblacion, Telefono = @telefono, NombrePredios = @nombrepredios WHERE CURP = @curp";
                con.Open();
                SqlCommand comando = new SqlCommand(actualizar, con);

                comando.Parameters.AddWithValue("@curp", textBox1CURP.Text);
                comando.Parameters.AddWithValue("@apaterno", textBox2Paterno.Text);
                comando.Parameters.AddWithValue("@amaterno", textBox3Materno.Text);
                comando.Parameters.AddWithValue("@nombre", textBox4Nombre.Text);
                comando.Parameters.AddWithValue("@fnacimiento", Convert.ToDateTime(textBox5FNacimiento.Text));
                comando.Parameters.AddWithValue("@edad", textBox6Edad.Text);
                comando.Parameters.AddWithValue("@domicilio", textBox7Domicilio.Text);
                comando.Parameters.AddWithValue("@colonia", textBoxColonia.Text);
                comando.Parameters.AddWithValue("@ciudadopoblacion", textBoxPoblacion.Text);
                comando.Parameters.AddWithValue("@telefono", textBox8Telefono.Text);
                comando.Parameters.AddWithValue("@nombrepredios", textBox9NamePredios.Text);
                comando.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Registro actualizado correctamente");

                dgvRegistros.DataSource = bd.SelectDataTable("select * from Socios");
            }

            catch
            {
                MessageBox.Show("Error al actualizar");
            }
        }



        //Metodo que uatocompleta el texbox donde se ingresa la CURP
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

            txtBuscar.AutoCompleteCustomSource = lista;

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        //Metodo que elimina un usuario
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            con.Open();
            int flag = 0;
            string cadena = "DELETE FROM Socios WHERE CURP = '" + textBox1CURP.Text + "'";
            SqlCommand comando = new SqlCommand(cadena, con);
            flag = comando.ExecuteNonQuery();

            if (flag == 1)
            {
                MessageBox.Show("El registro se borro correctamente");
            }
            else
            {
                MessageBox.Show("No se encontro a la persona");
            }
            textBox1CURP.Text = "";
            dgvRegistros.DataSource = bd.SelectDataTable("select * from Socios");
            con.Close();
        }

        private void button1_Click_2(object sender, EventArgs e)
        {

        }

        //Metodo que abre la carpeta de los documentos del socio seleccionado
        private void btnExaminar_Click(object sender, EventArgs e)
        {
            Process.Start("explorer.exe", @"D:\" + "" + textBox2Paterno.Text + " " + textBox3Materno.Text + " " + textBox4Nombre.Text + " " + textBox1CURP.Text);
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_3(object sender, EventArgs e)
        {
            this.Hide();

            AgregarDocPersonales agregarDocPersonales = new AgregarDocPersonales();
           // agregarDocPersonales.Show();

            AgregarDocPersonales docper = new AgregarDocPersonales();
            docper.textBox4.Text = textBox2Paterno.Text;
            docper.textBox6.Text = textBox3Materno.Text;
            docper.textBox5.Text = textBox4Nombre.Text;
            docper.textBox3.Text = textBox1CURP.Text;
            docper.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            menu menuprin = new menu();
            menuprin.Show();
        }

        private void button2_MouseMove(object sender, MouseEventArgs e)
        {
            button2.BackColor = Color.LightSkyBlue;
        }

        private void button2_MouseLeave(object sender, EventArgs e)
        {
            button2.BackColor = Color.SteelBlue;
        }
    }
}
