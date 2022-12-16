using HospitalCoreService;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital
{
    class DAOCuenta
    {
        static HospitalServiceDBEntities context = new HospitalServiceDBEntities();
        static public List<Cuenta> GetCuentas()
        {
            context.Configuration.ProxyCreationEnabled = false;
            return context.Cuenta.ToList();
        }

        static public Cuenta getCuenta(int id)
        {
            context.Configuration.ProxyCreationEnabled = false;
            return context.Cuenta.Find(id);
        }

        static public int RegistrarCuenta(Cuenta Cuenta)
        {
            context.Configuration.ProxyCreationEnabled = false;
            try
            {
                context.Cuenta.Add(Cuenta);
                return context.SaveChanges();
            }
            catch (Exception e)
            {
                return 0;
            }
        }

        static public int UpdateCuenta(Cuenta Cuenta)
        {
            context.Configuration.ProxyCreationEnabled = false;
            var retrievedCuenta = context.Cuenta.Find(Cuenta.IdCuenta);
            retrievedCuenta.Balance = Cuenta.Balance;
            return context.SaveChanges();
        }

        static public int DeleteCuenta(Cuenta Cuenta)
        {
            context.Configuration.ProxyCreationEnabled = false;
            context.Cuenta.Remove(Cuenta);
            return context.SaveChanges();
        }
    }
}
