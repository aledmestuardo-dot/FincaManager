using FincaManager.DataAccess;
using FincaManager.Entities;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Text;

namespace FincaManager.Datos
{
    public class UsuariosDatos
    {
        private readonly ConexionBD _conexionDatos = new ConexionBD();

        public List<UsuariosEntidad> MtdConsultar()
        {
            List<UsuariosEntidad> listaUsuarios = new List<UsuariosEntidad>();

            try
            {
                using (SqlConnection conn = _conexionDatos.MtdObtenerConexion())
                {
                    string QueryConsultar = @"";

                    using (SqlCommand cmd = new SqlCommand(QueryConsultar, conn))
                    {
                        conn.Open();

                        using (SqlDataReader rd = cmd.ExecuteReader())
                        {
                            while (rd.Read())
                            {
                                listaUsuarios.Add(new UsuariosEntidad
                                {
                                    IdUsuario = Convert.ToInt32(rd["IdUsuario"]),
                                    IdRol = Convert.ToInt32(rd["IdRol"]),
                                    Nombre = Convert.ToString(rd["Nombre"]) ?? string.Empty,
                                    Correo = Convert.ToString(rd["Correo"]) ?? string.Empty,
                                    PasswordHash = Convert.ToString(rd["PasswordHash"]) ?? string.Empty,
                                    Activo = Convert.ToBoolean(rd["Activo"]),
                                    Eliminado = Convert.ToBoolean(rd["Eliminado"])
                                });
                            }
                        }
                    }
                }
                return listaUsuarios;
            }
            catch (Exception ex)
            {

                throw new Exception("Error al consultar Usuarios", ex);
            }
        }
    }
}
