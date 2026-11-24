using FincaManager.DataAccess;
using FincaManager.Entities;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Text;

namespace FincaManager.Datos
{
    public class CuentasFinancierasDatos
    {
        private readonly ConexionBD _conexionDatos = new ConexionBD();

        public List<CuentasFinancierasEntidad> MtdConsultar()
        {
            List<CuentasFinancierasEntidad> listaCuentasFinancieras = new List<CuentasFinancierasEntidad>();

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
                                CuentasFinancierasEntidad cuentasFinanciaras = new CuentasFinancierasEntidad(
                                    Convert.ToInt32(rd["IdCuentaFinanciera"]),
                                    Convert.ToString(rd["Nombre"]) ?? string.Empty,
                                    Convert.ToString(rd["Tipo"]) ?? string.Empty,
                                    Convert.ToString(rd["NumeroCuenta"]) ?? string.Empty,
                                    Convert.ToString(rd["NombreBanco"]) ?? string.Empty,
                                    Convert.ToBoolean(rd["Activo"]),
                                    Convert.ToBoolean(rd["Eliminado"]),
                                    Convert.ToDecimal(rd["SaldoActualQuetzales"])
                                    );

                                listaCuentasFinancieras.Add(cuentasFinanciaras);
                            }
                        }
                    }
                }
                return listaCuentasFinancieras;
            }
            catch (Exception ex)
            {

                throw new Exception("Error al consultar Cuentas Financieras", ex);
            }
        }
    }
}
