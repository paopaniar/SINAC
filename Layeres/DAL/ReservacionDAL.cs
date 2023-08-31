using SINAC.Layeres.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace SINAC.Layeres.DAL
{
    class ReservacionDAL
    {
        /// <summary>
        /// Funcion para guardar una Reservacion en la Base de Datos
        /// </summary>
        /// <param name="reserv">Reservacion que se va a guardar</param>

        public static void InsertarReservacion(Entities.Reservacion reserv)
        {
            try
            {
                using (IDataBase db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnection()))
                {
                    string sql = @"SP_InsertarReservacion";

                    var comando = new SqlCommand(sql);
                    comando.Parameters.AddWithValue("@FechaDeConservaciones", reserv.FechaDeConservaciones);
                    comando.Parameters.AddWithValue("@ID_Tipo", reserv.Area.Tipo);
                    comando.Parameters.AddWithValue("@ID_Usuario", reserv.ID_Usuario);
                    comando.Parameters.AddWithValue("@ID", reserv.ID);

                    //comando.Parameters.AddWithValue("@IDVisitantes", reserv.IDVisitantes);
                    
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
        /// Funcion para mostrar una Reservacion segun su identificaion en la Base de Datos
        /// </summary>
        /// <param name="id"> identificacion Reservacion  que se va a mostar</param>

        public static Reservacion ObtenerPorId(int id)
            {
                // System.Configuration: necesita agregar la referencia
                string cadena = System.Configuration.ConfigurationManager.
                                ConnectionStrings["SINAC.Properties.Settings.Conexion"].ConnectionString;
                // Para conectarnos a SQLServer se utiliza ADO.NET -> agregar using System.Data.SqlClient;
                SqlConnection conn = new SqlConnection(cadena);
                try
                {
                    conn.Open();
                    string sql = "SP_SeleccionarReservaPorId";
                    SqlCommand command = new SqlCommand(sql, conn);
                    command.Parameters.AddWithValue("@ID", id);
                    command.CommandType = System.Data.CommandType.StoredProcedure;
                    // Ejecuta la sentencia sql en la conexion indicada
                    SqlDataReader reader = command.ExecuteReader();
                    // Cada Read lee un registro de la consulta
                    while (reader.Read())
                    {
                        Reservacion r = new Reservacion();
                        //evento.ID = Convert.ToInt32(reader["Id"]);
                        r.ID = Convert.ToInt32(reader["ID"].ToString());
                        r.FechaDeConservaciones = Convert.ToDateTime(reader["FechaDeConservaciones"]);
                        r.ID_Tipo = reader["ID_Tipo"].ToString();
                        r.ID_Usuario = reader["ID_Usuario"].ToString();
                        //r.CantidadTickets = Convert.ToInt32(reader["CantidadTickets"].ToString());
                        //r.MontoaPagar = Convert.ToSingle(reader["MontoaPagar"].ToString());
                        //r.Moneda = Convert.ToInt32(reader["Moneda"].ToString());
                        //r.MetodoPago = Convert.ToInt32(reader["MetodoPago"].ToString());
                        //r.Pais = Convert.ToInt32(reader["Pais"].ToString());

                        r.Usuarios = UsuarioDAL.ObtenerPorReserva(r.ID);

                        return r;
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


        public static Reservacion ObtenerPorUser(string id)
        {
            // System.Configuration: necesita agregar la referencia
            string cadena = System.Configuration.ConfigurationManager.
                            ConnectionStrings["SINAC.Properties.Settings.Conexion"].ConnectionString;
            // Para conectarnos a SQLServer se utiliza ADO.NET -> agregar using System.Data.SqlClient;
            SqlConnection conn = new SqlConnection(cadena);
            try
            {
                conn.Open();
                string sql = "SP_SeleccionarReservaPorId";
                SqlCommand command = new SqlCommand(sql, conn);
                command.Parameters.AddWithValue("@ID_Usuario", id);
                command.CommandType = System.Data.CommandType.StoredProcedure;
                // Ejecuta la sentencia sql en la conexion indicada
                SqlDataReader reader = command.ExecuteReader();
                // Cada Read lee un registro de la consulta
                while (reader.Read())
                {
                    Reservacion r = new Reservacion();
                    //evento.ID = Convert.ToInt32(reader["Id"]);
                    r.ID = Convert.ToInt32(reader["ID"].ToString());
                    r.FechaDeConservaciones = Convert.ToDateTime(reader["FechaDeConservaciones"]);
                    r.ID_Tipo = reader["ID_Tipo"].ToString();
                    r.ID_Usuario = reader["ID_Usuario"].ToString();
                    //r.CantidadTickets = Convert.ToInt32(reader["CantidadTickets"].ToString());
                    //r.MontoaPagar = Convert.ToSingle(reader["MontoaPagar"].ToString());
                    //r.Moneda = Convert.ToInt32(reader["Moneda"].ToString());
                    //r.MetodoPago = Convert.ToInt32(reader["MetodoPago"].ToString());
                    //r.Pais = Convert.ToInt32(reader["Pais"].ToString());

                    r.Usuarios = UsuarioDAL.ObtenerPorReserva(r.ID);

                    return r;
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

        public static List<Reservacion> ObtenerTodos()
        {
            List<Reservacion> lista = new List<Reservacion>();

            // System.Configuration: necesita agregar la referencia
            string cadena =
 System.Configuration.ConfigurationManager.
                ConnectionStrings["SINAC.Properties.Settings.Conexion"].ConnectionString;
            // Para conectarnos a SQLServer se utiliza ADO.NET -> agregar using System.Data.SqlClient;
            SqlConnection conn = new SqlConnection(cadena);
            try
            {
                conn.Open();
                string sql = "SP_SeleccionarReservas";
                SqlCommand command = new SqlCommand(sql, conn);
                command.CommandType = System.Data.CommandType.StoredProcedure;
                // Ejecuta la sentencia sql en la conexion indicada
                SqlDataReader reader = command.ExecuteReader();
                // Cada Read lee un registro de la consulta
                while (reader.Read())
                {

                    string idTipo = reader["ID_Tipo"].ToString();
                    Reservacion r = new Reservacion();

                    r.ID = Convert.ToInt32(reader["ID"].ToString());
                    r.FechaDeConservaciones = Convert.ToDateTime(reader["FechaDeConservaciones"]);
                    //r.ID_Tipo = reader["ID_Tipo"].ToString();
                    r.Area = DAL.AreaMantenimientoDAL.SeleccionarPorTipo(idTipo); 
                    r.ID_Usuario = reader["ID_Usuario"].ToString();
   

                    r.Usuarios = UsuarioDAL.ObtenerPorReserva(r.ID);
                
                    lista.Add(r);
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


        public static void InsertarUsandoTransacciones(Entities.Reservacion reser, Entities.CarritoCompras carrito)
        {
            try
            {
                using (IDataBase db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnection()))
                {
                    string sql = @"SP_InsertarReservacion";

                    var comando = new SqlCommand(sql);
                    comando.Parameters.AddWithValue("@FechaDeConservaciones", reser.FechaDeConservaciones);
                    comando.Parameters.AddWithValue("@ID_Tipo", reser.Area.Tipo);
                    comando.Parameters.AddWithValue("@ID_Usuario", reser.ID_Usuario);
                    comando.Parameters.AddWithValue("@ID", reser.ID);

                    comando.CommandType = System.Data.CommandType.StoredProcedure;

                    //db.ExecuteNonQuery(comando); usar Execute de transacciones


                    var comando2 = new SqlCommand(@"SP_InsertarCompra");
                    comando.Parameters.AddWithValue("@ID", carrito.ID);
                    comando.Parameters.AddWithValue("@IdReserva", carrito.IdReserva);
                    comando.Parameters.AddWithValue("@CantidadTickets", carrito.CantidadTickets);
                    comando.Parameters.AddWithValue("@MontoaPagar", carrito.MontoaPagar);
                    comando.Parameters.AddWithValue("@Moneda", carrito.Moneda);
                    comando.Parameters.AddWithValue("@MetodoPago", carrito.MetodoPago);
                    comando.Parameters.AddWithValue("@Pais", carrito.Pais);

                    comando2.CommandType = System.Data.CommandType.StoredProcedure;

                    var lista = new List<IDbCommand>();
                    lista.Add(comando);
                    lista.Add(comando2);

                    db.ExecuteNonQuery(lista, System.Data.IsolationLevel.ReadCommitted);
                }
            }
            catch (SqlException sqlEx)
            {
               Log.CreateSQLExceptionsErrorDetails(sqlEx);
                throw;
            }
            catch (Exception ex)
            {
                Log.CreateGenericErrorExceptionDetail(ex);
                throw;
            }
        }

        //public static void InsertarReservacion(Reservacion reserva, Usuario user)
        //{
        //    try
        //    {
        //        using (IDataBase db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnection()))
        //        {
        //            string sql = @"SP_InsertarReservacionUsuario";

        //            var comando = new SqlCommand(sql);
        //            comando.Parameters.AddWithValue("@Reserva_Id", reserva.ID);
        //            comando.Parameters.AddWithValue("@Usuario_Id", user.CorreoElectronico);

        //            // IMPORTANTE: antes del Execute se debe indicar al comando que es un SP
        //            comando.CommandType = System.Data.CommandType.StoredProcedure;

        //            db.ExecuteNonQuery(comando);
        //        }
        //    }
        //    catch (SqlException sqlEx)
        //    {
        //        Log.LogSQLException(sqlEx);
        //        throw;
        //    }
        //    catch (Exception ex)
        //    {
        //      Log.LogGenericException(ex);
        //        throw;
        //    }
    }



    }







