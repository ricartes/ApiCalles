using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ApiCalles.DTO
{
    public class CalleDTO
    {
        public int STRT_CODE;
        public string CITY_CODE;
        public string CITY_NAME;
        public string STREET;
        public DateTime FECHA;

        public CalleDTO(int STRT_CODE, string CITY_CODE, string CITY_NAME, string STREET, DateTime FECHA)
        {
            this.STRT_CODE = STRT_CODE;
            this.CITY_CODE = CITY_CODE;
            this.CITY_NAME = CITY_NAME;
            this.STREET = STREET;
            this.FECHA = FECHA;
        }
    }
}