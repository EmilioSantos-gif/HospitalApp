using HospitalCoreService;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital
{
    class DAOUsuario
    {
        static HospitalServiceDBEntities context = new HospitalServiceDBEntities();
        static public List<Usuarios> GetUsuarios()
        {
            context.Configuration.ProxyCreationEnabled = false;
            return context.Usuarios.ToList();
        }

        static public Usuarios getUsuario(int id)
        {
            context.Configuration.ProxyCreationEnabled = false;
            return context.Usuarios.Find(id);
        }

        static public int RegistrarUsuario(Usuarios Usuario)
        {
            context.Configuration.ProxyCreationEnabled = false;
            try
            {
                context.Usuarios.Add(Usuario);
                return context.SaveChanges();
            } catch (Exception e)
            {
                return 0;
            }
        }

        static public int UpdateUsuario(Usuarios Usuario)
        {
            context.Configuration.ProxyCreationEnabled = false;
            var retrievedUsuario = context.Usuarios.Find(Usuario.Id);
            retrievedUsuario = Usuario;
            return context.SaveChanges();
        }

        static public int DeleteUsuario(Usuarios usuario)
        {
            context.Configuration.ProxyCreationEnabled = false;
            context.Usuarios.Remove(usuario);
            return context.SaveChanges();
        }
    }
}
