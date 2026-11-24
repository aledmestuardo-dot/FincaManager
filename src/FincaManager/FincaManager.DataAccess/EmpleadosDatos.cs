using FincaManager.DataAccess;
using FincaManager.Entities;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Text;

namespace FincaManager.Datos
{
    public class EmpleadosDatos
    {
        private readonly ConexionBD _conexionDatos = new ConexionBD();

        public List<EmpleadosEntidad> MtdConsultar()
        {
            List<EmpleadosEntidad> listaEmpleados = new List<EmpleadosEntidad>();

            try
            {
                using(SqlConnection conn = _conexionDatos.MtdObtenerConexion())
                {
                    string QueryConsultar = @"";

                    using(SqlCommand cmd = new SqlCommand(QueryConsultar, conn))
                    {
                        conn.Open();

                        using(SqlDataReader rd = cmd.ExecuteReader())
                        {
                            while (rd.Read())
                            {
                                EmpleadosEntidad empleado = new EmpleadosEntidad(
                                    Convert.ToInt32(rd["IdEmpleado"]),
                                    Convert.ToString(rd["Nombres"]) ?? string.Empty,
                                    Convert.ToString(rd["Apellidos"]) ?? string.Empty,
                                    Convert.ToString(rd["DPI"]) ?? string.Empty,
                                    Convert.ToString(rd["Telefono"]) ?? string.Empty,
                                    Convert.ToBoolean(rd["Activo"]),
                                    Convert.ToBoolean(rd["Eliminado"])
                                    );

                                listaEmpleados.Add(empleado);
                            }
                        }
                    }
                }
                return listaEmpleados;
            }
            catch (Exception ex)
            {

                throw new Exception("Error al consultar Empleados", ex);
            }
        }
    }
}
