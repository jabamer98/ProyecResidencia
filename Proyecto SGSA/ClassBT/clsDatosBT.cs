using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassBT
{
  
    public static class clsDetallesPago
    {
        public static int FolioDetalle { get; set; }
        public static string CURPfk { get; set; }
        public static int CantidadAños { get; set; }
        public static bool Años { get; set; }
        public static float Costo { get; set; }
        public static int Foliofk { get; set; }
    }
    public static class clsSocio 
    {
        public static string CURP { get; set; }
        public static string APaterno { get; set; }
        public static string AMaterno { get; set; }
        public static string Nombre { get; set; }
        public static float FNacimiento { get; set; }
        public static int Edad { get; set; }
        public static float Domicilio { get; set; }
        public static string Colonia { get; set; }
        public static string CiudadOPoblacion { get; set; }
        public static int Telefono { get; set; }
        public static string NombrePredios { get; set; }

    }
    public static class clsPagos
    {

        public static int Folio { get; set; }
        public static string Fecha { get; set; }
        public static float Costos { get; set; }

    }
    public static class clsBT 
    {

    }

}
