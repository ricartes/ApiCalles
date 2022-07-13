using ApiCalles.DTO;
using ApiCalles.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Services;

namespace ApiCalles
{
    /// <summary>
    /// Descripción breve de WebService
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
    // [System.Web.Script.Services.ScriptService]
    public class WebService : System.Web.Services.WebService
    {
        private CalleService calleService;
        public WebService()
        {
            calleService = new CalleService();
        }

        [WebMethod]
        public string insertarCalle(string SAP_VAN_DESCRIPCION, string COMUNA, string FECHA)
        {
            string mensaje = "correcto";
            
            if (validaEntradas(COMUNA, SAP_VAN_DESCRIPCION, FECHA))
            {
                DateTime fechaDateTime;
                DateTime.TryParse(FECHA.Trim(), out fechaDateTime);
                CalleDTO calleDTO = new CalleDTO(1, "1", COMUNA.Trim(), SAP_VAN_DESCRIPCION.Trim(), fechaDateTime);
                calleDTO = calleService.insertar(calleDTO);

            }
            else
            {
                mensaje = "incorrecto";
            }

            return mensaje;
        }

        private bool validaEntradas(string STR_MAN_ID, string STR_VAN_DESCRIPCION, string FECHA)
        {
            bool validado = true;

            if (string.IsNullOrEmpty(STR_MAN_ID))
            {
                validado = false;
               
            }
            if (string.IsNullOrEmpty(STR_VAN_DESCRIPCION))
            {
                validado = false;
                
            }
            if (string.IsNullOrEmpty(FECHA))
            {
                validado = false;
               
            }

            DateTime dt;
            if (!DateTime.TryParse(FECHA.Trim(), out dt))
            {
                validado = false;
            }

            return validado;
        }
        
    }
}
