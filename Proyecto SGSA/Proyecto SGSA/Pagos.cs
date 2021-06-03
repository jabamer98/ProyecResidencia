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
        {///
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

            /*COMENTADO PARA QUE FUNCIONE************************************************************************************

            try
            {
                if (txtBuscar.Text != "" && textBoxCantidadNumero.Text != "")
                {


                    ListaCompra[Fila, 0] = txtBuscar.Text;
                    ListaCompra[Fila, 1] = lblNombre.Text;
                    ListaCompra[Fila, 2] = lblTelefono.Text;
                    ListaCompra[Fila, 3] = lblDomicilio.Text;
                    ListaCompra[Fila, 4] = lblColonia.Text;
                    ListaCompra[Fila, 5] = lblCiudad.Text;
                    ListaCompra[Fila, 6] = lblPredioDenominado.Text;
                    ListaCompra[Fila, 7] = textBoxCantidadNumero.Text;
                    ListaCompra[Fila, 8] = (float.Parse(textBoxCantidadNumero.Text) * float.Parse(lblBuenoPor.Text)).ToString();



                    dgvPagos.Rows.Add(ListaCompra[Fila, 0], ListaCompra[Fila, 1], ListaCompra[Fila, 2], ListaCompra[Fila, 3], ListaCompra[Fila, 4]);
                    Fila++;// se le agrega uno a la fila para futuras generaciones jejeje
                    txtBuscar.Text = lblNombre.Text = lblBuenoPor.Text = textBoxCantidadNumero.Text = "";

                    txtBuscar.Focus();

                }
            }
            catch
            {

            }
            CostoApagar();
            */

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

        private void dgvPagos_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow fila = dgvPagos.Rows[e.RowIndex];
            textBoxNombreS.Text = Convert.ToString(fila.Cells[3].Value);
            textBoxApellidoPS.Text = Convert.ToString(fila.Cells[1].Value);
            textBoxApellidoMS.Text = Convert.ToString(fila.Cells[2].Value);
            textBoxDomicilio.Text = Convert.ToString(fila.Cells[6].Value);
            textBoxColonia.Text = Convert.ToString(fila.Cells[7].Value);
            textBoxPoblacion.Text = Convert.ToString(fila.Cells[8].Value);
            textBoxTelefono.Text = Convert.ToString(fila.Cells[9].Value);
            textBoxNamePredio.Text = Convert.ToString(fila.Cells[10].Value);
        }

        ///


        ///




        ///
        public void CostoApagar()
        {
            float CostoTotal = 0;
            int Conteo = 0;

            Conteo = dgvPagos.RowCount; // se cuenta los productos y se utilisa el conteo como limite del for
            for (int i = 0; i < Conteo; i++)
            {
                //COMENTADO PARA QUE FUNCIONE****************************************************************************************
                //CostoTotal += float.Parse(dgvPagos.Rows[i].Cells[4].Value.ToString());
            }

            lblCostoApagar.Text = CostoTotal.ToString();
        }
        ///
        ///
        private void textBoxCantidadNumero_TextChanged(object sender, EventArgs e)
        {
            try
            {
                lbldevolucion.Text = (float.Parse(textBox3.Text) - float.Parse(lblCostoApagar.Text)).ToString();
            }
            catch
            {
                lbldevolucion.Text = 0.ToString();

            }
        }
        ///

        ///
        int Conteo;
        private void button1_Click(object sender, EventArgs e)
        {

            Conteo = dgvPagos.RowCount; // se cuenta los productos y se utilisa el conteo como limite del for
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


                    for (int i = 0; i < Conteo; i++)
                    {
                        ClassBT.clsDetallesPago.CURPfk = float.Parse(dgvPagos.Rows[i].Cells[0].Value.ToString()); ;
                        ClassBT.clsDetallesPago.CantidadAños = int.Parse(dgvPagos.Rows[i].Cells[3].Value.ToString());
                        ClassBT.clsDetallesPago.CostoDetalle = int.Parse(dgvPagos.Rows[i].Cells[2].Value.ToString());

                        ClassFunciones.clsFunciones.EjecutaQuery("RDV");//registra el detalle de la venta 

                    }
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

                Ticket1.TextoIzquierda("Dirección: Av. Luis Huerta No. 17 C.P 69010 COL. Centro Santiago Chazumba");
                Ticket1.TextoIzquierda("Teléfono: 953-52-502-22 ");
                Ticket1.TextoIzquierda("");
                Ticket1.TextoCentro("                                        TESORERIA");
                Ticket1.TextoCentro("                                     RECIBO PREDIAL"); //imprime una linea de descripcion
                Ticket1.TextoIzquierda("FOLIO:" + ClassBT.clsDetallesPago.Foliofk.ToString());
                Ticket1.TextoIzquierda("Villa de Santiago Chazumba, Huaj., Oax., a:  " + DateTime.Now.ToShortDateString() + " Hora:" + DateTime.Now.ToShortTimeString());
                Ticket1.TextoIzquierda("");
                ClassFunciones.clsFunciones.CreaTicket.LineasGuion();//-------------------------

                ClassFunciones.clsFunciones.CreaTicket.EncabezadoVenta();
                ClassFunciones.clsFunciones.CreaTicket.LineasGuion();
                //Detalle de la factura

                //COMENTADO PARA QUE FUNCIONE************************************************************************************************
                /*foreach (DataGridViewRow r in dgvPagos.Rows)
                {
                    // Articulo                     //Precio                                    cantidad                            Subtotal
                    Ticket1.AgregaArticulo(r.Cells[1].Value.ToString(), 
                        double.Parse(r.Cells[2].Value.ToString()), 
                        int.Parse(r.Cells[3].Value.ToString()), 
                        double.Parse(r.Cells[4].Value.ToString())); //imprime una linea de descripcion
                }*/


                ClassFunciones.clsFunciones.CreaTicket.LineasGuion();
                //Ticket1.AgregaTotales("Sub-Total", double.Parse("000")); // imprime linea con Subtotal
                //Ticket1.AgregaTotales("Menos Descuento", double.Parse("000")); // imprime linea con decuento total
                //Ticket1.AgregaTotales("Mas ITBIS", double.Parse("000")); // imprime linea con ITBis total
                Ticket1.TextoIzquierda(" ");
                Ticket1.AgregaTotales("Total", double.Parse(textBoxCantidadNumero.Text)); // imprime linea con total
                Ticket1.Letra("Importe con letra:", lblCantidadLetra.Text);
                Ticket1.TextoIzquierda(" ");
                Ticket1.AgregaTotales("Efectivo Entregado:", double.Parse(textBoxCantidadNumero.Text));
                Ticket1.AgregaTotales("Efectivo Devuelto:", double.Parse(lbldevolucion.Text));
                Ticket1.TextoIzquierda(" ");
                Ticket1.TextoIzquierda("                                  Tesorero                                                               Sello");
                Ticket1.TextoIzquierda("                 ________________________                             _____________________");
         
                // Ticket1.LineasTotales(); // imprime linea 


                //Ticket1.TextoIzquierda(" ");
                //Ticket1.TextoCentro("**************************************************************************************************");
                Ticket1.TextoCentro("            Estimado Socio favor de conservar su Recibo Predial para cualquier Aclaración");
                Ticket1.TextoCentro("                                   El Pago de este Recibo No Libera de Adeudos Anteriores");
                //Ticket1.TextoCentro("**************************************************************************************************");
                Ticket1.TextoIzquierda(" ");

                Ticket1.ImprimirTiket(cmbInstalledPrinters.Text); //Imprimir




                Fila = 0;
                while (dgvPagos.RowCount > 0)//limpia el dgv
                { dgvPagos.Rows.Remove(dgvPagos.CurrentRow); }
                //LBLIDnuevaFACTURA.Text = ClaseFunciones.ClsFunciones.IDNUEVAFACTURA().ToString();
                //Checar si Txt Buscar se le queda la curp al hacer clic en la curp del datagridview
                txtBuscar.Text = lblNombre.Text = txtPagoAnual.Text = textBoxCantidadNumero.Text = "";
                lblCostoApagar.Text = lbldevolucion.Text = textBoxCantidadNumero.Text = "0";
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
