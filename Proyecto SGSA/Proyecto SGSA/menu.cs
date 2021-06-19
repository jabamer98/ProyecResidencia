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
namespace Proyecto_SGSA
{
    public partial class menu : MaterialForm
    {
        private readonly MaterialSkinManager materialSkinManager;
        public menu()
        {
            InitializeComponent();
            personalizarDiseno();

            /*con esta parte de codigo mandamos a inicializar el form con el tema de materialskin
             ademas de que podemos modificar algunos aspectos como los botones y algunos controles con el mismo tema*/
            MaterialSkinManager materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;

            materialSkinManager.ColorScheme = new ColorScheme(
                Primary.Blue400, Primary.Blue500,
                Primary.Blue500, Accent.LightBlue200,
                TextShade.WHITE);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            mostrarSubmenu(subpanelbtn1);
            /*this.Hide();
            menusocios menusocio = new menusocios();
            menusocio.Show();*/
        }

        private void button2_Click(object sender, EventArgs e)
        {
            mostrarSubmenu(subpanelbtn2);
            /*this.Hide();
            MenuExpedientes expedientes = new MenuExpedientes();
            expedientes.Show();*/
        }

        private void button3_Click(object sender, EventArgs e)
        {
            mostrarSubmenu(subpanelbtn3);

            /*this.Hide();
            Pagos pagos = new Pagos();
            pagos.Show();*/
        }

        private void button4_Click(object sender, EventArgs e)
        {
            mostrarSubmenu(subpanelbtn4);

            /*Agenda agenda = new Agenda();
            agenda.Show();*/
        }

        private void menu_Load(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Panellateral_Paint(object sender, PaintEventArgs e)
        {

        }

        private void personalizarDiseno()
            /*en esta parte del codigo creamos un metodo para hacer que los subpanes entren por defecto
             minimizados*/
        {
            subpanelbtn1.Visible = false;
            subpanelbtn2.Visible = false;
            subpanelbtn3.Visible = false;
            subpanelbtn4.Visible = false;
         
        }
        private void ocultarSubmenu()
        {
            /*en esta parte del codigo creamos un metodo para que al momento que damos clic en un subboton el
             submenu se contrae y todo se minimiza*/
            if (subpanelbtn1.Visible == true)
                subpanelbtn1.Visible = false;
            if (subpanelbtn2.Visible == true)
                subpanelbtn2.Visible = false;
            if (subpanelbtn3.Visible == true)
                subpanelbtn3.Visible = false;
            if (subpanelbtn4.Visible == true)
                subpanelbtn4.Visible = false;
        }

        private void mostrarSubmenu(Panel Submenu)
        {
            /*en esta parte del codigo creamos un metodo para que cuando damos clic en el boton principal
             de cada panel, esos por defecto al inicio aparecen ocultos, entonces al dar clic se despliega
             todo el submenu de ese boton*/
            if (Submenu.Visible == false)
            {
                ocultarSubmenu();
                Submenu.Visible = true;
            }
            else
                Submenu.Visible = false;
        }

        private void materialFlatButton1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Pagos pagos = new Pagos();
            ocultarSubmenu();
            pagos.Show();
        }

        private void materialFlatButton6_Click(object sender, EventArgs e)
        {
            this.Hide();
            ConsultaPagos consultapagos = new ConsultaPagos();
            ocultarSubmenu();
            consultapagos.Show();
        }

        private void materialFlatButton2_Click(object sender, EventArgs e)
        {
            this.Hide();
            AltaSocios altasocios = new AltaSocios();
            ocultarSubmenu();
            altasocios.Show();
        }

        private void materialFlatButton3_Click(object sender, EventArgs e)
        {
            this.Hide();
            BuscarSocioParaModificar modificasocio = new BuscarSocioParaModificar();
            ocultarSubmenu();
            modificasocio.Show();
        }

        private void materialFlatButton4_Click(object sender, EventArgs e)
        {
            this.Hide();
            DocumentosDePredios docpredios = new DocumentosDePredios();
            ocultarSubmenu();
            docpredios.Show();
        }

        private void materialFlatButton5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Expedientes expedientes = new Expedientes();
            ocultarSubmenu();
            expedientes.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }



 

        private void button2_MouseMove(object sender, MouseEventArgs e)
        {
            button2.BackColor = Color.LightSkyBlue;
        }

        private void button2_MouseLeave(object sender, EventArgs e)
        {
            button2.BackColor = Color.SteelBlue;
        }

        private void button3_MouseMove(object sender, MouseEventArgs e)
        {
            button3.BackColor = Color.LightSkyBlue;
        }

        private void button3_MouseLeave(object sender, EventArgs e)
        {
            button3.BackColor = Color.SteelBlue;
        }


        private void button1_MouseMove(object sender, MouseEventArgs e)
            /*COn este metodo podemos modificar el estado del boton cuando le pasamos el cursor encima
             colocando un color diferente que lo haga resaltar*/
        {
            button1.BackColor = Color.LightSkyBlue;
        }

        private void button1_MouseLeave(object sender, EventArgs e)
            /*COn este metodo podemos modificar el estado del boton cuando quitamos el cursor encima del mismo
             haciendo que regrese a su estado original neutro*/
        {
            button1.BackColor = Color.SteelBlue;
        }

        private void button4_MouseMove(object sender, MouseEventArgs e)
        {
            button4.BackColor = Color.LightSkyBlue;
        }

        private void button4_MouseLeave(object sender, EventArgs e)
        {
            button4.BackColor = Color.SteelBlue;
        }

        private void materialFlatButton7_Click(object sender, EventArgs e)
        {
            this.Hide();
            HistorialCitas historialcitas = new HistorialCitas();
            ocultarSubmenu();
            historialcitas.Show();
        }

        private void materialFlatButton8_Click(object sender, EventArgs e)
        {
            this.Hide();
            Agenda agenda = new Agenda();
            ocultarSubmenu();
            agenda.Show();
        }
    }
}
