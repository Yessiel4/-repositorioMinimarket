using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Google.Protobuf;

namespace CL_AccesoDatos
{
    public class DA_BASE
    {
        public static string CadenaConexion = "SERVER=localhost;" +
            "DATABASE= minimarket; UID=root ; PASSWORD=";

        //Sentencias insert, update y delete

        public static bool RealizarTransaccion(string strSQL)
        {
            bool resultado = false;

            try
            {
                using (MySqlConnection conn = new MySqlConnection
                    (CadenaConexion))
                {
                    conn.Open();
                    using (MySqlTransaction tr = conn.BeginTransaction())
                    {
                        try
                        {
                            using (MySqlCommand cmd = new MySqlCommand
                                (strSQL, conn))
                            {
                                cmd.Transaction = tr;
                                cmd.ExecuteNonQuery();
                            }
                            tr.Commit();
                            resultado = true;
                        }
                        catch (Exception)
                        {
                            tr.Rollback();
                            resultado = false;
                            throw;
                        }
                        return resultado;
                    }
                }
            }
            catch (Exception) 
            {
            resultado = false;
             throw;
            }
        }
    }
}
