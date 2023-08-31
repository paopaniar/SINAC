
using SINAC.Layeres.DAL;
using SINAC.Layeres.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SINAC.Layeres.BLL
{
    public class UsuarioBLL
    {
        public void Guardar(Usuario user)
        {
            if (String.IsNullOrEmpty(user.Nombre))
                throw new ApplicationException("Debe ingresar el nombre");
            if (user.Nombre.Length <= 3)
                throw new ApplicationException("El nombre debe tener más de 3 letras");

            UsuarioDAL datos = new UsuarioDAL();
            Usuario existe = UsuarioDAL.ObtenerPorId(user.CorreoElectronico);
            if (existe!=null)
            {
                datos.ModificarClave(user); 
            }
            else
            {
                UsuarioDAL.InsertarUsuario(user);
            }

            
        }


        public void Modificar(Usuario user)
        {
            if (String.IsNullOrEmpty(user.CorreoElectronico))
                throw new ApplicationException("Debe ingresar el correo Electrónico");
            UsuarioDAL datos = new UsuarioDAL();
            Usuario existe = UsuarioDAL.ObtenerPorId(user.CorreoElectronico);
            if (existe != null)
            {
                datos.ModificarUsuario(user);
            }
            else
            {
                throw new ApplicationException("Este correo no existe, debe registrarse");
            }
        }

        public Usuario ObtenerPorId(string id)
        {
            return UsuarioDAL.ObtenerPorId(id);
        }

        //public void Modificar(Usuario u) { 

        //    UsuarioDAL datos = new UsuarioDAL();
        //    ////Usuario existe = UsuarioDAL.ObtenerPorId(correo);

        //    ////if (existe != null)
        //        datos.ModificarClave(u);
            
        //}


        public static List<Usuario> ObtenerPorReserva(int reservaId)
        {
            return UsuarioDAL.ObtenerPorReserva(reservaId);
        }
    }
}