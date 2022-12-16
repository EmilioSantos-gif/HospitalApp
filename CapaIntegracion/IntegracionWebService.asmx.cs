using CapaIntegracion.CoreWebService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace CapaIntegracion
{
    /// <summary>
    /// Summary description for IntegracionWebService
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class IntegracionWebService : System.Web.Services.WebService
    {
        CoreWebServiceSoapClient coreClient = new CoreWebServiceSoapClient();

        //============================ANALISIS===============================//
        [WebMethod]
        public List<Analisis> GetAnalisis1()
        {
            return coreClient.GetAnalisis().ToList();
        }

        [WebMethod]
        public Analisis GetAnalisis(int id)
        {
            return coreClient.getAnalisis1(id);
        }

        [WebMethod]
        public int RegistrarAnalisis(Analisis analisis)
        {
            return coreClient.RegistrarAnalisis(analisis);
        }

        [WebMethod]
        public int UpdateAnalisis(Analisis analisis)
        {
            return coreClient.UpdateAnalisis(analisis);
        }

        [WebMethod]
        public int DeleteAnalisis(Analisis analisis)
        {
            return coreClient.DeleteAnalisis(analisis);
        }
        //============================CUENTA===============================//
        [WebMethod]
        public List<Cuenta> GetCuentas()
        {
            return coreClient.GetCuentas().ToList();
        }

        [WebMethod]
        public Cuenta GetCuenta(int id)
        {
            return coreClient.getCuenta(id);
        }

        [WebMethod]
        public int RegistrarCuenta(Cuenta cuenta)
        {
            return coreClient.RegistrarCuenta(cuenta);
        }

        [WebMethod]
        public int UpdateCuenta(Cuenta cuenta)
        {
            return coreClient.UpdateCuenta(cuenta);
        }

        [WebMethod]
        public int DeleteCuenta(Cuenta cuenta)
        {
            return coreClient.DeleteCuenta(cuenta);
        }
        //============================PACIENTE===============================//
        [WebMethod]
        public List<Paciente> GetPacientes()
        {
            return coreClient.GetPacientes().ToList();
        }

        [WebMethod]
        public Paciente GetPaciente(int id)
        {
            return coreClient.getPaciente(id);
        }

        [WebMethod]
        public int RegistrarPaciente(Paciente paciente)
        {
            return coreClient.RegistrarPaciente(paciente);
        }

        [WebMethod]
        public int UpdatePaciente(Paciente paciente)
        {
            return coreClient.UpdatePaciente(paciente);
        }

        [WebMethod]
        public int DeletePaciente(Paciente paciente)
        {
            return coreClient.DeletePaciente(paciente);
        }
        //============================PAGO===============================//
        [WebMethod]
        public List<Pago> GetPagos()
        {
            return coreClient.GetPagos().ToList();
        }

        [WebMethod]
        public Pago GetPago(int id)
        {
            return coreClient.getPago(id);
        }

        [WebMethod]
        public int RegistrarPago(Pago pago)
        {
            return coreClient.RegistrarPago(pago);
        }

        [WebMethod]
        public int UpdatePago(Pago pago)
        {
            return coreClient.UpdatePago(pago);
        }

        [WebMethod]
        public int DeletePago(Pago pago)
        {
            return coreClient.DeletePago(pago);
        }
        //============================PROCEDIMIENTO===============================//
        [WebMethod]
        public List<Procedimiento> GetProcedimientos()
        {
            return coreClient.GetProcedimientos().ToList();
        }

        [WebMethod]
        public Procedimiento GetProcedimiento(int id)
        {
            return coreClient.getProcedimiento(id);
        }

        [WebMethod]
        public int RegistrarProcedimiento(Procedimiento procedimiento)
        {
            return coreClient.RegistrarProcedimiento(procedimiento);
        }

        [WebMethod]
        public int UpdateProcedimiento(Procedimiento procedimiento)
        {
            return coreClient.UpdateProcedimiento(procedimiento);
        }

        [WebMethod]
        public int DeleteProcedimiento(Procedimiento procedimiento)
        {
            return coreClient.DeleteProcedimiento(procedimiento);
        }
        //============================ROL===============================//
        [WebMethod]
        public List<Roles> GetRoles1()
        {
            return coreClient.GetRoles().ToList();
        }

        [WebMethod]
        public Roles GetRoles(int id)
        {
            return coreClient.getRoles1(id);
        }

        [WebMethod]
        public int RegistrarRoles(Roles rol)
        {
            return coreClient.RegistrarRoles(rol);
        }

        [WebMethod] 
        public int UpdateRoles(Roles rol)
        {
            return coreClient.UpdateRoles(rol);
        }

        [WebMethod]
        public int DeleteRoles(Roles rol)
        {
            return coreClient.DeleteRoles(rol);
        }
        //============================USUARIOS===============================//
        [WebMethod]
        public List<Usuarios> GetUsuarios()
        {
            return coreClient.GetUsuarios().ToList();
        }

        [WebMethod]
        public Usuarios GetUsuario(int id)
        {
            return coreClient.getUsuarios1(id);
        }

        [WebMethod]
        public int RegistrarUsuario(Usuarios usuario)
        {
            return coreClient.RegistrarUsuarios(usuario);
        }

        [WebMethod]
        public int UpdateUsuario(Usuarios usuario)
        {
            return coreClient.UpdateUsuarios(usuario);
        }

        [WebMethod]
        public int DeleteUsuario(Usuarios usuario)
        {
            return coreClient.DeleteUsuarios(usuario);
        }

    }
}
