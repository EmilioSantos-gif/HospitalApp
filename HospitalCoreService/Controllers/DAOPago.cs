using HospitalCoreService;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital
{
    class DAOPago
    {
        static HospitalServiceDBEntities context = new HospitalServiceDBEntities();
        static public List<Pago> GetPagos()
        {
            context.Configuration.ProxyCreationEnabled = false;
            return context.Pago.ToList();
        }

        static public Pago getPago(int id)
        {
            context.Configuration.ProxyCreationEnabled = false;
            return context.Pago.Find(id);
        }

        static public int RegistrarPago(Pago Pago)
        {
            context.Configuration.ProxyCreationEnabled = false;
            try
            {
                Pago.FechaRegistro = DateTime.Now; 
                context.Pago.Add(Pago);
                return context.SaveChanges();
            }
            catch (Exception e)
            {
                return 0;
            }
        }

        static public int UpdatePago(Pago Pago)
        {
            context.Configuration.ProxyCreationEnabled = false;
            var retrievedPago = context.Pago.Find(Pago.IdPago);
            retrievedPago.IsWeb = Pago.IsWeb;
            return context.SaveChanges();
        }

        static public int DeletePago(Pago Pago)
        {
            context.Configuration.ProxyCreationEnabled = false;
            context.Pago.Remove(Pago);
            return context.SaveChanges();
        }
    }
}
