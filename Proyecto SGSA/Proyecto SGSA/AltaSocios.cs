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
using System.Data.SqlClient;
using MaterialSkin;
using MaterialSkin.Controls;

namespace Proyecto_SGSA
{
    public partial class AltaSocios : MaterialForm
    {
        public AltaSocios()
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
        //en este metodo solo agrege un link por medio de codigo para que se pueda hacer la consulta de la curp a traves de internet
        private void AltaSocios_Load(object sender, EventArgs e)
        {
            linkLabel1.Text = "Consulta aquí la CURP desde el sitio oficial de RENAPO";
            linkLabel1.Links.Add(0, 0, "www.gob.mx/curp/");
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.sociosTableAdapter.FillBy(this.dB_A7241D_sgsaDataSet.Socios);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }
      

        SqlConnection con = new SqlConnection(@"Data Source=SQL5092.site4now.net;Initial Catalog=db_a758a9_sgsa;User Id=db_a758a9_sgsa_admin;Password=sgsa1234");

        public void carpet(string apaterno, string amaterno, string nombre, string CURP)
        {
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT CURP FROM Socios WHERE APaterno = @apepaterno AND AMaterno = @apematerno AND Nombre = @nombre AND CURP = @curp", con);
                cmd.Parameters.AddWithValue("apepaterno", apaterno);
                cmd.Parameters.AddWithValue("apematerno", amaterno);
                cmd.Parameters.AddWithValue("nombre", nombre);
                cmd.Parameters.AddWithValue("curp", CURP);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);

                // Especifique el directorio que desea manipular.
                string path = @"D:\" + "" +apaterno + " " + amaterno + " " +nombre + " " + CURP;
                 
                try
                {
                    // Determina si la carpeta ya existe.
                    if (Directory.Exists(path))
                    {
                        Console.WriteLine("Esta carpeta ya existe..");
                        return;
                    }

                    // Intenta crear el directorio.
                    DirectoryInfo di = Directory.CreateDirectory(path);
                    Console.WriteLine("La carpeta se creo correctamente en {0}.", Directory.GetCreationTime(path));

                }
                catch (Exception ex)
                {
                    Console.WriteLine("El proceso ha fallado: {0}", ex.ToString());
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
            finally
            {
                con.Close();
            }

        }


        BaseDeDatos bd = new BaseDeDatos();
       

