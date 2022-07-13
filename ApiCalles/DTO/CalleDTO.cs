using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ApiCalles.DTO
{
    public class CalleDTO
    {
        public int STR_VAN_ID;
        public string STR_MAN_ID;
        public string STR_VAN_DESCRIPCION;
        public DateTime STR_FECHA;

        public CalleDTO(int STR_VAN_ID, string STR_MAN_ID, string STR_VAN_DESCRIPCION, DateTime STR_FECHA)
        {
            this.STR_VAN_ID = STR_VAN_ID;
            this.STR_MAN_ID = STR_MAN_ID;
            this.STR_VAN_DESCRIPCION = STR_VAN_DESCRIPCION;
            this.STR_FECHA = STR_FECHA;
        }
    }
}