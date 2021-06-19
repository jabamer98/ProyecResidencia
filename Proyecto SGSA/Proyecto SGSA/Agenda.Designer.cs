namespace Proyecto_SGSA
{
    partial class Agenda
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
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtbuscar = new System.Windows.Forms.TextBox();
            this.dtasocios = new System.Windows.Forms.DataGridView();
            this.btnprogramar = new System.Windows.Forms.Button();
            this.btnbuscar = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.txtsitio = new System.Windows.Forms.TextBox();
            this.lblnombre = new System.Windows.Forms.Label();
            this.lblApaterno = new System.Windows.Forms.Label();
            this.lblAmaterno = new System.Windows.Forms.Label();
            this.lblhoraprogr = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dtafechas = new System.Windows.Forms.DataGridView();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.cboxhoras = new System.Windows.Forms.ComboBox();
            this.cboxminutos = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cboxAMPM = new System.Windows.Forms.ComboBox();
            this.dtahoras = new System.Windows.Forms.DataGridView();
            this.label8 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtasocios)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtafechas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtahoras)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.SteelBlue;
            this.button1.Dock = System.Windows.Forms.DockStyle.Top;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Image = global::Proyecto_SGSA.Properties.Resources.casa;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button1.Location = new System.Drawing.Point(0, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(200, 63);
            this.button1.TabIndex = 0;
            this.button1.Text = "Regresar";
            this.button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            this.button1.MouseLeave += new System.EventHandler(this.button1_MouseLeave);
            this.button1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.button1_MouseMove);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightSkyBlue;
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.dtahoras);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.dateTimePicker2);
            this.panel1.Controls.Add(this.dateTimePicker1);
            this.panel1.Controls.Add(this.dtafechas);
            this.panel1.Controls.Add(this.textBox3);
            this.panel1.Controls.Add(this.lblhoraprogr);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Location = new System.Drawing.Point(0, 64);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 385);
            this.panel1.TabIndex = 1;
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(212, 164);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 2;
            this.monthCalendar1.DateSelected += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar1_DateSelected);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.button1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 84);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(200, 63);
            this.panel3.TabIndex = 1;
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(303, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(371, 29);
            this.label1.TabIndex = 2;
            this.label1.Text = "PROGRAMACIÓN DE EVENTOS";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "yyyy-MM-dd";
            this.dateTimePicker1.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(12, 180);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(98, 20);
            this.dateTimePicker1.TabIndex = 3;
            this.dateTimePicker1.Visible = false;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(298, 131);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 24);
            this.label2.TabIndex = 4;
            this.label2.Text = "El día:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(464, 274);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 24);
            this.label3.TabIndex = 5;
            this.label3.Text = "Con el socio:";
            // 
            // txtbuscar
            // 
            this.txtbuscar.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtbuscar.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtbuscar.Location = new System.Drawing.Point(590, 278);
            this.txtbuscar.Name = "txtbuscar";
            this.txtbuscar.Size = new System.Drawing.Size(200, 20);
            this.txtbuscar.TabIndex = 6;
            // 
            // dtasocios
            // 
            this.dtasocios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtasocios.Location = new System.Drawing.Point(209, 336);
            this.dtasocios.Name = "dtasocios";
            this.dtasocios.ReadOnly = true;
            this.dtasocios.Size = new System.Drawing.Size(579, 73);
            this.dtasocios.TabIndex = 7;
            this.dtasocios.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtasocios_CellContentClick);
            // 
            // btnprogramar
            // 
            this.btnprogramar.Location = new System.Drawing.Point(678, 415);
            this.btnprogramar.Name = "btnprogramar";
            this.btnprogramar.Size = new System.Drawing.Size(110, 23);
            this.btnprogramar.TabIndex = 8;
            this.btnprogramar.Text = "Programar evento";
            this.btnprogramar.UseVisualStyleBackColor = true;
            this.btnprogramar.Click += new System.EventHandler(this.btnprogramar_Click);
            // 
            // btnbuscar
            // 
            this.btnbuscar.Location = new System.Drawing.Point(618, 303);
            this.btnbuscar.Name = "btnbuscar";
            this.btnbuscar.Size = new System.Drawing.Size(75, 23);
            this.btnbuscar.TabIndex = 9;
            this.btnbuscar.Text = "Buscar";
            this.btnbuscar.UseVisualStyleBackColor = true;
            this.btnbuscar.Click += new System.EventHandler(this.btnbuscar_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(206, 104);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(154, 24);
            this.label7.TabIndex = 15;
            this.label7.Text = "Evento a realizar:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(366, 109);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(422, 20);
            this.textBox1.TabIndex = 16;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(528, 175);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 24);
            this.label4.TabIndex = 19;
            this.label4.Text = "A las:";
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.CustomFormat = "hh:mm tt";
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker2.Location = new System.Drawing.Point(12, 154);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(98, 20);
            this.dateTimePicker2.TabIndex = 20;
            this.dateTimePicker2.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(488, 224);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 24);
            this.label5.TabIndex = 21;
            this.label5.Text = "En el sitio:";
            // 
            // txtsitio
            // 
            this.txtsitio.Location = new System.Drawing.Point(590, 228);
            this.txtsitio.Name = "txtsitio";
            this.txtsitio.Size = new System.Drawing.Size(198, 20);
            this.txtsitio.TabIndex = 22;
            // 
            // lblnombre
            // 
            this.lblnombre.AutoSize = true;
            this.lblnombre.Location = new System.Drawing.Point(514, 428);
            this.lblnombre.Name = "lblnombre";
            this.lblnombre.Size = new System.Drawing.Size(0, 13);
            this.lblnombre.TabIndex = 26;
            this.lblnombre.Visible = false;
            // 
            // lblApaterno
            // 
            this.lblApaterno.AutoSize = true;
            this.lblApaterno.Location = new System.Drawing.Point(584, 428);
            this.lblApaterno.Name = "lblApaterno";
            this.lblApaterno.Size = new System.Drawing.Size(0, 13);
            this.lblApaterno.TabIndex = 27;
            this.lblApaterno.Visible = false;
            // 
            // lblAmaterno
            // 
            this.lblAmaterno.AutoSize = true;
            this.lblAmaterno.Location = new System.Drawing.Point(649, 428);
            this.lblAmaterno.Name = "lblAmaterno";
            this.lblAmaterno.Size = new System.Drawing.Size(0, 13);
            this.lblAmaterno.TabIndex = 28;
            this.lblAmaterno.Visible = false;
            // 
            // lblhoraprogr
            // 
            this.lblhoraprogr.AutoSize = true;
            this.lblhoraprogr.Location = new System.Drawing.Point(116, 160);
            this.lblhoraprogr.Name = "lblhoraprogr";
            this.lblhoraprogr.Size = new System.Drawing.Size(35, 13);
            this.lblhoraprogr.TabIndex = 30;
            this.lblhoraprogr.Text = "label8";
            this.lblhoraprogr.Visible = false;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // textBox2
            // 
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Font = new System.Drawing.Font("qtquickcontrols", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(209, 420);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(230, 18);
            this.textBox2.TabIndex = 31;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(83, 210);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 32;
            this.label6.Text = "label6";
            this.label6.Visible = false;
            // 
            // dtafechas
            // 
            this.dtafechas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtafechas.Location = new System.Drawing.Point(3, 206);
            this.dtafechas.Name = "dtafechas";
            this.dtafechas.Size = new System.Drawing.Size(74, 62);
            this.dtafechas.TabIndex = 33;
            this.dtafechas.Visible = false;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(83, 239);
            this.textBox3.MaxLength = 10;
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(110, 20);
            this.textBox3.TabIndex = 34;
            this.textBox3.Visible = false;
            // 
            // cboxhoras
            // 
            this.cboxhoras.FormattingEnabled = true;
            this.cboxhoras.Items.AddRange(new object[] {
            "01",
            "02",
            "03",
            "04",
            "05",
            "06",
            "07",
            "08",
            "09",
            "10",
            "11",
            "12"});
            this.cboxhoras.Location = new System.Drawing.Point(591, 177);
            this.cboxhoras.Name = "cboxhoras";
            this.cboxhoras.Size = new System.Drawing.Size(39, 21);
            this.cboxhoras.TabIndex = 35;
            this.cboxhoras.Text = "01";
            this.cboxhoras.SelectedIndexChanged += new System.EventHandler(this.cboxhoras_SelectedIndexChanged);
            // 
            // cboxminutos
            // 
            this.cboxminutos.FormattingEnabled = true;
            this.cboxminutos.Items.AddRange(new object[] {
            "00",
            "01",
            "02",
            "03",
            "04",
            "05",
            "06",
            "07",
            "08",
            "09",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31",
            "32",
            "33",
            "34",
            "35",
            "36",
            "37",
            "38",
            "39",
            "40",
            "41",
            "42",
            "43",
            "44",
            "45",
            "46",
            "47",
            "48",
            "49",
            "50",
            "51",
            "52",
            "53",
            "54",
            "55",
            "56",
            "57",
            "58",
            "59"});
            this.cboxminutos.Location = new System.Drawing.Point(636, 177);
            this.cboxminutos.Name = "cboxminutos";
            this.cboxminutos.Size = new System.Drawing.Size(38, 21);
            this.cboxminutos.TabIndex = 36;
            this.cboxminutos.Text = "00";
            this.cboxminutos.SelectedIndexChanged += new System.EventHandler(this.cboxminutos_SelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(116, 341);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(35, 13);
            this.label9.TabIndex = 3;
            this.label9.Text = "label9";
            this.label9.Visible = false;
            // 
            // cboxAMPM
            // 
            this.cboxAMPM.FormattingEnabled = true;
            this.cboxAMPM.Items.AddRange(new object[] {
            "AM",
            "PM"});
            this.cboxAMPM.Location = new System.Drawing.Point(680, 177);
            this.cboxAMPM.Name = "cboxAMPM";
            this.cboxAMPM.Size = new System.Drawing.Size(43, 21);
            this.cboxAMPM.TabIndex = 37;
            this.cboxAMPM.Text = "AM";
            this.cboxAMPM.SelectedIndexChanged += new System.EventHandler(this.cboxAMPM_SelectedIndexChanged);
            // 
            // dtahoras
            // 
            this.dtahoras.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtahoras.Location = new System.Drawing.Point(3, 320);
            this.dtahoras.Name = "dtahoras";
            this.dtahoras.Size = new System.Drawing.Size(110, 62);
            this.dtahoras.TabIndex = 38;
            this.dtahoras.Visible = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(116, 360);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(35, 13);
            this.label8.TabIndex = 39;
            this.label8.Text = "label8";
            this.label8.Visible = false;
            // 
            // Agenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.cboxAMPM);
            this.Controls.Add(this.cboxminutos);
            this.Controls.Add(this.cboxhoras);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.lblAmaterno);
            this.Controls.Add(this.lblApaterno);
            this.Controls.Add(this.lblnombre);
            this.Controls.Add(this.txtsitio);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnbuscar);
            this.Controls.Add(this.btnprogramar);
            this.Controls.Add(this.dtasocios);
            this.Controls.Add(this.txtbuscar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Name = "Agenda";
            this.Text = "Agenda";
            this.Load += new System.EventHandler(this.Agenda_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtasocios)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtafechas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtahoras)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtbuscar;
        private System.Windows.Forms.DataGridView dtasocios;
        private System.Windows.Forms.Button btnprogramar;
        private System.Windows.Forms.Button btnbuscar;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtsitio;
        private System.Windows.Forms.Label lblnombre;
        private System.Windows.Forms.Label lblApaterno;
        private System.Windows.Forms.Label lblAmaterno;
        private System.Windows.Forms.Label lblhoraprogr;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dtafechas;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.ComboBox cboxminutos;
        private System.Windows.Forms.ComboBox cboxhoras;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cboxAMPM;
        private System.Windows.Forms.DataGridView dtahoras;
        private System.Windows.Forms.Label label8;
    }
}