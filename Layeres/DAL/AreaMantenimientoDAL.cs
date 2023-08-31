using SINAC.Layeres.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SINAC.Layeres.DAL
{
    class AreaMantenimientoDAL
    {
        /// <summary>
        /// Funcion para guardar una Area en la Base de Datos
        /// </summary>
        /// <param name="area">area que se va a guardar</param>

        public static void InsertarArea(AreaMantenimiento area)
        {
            try
            {
                using (IDataBase db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnection()))
                {   
                    string sql = @"SP_InsertarAreaConservacion";

                    var comando = new SqlCommand(sql);
                    comando.Parameters.AddWithValue("@Codigo", area.Codigo);
                    comando.Parameters.AddWithValue("@Nombre", area.Nombre);
                    comando.Parameters.AddWithValue("@SitioWeb", area.SitioWeb);
                    comando.Parameters.AddWithValue("@Horario", area.Horario);
                    comando.Parameters.AddWithValue("@Tipo", area.Tipo);
                    comando.Parameters.AddWithValue("@Precio", area.Precio);
                    comando.Parameters.AddWithValue("@Disponibilidad", area.Disponibilidad);
                    comando.Parameters.AddWithValue("@Foto", area.Foto);
                    comando.Parameters.AddWithValue("@Hora", area.Hora);
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
        /// Funcion muestra todas las areas en la base de datos
        /// </summary>
        /// <returns></returns>

        public static List<AreaMantenimiento> SeleccionarTodosSP()
        {
            try
            {
                using (IDataBase db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnection()))
                {
                    string sql = @"SP_SeleccionarAreas";

                    var comando = new SqlCommand(sql);

                    // IMPORTANTE: antes del Execute se debe indicar al comando que es un SP
                    comando.CommandType = System.Data.CommandType.StoredProcedure;

                    var reader = db.ExecuteReader(comando);

                    List<AreaMantenimiento> lista = new List<AreaMantenimiento>();
                    while (reader.Read())
                    {
                        AreaMantenimiento area = new AreaMantenimiento();
                        area.Codigo = Convert.ToInt32(reader["Codigo"]);
                        area.Nombre = reader["Nombre"].ToString();
                        area.SitioWeb = reader["SitioWeb"].ToString();
                        area.Horario = Convert.ToDateTime(reader["Horario"]);
                        area.Tipo = reader["Tipo"].ToString();
                        area.Precio = Convert.ToInt32(reader["Precio"]);
                        area.Disponibilidad = Convert.ToInt32(reader["Disponibilidad"]);
                        area.Foto = (byte[])reader["Foto"];
                        area.Hora = reader["Hora"].ToString();

                        lista.Add(area);
                    }

                    return lista;
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


        /// <summary>
        /// Funcion para modificar una Area en la Base de Datos
        /// </summary>
        /// <param name="area">area que se va a guardar</param>
        public void ModificarAreaMantenimiento(AreaMantenimiento area)
        {


            try
            {
                using (IDataBase db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnection()))
                {
                    string sql = @"SP_ModificarAreaConservacion";

                    var comando = new SqlCommand(sql);
                    comando.Parameters.AddWithValue("@Codigo", area.Codigo);
                    comando.Parameters.AddWithValue("@Nombre", area.Nombre);
                    comando.Parameters.AddWithValue("@SitioWeb", area.SitioWeb);
                    comando.Parameters.AddWithValue("@Horario", area.Horario);
                    comando.Parameters.AddWithValue("@Tipo", area.Tipo);
                    comando.Parameters.AddWithValue("@Precio", area.Precio);
                    comando.Parameters.AddWithValue("@Disponibilidad", area.Disponibilidad);
                    comando.Parameters.AddWithValue("@Foto", area.Foto);
                    comando.Parameters.AddWithValue("@Hora", area.Hora);
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

        /// <summary>
        /// Funcion para eliminar una Area en la Base de Datos
        /// </summary>
        /// <param name="Codigo">area que se va a eliminar</param>
        public void EliminarAreaMantenimiento(int Codigo)
        {


            try
            {
                using (IDataBase db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnection()))
                {
                    string sql = @"SP_EliminarAreaConservacion";

                    var comando = new SqlCommand(sql);

                    comando.Parameters.AddWithValue("@Codigo", Codigo);


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


        public void FiltarPorTipo(string Tipo)
        {
            try
            {
                using (IDataBase db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnection()))
                {
                    string sql = @"SP_SeleccionarAreaPorTipo";

                    var comando = new SqlCommand(sql);
                    comando.Parameters.AddWithValue("@Tipo", Tipo);
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
        /// <summary>
        /// Funcion para mostrar los tipos de una Area seleccionados por tipo de la Base de Datos
        /// </summary>
        /// <param name="tipo">area que se va a seleccionar</param>
        //public static Entities.AreaMantenimiento SeleccionarPorTipo(string tipo)
        //    {
        //        try
        //        {
        //            using (IDataBase db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnection()))
        //            {
        //                string sql = @"SP_SeleccionarAreaPorTipo";
        //                Entities.AreaMantenimiento area = null;

        //                var comando = new SqlCommand(sql);
        //                comando.Parameters.AddWithValue("@Tipo", tipo);
        //                // IMPORTANTE: antes del Execute se debe indicar al comando que es un SP
        //                comando.CommandType = System.Data.CommandType.StoredProcedure;

        //                var reader = db.ExecuteReader(comando, "AreaConservacion");
        //                foreach (DataRow row in reader.Tables[0].Rows)
        //                {
        //                    string areaType = row["Tipo"].ToString();


        //                area = new Entities.AreaMantenimiento()
        //                {
        //                    Codigo = Convert.ToInt32(row["Codigo"]),
        //                Nombre = row["Nombre"].ToString(),
        //                SitioWeb = row["SitioWeb"].ToString(),
        //                Horario = Convert.ToDateTime(row["Horario"]),
        //                //Tipo = row["Tipo"].ToString(),
        //                Precio = Convert.ToInt32(row["Precio"]),
        //                Disponibilidad = Convert.ToInt32(row["Disponibilidad"]),
        //                Foto = (byte[])row["Foto"],
        //                Hora = row["Hora"].ToString(),
        //            };

        //                }

        //                return area;
        //            }
        //        }
        //        catch (SqlException sqlEx)
        //        {
        //        Log.LogSQLException(sqlEx);
        //            throw;
        //        }
        //        catch (Exception ex)
        //        {
        //          Log.LogGenericException(ex);
        //            throw;
        //        }
        //    }
        public static Entities.AreaMantenimiento SeleccionarPorTipo(string tipo)
        {
            try
            {
                using (IDataBase db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnection()))
                {
                    string sql = @"SP_SeleccionPorId";

                    var comando = new SqlCommand(sql);
                    comando.Parameters.AddWithValue("@Tipo", tipo);

                    comando.CommandType = System.Data.CommandType.StoredProcedure;

                    var reader = db.ExecuteReader(comando);


                    while (reader.Read())
                    {
                        Entities.AreaMantenimiento area = new Entities.AreaMantenimiento();
                        area.Codigo = Convert.ToInt32(reader["Codigo"]);
                        area.Nombre = reader["Nombre"].ToString();
                        area.SitioWeb = reader["SitioWeb"].ToString();
                        area.Horario = Convert.ToDateTime(reader["Horario"]);
                        area.Tipo = reader["Tipo"].ToString();
                        area.Precio = Convert.ToInt32(reader["Precio"]);
                        area.Disponibilidad = Convert.ToInt32(reader["Disponibilidad"]);
                        area.Foto = (byte[])reader["Foto"];
                        area.Hora = reader["Hora"].ToString();
                        return area;
                    }
                    return null;
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


    

