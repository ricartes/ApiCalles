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
        public string insertarCalle(string STR_MAN_ID, string STR_VAN_DESCRIPCION, string FECHA)
        {
            string mensaje = "correcto";
            bool error = false;
            if (string.IsNullOrEmpty(STR_MAN_ID))
            {
                error = true;
                mensaje = "incorrecto";
            }
            if (string.IsNullOrEmpty(STR_VAN_DESCRIPCION))
            {
                error = true;
                mensaje = "incorrecto";
            }
            if (string.IsNullOrEmpty(FECHA))
            {
                error = true;
                mensaje = "incorrecto";
            }

            DateTime dt;
            if (!DateTime.TryParse(FECHA.Trim(), out dt))
            {
                error = true;
                mensaje = "incorrecto";
            }

            if (!error)
            {
                CalleDTO calleDTO = new CalleDTO(1, STR_MAN_ID.Trim(), STR_VAN_DESCRIPCION.Trim(), dt);
                calleDTO = calleService.insertar(calleDTO);

            }

            
            return mensaje;
        }
        
    }
}
