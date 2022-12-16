using HospitalCoreService;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital
{
    class DAOProcedimiento
    {
        static HospitalServiceDBEntities context = new HospitalServiceDBEntities();
        static public List<Procedimiento> GetProcedimientos()
        {
            context.Configuration.ProxyCreationEnabled = false;
            return context.Procedimiento.ToList();
        }

        static public Procedimiento getProcedimiento(int id)
        {
            context.Configuration.ProxyCreationEnabled = false;
            return context.Procedimiento.Find(id);
        }

        static public int RegistrarProcedimiento(Procedimiento Procedimiento)
        {
            context.Configuration.ProxyCreationEnabled = false;
            try
            {
                context.Procedimiento.Add(Procedimiento);
                return context.SaveChanges();
            }
            catch (Exception e)
            {
                return 0;
            }
        }

        static public int UpdateProcedimiento(Procedimiento Procedimiento)
        {
            context.Configuration.ProxyCreationEnabled = false;
            var retrievedProcedimiento = context.Procedimiento.Find(Procedimiento.IdProcedimiento);
            retrievedProcedimiento.Pago = Procedimiento.Pago;
            return context.SaveChanges();
        }

        static public int DeleteProcedimiento(Procedimiento Procedimiento)
        {
            context.Configuration.ProxyCreationEnabled = false;
            context.Procedimiento.Remove(Procedimiento);
            return context.SaveChanges();
        }
    }
}
