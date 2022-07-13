using ApiCalles.DAO;
using ApiCalles.DTO;


namespace ApiCalles.Services
{
    public class CalleService
    {
        CalleDAO calleDAO;
        public CalleService()
        {
            calleDAO = new CalleDAO();

        }

        public CalleDTO insertar(CalleDTO calleDTO)
        {
            long cantidadCalles = calleDAO.cantidadCalles(calleDTO);
            if (cantidadCalles == 0)
            {
                calleDTO = calleDAO.insertar(calleDTO);
            }

            
            return calleDTO;

        }
    }
}