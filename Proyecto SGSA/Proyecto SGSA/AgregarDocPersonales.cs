using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WIA;

namespace Proyecto_SGSA
{
    public partial class AgregarDocPersonales : Form
    {
        public AgregarDocPersonales()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ListScanners();

            // Establecer carpeta de salida de inicio TMP
            textBox1.Text = Path.GetTempPath();
            // Establecer JPEG como predeterminada
            comboBox1.SelectedIndex = 1;

        }

        private void ListScanners()
        {
            // limpiar el ListBox.
            listBox1.Items.Clear();

            // Crea una instancia de DeviceManager
            var deviceManager = new DeviceManager();

            // Recorre la lista de dispositivos y agrega el nombre al cuadro de lista
            for (int i = 1; i <= deviceManager.DeviceInfos.Count; i++)
            {
                // Agrega el dispositivo solo si es un escáner
                if (deviceManager.DeviceInfos[i].Type != WiaDeviceType.ScannerDeviceType)
                {
                    continue;
                }

                // Agregue el dispositivo del escáner al cuadro de lista (el objeto DeviceInfos completo)
                // Importante: almacenamos un objeto de tipo escáner (cuyo método ToString devuelve el nombre del escáner)
                listBox1.Items.Add(
                    new Scanner(deviceManager.DeviceInfos[i])
                );
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Task.Factory.StartNew(StartScanning).ContinueWith(result => TriggerScan());
        }

        private void TriggerScan()
        {
            Console.WriteLine("Imagen escaneada con éxito");
        }

        public void StartScanning()
        {
            Scanner device = null;

            this.Invoke(new MethodInvoker(delegate ()
            {
                device = listBox1.SelectedItem as Scanner;
            }));

            if (device == null)
            {
                MessageBox.Show("Primero debe seleccionar un dispositivo de escáner de la lista",
                                "Advertencia",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }else if(String.IsNullOrEmpty(textBox2.Text))
            {
                MessageBox.Show("Proporcione un nombre de archivo",
                                "Advertencia",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            ImageFile image = new ImageFile();
            string imageExtension = "";

            this.Invoke(new MethodInvoker(delegate ()
            {
                switch (comboBox1.SelectedIndex)
                {
                    case 1:
                        image = device.ScanJPEG();
                        imageExtension = ".jpeg";
                        break;
                }
            }));
            
            
            // Guarda la imagen
            var path = Path.Combine(textBox1.Text, textBox2.Text + imageExtension);

            if (File.Exists(path))
            {
                File.Delete(path);
            }

            image.SaveFile(path);

            pictureBox1.Image = new Bitmap(path);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderDlg = new FolderBrowserDialog();
            folderDlg.ShowNewFolderButton = true;
            DialogResult result = folderDlg.ShowDialog();

            if (result == DialogResult.OK)
            {
                textBox1.Text = folderDlg.SelectedPath;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
