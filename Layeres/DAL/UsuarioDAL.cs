using SINAC.Layeres.Entities;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace SINAC.Layeres.DAL
{
    class UsuarioDAL
    {
        /// <summary>
        /// Funcion para guardar un Usuario en la Base de Datos
        /// </summary>
        /// <param name="user">Usuario que se va a guardar</param>
        public static void InsertarUsuario(Entities.Usuario user)
        {
            try
            {
                using (IDataBase db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnection()))
                {
                    string sql = @"SP_InsertarUsuario";

                    var comando = new SqlCommand(sql);
                    comando.Parameters.AddWithValue("@Nombre", user.Nombre);
                    comando.Parameters.AddWithValue("@Apellidos", user.Apellidos);
                    comando.Parameters.AddWithValue("@Telefono", user.Telefono);
                    comando.Parameters.AddWithValue("@Nacionalidad", user.Nacionalidad);
                    comando.Parameters.AddWithValue("@Nacimiento", user.Nacimiento);
                    comando.Parameters.AddWithValue("@Profesion", user.Profesion);
                    comando.Parameters.AddWithValue("@CorreoElectronico", user.CorreoElectronico);
                    comando.Parameters.AddWithValue("@Clave", user.Clave);
                    comando.Parameters.AddWithValue("@CodRol", user.CodRol);
                    comando.CommandType = System.Data.CommandType.StoredProcedure;

                    db.ExecuteNonQuery(comando);
                }

            }
            catch (Exception)
            {

                throw;
            }
        }


        /// <summary>
        /// Funcion para obtener un Usuario por su correo en la Base de Datos
        /// </summary>
        /// <param name="id">Usuario que se va a mostrar</param>
        public static Usuario ObtenerPorId(string id)
        {
            // System.Configuration: necesita agregar la referencia
            string cadena = System.Configuration.ConfigurationManager.
                           ConnectionStrings["SINAC.Properties.Settings.Conexion"].ConnectionString;
            // Para conectarnos a SQLServer se utiliza ADO.NET -> agregar using System.Data.SqlClient;
            SqlConnection conn = new SqlConnection(cadena);
            try
            {
                conn.Open();
                string sql = "SP_SeleccionarUsuarioPorId";
                SqlCommand command = new SqlCommand(sql, conn);
                command.Parameters.AddWithValue("@CorreoElectronico", id);
                command.CommandType = System.Data.CommandType.StoredProcedure;
                // Ejecuta la sentencia sql en la conexion indicada
                SqlDataReader reader = command.ExecuteReader();
                // Cada Read lee un registro de la consulta
                while (reader.Read())
                {

                    Usuario u = new Usuario();

                    u.Nombre = reader["Nombre"].ToString();
                    u.Apellidos = reader["Apellidos"].ToString();
                    u.Telefono = reader["Telefono"].ToString();
                    u.Nacionalidad = Convert.ToInt32(reader["Nacionalidad"]);
                    u.Nacimiento = Convert.ToDateTime(reader["Nacimiento"]);
                    u.Profesion = reader["Profesion"].ToString();
                    u.Clave = reader["Clave"].ToString();
                    u.CodRol = Convert.ToInt32(reader["CodRol"]);
                    return u;
                }
            }
            catch
            {
                throw;
            }
            finally
            {
                conn.Close();
            }

            return null;
        }

        /// <summary>
        /// Funcion para modificar la clave de un Usuario en la Base de Datos
        /// </summary>
        /// <param name="u">Usuario que se le va a modificar clave </param>
        public void ModificarClave(Usuario u)
        {
            string cadena = System.Configuration.ConfigurationManager.
               ConnectionStrings["SINAC.Properties.Settings.Conexion"].ConnectionString;
            // Para conectarnos a SQLServer se utiliza ADO.NET -> agregar using System.Data.SqlClient;
            SqlConnection conn = new SqlConnection(cadena);
            try
            {
                conn.Open();
                string sql = "SP_ModificarClave";
                SqlCommand command = new SqlCommand(sql, conn);
                command.CommandType = System.Data.CommandType.StoredProcedure;


                command.Parameters.AddWithValue("@CorreoElectronico", u.CorreoElectronico);
                command.Parameters.AddWithValue("@Clave", u.Clave);
                
                // Ejecuta la sentencia sql en la conexion indicada
                command.ExecuteNonQuery();
            }
            catch
            {
                throw;
            }
            finally
            {
                conn.Close();
            }

        }

        /// <summary>
        /// Funcion para obtnener un Usuario por su reserva en la Base de Datos
        /// </summary>
        /// <param name="reservaId">Reserva que se va a buscar</param>
        public static List<Usuario> ObtenerPorReserva(int reservaId)
        {
            List<Usuario> lista = new List<Usuario>();

            // System.Configuration: necesita agregar la referencia
            string cadena =
           System.Configuration.ConfigurationManager.
                          ConnectionStrings["SINAC.Properties.Settings.Conexion"].ConnectionString;
            // Para conectarnos a SQLServer se utiliza ADO.NET -> agregar using System.Data.SqlClient;
            SqlConnection conn = new SqlConnection(cadena);
            try
            {
                conn.Open();
                string sql = "SP_SeleccionarUsuariosPorReserva";
                SqlCommand command = new SqlCommand(sql, conn);
                command.CommandType = System.Data.CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@ReservaId", reservaId);
                // Ejecuta la sentencia sql en la conexion indicada
                SqlDataReader reader = command.ExecuteReader();
                // Cada Read lee un registro de la consulta
                while (reader.Read())
                {
                    Usuario u = new Usuario();

                    u.Nombre = reader["Nombre"].ToString();
                    u.Apellidos = reader["Apellidos"].ToString();
                    u.Telefono = reader["Telefono"].ToString();
                    u.Nacionalidad = Convert.ToInt32(reader["Nacionalidad"]);
                    u.Nacimiento = Convert.ToDateTime(reader["Nacimiento"]);
                    u.Profesion = reader["Profesion"].ToString();
                    u.Clave = reader["Clave"].ToString();
                    u.CodRol = Convert.ToInt32(reader["CodRol"]);
                    



                    lista.Add(u);
                }
            }
            catch
            {
                throw;
            }
            finally
            {
                conn.Close();
            }

            return lista;
        }
        /// <summary>
        /// Funcion para editar un Usuario en la Base de Datos
        /// </summary>
        /// <param name="user">Usuario que se va a modificar</param>
        public void ModificarUsuario(Usuario user)
        {


            try
            {
                using (IDataBase db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnection()))
                {
                    string sql = @"SP_ModificarUsuario";

                    var comando = new SqlCommand(sql);
                    comando.Parameters.AddWithValue("@Nombre", user.Nombre);
                    comando.Parameters.AddWithValue("@Apellidos", user.Apellidos);
                    comando.Parameters.AddWithValue("@Telefono", user.Telefono);
                    comando.Parameters.AddWithValue("@Nacionalidad", user.Nacionalidad);
                    comando.Parameters.AddWithValue("@Nacimiento", user.Nacimiento);
                    comando.Parameters.AddWithValue("@Profesion", user.Profesion);
                    comando.Parameters.AddWithValue("@CorreoElectronico", user.CorreoElectronico);
                    comando.Parameters.AddWithValue("@Clave", user.Clave);
                    comando.Parameters.AddWithValue("@CodRol", user.CodRol);
                    comando.CommandType = System.Data.CommandType.StoredProcedure;
                    db.ExecuteNonQuery(comando);
                }
            }
            catch (SqlException sqlEx)
            {
                Log.LogSQLException(sqlEx);
                throw;
            }
            catch (Exception ex)
            {
                Log.LogGenericException(ex);
                throw;
            }
        }

    }
}
