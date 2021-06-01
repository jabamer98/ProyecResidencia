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
            this.dgvpagos = new System.Windows.Forms.DataGridView();
            this.aPaternoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aMaternoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Domicilio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Telefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombrePredios = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.textBoxbueno = new System.Windows.Forms.TextBox();
            this.textBoximporte = new System.Windows.Forms.TextBox();
            this.textBoxnombresoc = new System.Windows.Forms.TextBox();
            this.textBoxcuepre1 = new System.Windows.Forms.TextBox();
            this.textBoxsocioavec = new System.Windows.Forms.TextBox();
            this.textBoxcuepre2 = new System.Windows.Forms.TextBox();
            this.textBoxtel = new System.Windows.Forms.TextBox();
            this.textBoxdomicilio = new System.Windows.Forms.TextBox();
            this.textBoxconcepto = new System.Windows.Forms.TextBox();
            this.textBoxpredio = new System.Windows.Forms.TextBox();
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
            ((System.ComponentModel.ISupportInitialize)(this.dgvpagos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sociosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dB_A7241D_sgsaDataSet)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.paneldata.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("qtquickcontrols", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(186, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Pagos";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("qtquickcontrols", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label2.Location = new System.Drawing.Point(266, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Buscar socio:";
            // 
            // dgvpagos
            // 
            this.dgvpagos.AutoGenerateColumns = false;
            this.dgvpagos.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvpagos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvpagos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvpagos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvpagos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.aPaternoDataGridViewTextBoxColumn,
            this.aMaternoDataGridViewTextBoxColumn,
            this.nombreDataGridViewTextBoxColumn,
            this.Domicilio,
            this.Telefono,
            this.NombrePredios});
            this.dgvpagos.DataSource = this.sociosBindingSource;
            this.dgvpagos.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgvpagos.Location = new System.Drawing.Point(0, 0);
            this.dgvpagos.Name = "dgvpagos";
            this.dgvpagos.Size = new System.Drawing.Size(598, 117);
            this.dgvpagos.TabIndex = 3;
            this.dgvpagos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvpagos_CellContentClick);
            // 
            // aPaternoDataGridViewTextBoxColumn
            // 
            this.aPaternoDataGridViewTextBoxColumn.DataPropertyName = "APaterno";
            this.aPaternoDataGridViewTextBoxColumn.HeaderText = "APaterno";
            this.aPaternoDataGridViewTextBoxColumn.Name = "aPaternoDataGridViewTextBoxColumn";
            // 
            // aMaternoDataGridViewTextBoxColumn
            // 
            this.aMaternoDataGridViewTextBoxColumn.DataPropertyName = "AMaterno";
            this.aMaternoDataGridViewTextBoxColumn.HeaderText = "AMaterno";
            this.aMaternoDataGridViewTextBoxColumn.Name = "aMaternoDataGridViewTextBoxColumn";
            // 
            // nombreDataGridViewTextBoxColumn
            // 
            this.nombreDataGridViewTextBoxColumn.DataPropertyName = "Nombre";
            this.nombreDataGridViewTextBoxColumn.HeaderText = "Nombre";
            this.nombreDataGridViewTextBoxColumn.Name = "nombreDataGridViewTextBoxColumn";
            // 
            // Domicilio
            // 
            this.Domicilio.DataPropertyName = "Domicilio";
            this.Domicilio.HeaderText = "Domicilio";
            this.Domicilio.Name = "Domicilio";
            // 
            // Telefono
            // 
            this.Telefono.DataPropertyName = "Telefono";
            this.Telefono.HeaderText = "Telefono";
            this.Telefono.Name = "Telefono";
            // 
            // NombrePredios
            // 
            this.NombrePredios.DataPropertyName = "NombrePredios";
            this.NombrePredios.HeaderText = "NombrePredios";
            this.NombrePredios.Name = "NombrePredios";
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
            this.btnbuscar.Location = new System.Drawing.Point(599, 82);
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
            this.txtBuscar.Location = new System.Drawing.Point(344, 85);
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
            this.label3.Font = new System.Drawing.Font("qtquickcontrols", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label3.Location = new System.Drawing.Point(182, 244);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 20);
            this.label3.TabIndex = 50;
            this.label3.Text = "Crear recibo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(186, 287);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 13);
            this.label4.TabIndex = 51;
            this.label4.Text = "Bueno por $:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(186, 309);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 13);
            this.label5.TabIndex = 52;
            this.label5.Text = "Importe con letra:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(185, 339);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(92, 13);
            this.label6.TabIndex = 53;
            this.label6.Text = "Nombre del socio:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(185, 366);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(112, 13);
            this.label7.TabIndex = 54;
            this.label7.Text = "No. de cuenta predial:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(185, 392);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(90, 13);
            this.label8.TabIndex = 55;
            this.label8.Text = "Socio avecinado:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(185, 416);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(112, 13);
            this.label9.TabIndex = 56;
            this.label9.Text = "No. de cuenta predial:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(186, 443);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(25, 13);
            this.label10.TabIndex = 57;
            this.label10.Text = "Tel:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(186, 462);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(75, 13);
            this.label11.TabIndex = 58;
            this.label11.Text = "Domicilio:Calle";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(487, 332);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(98, 13);
            this.label12.TabIndex = 59;
            this.label12.Text = "Concepto de pago:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(486, 357);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(101, 13);
            this.label13.TabIndex = 60;
            this.label13.Text = "Predio denominado:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(486, 383);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(78, 13);
            this.label14.TabIndex = 61;
            this.label14.Text = "Tipo de predio:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(487, 407);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(96, 13);
            this.label15.TabIndex = 62;
            this.label15.Text = "Predio ubicado en:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(486, 429);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(146, 13);
            this.label16.TabIndex = 63;
            this.label16.Text = "Pago correspondiente al año:";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(487, 476);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(32, 13);
            this.label17.TabIndex = 64;
            this.label17.Text = "Folio:";
            // 
            // textBoxbueno
            // 
            this.textBoxbueno.Location = new System.Drawing.Point(303, 280);
            this.textBoxbueno.Name = "textBoxbueno";
            this.textBoxbueno.Size = new System.Drawing.Size(161, 20);
            this.textBoxbueno.TabIndex = 65;
            // 
            // textBoximporte
            // 
            this.textBoximporte.Location = new System.Drawing.Point(303, 306);
            this.textBoximporte.Name = "textBoximporte";
            this.textBoximporte.Size = new System.Drawing.Size(161, 20);
            this.textBoximporte.TabIndex = 66;
            // 
            // textBoxnombresoc
            // 
            this.textBoxnombresoc.Cursor = System.Windows.Forms.Cursors.No;
            this.textBoxnombresoc.Location = new System.Drawing.Point(303, 332);
            this.textBoxnombresoc.Name = "textBoxnombresoc";
            this.textBoxnombresoc.ReadOnly = true;
            this.textBoxnombresoc.Size = new System.Drawing.Size(161, 20);
            this.textBoxnombresoc.TabIndex = 67;
            // 
            // textBoxcuepre1
            // 
            this.textBoxcuepre1.Location = new System.Drawing.Point(303, 359);
            this.textBoxcuepre1.Name = "textBoxcuepre1";
            this.textBoxcuepre1.Size = new System.Drawing.Size(161, 20);
            this.textBoxcuepre1.TabIndex = 68;
            // 
            // textBoxsocioavec
            // 
            this.textBoxsocioavec.Location = new System.Drawing.Point(303, 385);
            this.textBoxsocioavec.Name = "textBoxsocioavec";
            this.textBoxsocioavec.Size = new System.Drawing.Size(161, 20);
            this.textBoxsocioavec.TabIndex = 69;
            // 
            // textBoxcuepre2
            // 
            this.textBoxcuepre2.Location = new System.Drawing.Point(303, 411);
            this.textBoxcuepre2.Name = "textBoxcuepre2";
            this.textBoxcuepre2.Size = new System.Drawing.Size(161, 20);
            this.textBoxcuepre2.TabIndex = 70;
            // 
            // textBoxtel
            // 
            this.textBoxtel.Cursor = System.Windows.Forms.Cursors.No;
            this.textBoxtel.Location = new System.Drawing.Point(303, 436);
            this.textBoxtel.Name = "textBoxtel";
            this.textBoxtel.ReadOnly = true;
            this.textBoxtel.Size = new System.Drawing.Size(161, 20);
            this.textBoxtel.TabIndex = 71;
            // 
            // textBoxdomicilio
            // 
            this.textBoxdomicilio.Cursor = System.Windows.Forms.Cursors.No;
            this.textBoxdomicilio.Location = new System.Drawing.Point(303, 459);
            this.textBoxdomicilio.Name = "textBoxdomicilio";
            this.textBoxdomicilio.ReadOnly = true;
            this.textBoxdomicilio.Size = new System.Drawing.Size(161, 20);
            this.textBoxdomicilio.TabIndex = 72;
            // 
            // textBoxconcepto
            // 
            this.textBoxconcepto.Location = new System.Drawing.Point(604, 325);
            this.textBoxconcepto.Name = "textBoxconcepto";
            this.textBoxconcepto.Size = new System.Drawing.Size(161, 20);
            this.textBoxconcepto.TabIndex = 73;
            // 
            // textBoxpredio
            // 
            this.textBoxpredio.Cursor = System.Windows.Forms.Cursors.No;
            this.textBoxpredio.Location = new System.Drawing.Point(604, 350);
            this.textBoxpredio.Name = "textBoxpredio";
            this.textBoxpredio.ReadOnly = true;
            this.textBoxpredio.Size = new System.Drawing.Size(161, 20);
            this.textBoxpredio.TabIndex = 74;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "SOLAR",
            "TERRENO DE SIEMBRA TEMPORAL",
            "TERRENO DE SIEMBRE RIEGO"});
            this.comboBox1.Location = new System.Drawing.Point(604, 376);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(161, 21);
            this.comboBox1.TabIndex = 75;
            // 
            // textBoxubicpred
            // 
            this.textBoxubicpred.Location = new System.Drawing.Point(604, 400);
            this.textBoxubicpred.Name = "textBoxubicpred";
            this.textBoxubicpred.Size = new System.Drawing.Size(161, 20);
            this.textBoxubicpred.TabIndex = 76;
            // 
            // textBoxpagoanual
            // 
            this.textBoxpagoanual.Location = new System.Drawing.Point(638, 426);
            this.textBoxpagoanual.Name = "textBoxpagoanual";
            this.textBoxpagoanual.Size = new System.Drawing.Size(127, 20);
            this.textBoxpagoanual.TabIndex = 77;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(671, 471);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 23);
            this.button1.TabIndex = 78;
            this.button1.Text = "Imprimir recibo";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // textBoxPoblacion
            // 
            this.textBoxPoblacion.Cursor = System.Windows.Forms.Cursors.No;
            this.textBoxPoblacion.Location = new System.Drawing.Point(604, 299);
            this.textBoxPoblacion.Name = "textBoxPoblacion";
            this.textBoxPoblacion.ReadOnly = true;
            this.textBoxPoblacion.Size = new System.Drawing.Size(161, 20);
            this.textBoxPoblacion.TabIndex = 82;
            // 
            // textBoxColonia
            // 
            this.textBoxColonia.Cursor = System.Windows.Forms.Cursors.No;
            this.textBoxColonia.Location = new System.Drawing.Point(604, 276);
            this.textBoxColonia.Name = "textBoxColonia";
            this.textBoxColonia.ReadOnly = true;
            this.textBoxColonia.Size = new System.Drawing.Size(161, 20);
            this.textBoxColonia.TabIndex = 81;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(487, 306);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(99, 13);
            this.label18.TabIndex = 80;
            this.label18.Text = "Ciudad o Poblacion";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(487, 283);
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
            this.panel1.Size = new System.Drawing.Size(180, 542);
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
            this.paneldata.Controls.Add(this.dgvpagos);
            this.paneldata.Location = new System.Drawing.Point(186, 111);
            this.paneldata.Name = "paneldata";
            this.paneldata.Size = new System.Drawing.Size(598, 120);
            this.paneldata.TabIndex = 85;
            // 
            // Pagos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 534);
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
            this.Controls.Add(this.textBoxpredio);
            this.Controls.Add(this.textBoxconcepto);
            this.Controls.Add(this.textBoxdomicilio);
            this.Controls.Add(this.textBoxtel);
            this.Controls.Add(this.textBoxcuepre2);
            this.Controls.Add(this.textBoxsocioavec);
            this.Controls.Add(this.textBoxcuepre1);
            this.Controls.Add(this.textBoxnombresoc);
            this.Controls.Add(this.textBoximporte);
            this.Controls.Add(this.textBoxbueno);
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
            ((System.ComponentModel.ISupportInitialize)(this.dgvpagos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sociosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dB_A7241D_sgsaDataSet)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.paneldata.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvpagos;
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
        private System.Windows.Forms.TextBox textBoxbueno;
        private System.Windows.Forms.TextBox textBoximporte;
        private System.Windows.Forms.TextBox textBoxnombresoc;
        private System.Windows.Forms.TextBox textBoxcuepre1;
        private System.Windows.Forms.TextBox textBoxsocioavec;
        private System.Windows.Forms.TextBox textBoxcuepre2;
        private System.Windows.Forms.TextBox textBoxtel;
        private System.Windows.Forms.TextBox textBoxdomicilio;
        private System.Windows.Forms.TextBox textBoxconcepto;
        private System.Windows.Forms.TextBox textBoxpredio;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox textBoxubicpred;
        private System.Windows.Forms.TextBox textBoxpagoanual;
        private System.Windows.Forms.DataGridViewTextBoxColumn aPaternoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aMaternoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Domicilio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Telefono;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombrePredios;
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
    }
}