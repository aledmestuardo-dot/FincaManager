using FincaManager.DataAccess;
using FincaManager.Entities;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;

namespace FincaManager.DataAccess
{
    public class MarcasDatos
    {
        // Instancia privada de ConexionBD para poder solicitar conexiones a la base de datos.
        private readonly ConexionBD _conexionDatos = new ConexionBD();

        // =====================================================
        // CRUD: CONSULTAR
        // =====================================================
        public List<MarcasEntidad> MtdConsultar() // Método público que devolverá una lista de objetos MarcasEntidad.
        {
            List<MarcasEntidad> listaMarcas = new List<MarcasEntidad>(); // Crea la lista vacía donde se guardarán las marcas.

            try // Inicia el bloque vigilado para capturar posibles fallos de conexión o SQL.
            {
                // Crea la conexión ("tubería") usando la cadena de ConexionBD. 
                // El bloque 'using' asegura que la conexión se cierre y libere automáticamente al terminar.
                using (SqlConnection conn = _conexionDatos.MtdObtenerConexion())
                {
                    // Define la consulta T-SQL que traerá solo las marcas que no han sido eliminadas lógicamente.
                    string QueryConsultar = @"
                SELECT 
                    IdMarca,
                    Nombre,
                    Activo,
                    Eliminado
                FROM Tbl_Marcas
                WHERE Eliminado = 0;";

                    // Prepara el comando vinculando la consulta SQL con la conexión abierta.
                    using (SqlCommand cmd = new SqlCommand(QueryConsultar, conn))
                    {
                        conn.Open(); // Abre físicamente la sesión con SQL Server.

                        // Envía la consulta a SQL Server (ExecuteReader) y obtiene un lector (rd) posicionado antes de la primera fila.
                        using (SqlDataReader rd = cmd.ExecuteReader())
                        {
                            // Avanza fila por fila en los resultados; devuelve true mientras queden registros por leer.
                            while (rd.Read())
                            {
                                // Toma los 4 datos crudos de la fila actual (rd["Columna"]), los convierte al tipo de dato
                                // de C# correspondiente y los "empaca" creando un nuevo objeto MarcasEntidad.
                                MarcasEntidad marcas = new MarcasEntidad(
                                    Convert.ToInt32(rd["IdMarca"]),
                                    Convert.ToString(rd["Nombre"]) ?? string.Empty,
                                    Convert.ToBoolean(rd["Activo"]),
                                    Convert.ToBoolean(rd["Eliminado"])
                                );

                                // Guarda el objeto ya armado dentro de la lista.
                                listaMarcas.Add(marcas);
                            }
                        }
                    }
                }

                // Devuelve la lista completa con todos los objetos MarcasEntidad hacia la capa que llamó al método.
                return listaMarcas;
            }
            catch (Exception ex) // Si ocurre cualquier error técnico dentro del 'try', lo atrapa en 'ex'.
            {
                // Lanza el error hacia la capa superior con un mensaje claro, adjuntando el error original (ex).
                throw new Exception("Error al consultar Marcas", ex);
            }
        }

        // =====================================================
        // CRUD: OBTENER POR ID
        // =====================================================
        public MarcasEntidad? MtdObtenerPorId(int idMarca)
        {
            MarcasEntidad? marcas = null;

            try
            {
                using (SqlConnection conn = _conexionDatos.MtdObtenerConexion())
                {
                    string QueryObtenerPorId = @"
                        SELECT 
                            IdMarca,
                            Nombre,
                            Activo,
                            Eliminado
                        FROM Tbl_Marcas
                        WHERE IdMarca = @IdMarca AND Eliminado = 0;";

                    using (SqlCommand cmd = new SqlCommand(QueryObtenerPorId, conn))
                    {
                        cmd.Parameters.AddWithValue("@IdMarca", idMarca);
                        conn.Open();

                        using (SqlDataReader rd = cmd.ExecuteReader())
                        {
                            if (rd.Read())
                            {
                                marcas = new MarcasEntidad(
                                    Convert.ToInt32(rd["IdMarca"]),
                                    Convert.ToString(rd["Nombre"]) ?? string.Empty,
                                    Convert.ToBoolean(rd["Activo"]),
                                    Convert.ToBoolean(rd["Eliminado"])
                                );
                            }
                        }
                    }
                }

                return marcas;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener la Marca por ID", ex);
            }
        }

        // =====================================================
        // CRUD: AGREGAR
        // =====================================================
        public bool MtdAgregar(MarcasEntidad marcas)
        {
            try
            {
                using (SqlConnection conn = _conexionDatos.MtdObtenerConexion())
                {
                    string QueryAgregar = @"
                        INSERT INTO Tbl_Marcas (Nombre, Activo, Eliminado)
                        VALUES (@Nombre, @Activo, @Eliminado);";

                    using (SqlCommand cmd = new SqlCommand(QueryAgregar, conn))
                    {
                        cmd.Parameters.AddWithValue("@Nombre", marcas.Nombre);
                        cmd.Parameters.AddWithValue("@Activo", marcas.Activo);
                        cmd.Parameters.AddWithValue("@Eliminado", marcas.Eliminado);

                        conn.Open();
                        return cmd.ExecuteNonQuery() > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al agregar la Marca", ex);
            }
        }

        // =====================================================
        // CRUD: ACTUALIZAR
        // =====================================================
        public bool MtdActualizar(MarcasEntidad marcas)
        {
            try
            {
                using (SqlConnection conn = _conexionDatos.MtdObtenerConexion())
                {
                    string QueryActualizar = @"
                        UPDATE Tbl_Marcas
                        SET 
                            Nombre = @Nombre,
                            Activo = @Activo
                        WHERE IdMarca = @IdMarca AND Eliminado = 0;";

                    using (SqlCommand cmd = new SqlCommand(QueryActualizar, conn))
                    {
                        cmd.Parameters.AddWithValue("@IdMarca", marcas.IdMarca);
                        cmd.Parameters.AddWithValue("@Nombre", marcas.Nombre);
                        cmd.Parameters.AddWithValue("@Activo", marcas.Activo);

                        conn.Open();
                        return cmd.ExecuteNonQuery() > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al actualizar la Marca", ex);
            }
        }

        // =====================================================
        // CRUD: ELIMINAR (Borrado Lógico)
        // =====================================================
        public bool MtdEliminar(int idMarca)
        {
            try
            {
                using (SqlConnection conn = _conexionDatos.MtdObtenerConexion())
                {
                    string QueryEliminar = @"
                        UPDATE Tbl_Marcas
                        SET 
                            Eliminado = 1,
                            Activo = 0
                        WHERE IdMarca = @IdMarca;";

                    using (SqlCommand cmd = new SqlCommand(QueryEliminar, conn))
                    {
                        cmd.Parameters.AddWithValue("@IdMarca", idMarca);

                        conn.Open();
                        return cmd.ExecuteNonQuery() > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al eliminar lógicamente la Marca", ex);
            }
        }
    }
}