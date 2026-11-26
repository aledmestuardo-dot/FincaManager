using FincaManager.DataAccess;
using FincaManager.Entities;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using System.Text;

namespace FincaManager.Datos
{
    public class ProductosDatos
    {
        private readonly ConexionBD _conexionDatos = new ConexionBD();

        public List<ProductosEntidad> MtdConsultar()
        {
            List<ProductosEntidad> listaProductos = new List<ProductosEntidad>();

            try
            {
                using(SqlConnection conn = _conexionDatos.MtdObtenerConexion())
                {
                    string queryConsultar = @"";

                    using(SqlCommand cmd = new SqlCommand(queryConsultar, conn))
                    {
                        conn.Open();

                        using(SqlDataReader rd = cmd.ExecuteReader())
                        {
                            while (rd.Read())
                            {
                                listaProductos.Add(new ProductosEntidad
                                {
                                    IdProducto = Convert.ToInt32(rd["IdProducto"]),
                                    IdCategoria = Convert.ToInt32(rd["IdCategoria"]),
                                    IdMarca = Convert.ToInt32(rd["IdMarca"]),
                                    IdUnidadMedida = Convert.ToInt32(rd["IdUnidadMedida"]),
                                    Nombre = Convert.ToString(rd["Nombre"]) ?? string.Empty,
                                    PesoProducto = Convert.ToDecimal(rd["PesoProducto"]),
                                    CantidadMedidas = Convert.ToDecimal(rd["CantidadMedidas"]),
                                    StockActual = Convert.ToDecimal(rd["StockActual"]),
                                    StockMinimo = Convert.ToDecimal(rd["StockMinimo"]),
                                    Activo = Convert.ToBoolean(rd["Activo"]),
                                    Eliminado = Convert.ToBoolean(rd["Eliminado"])
                                });
                            }
                        }
                    }
                }
                return listaProductos;
            }
            catch (Exception ex)
            {

                throw new Exception("Error al consultar Productos", ex);
            }
        }
    }
}
