using Entities.EntCliente;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.DatClientes
{
    public class DatCliente
    {
        private string _cadenaConexion = string.Empty;
        public DatCliente()
        {
            _cadenaConexion = new Conexion().CadenaConexion();
        }

        public List<EntCliente> ListaClientes()
        {

            List<EntCliente> lstClientes = new List<EntCliente>();
            DataSet ds = new DataSet();
            try
            {
                using (var conexion = new SqlConnection(_cadenaConexion))
                {
                    conexion.Open();
                    SqlCommand command = new SqlCommand("dbo.usp_ObtenerEmpleados", conexion);
                    command.CommandType = CommandType.StoredProcedure;
                    command.CommandTimeout = 3600;
                    SqlDataAdapter da = new SqlDataAdapter();
                    da.SelectCommand = command;
                    da.Fill(ds);
                    conexion.Close();

                    if (ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
                    {
                        lstClientes = ds.Tables[0].AsEnumerable().Select(m => new EntCliente()
                        {
                            IdCliente = m.Field<int>("IdCliente"),
                            Nombre = m.Field<string>("Nombre"),
                            ApMaterno = m.Field<string>("ApMaterno"),
                            ApPaterno = m.Field<string>("ApPaterno"),
                            Sexo = m.Field<int>("Sexo"),
                            Edad = m.Field<int>("Edad"),
                            FechaNacimiento = m.Field<DateTime>("FechaNacimiento"),
                            Correo = m.Field<string>("Correo"),
                            Telefono = m.Field<string>("Telefono")
                        }).ToList();
                    }
                }
            }
            catch (Exception ex)
            {
                lstClientes = new List<EntCliente>();
            }

            return lstClientes;

        }

    }
}
