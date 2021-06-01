namespace Proyecto_SGSA
{
    partial class Pagos
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.sociosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dB_A7241D_sgsaDataSet = new Proyecto_SGSA.DB_A7241D_sgsaDataSet();
            this.sociosTableAdapter = new Proyecto_SGSA.DB_A7241D_sgsaDataSetTableAdapters.SociosTableAdapter();
            this.btnbuscar = new System.Windows.Forms.Button();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.textBoxCantidadNumero = new System.Windows.Forms.TextBox();
            this.textBoxCantidadLetra = new System.Windows.Forms.TextBox();
            this.textBoxNombreS = new System.Windows.Forms.TextBox();
            this.textBoxcuepre1 = new System.Windows.Forms.TextBox();
            this.textBoxsocioavec = new System.Windows.Forms.TextBox();
            this.textBoxcuepre2 = new System.Windows.Forms.TextBox();
            this.textBoxTelefono = new System.Windows.Forms.TextBox();
            this.textBoxDomicilio = new System.Windows.Forms.TextBox();
            this.textBoxconcepto = new System.Windows.Forms.TextBox();
            this.textBoxNamePredio = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.textBoxubicpred = new System.Windows.Forms.TextBox();
            this.textBoxpagoanual = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.textBoxPoblacion = new System.Windows.Forms.TextBox();
            this.textBoxColonia = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.materialFlatButton1 = new MaterialSkin.Controls.MaterialFlatButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.paneldata = new System.Windows.Forms.Panel();
            this.dgvPagos = new System.Windows.Forms.DataGridView();
            this.buttonConvLetra = new System.Windows.Forms.Button();
            this.textBoxApellidoPS = new System.Windows.Forms.TextBox();
            this.textBoxApellidoMS = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.sociosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dB_A7241D_sgsaDataSet)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.paneldata.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPagos)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(186, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Pagos";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label2.Location = new System.Drawing.Point(266, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Buscar socio:";
            // 
            // sociosBindingSource
            // 
            this.sociosBindingSource.DataMember = "Socios";
            this.sociosBindingSource.DataSource = this.dB_A7241D_sgsaDataSet;
            // 
            // dB_A7241D_sgsaDataSet
            // 
            this.dB_A7241D_sgsaDataSet.DataSetName = "DB_A7241D_sgsaDataSet";
            this.dB_A7241D_sgsaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sociosTableAdapter
            // 
            this.sociosTableAdapter.ClearBeforeFill = true;
            // 
            // btnbuscar
            // 
            this.btnbuscar.Location = new System.Drawing.Point(654, 85);
            this.btnbuscar.Name = "btnbuscar";
            this.btnbuscar.Size = new System.Drawing.Size(75, 23);
            this.btnbuscar.TabIndex = 4;
            this.btnbuscar.Text = "Buscar";
            this.btnbuscar.UseVisualStyleBackColor = true;
            this.btnbuscar.Click += new System.EventHandler(this.btnbuscar_Click);
            // 
            // txtBuscar
            // 
            this.txtBuscar.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtBuscar.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtBuscar.BackColor = System.Drawing.Color.White;
            this.txtBuscar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBuscar.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtBuscar.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtBuscar.Location = new System.Drawing.Point(372, 88);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(229, 20);
            this.txtBuscar.TabIndex = 49;
            this.txtBuscar.Text = "Por CURP";
            this.txtBuscar.Enter += new System.EventHandler(this.txtBuscar_Enter);
            this.txtBuscar.Leave += new System.EventHandler(this.txtBuscar_Leave);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label3.Location = new System.Drawing.Point(198, 260);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 24);
            this.label3.TabIndex = 50;
            this.label3.Text = "Crear recibo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(200, 300);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 13);
            this.label4.TabIndex = 51;
            this.label4.Text = "Bueno por $:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(200, 322);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 13);
            this.label5.TabIndex = 52;
            this.label5.Text = "Importe con letra:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(199, 352);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(92, 13);
            this.label6.TabIndex = 53;
            this.label6.Text = "Nombre del socio:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(199, 379);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(112, 13);
            this.label7.TabIndex = 54;
            this.label7.Text = "No. de cuenta predial:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(199, 405);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(90, 13);
            this.label8.TabIndex = 55;
            this.label8.Text = "Socio avecinado:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(199, 429);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(112, 13);
            this.label9.TabIndex = 56;
            this.label9.Text = "No. de cuenta predial:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(200, 456);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(25, 13);
            this.label10.TabIndex = 57;
            this.label10.Text = "Tel:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(200, 475);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(75, 13);
            this.label11.TabIndex = 58;
            this.label11.Text = "Domicilio:Calle";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(200, 545);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(98, 13);
            this.label12.TabIndex = 59;
            this.label12.Text = "Concepto de pago:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(199, 570);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(101, 13);
            this.label13.TabIndex = 60;
            this.label13.Text = "Predio denominado:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(199, 596);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(78, 13);
            this.label14.TabIndex = 61;
            this.label14.Text = "Tipo de predio:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(200, 620);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(96, 13);
            this.label15.TabIndex = 62;
            this.label15.Text = "Predio ubicado en:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(199, 642);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(146, 13);
            this.label16.TabIndex = 63;
            this.label16.Text = "Pago correspondiente al año:";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(765, 626);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(32, 13);
            this.label17.TabIndex = 64;
            this.label17.Text = "Folio:";
            // 
            // textBoxCantidadNumero
            // 
            this.textBoxCantidadNumero.Location = new System.Drawing.Point(317, 293);
            this.textBoxCantidadNumero.Name = "textBoxCantidadNumero";
            this.textBoxCantidadNumero.Size = new System.Drawing.Size(161, 20);
            this.textBoxCantidadNumero.TabIndex = 65;
            // 
            // textBoxCantidadLetra
            // 
            this.textBoxCantidadLetra.Location = new System.Drawing.Point(317, 319);
            this.textBoxCantidadLetra.Name = "textBoxCantidadLetra";
            this.textBoxCantidadLetra.Size = new System.Drawing.Size(250, 20);
            this.textBoxCantidadLetra.TabIndex = 66;
            // 
            // textBoxNombreS
            // 
            this.textBoxNombreS.Cursor = System.Windows.Forms.Cursors.No;
            this.textBoxNombreS.Location = new System.Drawing.Point(317, 345);
            this.textBoxNombreS.Name = "textBoxNombreS";
            this.textBoxNombreS.ReadOnly = true;
            this.textBoxNombreS.Size = new System.Drawing.Size(82, 20);
            this.textBoxNombreS.TabIndex = 67;
            // 
            // textBoxcuepre1
            // 
            this.textBoxcuepre1.Location = new System.Drawing.Point(317, 372);
            this.textBoxcuepre1.Name = "textBoxcuepre1";
            this.textBoxcuepre1.Size = new System.Drawing.Size(161, 20);
            this.textBoxcuepre1.TabIndex = 68;
            // 
            // textBoxsocioavec
            // 
            this.textBoxsocioavec.Location = new System.Drawing.Point(317, 398);
            this.textBoxsocioavec.Name = "textBoxsocioavec";
            this.textBoxsocioavec.Size = new System.Drawing.Size(161, 20);
            this.textBoxsocioavec.TabIndex = 69;
            // 
            // textBoxcuepre2
            // 
            this.textBoxcuepre2.Location = new System.Drawing.Point(319, 424);
            this.textBoxcuepre2.Name = "textBoxcuepre2";
            this.textBoxcuepre2.Size = new System.Drawing.Size(159, 20);
            this.textBoxcuepre2.TabIndex = 70;
            // 
            // textBoxTelefono
            // 
            this.textBoxTelefono.Cursor = System.Windows.Forms.Cursors.No;
            this.textBoxTelefono.Location = new System.Drawing.Point(317, 449);
            this.textBoxTelefono.Name = "textBoxTelefono";
            this.textBoxTelefono.ReadOnly = true;
            this.textBoxTelefono.Size = new System.Drawing.Size(161, 20);
            this.textBoxTelefono.TabIndex = 71;
            // 
            // textBoxDomicilio
            // 
            this.textBoxDomicilio.Cursor = System.Windows.Forms.Cursors.No;
            this.textBoxDomicilio.Location = new System.Drawing.Point(317, 472);
            this.textBoxDomicilio.Name = "textBoxDomicilio";
            this.textBoxDomicilio.ReadOnly = true;
            this.textBoxDomicilio.Size = new System.Drawing.Size(250, 20);
            this.textBoxDomicilio.TabIndex = 72;
            // 
            // textBoxconcepto
            // 
            this.textBoxconcepto.Location = new System.Drawing.Point(317, 538);
            this.textBoxconcepto.Name = "textBoxconcepto";
            this.textBoxconcepto.Size = new System.Drawing.Size(250, 20);
            this.textBoxconcepto.TabIndex = 73;
            // 
            // textBoxNamePredio
            // 
            this.textBoxNamePredio.Cursor = System.Windows.Forms.Cursors.No;
            this.textBoxNamePredio.Location = new System.Drawing.Point(317, 563);
            this.textBoxNamePredio.Name = "textBoxNamePredio";
            this.textBoxNamePredio.ReadOnly = true;
            this.textBoxNamePredio.Size = new System.Drawing.Size(250, 20);
            this.textBoxNamePredio.TabIndex = 74;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "SOLAR",
            "TERRENO DE SIEMBRA TEMPORAL",
            "TERRENO DE SIEMBRE RIEGO"});
            this.comboBox1.Location = new System.Drawing.Point(317, 589);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(250, 21);
            this.comboBox1.TabIndex = 75;
            // 
            // textBoxubicpred
            // 
            this.textBoxubicpred.Location = new System.Drawing.Point(317, 613);
            this.textBoxubicpred.Name = "textBoxubicpred";
            this.textBoxubicpred.Size = new System.Drawing.Size(250, 20);
            this.textBoxubicpred.TabIndex = 76;
            // 
            // textBoxpagoanual
            // 
            this.textBoxpagoanual.Location = new System.Drawing.Point(351, 639);
            this.textBoxpagoanual.Name = "textBoxpagoanual";
            this.textBoxpagoanual.Size = new System.Drawing.Size(216, 20);
            this.textBoxpagoanual.TabIndex = 77;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(703, 645);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 23);
            this.button1.TabIndex = 78;
            this.button1.Text = "Imprimir recibo";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // textBoxPoblacion
            // 
            this.textBoxPoblacion.Cursor = System.Windows.Forms.Cursors.No;
            this.textBoxPoblacion.Location = new System.Drawing.Point(317, 512);
            this.textBoxPoblacion.Name = "textBoxPoblacion";
            this.textBoxPoblacion.ReadOnly = true;
            this.textBoxPoblacion.Size = new System.Drawing.Size(250, 20);
            this.textBoxPoblacion.TabIndex = 82;
            // 
            // textBoxColonia
            // 
            this.textBoxColonia.Cursor = System.Windows.Forms.Cursors.No;
            this.textBoxColonia.Location = new System.Drawing.Point(317, 489);
            this.textBoxColonia.Name = "textBoxColonia";
            this.textBoxColonia.ReadOnly = true;
            this.textBoxColonia.Size = new System.Drawing.Size(161, 20);
            this.textBoxColonia.TabIndex = 81;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(200, 519);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(99, 13);
            this.label18.TabIndex = 80;
            this.label18.Text = "Ciudad o Poblacion";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(200, 496);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(45, 13);
            this.label19.TabIndex = 79;
            this.label19.Text = "Colonia:";
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.panel1.BackColor = System.Drawing.Color.LightSkyBlue;
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(0, 64);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(180, 615);
            this.panel1.TabIndex = 84;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.button2);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 136);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(180, 100);
            this.panel3.TabIndex = 2;
            // 
            // button2
            // 
            this.button2.Image = global::Proyecto_SGSA.Properties.Resources.casa;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button2.Location = new System.Drawing.Point(50, 9);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(101, 75);
            this.button2.TabIndex = 83;
            this.button2.Text = "Regresar";
            this.button2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.materialFlatButton1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 83);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(180, 53);
            this.panel2.TabIndex = 1;
            // 
            // materialFlatButton1
            // 
            this.materialFlatButton1.AutoSize = true;
            this.materialFlatButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialFlatButton1.BackgroundImage = global::Proyecto_SGSA.Properties.Resources.agendach;
            this.materialFlatButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.materialFlatButton1.Depth = 0;
            this.materialFlatButton1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.materialFlatButton1.Image = global::Proyecto_SGSA.Properties.Resources.agendach;
            this.materialFlatButton1.Location = new System.Drawing.Point(0, 0);
            this.materialFlatButton1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialFlatButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialFlatButton1.Name = "materialFlatButton1";
            this.materialFlatButton1.Primary = false;
            this.materialFlatButton1.Size = new System.Drawing.Size(180, 53);
            this.materialFlatButton1.TabIndex = 0;
            this.materialFlatButton1.Text = "regresar «";
            this.materialFlatButton1.UseVisualStyleBackColor = true;
            this.materialFlatButton1.Click += new System.EventHandler(this.materialFlatButton1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.Image = global::Proyecto_SGSA.Properties.Resources.logocactusrpueba;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(180, 83);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // paneldata
            // 
            this.paneldata.AutoScroll = true;
            this.paneldata.Controls.Add(this.dgvPagos);
            this.paneldata.Location = new System.Drawing.Point(186, 111);
            this.paneldata.Name = "paneldata";
            this.paneldata.Size = new System.Drawing.Size(876, 128);
            this.paneldata.TabIndex = 85;
            // 
            // dgvPagos
            // 
            this.dgvPagos.AllowUserToAddRows = false;
            this.dgvPagos.AllowUserToDeleteRows = false;
            this.dgvPagos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPagos.Location = new System.Drawing.Point(1, 0);
            this.dgvPagos.Name = "dgvPagos";
            this.dgvPagos.ReadOnly = true;
            this.dgvPagos.Size = new System.Drawing.Size(871, 123);
            this.dgvPagos.TabIndex = 51;
            this.dgvPagos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPagos_CellContentClick_1);
            // 
            // buttonConvLetra
            // 
            this.buttonConvLetra.Location = new System.Drawing.Point(485, 293);
            this.buttonConvLetra.Name = "buttonConvLetra";
            this.buttonConvLetra.Size = new System.Drawing.Size(116, 23);
            this.buttonConvLetra.TabIndex = 86;
            this.buttonConvLetra.Text = "Convertir a letra";
            this.buttonConvLetra.UseVisualStyleBackColor = true;
            this.buttonConvLetra.Click += new System.EventHandler(this.buttonConvLetra_Click);
            // 
            // textBoxApellidoPS
            // 
            this.textBoxApellidoPS.Cursor = System.Windows.Forms.Cursors.No;
            this.textBoxApellidoPS.Location = new System.Drawing.Point(405, 345);
            this.textBoxApellidoPS.Name = "textBoxApellidoPS";
            this.textBoxApellidoPS.ReadOnly = true;
            this.textBoxApellidoPS.Size = new System.Drawing.Size(82, 20);
            this.textBoxApellidoPS.TabIndex = 87;
            // 
            // textBoxApellidoMS
            // 
            this.textBoxApellidoMS.Cursor = System.Windows.Forms.Cursors.No;
            this.textBoxApellidoMS.Location = new System.Drawing.Point(493, 345);
            this.textBoxApellidoMS.Name = "textBoxApellidoMS";
            this.textBoxApellidoMS.ReadOnly = true;
            this.textBoxApellidoMS.Size = new System.Drawing.Size(82, 20);
            this.textBoxApellidoMS.TabIndex = 88;
            // 
            // Pagos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1074, 680);
            this.Controls.Add(this.textBoxApellidoMS);
            this.Controls.Add(this.textBoxApellidoPS);
            this.Controls.Add(this.buttonConvLetra);
            this.Controls.Add(this.paneldata);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.textBoxPoblacion);
            this.Controls.Add(this.textBoxColonia);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBoxpagoanual);
            this.Controls.Add(this.textBoxubicpred);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.textBoxNamePredio);
            this.Controls.Add(this.textBoxconcepto);
            this.Controls.Add(this.textBoxDomicilio);
            this.Controls.Add(this.textBoxTelefono);
            this.Controls.Add(this.textBoxcuepre2);
            this.Controls.Add(this.textBoxsocioavec);
            this.Controls.Add(this.textBoxcuepre1);
            this.Controls.Add(this.textBoxNombreS);
            this.Controls.Add(this.textBoxCantidadLetra);
            this.Controls.Add(this.textBoxCantidadNumero);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.btnbuscar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Pagos";
            this.Sizable = false;
            this.Text = "Pagos";
            this.Load += new System.EventHandler(this.Pagos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.sociosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dB_A7241D_sgsaDataSet)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.paneldata.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPagos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private DB_A7241D_sgsaDataSet dB_A7241D_sgsaDataSet;
        private System.Windows.Forms.BindingSource sociosBindingSource;
        private DB_A7241D_sgsaDataSetTableAdapters.SociosTableAdapter sociosTableAdapter;
        private System.Windows.Forms.Button btnbuscar;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox textBoxCantidadNumero;
        private System.Windows.Forms.TextBox textBoxCantidadLetra;
        private System.Windows.Forms.TextBox textBoxNombreS;
        private System.Windows.Forms.TextBox textBoxcuepre1;
        private System.Windows.Forms.TextBox textBoxsocioavec;
        private System.Windows.Forms.TextBox textBoxcuepre2;
        private System.Windows.Forms.TextBox textBoxTelefono;
        private System.Windows.Forms.TextBox textBoxDomicilio;
        private System.Windows.Forms.TextBox textBoxconcepto;
        private System.Windows.Forms.TextBox textBoxNamePredio;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox textBoxubicpred;
        private System.Windows.Forms.TextBox textBoxpagoanual;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBoxPoblacion;
        private System.Windows.Forms.TextBox textBoxColonia;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private MaterialSkin.Controls.MaterialFlatButton materialFlatButton1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel paneldata;
        private System.Windows.Forms.DataGridView dgvPagos;
        private System.Windows.Forms.Button buttonConvLetra;
        private System.Windows.Forms.TextBox textBoxApellidoPS;
        private System.Windows.Forms.TextBox textBoxApellidoMS;
    }
}