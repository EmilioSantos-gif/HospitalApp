using Hospital;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Xml.Serialization;

namespace HospitalCoreService
{
    /// <summary>
    /// Summary description for CoreWebService
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class CoreWebService : System.Web.Services.WebService
    {

        //============================ANALISIS===============================//
        
        [WebMethod]
        public List<Analisis> GetAnalisis()
        {
            return DAOAnalisis.GetAnalisis();
        }

        [WebMethod]
        public Analisis getAnalisis(int id)
        {
            return DAOAnalisis.getAnalisis(id);
        }

        [WebMethod]
        public int RegistrarAnalisis(Analisis analisis)
        {
            return DAOAnalisis.RegistrarAnalisis(analisis);     
        }

        [WebMethod]
        public int UpdateAnalisis(Analisis analisis)
        {
            return DAOAnalisis.UpdateAnalisis(analisis);
        }

        [WebMethod]
        public int DeleteAnalisis(Analisis analisis)
        {
            return DAOAnalisis.DeleteAnalisis(analisis);
        }

        //============================CUENTAS===============================//
        [WebMethod]
        public List<Cuenta> GetCuentas()
        {
            return DAOCuenta.GetCuentas();
        }

        [WebMethod]
        public Cuenta getCuenta(int id)
        {
            return DAOCuenta.getCuenta(id);
        }

        [WebMethod]
        public int RegistrarCuenta(Cuenta cuenta)
        {
            return DAOCuenta.RegistrarCuenta(cuenta);
        }

        [WebMethod]
        public int UpdateCuenta(Cuenta cuenta)
        {
            return DAOCuenta.UpdateCuenta(cuenta);
        }

        [WebMethod]
        public int DeleteCuenta(Cuenta cuenta)
        {
            return DAOCuenta.DeleteCuenta(cuenta);
        }

        //============================PACIENTE===============================//
        [WebMethod]
        public List<Paciente> GetPacientes()
        {
            return DAOPaciente.GetPacientes();
        }

        [WebMethod]
        public Paciente getPaciente(int id)
        {
            return DAOPaciente.getPaciente(id);
        }

        [WebMethod]
        public int RegistrarPaciente(Paciente paciente)
        {
            return DAOPaciente.RegistrarPaciente(paciente);
        }

        [WebMethod]
        public int UpdatePaciente(Paciente paciente)
        {
            return DAOPaciente.UpdatePaciente(paciente);
        }

        [WebMethod]
        public int DeletePaciente(Paciente paciente)
        {
            return DAOPaciente.DeletePaciente(paciente);
        }

        //============================PAGO===============================//
        [WebMethod]
        public List<Pago> GetPagos()
        {
            return DAOPago.GetPagos();
        }

        [WebMethod]
        public Pago getPago(int id)
        {
            return DAOPago.getPago(id);
        }

        [WebMethod]
        public int RegistrarPago(Pago pago)
        {
            return DAOPago.RegistrarPago(pago);
        }

        [WebMethod]
        public int UpdatePago(Pago pago)
        {
            return DAOPago.UpdatePago(pago);
        }

        [WebMethod]
        public int DeletePago(Pago pago)
        {
            return DAOPago.DeletePago(pago);
        }

        //============================PROCEDIMIENTO===============================//
        [WebMethod]
        public List<Procedimiento> GetProcedimientos()
        {
            return DAOProcedimiento.GetProcedimientos();
        }

        [WebMethod]
        public Procedimiento getProcedimiento(int id)
        {
            return DAOProcedimiento.getProcedimiento(id);
        }

        [WebMethod]
        public int RegistrarProcedimiento(Procedimiento procedimiento)
        {
            return DAOProcedimiento.RegistrarProcedimiento(procedimiento);
        }

        [WebMethod]
        public int UpdateProcedimiento(Procedimiento procedimiento)
        {
            return DAOProcedimiento.UpdateProcedimiento(procedimiento);
        }

        [WebMethod]
        public int DeleteProcedimiento(Procedimiento procedimiento)
        {
            return DAOProcedimiento.DeleteProcedimiento(procedimiento);
        }

        //============================USUARIOS===============================//
        [WebMethod]
        public List<Usuarios> GetUsuarios()
        {
            return DAOUsuario.GetUsuarios();
        }

        [WebMethod]
        public Usuarios getUsuarios(int id)
        {
            return DAOUsuario.getUsuario(id);
        }

        [WebMethod]
        public int RegistrarUsuarios(Usuarios usuarios)
        {
            return DAOUsuario.RegistrarUsuario(usuarios);
        }

        [WebMethod]
        public int UpdateUsuarios(Usuarios usuarios)
        {
            return DAOUsuario.UpdateUsuario(usuarios);
        }

        [WebMethod]
        public int DeleteUsuarios(Usuarios usuarios)
        {
            return DAOUsuario.DeleteUsuario(usuarios);
        }
        
        //============================ROL===============================//
        [WebMethod]


        public List<Roles> GetRoles()
        {
            return DAORol.GetRoles();
        }
        
        [WebMethod]

        public Roles getRoles(int id)
        {
            HospitalServiceDBEntities context = new HospitalServiceDBEntities();
            return context.Roles.Find(id);
            //return DAORol.getRoles(id);
        }
        
        [WebMethod]
        public int RegistrarRoles(Roles roles)
        {
            return DAORol.RegistrarRoles(roles);
        }

        [WebMethod]
        public int UpdateRoles(Roles roles)
        {
            return DAORol.UpdateRoles(roles);
        }

        [WebMethod]
        public int DeleteRoles(Roles roles)
        {
            return DAORol.DeleteRoles(roles);
        }
        
    }
}
