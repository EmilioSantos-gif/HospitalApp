using HospitalCoreService;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital
{
    class DAORol
    {
        static HospitalServiceDBEntities context = new HospitalServiceDBEntities();
        static public List<Roles> GetRoles()
        {
            context.Configuration.ProxyCreationEnabled = false;
            return context.Roles.ToList();
            //return context.Roles.ToList().Select(r => new Roles { Id = r.Id, NombreRol = r.NombreRol }).ToList();
        }

        static public Roles getRoles(int id)
        {
            context.Configuration.ProxyCreationEnabled = false;
            return context.Roles.Find(id);
        }

        static public int RegistrarRoles(Roles Roles)
        {
            context.Configuration.ProxyCreationEnabled = false;
            try
            {
                context.Roles.Add(Roles);
                return context.SaveChanges();
            }
            catch (Exception e)
            {
                return 0;
            }
        }

        static public int UpdateRoles(Roles Roles)
        {
            context.Configuration.ProxyCreationEnabled = false;

            var retrievedRoles = context.Roles.Find(Roles.Id);
            retrievedRoles = Roles;
            return context.SaveChanges();
        }

        static public int DeleteRoles(Roles Roles)
        {
            context.Configuration.ProxyCreationEnabled = false;

            context.Roles.Remove(Roles);
            return context.SaveChanges();
        }
    }
}
