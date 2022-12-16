using HospitalCoreService;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital
{
    class DAOAnalisis
    {
        static HospitalServiceDBEntities context = new HospitalServiceDBEntities();
        static public List<Analisis> GetAnalisis()
        {
            context.Configuration.ProxyCreationEnabled = false;
            return context.Analisis.ToList();
        }

        static public Analisis getAnalisis(int id)
        {
            context.Configuration.ProxyCreationEnabled = false;
            return context.Analisis.Find(id);
        }

        static public int RegistrarAnalisis(Analisis Analisis)
        {
            context.Configuration.ProxyCreationEnabled = false;
            try
            {
                context.Analisis.Add(Analisis);
                return context.SaveChanges();
            }
            catch (Exception e)
            {
                return 0;
            }
        }

        static public int UpdateAnalisis(Analisis Analisis)
        {
            context.Configuration.ProxyCreationEnabled = false;
            var retrievedAnalisis = context.Analisis.Find(Analisis.IdAnalisis);
            retrievedAnalisis.Pago = Analisis.Pago;
            return context.SaveChanges();
        }

        static public int DeleteAnalisis(Analisis Analisis)
        {
            context.Configuration.ProxyCreationEnabled = false;
            context.Analisis.Remove(Analisis);
            return context.SaveChanges();
        }
    }
}
