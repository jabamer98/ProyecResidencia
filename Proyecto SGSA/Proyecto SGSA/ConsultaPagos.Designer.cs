namespace Proyecto_SGSA
{
    partial class ConsultaPagos
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.materialFlatButton1 = new MaterialSkin.Controls.MaterialFlatButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.paneldata = new System.Windows.Forms.Panel();
            this.dgvPagos = new System.Windows.Forms.DataGridView();
            this.dB_A7241D_sgsaDataSet1 = new Proyecto_SGSA.DB_A7241D_sgsaDataSet1();
            this.dBA7241DsgsaDataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pagosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pagosTableAdapter = new Proyecto_SGSA.DB_A7241D_sgsaDataSet1TableAdapters.PagosTableAdapter();
            this.dBA7241DsgsaDataSet1BindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.detallePagoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.detallePagoTableAdapter = new Proyecto_SGSA.DB_A7241D_sgsaDataSet1TableAdapters.DetallePagoTableAdapter();
            this.detallePagoBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.pagosBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.pagosBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.sociosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dB_A7241D_sgsaDataSet)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.paneldata.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPagos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dB_A7241D_sgsaDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBA7241DsgsaDataSet1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pagosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBA7241DsgsaDataSet1BindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.detallePagoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.detallePagoBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pagosBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pagosBindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(186, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(179, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Historial de Pagos";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label2.Location = new System.Drawing.Point(266, 104);
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
            this.btnbuscar.Location = new System.Drawing.Point(607, 100);
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
            this.txtBuscar.Location = new System.Drawing.Point(372, 103);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(229, 20);
            this.txtBuscar.TabIndex = 49;
            this.txtBuscar.Text = "Por CURP";
            this.txtBuscar.TextChanged += new System.EventHandler(this.txtBuscar_TextChanged_1);
            this.txtBuscar.Enter += new System.EventHandler(this.txtBuscar_Enter);
            this.txtBuscar.Leave += new System.EventHandler(this.txtBuscar_Leave);
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.panel1.BackColor = System.Drawing.Color.LightSkyBlue;
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(0, 104);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(180, 655);
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
            this.paneldata.Location = new System.Drawing.Point(186, 129);
            this.paneldata.Name = "paneldata";
            this.paneldata.Size = new System.Drawing.Size(689, 550);
            this.paneldata.TabIndex = 85;
            // 
            // dgvPagos
            // 
            this.dgvPagos.AllowUserToAddRows = false;
            this.dgvPagos.AllowUserToDeleteRows = false;
            this.dgvPagos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPagos.Location = new System.Drawing.Point(1, 3);
            this.dgvPagos.Name = "dgvPagos";
            this.dgvPagos.ReadOnly = true;
            this.dgvPagos.Size = new System.Drawing.Size(669, 533);
            this.dgvPagos.TabIndex = 51;
            this.dgvPagos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPagos_CellContentClick_1);
            // 
            // dB_A7241D_sgsaDataSet1
            // 
            this.dB_A7241D_sgsaDataSet1.DataSetName = "DB_A7241D_sgsaDataSet1";
            this.dB_A7241D_sgsaDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dBA7241DsgsaDataSet1BindingSource
            // 
            this.dBA7241DsgsaDataSet1BindingSource.DataSource = this.dB_A7241D_sgsaDataSet1;
            this.dBA7241DsgsaDataSet1BindingSource.Position = 0;
            // 
            // pagosBindingSource
            // 
            this.pagosBindingSource.DataMember = "Pagos";
            this.pagosBindingSource.DataSource = this.dBA7241DsgsaDataSet1BindingSource;
            // 
            // pagosTableAdapter
            // 
            this.pagosTableAdapter.ClearBeforeFill = true;
            // 
            // dBA7241DsgsaDataSet1BindingSource1
            // 
            this.dBA7241DsgsaDataSet1BindingSource1.DataSource = this.dB_A7241D_sgsaDataSet1;
            this.dBA7241DsgsaDataSet1BindingSource1.Position = 0;
            // 
            // detallePagoBindingSource
            // 
            this.detallePagoBindingSource.DataMember = "DetallePago";
            this.detallePagoBindingSource.DataSource = this.dBA7241DsgsaDataSet1BindingSource1;
            // 
            // detallePagoTableAdapter
            // 
            this.detallePagoTableAdapter.ClearBeforeFill = true;
            // 
            // detallePagoBindingSource1
            // 
            this.detallePagoBindingSource1.DataMember = "DetallePago";
            this.detallePagoBindingSource1.DataSource = this.dBA7241DsgsaDataSet1BindingSource1;
            // 
            // pagosBindingSource1
            // 
            this.pagosBindingSource1.DataMember = "Pagos";
            this.pagosBindingSource1.DataSource = this.dBA7241DsgsaDataSet1BindingSource;
            // 
            // pagosBindingSource2
            // 
            this.pagosBindingSource2.DataMember = "Pagos";
            this.pagosBindingSource2.DataSource = this.dBA7241DsgsaDataSet1BindingSource;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Image = global::Proyecto_SGSA.Properties.Resources.Pagoicono;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button1.Location = new System.Drawing.Point(923, 240);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(101, 184);
            this.button1.TabIndex = 109;
            this.button1.Text = "Pagar";
            this.button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ConsultaPagos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1074, 760);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.paneldata);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.btnbuscar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ConsultaPagos";
            this.Sizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
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
            ((System.ComponentModel.ISupportInitialize)(this.dB_A7241D_sgsaDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBA7241DsgsaDataSet1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pagosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBA7241DsgsaDataSet1BindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.detallePagoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.detallePagoBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pagosBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pagosBindingSource2)).EndInit();
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
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private MaterialSkin.Controls.MaterialFlatButton materialFlatButton1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel paneldata;
        private System.Windows.Forms.DataGridView dgvPagos;
        private System.Windows.Forms.BindingSource dBA7241DsgsaDataSet1BindingSource;
        private DB_A7241D_sgsaDataSet1 dB_A7241D_sgsaDataSet1;
        private System.Windows.Forms.BindingSource pagosBindingSource;
        private DB_A7241D_sgsaDataSet1TableAdapters.PagosTableAdapter pagosTableAdapter;
        private System.Windows.Forms.BindingSource dBA7241DsgsaDataSet1BindingSource1;
        private System.Windows.Forms.BindingSource detallePagoBindingSource;
        private DB_A7241D_sgsaDataSet1TableAdapters.DetallePagoTableAdapter detallePagoTableAdapter;
        private System.Windows.Forms.BindingSource detallePagoBindingSource1;
        private System.Windows.Forms.BindingSource pagosBindingSource1;
        private System.Windows.Forms.BindingSource pagosBindingSource2;
        private System.Windows.Forms.Button button1;
    }
}