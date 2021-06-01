namespace Proyecto_SGSA
{
    partial class BuscarSocioParaModificar
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
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.dBA7241DsgsaDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dB_A7241D_sgsaDataSet = new Proyecto_SGSA.DB_A7241D_sgsaDataSet();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.sociosTableAdapter1 = new Proyecto_SGSA.DB_A7241D_sgsaDataSetTableAdapters.SociosTableAdapter();
            this.dgvRegistros = new System.Windows.Forms.DataGridView();
            this.btnModificar = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.textBox9NamePredios = new System.Windows.Forms.TextBox();
            this.textBox8Telefono = new System.Windows.Forms.TextBox();
            this.textBox7Domicilio = new System.Windows.Forms.TextBox();
            this.textBox6Edad = new System.Windows.Forms.TextBox();
            this.textBox5FNacimiento = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox4Nombre = new System.Windows.Forms.TextBox();
            this.textBox3Materno = new System.Windows.Forms.TextBox();
            this.textBox2Paterno = new System.Windows.Forms.TextBox();
            this.textBox1CURP = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnExaminar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.textBoxPoblacion = new System.Windows.Forms.TextBox();
            this.textBoxColonia = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dBA7241DsgsaDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dB_A7241D_sgsaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRegistros)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label11.Location = new System.Drawing.Point(223, 71);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(192, 24);
            this.label11.TabIndex = 45;
            this.label11.Text = "MODIFICAR SOCIO";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label10.Location = new System.Drawing.Point(224, 114);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(319, 18);
            this.label10.TabIndex = 46;
            this.label10.Text = "Ingrese la CURP del socio que desee modificar";
            // 
            // dBA7241DsgsaDataSetBindingSource
            // 
            this.dBA7241DsgsaDataSetBindingSource.DataSource = this.dB_A7241D_sgsaDataSet;
            this.dBA7241DsgsaDataSetBindingSource.Position = 0;
            // 
            // dB_A7241D_sgsaDataSet
            // 
            this.dB_A7241D_sgsaDataSet.DataSetName = "DB_A7241D_sgsaDataSet";
            this.dB_A7241D_sgsaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txtBuscar
            // 
            this.txtBuscar.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtBuscar.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtBuscar.Location = new System.Drawing.Point(549, 113);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(207, 20);
            this.txtBuscar.TabIndex = 48;
            this.txtBuscar.TextChanged += new System.EventHandler(this.txtBuscar_TextChanged);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(773, 110);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 49;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // sociosTableAdapter1
            // 
            this.sociosTableAdapter1.ClearBeforeFill = true;
            // 
            // dgvRegistros
            // 
            this.dgvRegistros.AllowUserToAddRows = false;
            this.dgvRegistros.AllowUserToDeleteRows = false;
            this.dgvRegistros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRegistros.Location = new System.Drawing.Point(227, 142);
            this.dgvRegistros.Name = "dgvRegistros";
            this.dgvRegistros.ReadOnly = true;
            this.dgvRegistros.Size = new System.Drawing.Size(798, 85);
            this.dgvRegistros.TabIndex = 50;
            this.dgvRegistros.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvRegistro_CellContentClick);
           // this.dgvRegistros.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvRegistros_CellContentClick);
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(854, 110);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(75, 23);
            this.btnModificar.TabIndex = 51;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.button1_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(560, 359);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(70, 13);
            this.label12.TabIndex = 71;
            this.label12.Text = "Año-Mes-Día";
            // 
            // textBox9NamePredios
            // 
            this.textBox9NamePredios.BackColor = System.Drawing.SystemColors.Window;
            this.textBox9NamePredios.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox9NamePredios.ForeColor = System.Drawing.SystemColors.WindowText;
            this.textBox9NamePredios.Location = new System.Drawing.Point(399, 517);
            this.textBox9NamePredios.Name = "textBox9NamePredios";
            this.textBox9NamePredios.Size = new System.Drawing.Size(265, 20);
            this.textBox9NamePredios.TabIndex = 70;
            // 
            // textBox8Telefono
            // 
            this.textBox8Telefono.BackColor = System.Drawing.SystemColors.Window;
            this.textBox8Telefono.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox8Telefono.ForeColor = System.Drawing.SystemColors.WindowText;
            this.textBox8Telefono.Location = new System.Drawing.Point(399, 491);
            this.textBox8Telefono.Name = "textBox8Telefono";
            this.textBox8Telefono.Size = new System.Drawing.Size(155, 20);
            this.textBox8Telefono.TabIndex = 69;
            // 
            // textBox7Domicilio
            // 
            this.textBox7Domicilio.BackColor = System.Drawing.SystemColors.Window;
            this.textBox7Domicilio.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox7Domicilio.ForeColor = System.Drawing.SystemColors.WindowText;
            this.textBox7Domicilio.Location = new System.Drawing.Point(399, 405);
            this.textBox7Domicilio.Name = "textBox7Domicilio";
            this.textBox7Domicilio.Size = new System.Drawing.Size(265, 20);
            this.textBox7Domicilio.TabIndex = 68;
            // 
            // textBox6Edad
            // 
            this.textBox6Edad.BackColor = System.Drawing.SystemColors.Window;
            this.textBox6Edad.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox6Edad.ForeColor = System.Drawing.SystemColors.WindowText;
            this.textBox6Edad.Location = new System.Drawing.Point(400, 379);
            this.textBox6Edad.Name = "textBox6Edad";
            this.textBox6Edad.Size = new System.Drawing.Size(79, 20);
            this.textBox6Edad.TabIndex = 67;
            // 
            // textBox5FNacimiento
            // 
            this.textBox5FNacimiento.BackColor = System.Drawing.SystemColors.Window;
            this.textBox5FNacimiento.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox5FNacimiento.ForeColor = System.Drawing.SystemColors.WindowText;
            this.textBox5FNacimiento.Location = new System.Drawing.Point(399, 354);
            this.textBox5FNacimiento.Name = "textBox5FNacimiento";
            this.textBox5FNacimiento.Size = new System.Drawing.Size(155, 20);
            this.textBox5FNacimiento.TabIndex = 66;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("qtquickcontrols", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label9.Location = new System.Drawing.Point(224, 522);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(155, 18);
            this.label9.TabIndex = 65;
            this.label9.Text = "Nombre de los predios:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("qtquickcontrols", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label8.Location = new System.Drawing.Point(224, 496);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(68, 18);
            this.label8.TabIndex = 64;
            this.label8.Text = "Teléfono:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("qtquickcontrols", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label7.Location = new System.Drawing.Point(224, 410);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 18);
            this.label7.TabIndex = 63;
            this.label7.Text = "Domicilio:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("qtquickcontrols", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label6.Location = new System.Drawing.Point(224, 384);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 18);
            this.label6.TabIndex = 62;
            this.label6.Text = "Edad:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("qtquickcontrols", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label5.Location = new System.Drawing.Point(224, 359);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(143, 18);
            this.label5.TabIndex = 61;
            this.label5.Text = "Fecha de nacimiento:";
            // 
            // textBox4Nombre
            // 
            this.textBox4Nombre.BackColor = System.Drawing.SystemColors.Window;
            this.textBox4Nombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox4Nombre.ForeColor = System.Drawing.SystemColors.WindowText;
            this.textBox4Nombre.Location = new System.Drawing.Point(399, 328);
            this.textBox4Nombre.Name = "textBox4Nombre";
            this.textBox4Nombre.Size = new System.Drawing.Size(178, 20);
            this.textBox4Nombre.TabIndex = 60;
            // 
            // textBox3Materno
            // 
            this.textBox3Materno.BackColor = System.Drawing.SystemColors.Window;
            this.textBox3Materno.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox3Materno.ForeColor = System.Drawing.SystemColors.WindowText;
            this.textBox3Materno.Location = new System.Drawing.Point(399, 302);
            this.textBox3Materno.Name = "textBox3Materno";
            this.textBox3Materno.Size = new System.Drawing.Size(155, 20);
            this.textBox3Materno.TabIndex = 59;
            // 
            // textBox2Paterno
            // 
            this.textBox2Paterno.BackColor = System.Drawing.SystemColors.Window;
            this.textBox2Paterno.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox2Paterno.ForeColor = System.Drawing.SystemColors.WindowText;
            this.textBox2Paterno.Location = new System.Drawing.Point(399, 276);
            this.textBox2Paterno.Name = "textBox2Paterno";
            this.textBox2Paterno.Size = new System.Drawing.Size(155, 20);
            this.textBox2Paterno.TabIndex = 58;
            // 
            // textBox1CURP
            // 
            this.textBox1CURP.BackColor = System.Drawing.SystemColors.Window;
            this.textBox1CURP.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1CURP.ForeColor = System.Drawing.SystemColors.WindowText;
            this.textBox1CURP.Location = new System.Drawing.Point(399, 250);
            this.textBox1CURP.Name = "textBox1CURP";
            this.textBox1CURP.Size = new System.Drawing.Size(265, 20);
            this.textBox1CURP.TabIndex = 57;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("qtquickcontrols", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label4.Location = new System.Drawing.Point(224, 333);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 18);
            this.label4.TabIndex = 56;
            this.label4.Text = "Nombre:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("qtquickcontrols", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label3.Location = new System.Drawing.Point(224, 307);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 18);
            this.label3.TabIndex = 55;
            this.label3.Text = "Apellido Materno:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("qtquickcontrols", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label2.Location = new System.Drawing.Point(224, 281);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 18);
            this.label2.TabIndex = 54;
            this.label2.Text = "Apellido Paterno:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("qtquickcontrols", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label1.Location = new System.Drawing.Point(224, 255);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 18);
            this.label1.TabIndex = 53;
            this.label1.Text = "CURP:";
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(935, 110);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 23);
            this.btnEliminar.TabIndex = 72;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnExaminar
            // 
            this.btnExaminar.Location = new System.Drawing.Point(773, 336);
            this.btnExaminar.Name = "btnExaminar";
            this.btnExaminar.Size = new System.Drawing.Size(197, 67);
            this.btnExaminar.TabIndex = 73;
            this.btnExaminar.Text = "Examinar Carpeta deDocumentos Personales \r\n";
            this.btnExaminar.UseVisualStyleBackColor = true;
            this.btnExaminar.Click += new System.EventHandler(this.btnExaminar_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(773, 414);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(197, 40);
            this.button1.TabIndex = 74;
            this.button1.Text = "Agregar y/o Modificar Documentos Personales";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_3);
            // 
            // textBoxPoblacion
            // 
            this.textBoxPoblacion.BackColor = System.Drawing.SystemColors.Window;
            this.textBoxPoblacion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxPoblacion.ForeColor = System.Drawing.SystemColors.WindowText;
            this.textBoxPoblacion.Location = new System.Drawing.Point(399, 460);
            this.textBoxPoblacion.Name = "textBoxPoblacion";
            this.textBoxPoblacion.Size = new System.Drawing.Size(155, 20);
            this.textBoxPoblacion.TabIndex = 78;
            this.textBoxPoblacion.TextChanged += new System.EventHandler(this.textBoxPoblacion_TextChanged);
            // 
            // textBoxColonia
            // 
            this.textBoxColonia.BackColor = System.Drawing.SystemColors.Window;
            this.textBoxColonia.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxColonia.ForeColor = System.Drawing.SystemColors.WindowText;
            this.textBoxColonia.Location = new System.Drawing.Point(399, 434);
            this.textBoxColonia.Name = "textBoxColonia";
            this.textBoxColonia.Size = new System.Drawing.Size(155, 20);
            this.textBoxColonia.TabIndex = 77;
            this.textBoxColonia.TextChanged += new System.EventHandler(this.textBoxColonia_TextChanged);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("qtquickcontrols", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label17.Location = new System.Drawing.Point(224, 469);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(134, 18);
            this.label17.TabIndex = 76;
            this.label17.Text = "Ciudad o Poblacion:";
            this.label17.Click += new System.EventHandler(this.label17_Click);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("qtquickcontrols", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label16.Location = new System.Drawing.Point(224, 441);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(59, 18);
            this.label16.TabIndex = 75;
            this.label16.Text = "Colonia:";
            this.label16.Click += new System.EventHandler(this.label16_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.SteelBlue;
            this.button2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Image = global::Proyecto_SGSA.Properties.Resources.casa;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button2.Location = new System.Drawing.Point(0, 0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(200, 67);
            this.button2.TabIndex = 79;
            this.button2.Text = "Regresar";
            this.button2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            this.button2.MouseLeave += new System.EventHandler(this.button2_MouseLeave);
            this.button2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.button2_MouseMove);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightSkyBlue;
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(0, 63);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 495);
            this.panel1.TabIndex = 80;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 84);
            this.panel2.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.Image = global::Proyecto_SGSA.Properties.Resources.logocactusrpueba;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(200, 84);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.button2);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 84);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(200, 67);
            this.panel3.TabIndex = 1;
            // 
            // BuscarSocioParaModificar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1052, 558);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.textBoxPoblacion);
            this.Controls.Add(this.textBoxColonia);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnExaminar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.label12);
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
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.dgvRegistros);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label11);
            this.Name = "BuscarSocioParaModificar";
            this.Text = "Modificar y Eliminar Socios";
            this.Load += new System.EventHandler(this.BuscarSocioParaModificar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dBA7241DsgsaDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dB_A7241D_sgsaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRegistros)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.BindingSource dBA7241DsgsaDataSetBindingSource;
        private DB_A7241D_sgsaDataSet dB_A7241D_sgsaDataSet;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Button btnBuscar;
        private DB_A7241D_sgsaDataSetTableAdapters.SociosTableAdapter sociosTableAdapter1;
        private System.Windows.Forms.DataGridView dgvRegistros;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox textBox9NamePredios;
        private System.Windows.Forms.TextBox textBox8Telefono;
        private System.Windows.Forms.TextBox textBox7Domicilio;
        private System.Windows.Forms.TextBox textBox6Edad;
        private System.Windows.Forms.TextBox textBox5FNacimiento;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox4Nombre;
        private System.Windows.Forms.TextBox textBox3Materno;
        private System.Windows.Forms.TextBox textBox2Paterno;
        private System.Windows.Forms.TextBox textBox1CURP;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnExaminar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBoxPoblacion;
        private System.Windows.Forms.TextBox textBoxColonia;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel3;
    }
}