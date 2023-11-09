using MySql.Data.MySqlClient;
using System;

internal static class DA_BASEHelpers
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
                }
            }
        }
        catch (Exception)
        {
            resultado = false;
            throw;
        }
        return resultado;
    }
}