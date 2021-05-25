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
            ((System.ComponentModel.ISupportInitialize)(this.dgvpagos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sociosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dB_A7241D_sgsaDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(81, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Pagos";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label2.Location = new System.Drawing.Point(85, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Buscar socio:";
            // 
            // dgvpagos
            // 
            this.dgvpagos.AutoGenerateColumns = false;
            this.dgvpagos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvpagos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.aPaternoDataGridViewTextBoxColumn,
            this.aMaternoDataGridViewTextBoxColumn,
            this.nombreDataGridViewTextBoxColumn,
            this.Domicilio,
            this.Telefono,
            this.NombrePredios});
            this.dgvpagos.DataSource = this.sociosBindingSource;
            this.dgvpagos.Location = new System.Drawing.Point(85, 87);
            this.dgvpagos.Name = "dgvpagos";
            this.dgvpagos.Size = new System.Drawing.Size(647, 124);
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
            this.btnbuscar.Location = new System.Drawing.Point(406, 58);
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
            this.txtBuscar.Location = new System.Drawing.Point(171, 58);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(229, 20);
            this.txtBuscar.TabIndex = 49;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label3.Location = new System.Drawing.Point(81, 232);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 24);
            this.label3.TabIndex = 50;
            this.label3.Text = "Crear recibo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(82, 272);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 13);
            this.label4.TabIndex = 51;
            this.label4.Text = "Bueno por $:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(82, 298);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 13);
            this.label5.TabIndex = 52;
            this.label5.Text = "Importe con letra:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(82, 324);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(92, 13);
            this.label6.TabIndex = 53;
            this.label6.Text = "Nombre del socio:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(82, 351);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(112, 13);
            this.label7.TabIndex = 54;
            this.label7.Text = "No. de cuenta predial:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(82, 377);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(90, 13);
            this.label8.TabIndex = 55;
            this.label8.Text = "Socio avecinado:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(82, 401);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(112, 13);
            this.label9.TabIndex = 56;
            this.label9.Text = "No. de cuenta predial:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(83, 428);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(25, 13);
            this.label10.TabIndex = 57;
            this.label10.Text = "Tel:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(83, 451);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(80, 13);
            this.label11.TabIndex = 58;
            this.label11.Text = "Domicilio socio:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(83, 474);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(98, 13);
            this.label12.TabIndex = 59;
            this.label12.Text = "Concepto de pago:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(82, 499);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(101, 13);
            this.label13.TabIndex = 60;
            this.label13.Text = "Predio denominado:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(82, 525);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(78, 13);
            this.label14.TabIndex = 61;
            this.label14.Text = "Tipo de predio:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(83, 549);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(96, 13);
            this.label15.TabIndex = 62;
            this.label15.Text = "Predio ubicado en:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(82, 571);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(146, 13);
            this.label16.TabIndex = 63;
            this.label16.Text = "Pago correspondiente al año:";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(590, 243);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(32, 13);
            this.label17.TabIndex = 64;
            this.label17.Text = "Folio:";
            // 
            // textBoxbueno
            // 
            this.textBoxbueno.Location = new System.Drawing.Point(200, 265);
            this.textBoxbueno.Name = "textBoxbueno";
            this.textBoxbueno.Size = new System.Drawing.Size(161, 20);
            this.textBoxbueno.TabIndex = 65;
            // 
            // textBoximporte
            // 
            this.textBoximporte.Location = new System.Drawing.Point(200, 291);
            this.textBoximporte.Name = "textBoximporte";
            this.textBoximporte.Size = new System.Drawing.Size(250, 20);
            this.textBoximporte.TabIndex = 66;
            // 
            // textBoxnombresoc
            // 
            this.textBoxnombresoc.Cursor = System.Windows.Forms.Cursors.No;
            this.textBoxnombresoc.Location = new System.Drawing.Point(200, 317);
            this.textBoxnombresoc.Name = "textBoxnombresoc";
            this.textBoxnombresoc.ReadOnly = true;
            this.textBoxnombresoc.Size = new System.Drawing.Size(161, 20);
            this.textBoxnombresoc.TabIndex = 67;
            // 
            // textBoxcuepre1
            // 
            this.textBoxcuepre1.Location = new System.Drawing.Point(200, 344);
            this.textBoxcuepre1.Name = "textBoxcuepre1";
            this.textBoxcuepre1.Size = new System.Drawing.Size(161, 20);
            this.textBoxcuepre1.TabIndex = 68;
            // 
            // textBoxsocioavec
            // 
            this.textBoxsocioavec.Location = new System.Drawing.Point(200, 370);
            this.textBoxsocioavec.Name = "textBoxsocioavec";
            this.textBoxsocioavec.Size = new System.Drawing.Size(161, 20);
            this.textBoxsocioavec.TabIndex = 69;
            // 
            // textBoxcuepre2
            // 
            this.textBoxcuepre2.Location = new System.Drawing.Point(202, 396);
            this.textBoxcuepre2.Name = "textBoxcuepre2";
            this.textBoxcuepre2.Size = new System.Drawing.Size(159, 20);
            this.textBoxcuepre2.TabIndex = 70;
            // 
            // textBoxtel
            // 
            this.textBoxtel.Cursor = System.Windows.Forms.Cursors.No;
            this.textBoxtel.Location = new System.Drawing.Point(200, 421);
            this.textBoxtel.Name = "textBoxtel";
            this.textBoxtel.ReadOnly = true;
            this.textBoxtel.Size = new System.Drawing.Size(161, 20);
            this.textBoxtel.TabIndex = 71;
            // 
            // textBoxdomicilio
            // 
            this.textBoxdomicilio.Cursor = System.Windows.Forms.Cursors.No;
            this.textBoxdomicilio.Location = new System.Drawing.Point(200, 444);
            this.textBoxdomicilio.Name = "textBoxdomicilio";
            this.textBoxdomicilio.ReadOnly = true;
            this.textBoxdomicilio.Size = new System.Drawing.Size(250, 20);
            this.textBoxdomicilio.TabIndex = 72;
            // 
            // textBoxconcepto
            // 
            this.textBoxconcepto.Location = new System.Drawing.Point(200, 467);
            this.textBoxconcepto.Name = "textBoxconcepto";
            this.textBoxconcepto.Size = new System.Drawing.Size(250, 20);
            this.textBoxconcepto.TabIndex = 73;
            // 
            // textBoxpredio
            // 
            this.textBoxpredio.Cursor = System.Windows.Forms.Cursors.No;
            this.textBoxpredio.Location = new System.Drawing.Point(200, 492);
            this.textBoxpredio.Name = "textBoxpredio";
            this.textBoxpredio.ReadOnly = true;
            this.textBoxpredio.Size = new System.Drawing.Size(250, 20);
            this.textBoxpredio.TabIndex = 74;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "SOLAR",
            "TERRENO DE SIEMBRA TEMPORAL",
            "TERRENO DE SIEMBRE RIEGO"});
            this.comboBox1.Location = new System.Drawing.Point(200, 518);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(250, 21);
            this.comboBox1.TabIndex = 75;
            // 
            // textBoxubicpred
            // 
            this.textBoxubicpred.Location = new System.Drawing.Point(200, 542);
            this.textBoxubicpred.Name = "textBoxubicpred";
            this.textBoxubicpred.Size = new System.Drawing.Size(250, 20);
            this.textBoxubicpred.TabIndex = 76;
            // 
            // textBoxpagoanual
            // 
            this.textBoxpagoanual.Location = new System.Drawing.Point(234, 568);
            this.textBoxpagoanual.Name = "textBoxpagoanual";
            this.textBoxpagoanual.Size = new System.Drawing.Size(216, 20);
            this.textBoxpagoanual.TabIndex = 77;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(561, 288);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 23);
            this.button1.TabIndex = 78;
            this.button1.Text = "Imprimir recibo";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Pagos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 601);
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
            this.Controls.Add(this.dgvpagos);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Pagos";
            this.Text = "Pagos";
            this.Load += new System.EventHandler(this.Pagos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvpagos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sociosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dB_A7241D_sgsaDataSet)).EndInit();
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
    }
}