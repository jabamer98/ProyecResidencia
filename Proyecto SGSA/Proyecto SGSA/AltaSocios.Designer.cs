namespace Proyecto_SGSA
{
    partial class AltaSocios
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AltaSocios));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.sociosTableAdapter = new Proyecto_SGSA.DB_A7241D_sgsaDataSetTableAdapters.SociosTableAdapter();
            this.tableAdapterManager = new Proyecto_SGSA.DB_A7241D_sgsaDataSetTableAdapters.TableAdapterManager();
            this.dB_A7241D_sgsaDataSet = new Proyecto_SGSA.DB_A7241D_sgsaDataSet();
            this.dBA7241DsgsaDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.textBox1CURP = new System.Windows.Forms.TextBox();
            this.textBox2Paterno = new System.Windows.Forms.TextBox();
            this.textBox3Materno = new System.Windows.Forms.TextBox();
            this.textBox4Nombre = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.textBox5FNacimiento = new System.Windows.Forms.TextBox();
            this.textBox6Edad = new System.Windows.Forms.TextBox();
            this.textBox7Domicilio = new System.Windows.Forms.TextBox();
            this.textBox8Telefono = new System.Windows.Forms.TextBox();
            this.textBox9NamePredios = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.label13 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.textBoxPoblacion = new System.Windows.Forms.TextBox();
            this.textBoxColonia = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dB_A7241D_sgsaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBA7241DsgsaDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label1.Location = new System.Drawing.Point(228, 159);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "CURP:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label2.Location = new System.Drawing.Point(228, 185);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Apellido Paterno:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label3.Location = new System.Drawing.Point(228, 211);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(139, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Apellido Materno:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label4.Location = new System.Drawing.Point(228, 237);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Nombre(s):";
            // 
            // sociosTableAdapter
            // 
            this.sociosTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.SociosTableAdapter = this.sociosTableAdapter;
            this.tableAdapterManager.UpdateOrder = Proyecto_SGSA.DB_A7241D_sgsaDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UsuariosTableAdapter = null;
            // 
            // dB_A7241D_sgsaDataSet
            // 
            this.dB_A7241D_sgsaDataSet.DataSetName = "DB_A7241D_sgsaDataSet";
            this.dB_A7241D_sgsaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dBA7241DsgsaDataSetBindingSource
            // 
            this.dBA7241DsgsaDataSetBindingSource.DataSource = this.dB_A7241D_sgsaDataSet;
            this.dBA7241DsgsaDataSetBindingSource.Position = 0;
            // 
            // textBox1CURP
            // 
            this.textBox1CURP.BackColor = System.Drawing.SystemColors.Window;
            this.textBox1CURP.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1CURP.ForeColor = System.Drawing.SystemColors.WindowText;
            this.textBox1CURP.Location = new System.Drawing.Point(415, 159);
            this.textBox1CURP.Name = "textBox1CURP";
            this.textBox1CURP.Size = new System.Drawing.Size(178, 20);
            this.textBox1CURP.TabIndex = 4;
            this.textBox1CURP.TextChanged += new System.EventHandler(this.textBox1CURP_TextChanged);
            // 
            // textBox2Paterno
            // 
            this.textBox2Paterno.BackColor = System.Drawing.SystemColors.Window;
            this.textBox2Paterno.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox2Paterno.ForeColor = System.Drawing.SystemColors.WindowText;
            this.textBox2Paterno.Location = new System.Drawing.Point(415, 185);
            this.textBox2Paterno.Name = "textBox2Paterno";
            this.textBox2Paterno.Size = new System.Drawing.Size(155, 20);
            this.textBox2Paterno.TabIndex = 5;
            // 
            // textBox3Materno
            // 
            this.textBox3Materno.BackColor = System.Drawing.SystemColors.Window;
            this.textBox3Materno.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox3Materno.ForeColor = System.Drawing.SystemColors.WindowText;
            this.textBox3Materno.Location = new System.Drawing.Point(415, 211);
            this.textBox3Materno.Name = "textBox3Materno";
            this.textBox3Materno.Size = new System.Drawing.Size(155, 20);
            this.textBox3Materno.TabIndex = 6;
            // 
            // textBox4Nombre
            // 
            this.textBox4Nombre.BackColor = System.Drawing.SystemColors.Window;
            this.textBox4Nombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox4Nombre.ForeColor = System.Drawing.SystemColors.WindowText;
            this.textBox4Nombre.Location = new System.Drawing.Point(415, 237);
            this.textBox4Nombre.Name = "textBox4Nombre";
            this.textBox4Nombre.Size = new System.Drawing.Size(178, 20);
            this.textBox4Nombre.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label5.Location = new System.Drawing.Point(228, 263);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(169, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "Fecha de nacimiento:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label6.Location = new System.Drawing.Point(228, 288);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 20);
            this.label6.TabIndex = 9;
            this.label6.Text = "Edad:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label7.Location = new System.Drawing.Point(228, 314);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(122, 20);
            this.label7.TabIndex = 10;
            this.label7.Text = "Domicilio:Calle";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label8.Location = new System.Drawing.Point(228, 398);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(78, 20);
            this.label8.TabIndex = 11;
            this.label8.Text = "Teléfono:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label9.Location = new System.Drawing.Point(228, 424);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(183, 20);
            this.label9.TabIndex = 12;
            this.label9.Text = "Nombre de los predios:";
            // 
            // textBox5FNacimiento
            // 
            this.textBox5FNacimiento.BackColor = System.Drawing.SystemColors.Window;
            this.textBox5FNacimiento.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox5FNacimiento.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.textBox5FNacimiento.Location = new System.Drawing.Point(415, 263);
            this.textBox5FNacimiento.Name = "textBox5FNacimiento";
            this.textBox5FNacimiento.Size = new System.Drawing.Size(155, 20);
            this.textBox5FNacimiento.TabIndex = 13;
            this.textBox5FNacimiento.Text = "Año-Mes-Día";
            this.textBox5FNacimiento.Enter += new System.EventHandler(this.textBox5FNacimiento_Enter);
            this.textBox5FNacimiento.Leave += new System.EventHandler(this.textBox5FNacimiento_Leave);
            this.textBox5FNacimiento.Validating += new System.ComponentModel.CancelEventHandler(this.textBox5FNacimiento_Validating);
            // 
            // textBox6Edad
            // 
            this.textBox6Edad.BackColor = System.Drawing.SystemColors.Window;
            this.textBox6Edad.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox6Edad.ForeColor = System.Drawing.SystemColors.WindowText;
            this.textBox6Edad.Location = new System.Drawing.Point(415, 288);
            this.textBox6Edad.Name = "textBox6Edad";
            this.textBox6Edad.Size = new System.Drawing.Size(79, 20);
            this.textBox6Edad.TabIndex = 14;
            this.textBox6Edad.Validating += new System.ComponentModel.CancelEventHandler(this.textBox6Edad_Validating);
            // 
            // textBox7Domicilio
            // 
            this.textBox7Domicilio.BackColor = System.Drawing.SystemColors.Window;
            this.textBox7Domicilio.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox7Domicilio.ForeColor = System.Drawing.SystemColors.WindowText;
            this.textBox7Domicilio.Location = new System.Drawing.Point(415, 314);
            this.textBox7Domicilio.Name = "textBox7Domicilio";
            this.textBox7Domicilio.Size = new System.Drawing.Size(265, 20);
            this.textBox7Domicilio.TabIndex = 15;
            // 
            // textBox8Telefono
            // 
            this.textBox8Telefono.BackColor = System.Drawing.SystemColors.Window;
            this.textBox8Telefono.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox8Telefono.ForeColor = System.Drawing.SystemColors.WindowText;
            this.textBox8Telefono.Location = new System.Drawing.Point(415, 398);
            this.textBox8Telefono.Name = "textBox8Telefono";
            this.textBox8Telefono.Size = new System.Drawing.Size(155, 20);
            this.textBox8Telefono.TabIndex = 16;
            this.textBox8Telefono.TextChanged += new System.EventHandler(this.textBox8Telefono_TextChanged);
           // this.textBox8Telefono.Validating += new System.ComponentModel.CancelEventHandler(this.textBox8Telefono_Validating);
            // 
            // textBox9NamePredios
            // 
            this.textBox9NamePredios.BackColor = System.Drawing.SystemColors.Window;
            this.textBox9NamePredios.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox9NamePredios.ForeColor = System.Drawing.SystemColors.WindowText;
            this.textBox9NamePredios.Location = new System.Drawing.Point(415, 424);
            this.textBox9NamePredios.Name = "textBox9NamePredios";
            this.textBox9NamePredios.Size = new System.Drawing.Size(318, 20);
            this.textBox9NamePredios.TabIndex = 17;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label10.Location = new System.Drawing.Point(225, 117);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(381, 18);
            this.label10.TabIndex = 18;
            this.label10.Text = "-Llene los siguientes campos con información del Socio:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label11.Location = new System.Drawing.Point(227, 74);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(153, 24);
            this.label11.TabIndex = 19;
            this.label11.Text = "NUEVO SOCIO";
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.AutoSize = true;
            this.button1.BackColor = System.Drawing.Color.Gainsboro;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button1.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.Desktop;
            this.button1.Location = new System.Drawing.Point(404, 463);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(228, 69);
            this.button1.TabIndex = 20;
            this.button1.Text = "Guardar Socio\r\nCrear Carpeta Personal\r\n";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Gainsboro;
            this.pictureBox1.Image = global::Proyecto_SGSA.Properties.Resources.guardar0;
            this.pictureBox1.Location = new System.Drawing.Point(415, 480);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(33, 37);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 21;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Gainsboro;
            this.pictureBox2.Image = global::Proyecto_SGSA.Properties.Resources.ingresarpredios;
            this.pictureBox2.Location = new System.Drawing.Point(666, 480);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(33, 37);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 23;
            this.pictureBox2.TabStop = false;
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.AutoSize = true;
            this.button2.BackColor = System.Drawing.Color.Gainsboro;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button2.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.Desktop;
            this.button2.Location = new System.Drawing.Point(647, 463);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(219, 69);
            this.button2.TabIndex = 22;
            this.button2.Text = "Ingresar Predios";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(622, 274);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(82, 13);
            this.label12.TabIndex = 24;
            this.label12.Text = "(Ej. 1999-12-20)";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(502, 294);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(31, 13);
            this.label13.TabIndex = 25;
            this.label13.Text = "Años";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(656, 161);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(24, 13);
            this.linkLabel1.TabIndex = 26;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "text";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(620, 161);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(24, 13);
            this.label14.TabIndex = 27;
            this.label14.Text = "/18";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(605, 161);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(13, 13);
            this.label15.TabIndex = 28;
            this.label15.Text = "0";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label16.Location = new System.Drawing.Point(228, 342);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(70, 20);
            this.label16.TabIndex = 29;
            this.label16.Text = "Colonia:";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label17.Location = new System.Drawing.Point(228, 368);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(158, 20);
            this.label17.TabIndex = 30;
            this.label17.Text = "Ciudad o Poblacion:";
            // 
            // textBoxPoblacion
            // 
            this.textBoxPoblacion.BackColor = System.Drawing.SystemColors.Window;
            this.textBoxPoblacion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxPoblacion.ForeColor = System.Drawing.SystemColors.WindowText;
            this.textBoxPoblacion.Location = new System.Drawing.Point(415, 368);
            this.textBoxPoblacion.Name = "textBoxPoblacion";
            this.textBoxPoblacion.Size = new System.Drawing.Size(155, 20);
            this.textBoxPoblacion.TabIndex = 32;
            // 
            // textBoxColonia
            // 
            this.textBoxColonia.BackColor = System.Drawing.SystemColors.Window;
            this.textBoxColonia.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxColonia.ForeColor = System.Drawing.SystemColors.WindowText;
            this.textBoxColonia.Location = new System.Drawing.Point(415, 342);
            this.textBoxColonia.Name = "textBoxColonia";
            this.textBoxColonia.Size = new System.Drawing.Size(155, 20);
            this.textBoxColonia.TabIndex = 31;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.SteelBlue;
            this.button3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Image = global::Proyecto_SGSA.Properties.Resources.casa;
            this.button3.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button3.Location = new System.Drawing.Point(0, 0);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(200, 67);
            this.button3.TabIndex = 33;
            this.button3.Text = "Regresar";
            this.button3.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            this.button3.MouseLeave += new System.EventHandler(this.button3_MouseLeave);
            this.button3.MouseMove += new System.Windows.Forms.MouseEventHandler(this.button3_MouseMove);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightSkyBlue;
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(0, 64);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 485);
            this.panel1.TabIndex = 34;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.button3);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 86);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(200, 67);
            this.panel3.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.pictureBox3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 86);
            this.panel2.TabIndex = 0;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox3.Image = global::Proyecto_SGSA.Properties.Resources.logocactusrpueba;
            this.pictureBox3.Location = new System.Drawing.Point(0, 0);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(200, 86);
            this.pictureBox3.TabIndex = 0;
            this.pictureBox3.TabStop = false;
            // 
            // AltaSocios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1002, 547);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.textBoxPoblacion);
            this.Controls.Add(this.textBoxColonia);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.textBox9NamePredios);
            this.Controls.Add(this.textBox8Telefono);
            this.Controls.Add(this.textBox7Domicilio);
            this.Controls.Add(this.textBox6Edad);
            this.Controls.Add(this.textBox5FNacimiento);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox4Nombre);
            this.Controls.Add(this.textBox3Materno);
            this.Controls.Add(this.textBox2Paterno);
            this.Controls.Add(this.textBox1CURP);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AltaSocios";
            this.Text = "Alta de Socios";
            this.Load += new System.EventHandler(this.AltaSocios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dB_A7241D_sgsaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBA7241DsgsaDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.BindingSource dBA7241DsgsaDataSetBindingSource;
        private DB_A7241D_sgsaDataSet dB_A7241D_sgsaDataSet;
        private DB_A7241D_sgsaDataSetTableAdapters.SociosTableAdapter sociosTableAdapter;
        private DB_A7241D_sgsaDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox textBox1CURP;
        private System.Windows.Forms.TextBox textBox2Paterno;
        private System.Windows.Forms.TextBox textBox3Materno;
        private System.Windows.Forms.TextBox textBox4Nombre;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBox5FNacimiento;
        private System.Windows.Forms.TextBox textBox6Edad;
        private System.Windows.Forms.TextBox textBox7Domicilio;
        private System.Windows.Forms.TextBox textBox8Telefono;
        private System.Windows.Forms.TextBox textBox9NamePredios;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox textBoxPoblacion;
        private System.Windows.Forms.TextBox textBoxColonia;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Panel panel3;
    }
}