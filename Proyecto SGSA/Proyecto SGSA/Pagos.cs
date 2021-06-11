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
    public partial class Pagos : MaterialForm
    {
        Conversion c = new Conversion();

        private Font printFont;///
        private StreamReader streamToPrint;///

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
        ///
        private void InstalledPrintersCombo()
        {
            // Add list of installed printers found to the combo box.
            // The pkInstalledPrinters string will be used to provide the display string.
            String pkInstalledPrinters;
            for (int i = 0; i < PrinterSettings.InstalledPrinters.Count; i++)
            {
                pkInstalledPrinters = PrinterSettings.InstalledPrinters[i];
                cmbInstalledPrinters.Items.Add(pkInstalledPrinters);

            }
            cmbInstalledPrinters.Text = "PDFLite";
        }

        ///



        private void Pagos_Load(object sender, EventArgs e)
        {
            InstalledPrintersCombo();
            lblFecha.Text = DateTime.Today.Day.ToString() + "/" + DateTime.Today.Month.ToString() + "/" + DateTime.Today.Year.ToString();
            
         ///

            // TODO: esta línea de código carga datos en la tabla 'dB_A7241D_sgsaDataSet.Socios' Puede moverla o quitarla según sea necesario.
            dgvPagos.DataSource = bd.SelectDataTable("select * from Socios");
           // this.sociosTableAdapter.Fill(this.dB_A7241D_sgsaDataSet.Socios);
            

        }
        //metodo que hace la busqueda por CURP
        BaseDeDatos bdt = new BaseDeDatos();



        string[,] ListaCompra = new string[200, 8];
        int Fila = 0;
        private void btnbuscar_Click(object sender, EventArgs e)
        {
            mostrarPaneldata(paneldata);
            string buscarPorCURP = "SELECT * FROM Socios WHERE CURP = '" + txtBuscar.Text + "'";
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
             DataGridViewRow fila = dgvPagos.Rows[e.RowIndex];
             textBoxCURP.Text = Convert.ToString(fila.Cells[0].Value);
             textBoxNombreS.Text = Convert.ToString(fila.Cells[3].Value);
             textBoxApellidoPS.Text = Convert.ToString(fila.Cells[1].Value);
             textBoxApellidoMS.Text = Convert.ToString(fila.Cells[2].Value);
             textBoxDomicilio.Text = Convert.ToString(fila.Cells[6].Value);
             textBoxColonia.Text = Convert.ToString(fila.Cells[7].Value);
             textBoxPoblacion.Text = Convert.ToString(fila.Cells[8].Value);
             textBoxTelefono.Text = Convert.ToString(fila.Cells[9].Value);
             textBoxNamePredio.Text = Convert.ToString(fila.Cells[10].Value);

        }


        public void CostoApagar()
        {
            
        }
        ///
        ///
        //Llena en efectivo que se le va a devolver de cambio
        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            try
            {
                lbldevolucion.Text = (float.Parse(textBox3.Text) - float.Parse(textBoxCantidadNumero.Text)).ToString();
            }
            catch
            {
                lbldevolucion.Text = 0.ToString();

            }
        }
        //Llena la cantidad a pagar
        private void textBoxCantidadNumero_TextChanged(object sender, EventArgs e)
        {
            try
            {
                lblCostoApagar.Text = (float.Parse(textBoxCantidadNumero.Text)).ToString();
            }
            catch
            {
                lblCostoApagar.Text = 0.ToString();

            }
        }
        ///
        
        private void dgvPago_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }
        ///
        SqlConnection conec = new SqlConnection(@"Data Source=SQL5092.site4now.net;Initial Catalog=db_a758a9_sgsa;User Id=db_a758a9_sgsa_admin;Password=sgsa1234");
        DataTable data = new DataTable();
        BaseDeDatos bdte = new BaseDeDatos();
        int Conteo;
        int Conteoo;
        private void button1_Click(object sender, EventArgs e)
        {

            Conteo = dgvPagos.RowCount; // se cuenta los productos y se utilisa el conteo como limite del for
            Conteoo = dgvPagos.RowCount;
            if (Conteo != 0)
            {
                
                //RegistrarCompra

                try
                {
                    ClassBT.clsPagos.Fecha = lblFecha.Text;

                    ClassBT.clsPagos.Costo = float.Parse(lblCostoApagar.Text);

                    ClassFunciones.clsFunciones.EjecutaQuery("RV");

                    DataTable d = new DataTable();
                    d = ClassFunciones.clsFunciones.EjecutaQueryConsulta("", "IDV");

                    

                    ClassBT.clsDetallesPago.Foliofk = ClassBT.clsPagos.Folio = int.Parse(d.Rows[0][0].ToString());
                  



                    string insertar = "INSERT INTO DetallePago ([Folio], [CURP],[CantidadAños],[Años],[costo]) " +
                        " VALUES ('" + ClassBT.clsPagos.Folio + "','" + textBoxCURP.Text + "', '" + textBoxNoAñosPagar.Text + "', '" + txtPagoAnual.Text + "', '" + lblCostoApagar.Text + "')";
                    con.Open();
                    SqlCommand comando = new SqlCommand(insertar, con);



                    comando.ExecuteNonQuery();
                    con.Close();


                    /*

                    //-----------------------------------------------------------------------------------------------------//
                    //Convert.ToString(textBoxCURP.Text);
                    ClassBT.clsDetallesPago.CURPfk = ClassBT.clsSocio.CURP = ;   //checar

                    ClassBT.clsDetallesPago.CantidadAños = int.Parse(textBoxNoAñosPagar.Text);

                    //Convert.ToString(txtPagoAnual.Text);
                    //ClassBT.clsDetallesPago.Años =  float.Parse(txtPagoAnual.Text);//checar

                    ClassBT.clsDetallesPago.Costo = float.Parse(lblCostoApagar.Text);

                        ClassFunciones.clsFunciones.EjecutaQuery("RDV");//registra el detalle de la venta 

                    */


                }
                catch (Exception a)
                {

                    MessageBox.Show(a.Message);
                }


                ClassFunciones.clsFunciones.CreaTicket Ticket1 = new ClassFunciones.clsFunciones.CreaTicket();
                Ticket1.TextoCentro("                                                 S            A            S            CH "); //imprime una linea de descripcion
                Ticket1.TextoCentro("            SOCIEDAD AGRÍCOLA DE SANTIAGO CHAZUMBA");
                Ticket1.TextoCentro("                                 Al Servicio de Nuestros Socios Sucesores");
                Ticket1.TextoIzquierda("____________________________________________________________________________________");

                Ticket1.TextoIzquierda("Dirección: Av. Luis Huerta No. 17 C.P 69010 Col. Centro  Santiago Chazumba");
                Ticket1.TextoIzquierda("Teléfono: 953-52-502-22 ");
                Ticket1.TextoIzquierda("");
                Ticket1.TextoCentro("                                        TESORERIA");
                Ticket1.TextoCentro("                                     RECIBO PREDIAL"); //imprime una linea de descripcion
                Ticket1.TextoDerecha("FOLIO:" + ClassBT.clsDetallesPago.Foliofk.ToString());
                //Ticket1.TextoIzquierda("Villa de Santiago Chazumba, Huaj., Oax., a:  " + DateTime.Now.ToShortDateString() + " Hora:" + DateTime.Now.ToShortTimeString());
                Ticket1.TextoIzquierda("");
                //ClassFunciones.clsFunciones.CreaTicket.LineasGuion();//-------------------------

                //ClassFunciones.clsFunciones.CreaTicket.EncabezadoVenta();
                //ClassFunciones.clsFunciones.CreaTicket.LineasGuion();
                //Detalle de la factura

                //COMENTADO PARA QUE FUNCIONE************************************************************************************************
                /* foreach (DataGridViewRow r in dataGridView1.Rows)
                 {
                     // Articulo                     //Precio                                    cantidad                            Subtotal
                     Ticket1.AgregaArticulo(r.Cells[0].Value.ToString(), 
                         int.Parse(r.Cells[1].Value.ToString()), 
                         int.Parse(r.Cells[3].Value.ToString()), 
                         double.Parse(r.Cells[2].Value.ToString())); //imprime una linea de descripcion
                 }*/


                Ticket1.RellenarDatos("Recibí del Socio: ", (textBoxNombreS.Text +" "+ textBoxApellidoPS.Text +" "+ textBoxApellidoMS.Text)); // imprime linea con Subtotal
                Ticket1.RellenarDatos("CURP: ", textBoxCURP.Text);
                Ticket1.RellenarDatos("No. de Cuenta Predial: ", textBoxcuepre1.Text);
                Ticket1.RellenarDatos("Socio Avecinado: ", textBoxsocioavec.Text);
                Ticket1.RellenarDatos("No. de Cuenta Predial: ", textBoxcuepre2.Text);
                Ticket1.RellenarDatos("Domicilio: ", textBoxDomicilio.Text);
                Ticket1.RellenarDatos("Colonia: ", textBoxColonia.Text);
                Ticket1.RellenarDatos("Teléfono: ", textBoxTelefono.Text);
                Ticket1.RellenarDatos("Ciudad o Población: ", textBoxPoblacion.Text);
                Ticket1.RellenarDatos("Concepto de Pago: ", textBoxconcepto.Text);
                Ticket1.RellenarDatos("Predio Denominado: ", textBoxNamePredio.Text);
                Ticket1.RellenarDatos("Tipo de predio: ", comboBox1.Text);
                Ticket1.RellenarDatos("Predio ubicado en: ", textBoxubicpred.Text);
                Ticket1.RellenarDatos("Colonia: ", textBoxColoniaPredio.Text);
                Ticket1.RellenarDatos("Pago Correspondiente al Año: ",txtPagoAnual.Text);



                ClassFunciones.clsFunciones.CreaTicket.LineasGuion();
                Ticket1.TextoIzquierda(" ");
                Ticket1.AgregaTotales("Total:                 "+"        ", double.Parse(textBoxCantidadNumero.Text)); // imprime linea con total
                Ticket1.Letra("Importe con letra:      ", lblCantidadLetra.Text);
                Ticket1.TextoIzquierda(" ");
                try {Ticket1.AgregaTotales("Efectivo Entregado:   ", double.Parse(textBox3.Text));}
                catch (FormatException ex){MessageBox.Show("Ingrese la acantidad de $ entregada por el cliente", "Atención");}
               
                

                Ticket1.AgregaTotales("Efectivo Devuelto:     ", double.Parse(lbldevolucion.Text));
                Ticket1.TextoIzquierda(" ");
                ClassFunciones.clsFunciones.CreaTicket.LineasGuion();//-------------------------
                Ticket1.TextoIzquierda("Villa de Santiago Chazumba, Huaj., Oax., a:  " + DateTime.Now.ToShortDateString() + " Hora:" + DateTime.Now.ToShortTimeString());
                Ticket1.TextoIzquierda(" ");
                Ticket1.TextoIzquierda("                                  Tesorero                                                               Sello");
                Ticket1.TextoIzquierda(" ");
                Ticket1.TextoIzquierda(" ");
                Ticket1.TextoIzquierda("                 ________________________                             _____________________");
         
                // Ticket1.LineasTotales(); // imprime linea 


                Ticket1.TextoIzquierda(" ");
                //Ticket1.TextoCentro("**************************************************************************************************");
                Ticket1.TextoCentro("            Estimado Socio favor de conservar su Recibo Predial para cualquier Aclaración");
                Ticket1.TextoCentro("                                   El Pago de este Recibo No Libera de Adeudos Anteriores");
                //Ticket1.TextoCentro("**************************************************************************************************");
                Ticket1.TextoIzquierda(" ");

                Ticket1.ImprimirTiket(cmbInstalledPrinters.Text); //Imprimir



                //METODO QUE LIMPIA LOS REGISTROS DESPUES DE IMPRIMIR O GUARDAR EL RECIBO Y SOLO DEJA EL DATAGRIDVIEW CON LA PERSONA QUE SE BUSCÓ
                Fila = 0;
                while (dgvPagos.RowCount > 1)//limpia el dgv
                {
                    dgvPagos.Rows.Remove(dgvPagos.CurrentRow);
                }
                //LBLIDnuevaFACTURA.Text = ClaseFunciones.ClsFunciones.IDNUEVAFACTURA().ToString();
                //Checar si Txt Buscar se le queda la curp al hacer clic en la curp del datagridview
                txtBuscar.Text = lblCantidadLetra.Text = textBoxNombreS.Text = textBoxApellidoPS.Text = textBoxApellidoMS.Text= textBoxCURP.Text
                = textBoxcuepre1.Text = textBoxsocioavec.Text = textBoxcuepre2.Text = textBoxDomicilio.Text = textBoxColonia.Text = textBoxTelefono.Text
                = textBoxPoblacion.Text = textBoxconcepto.Text = textBoxNamePredio.Text = comboBox1.Text = textBoxubicpred.Text = textBoxColoniaPredio.Text
                = txtPagoAnual.Text = txtPagoAnual.Text = textBoxCantidadNumero.Text = textBoxColoniaPredio.Text = textBoxNoAñosPagar.Text = textBox3.Text = "";

                lblCostoApagar.Text = lbldevolucion.Text = textBoxCantidadNumero.Text = "";
                txtBuscar.Focus();
                MessageBox.Show("    Estimado Usuario Recuerde \n Colacar Sello y Firma en el Recibo", "Mensaje Informativo", MessageBoxButtons.OK, MessageBoxIcon.Question);
                


            }

        }
        //



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

        //Metodo que llama a clase conversion y convierte de numeros a letras, se pone .ToLower para poner en minusculas
        private void buttonConvLetra_Click(object sender, EventArgs e)
        {
            lblCantidadLetra.Text = c.enletras(textBoxCantidadNumero.Text);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

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


    }
}
