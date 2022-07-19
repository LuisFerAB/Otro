using Microsoft.Extensions.Configuration;
using System.Data.SqlClient;

namespace WebApplication1.Models
{
    public class Conexion
    {
        IConfiguration configuration;
        private string _cadenaSql = string.Empty;

        public Conexion()
        {
            _cadenaSql = configuration.GetConnectionString("Veterinaria_SqlServer");
        }

        public string CadenaConexion()
        {
            return _cadenaSql;
        }
    
    }
}
