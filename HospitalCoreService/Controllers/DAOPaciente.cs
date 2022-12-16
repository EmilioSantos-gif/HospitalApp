using HospitalCoreService;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital
{
    class DAOPaciente
    {
        static HospitalServiceDBEntities context = new HospitalServiceDBEntities();
        static public List<Paciente> GetPacientes()
        {
            context.Configuration.ProxyCreationEnabled = false;
            return context.Paciente.ToList();
        }

        static public Paciente getPaciente(int id)
        {
            context.Configuration.ProxyCreationEnabled = false;
            return context.Paciente.Find(id);
        }

        static public int RegistrarPaciente(Paciente Paciente)
        {
            context.Configuration.ProxyCreationEnabled = false;
            try
            {
                context.Paciente.Add(Paciente);
                return context.SaveChanges();
            }
            catch (Exception e)
            {
                return 0;
            }
        }

        static public int UpdatePaciente(Paciente Paciente)
        {
            context.Configuration.ProxyCreationEnabled = false;
            var retrievedPaciente = context.Paciente.Find(Paciente.IdPaciente);
            retrievedPaciente = Paciente;
            return context.SaveChanges();
        }

        static public int DeletePaciente(Paciente Paciente)
        {
            context.Configuration.ProxyCreationEnabled = false;
            context.Paciente.Remove(Paciente);
            return context.SaveChanges();
        }
    }
}
