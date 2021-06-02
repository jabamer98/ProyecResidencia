using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_SGSA
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new Login());
            //Application.Run(new MenuP());
            //Application.Run(new menu());
            //Application.Run(new PagosV2());
            //Application.Run(new AltaSocios());
            //Application.Run(new Pagos());
            //Application.Run(new BuscarSocioParaModificar());
            //Application.Run(new Documentos_Personales());
            Application.Run(new DocumentosDePredios());
            //Application.Run(new AgregarDocPersonales());
            //cambiar alta socios para que inicie con Form1 desde el login
        }
    }
}
