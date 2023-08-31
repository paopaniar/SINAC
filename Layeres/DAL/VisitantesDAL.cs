using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SINAC.Layeres.DAL
{
    class VisitantesDAL
    {/// <summary>
     /// Funcion para guardar un visitante en la Base de Datos
     /// </summary>
     /// <param name="visita">Visita que se va a guardar</param>

        public static void InsertarVisitantes(Entities.Visitantes visita)
        {
            try
            {
                using (IDataBase db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnection()))
                {
                    string sql = @"SP_InsertarVisitante";

                    var comando = new SqlCommand(sql);
                    comando.Parameters.AddWithValue("@NombresCompletos", visita.NombresCompletos);
                    comando.Parameters.AddWithValue("@IDVisitantes", visita.IDVisitantes);
                    comando.Parameters.AddWithValue("@ID_Usuario", visita.ID_Usuario);
                    comando.CommandType = System.Data.CommandType.StoredProcedure;

                    db.ExecuteNonQuery(comando);
                }

            }
            catch (Exception)
            {

                throw;
            }
        }



    }
}
