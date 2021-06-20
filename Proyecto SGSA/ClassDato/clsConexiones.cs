using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Windows.Forms;
using System.Data;

namespace ClassDato
{
  public  class clsConexiones
  {
        public static SqlConnection cnx = new SqlConnection(@"Data Source=SQL5092.site4now.net;Initial Catalog=db_a758a9_sgsa;User Id=db_a758a9_sgsa_admin;Password=sgsa1234");

        public static void EjecutaQuery( string Opcion)
        {
            SqlCommand cmd = new SqlCommand();
            
            switch (Opcion)
            {

             /*   case "RP":
                    cmd = new SqlCommand($"INSERT INTO Socios (`APaterno`, `AMaterno`, `Nombre`, `Domicilio`, `Colonia`, `CiudadOPoblacion`, `Telefono`, `NombrePredios`) " +
                        $"VALUES ('{ClassBT.clsSocio.AMaterno}',{ClassBT.clsSocio.APaterno},'{ClassBT.clsSocio.Nombre}','{ClassBT.clsSocio.Domicilio}','{ClassBT.clsSocio.Colonia}'," +
                        $"'{ClassBT.clsSocio.CiudadOPoblacion}','{ClassBT.clsSocio.Telefono}','{ClassBT.clsSocio.NombrePredios}',)", cnx);
                    break;*/

                case "RV":
                    cmd = new SqlCommand($"INSERT INTO Pagos ( Fecha, Costos) " +
                        $"VALUES ('{ClassBT.clsPagos.Fecha}',{ClassBT.clsPagos.Costos})", cnx);
                    break;
/*
                case "RDV":
                    cmd = new SqlCommand($"INSERT INTO DetallePago (  Folio, CURP, CantidadAños,  Costo) " +
                        $"VALUES ({ClassBT.clsDetallesPago.Foliofk}, {ClassBT.clsDetallesPago.CURPfk},{ClassBT.clsDetallesPago.CantidadAños},{ClassBT.clsDetallesPago.Costo})", cnx);
                    break;*/
            }
            
             try
            {
                cnx.Open();
                //COMENTADO PARA QUE FUNCIONE********************************************************************
                cmd.ExecuteNonQuery();
                cnx.Close();                
            }
            catch (Exception e)
            {
                MessageBox.Show("ERROR: "+e);
            }
            finally { cnx.Close(); }

        }
        
        public static DataTable EjecutaQueryConsulta(string Dato,string Opcion)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter();

            switch (Opcion)
            {

                case "C":
                    da = new SqlDataAdapter("SELECT * FROM Socios ", cnx);
                    break;

                case "CO":
                    da = new SqlDataAdapter("SELECT MAX(CURP)FROM Socios ", cnx);
                    break;


                case "IDV":
                    da = new SqlDataAdapter("SELECT MAX( Folio) FROM Pagos", cnx);
                    break;


            /*
                case "CDV":
                    da = new SqlDataAdapter("SELECT Folio, Fecha, P.Costo, CURP, APaterno, AMaterno, Nombre, CURPfk, dp.CantidadAños " +
                        "FROM Pagos as P, Socio as s,DetallePago as dp WHERE P.Folio=dp.Foliofk and CURP=CURPfk", cnx);
                    break;
*/
            }
            try
            {
                cnx.Open();
                //COMENTADO PARA QUE FUNCIONE*********************************************************************************************
                da.Fill(dt); 
                cnx.Close();

            }
            catch (Exception e)
            {

                MessageBox.Show("ERROR: " + e);
            }
            finally { cnx.Close(); }
            return dt;

        }

  }
}
