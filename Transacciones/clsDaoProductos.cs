using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;


namespace Transacciones
{
    public class clsDaoProductos
    {
        private string cadenaConexion = "server=127.0.0.1;port=3307;user=root;password=;database=tiendita;";

        public DataTable BuscarProductoPorCodigo(string codigoBarras)
        {
            DataTable dt = new DataTable();

            try
            {
                using (MySqlConnection con = new MySqlConnection(cadenaConexion))
                {
                    string query = "SELECT * FROM productos WHERE Codigo_Barras = @CodigoBarras";
                    MySqlCommand cmd = new MySqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@CodigoBarras", codigoBarras);

                    con.Open();
                    MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                    da.Fill(dt);
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al buscar el producto: " + ex.Message);
            }

            return dt;
        }

        public bool DescontinuarProducto(string codigoBarras)
        {
            bool exito = false;

            using (MySqlConnection con = new MySqlConnection(cadenaConexion))
            {
                con.Open();
                MySqlTransaction transaccion = con.BeginTransaction();

                try
                {
                    string query = "UPDATE productos SET Descontinuado = TRUE WHERE Codigo_Barras = @CodigoBarras";
                    MySqlCommand cmd = new MySqlCommand(query, con, transaccion);
                    cmd.Parameters.AddWithValue("@CodigoBarras", codigoBarras);

                    int filasAfectadas = cmd.ExecuteNonQuery();

                    if (filasAfectadas > 0)
                    {
                        transaccion.Commit();
                        exito = true;
                    }
                    else
                    {
                        transaccion.Rollback();
                    }
                }
                catch (Exception ex)
                {
                    transaccion.Rollback();
                    throw new Exception("Error al descontinuar el producto: " + ex.Message);
                }
            }

            return exito;
        }
    }
}