        private void button1_Click(object sender, EventArgs e)
        {
            // con.Open(); esta parte ya estaba comentada cuando comenze a trabajar el 12/04/21
            // ATENCION en esta parte intente hacer la conexion con el sqlcommand pero no funciono porque no ocupe el dataReader
            /*SqlCommand curp = new SqlCommand("SELECT CURP FROM Socios WHERE CURP = CURP", con);
             curp.Parameters.AddWithValue("CURP", textBox1CURP.Text);
             con.Open();
             SqlDataReader curpconsultada = curp.ExecuteReader();
             if (curpconsultada.Read())
             {
                 string curpf = curpconsultada["CURP"].ToString();
             }
             con.Close();*/




            carpet(this.textBox2Paterno.Text, this.textBox3Materno.Text, this.textBox4Nombre.Text, this.textBox1CURP.Text);

            string consultar = bd.selectstring("SELECT * FROM Socios WHERE CURP = '"+ textBox1CURP.Text +"'");
            string agregar = "INSERT INTO Socios ([CURP], [APaterno], [AMaterno], [Nombre], [FNacimiento], [Edad], [Domicilio], [Colonia], [CiudadOPoblacion], [Telefono], [NombrePredios]) " +
                                    "VALUES ('" + textBox1CURP.Text + "', '" + textBox2Paterno.Text + "', '" + textBox3Materno.Text + "', '" + textBox4Nombre.Text + "', '" + textBox5FNacimiento.Text + "', '" + textBox6Edad.Text + "', '" + textBox7Domicilio.Text + "', '" + textBoxColonia.Text + "', '" + textBoxPoblacion.Text + "', '" + textBox8Telefono.Text + "', '" + textBox9NamePredios.Text + "')";





            //se uso un bool para validar que todos los campos no queden vacios y si lo estan salen los mensajes entre comillas, hsta que se cumpla el valido true, aplica el returno con el valido 
             bool validarCapmpos()
            {
                bool valido = true;

                if(textBox1CURP.Text == "")
                {
                    valido = false;
                    errorProvider1.SetError(textBox1CURP, "ingrese CURP");
                }
                if (textBox2Paterno.Text == "")
                {
                    valido = false;
                    errorProvider1.SetError(textBox2Paterno, "ingrese apellido paterno");
                }
                if (textBox3Materno.Text == "")
                {
                    valido = false;
                    errorProvider1.SetError(textBox3Materno, "ingrese apellido materno");
                }
                if (textBox4Nombre.Text == "")
                {
                    valido = false;
                    errorProvider1.SetError(textBox4Nombre, "ingrese un nombre");
                }
                if (textBox5FNacimiento.Text == "")
                {
                    valido = false;
                    errorProvider1.SetError(textBox5FNacimiento, "ingrese una fecha en formato AAAA-MM-DD");
                }
                if (textBox6Edad.Text == "")
                {
                    valido = false;
                    errorProvider1.SetError(textBox6Edad, "ingrese una edad en sólo número");
                }
                if (textBox7Domicilio.Text == "")
                {
                    valido = false;
                    errorProvider1.SetError(textBox7Domicilio, "ingrese un domicílio");
                }
                if (textBoxColonia.Text == "")
                {
                    valido = false;
                    errorProvider1.SetError(textBox7Domicilio, "ingrese una Colonia");
                }
                if (textBoxPoblacion.Text == "")
                {
                    valido = false;
                    errorProvider1.SetError(textBox7Domicilio, "ingrese una Poblacion");
                }
                if (textBox8Telefono.Text == "")
                {
                    valido = false;
                    errorProvider1.SetError(textBox8Telefono, "ingrese Teléfono");
                }
                if (textBox9NamePredios.Text == "")
                {
                    valido = false;
                    errorProvider1.SetError(textBox9NamePredios, "ingrese Predios");
                }

                return valido;
            }
            //una vez validado cada campo se limpiara con el metodo borrarmesajesError
             void BorrarMensajesError()
            {
                errorProvider1.SetError(textBox1CURP, "");
                errorProvider1.SetError(textBox2Paterno, "");
                errorProvider1.SetError(textBox3Materno, "");
                errorProvider1.SetError(textBox4Nombre, "");
                errorProvider1.SetError(textBox5FNacimiento, "");
                errorProvider1.SetError(textBox6Edad, "");
                errorProvider1.SetError(textBox7Domicilio, "");
                errorProvider1.SetError(textBoxColonia, "");
                errorProvider1.SetError(textBoxPoblacion, "");
                errorProvider1.SetError(textBox8Telefono, "");
                errorProvider1.SetError(textBox9NamePredios, "");
            }
            //en esta parte del codigo nos pregunta si esta vacio el textbox correspondiente a la curp, la tomamos como id principal, por eso tiene su propio metodo para corroborar la ausencia de datos
            if (string.IsNullOrWhiteSpace(textBox1CURP.Text))
                //si es nulo el campo, saldra el siguiente mensaje con una ventana de alerta
            {  
                MessageBox.Show("Error, No ha introducido una curp", "Campos vacíos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else //de otro modo si al buscar en la base de datos y encuentra una curp duplicada saldra el siguiente mensaje
            {
                if (consultar == textBox1CURP.Text)
                {


                    MessageBox.Show("Esta CURP ya ha sido registrada", "CURP duplicada",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
        
                }
                else //el ultimo de otro modo "else" nos indica que al agregar datos nuevos y sin duplicar el usuario o curp queda registrado satisfactoriamente

                {
                    
                        BorrarMensajesError(); //este borrar mensajes es indispensable mandarlo a llamar para que limpie todos los campos con mensajes previos de otros campos vacios
                        if (validarCapmpos())
                        {
                            MessageBox.Show("Datos agregados correctamente");
                        bd.executecommand(agregar);
                        MessageBox.Show("El socio: " + textBox2Paterno.Text + " " + textBox3Materno.Text + " " + textBox4Nombre.Text + " se ha agregado y creado su carpeta de archivos CORRECTAMENTE", "Aceptar", MessageBoxButtons.OK);
                    }



                    


                   /* if (bd.executecommand(agregar))
                    {
                        MessageBox.Show("La persona:" + textBox2Paterno.Text + " " + textBox3Materno.Text + " " + textBox4Nombre.Text + " se le ha agregado y creado su carpeta de archivos CORRECTAMENTE","Aceptar",MessageBoxButtons.OK);
                        
                    }
                    /*ATENCION este msgbox lo use para saber que imprimia consultar
                    porque pense que imprimia el resultado de la cadena pero en realidad estaba
                        imprimiendo el select literalmente completo y por eso fallaba al 
                        comparar con el textboxCurp*/
                    //System.Windows.Forms.MessageBox.Show(consultar.ToString());
                    else
                    {
                        MessageBox.Show("Faltan datos","Error al agregar",MessageBoxButtons.OK,MessageBoxIcon.Error);
                    }
                }

            }


        }


        //metodo pendiente de probar, hasta la fecha no indispensable 4/05/21
        private string ToString(string curp)
        {
            throw new NotImplementedException();
        }


        //metodo para confirmar que el usuario esta ingresando datos tipo fecha por el datatime fecha, donde fecha es la variable
        private void textBox5FNacimiento_Validating(object sender, CancelEventArgs e)
        {
            DateTime fecha;
            if(!DateTime.TryParse(textBox5FNacimiento.Text, out fecha))
            {
                MessageBox.Show("Debe colocar la fecha en el formato correcto", "Error de captura", MessageBoxButtons.OK, MessageBoxIcon.Error);
                errorProvider1.SetError(textBox5FNacimiento, "El formato correcto es AAAA-MM-DD");
            }
            else
            {
                errorProvider1.SetError(textBox5FNacimiento, "");
            }
        }
        //metodo para confirmar que el usuario esta ingresando solo numeros enteros por el int edad, donde edad es la variable
        private void textBox6Edad_Validating(object sender, CancelEventArgs e)
        {
            int edad;
            if(!int.TryParse(textBox6Edad.Text, out edad))
            {
                MessageBox.Show("Debe colocar la edad en valor númerico", "Error de captura", MessageBoxButtons.OK, MessageBoxIcon.Error);
                errorProvider1.SetError(textBox6Edad, "Debe colocar un valor en número");
            }
            else
            {
                errorProvider1.SetError(textBox6Edad, "");
            }
        }
        //metodo para confirmar que el usuario esta ingresando solo numeros enteros por el int tel, donde tel es la variable y al final se muestra en una ventana de dialogo
        private void textBox8Telefono_Validating(object sender, CancelEventArgs e)
        {
            int tel;
            if(!int.TryParse(textBox8Telefono.Text, out tel))
            {
                MessageBox.Show("Debe colocar el teléfono en formato númerico","Error de captura",MessageBoxButtons.OK,MessageBoxIcon.Error);
                errorProvider1.SetError(textBox8Telefono, "el teléfono va en formato númerico");
            }
            else
            {
                errorProvider1.SetError(textBox8Telefono, "");
            }
        }

        private void linkLabel1_LinkClicked(object sender, System.Windows.Forms.LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(e.Link.LinkData.ToString());
        }
        //metodo para saber cuantos caracteres se estan ingeresando en el textbox, ademas que se coloca un limite de longitud de numeros, que en este caso es de 18 digitos
        private void textBox1CURP_TextChanged(object sender, EventArgs e)
        {
            label15.Text = Convert.ToString(textBox1CURP.Text.Length);
            textBox1CURP.MaxLength = 18;
        }
        //Metodo que manda a llamar al formulario Documentos Personales y Los datos llenados del Texbox 1-4 son mandados para que guarde con el nombre que reciben los texbox
        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();

            AgregarDocPersonales agregarDocPersonales = new AgregarDocPersonales();
           // agregarDocPersonales.Show();

            //manda los los datos del texbox y los reciben los otros texbox de alta socios a AgregarDocPersonales 
            //Se deben poner los texbox(texbox1,2,3,4) que reciben los datos como publicos para que aparezcan. Eso en propiedades-Modifiers-public
            AgregarDocPersonales docper = new AgregarDocPersonales();
            docper.textBox4.Text = textBox2Paterno.Text;
            docper.textBox6.Text = textBox3Materno.Text;
            docper.textBox5.Text = textBox4Nombre.Text;
            docper.textBox3.Text = textBox1CURP.Text;
            docper.Show();

            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            menu menuprin = new menu();
            menuprin.Show();
        }

        private void textBox5FNacimiento_Enter(object sender, EventArgs e)
        {
            /*CON este metodo hacemos que en la propiedad del textbox del focus enter nos aparezca un texto
             predeterminado por nosotros y en la parte de abajo podemos ver el texto que querramos que desaparezca
             con el if y en la parte del forecolor indicamos que lo que escribamos despues se coloque en color negro*/
            if(textBox5FNacimiento.Text == "Año-Mes-Día")
            {
                textBox5FNacimiento.Text = "";
                textBox5FNacimiento.ForeColor = Color.Black;
            }
        }

        private void textBox5FNacimiento_Leave(object sender, EventArgs e)
        {
            /*Con este metodo hacemos lo contrario de la propiedad focus enter en este caso si no escribimos nada
             en el textbox lo que hara en la condicion if es que volvera a colocar el texto predeterminado nuevamente
             en este caso en el forecolor nos indica que estara en color silver*/
            if (textBox5FNacimiento.Text == "")
            {
                textBox5FNacimiento.Text = "Año-Mes-Día";
                textBox5FNacimiento.ForeColor = Color.Silver;
            }
        }

        private void button3_MouseMove(object sender, MouseEventArgs e)
        {
            button3.BackColor = Color.LightSkyBlue;
        }

        private void button3_MouseLeave(object sender, EventArgs e)
        {
            button3.BackColor = Color.SteelBlue;
        }
    }
}
