using FincaManager.DataAccess;
using FincaManager.Entities;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Text;

namespace FincaManager.Datos
{
    public class CategoriasDatos
    {
        //Instancias ConexionBD.
        private readonly ConexionBD _conexionDatos = new ConexionBD();
        
        //Crear método consultar.
        public List<CategoriasEntidad> MtdConsultar()
        {
            //Crear una lista de objetos de tipo CategoriasEntidad.
            List<CategoriasEntidad> listaCategorias = new List<CategoriasEntidad>();

            //Crear bloque try - catch.
            try
            {
                //Crear bloque using que extraiga la cadena de conexión y cree el transporte.
                using (SqlConnection conn = _conexionDatos.MtdObtenerConexion())
                {
                    //Crear script de consulta.
                    string QueryConsultar = @"";

                    //Crear bloque using que cree la Consulta
                    using (SqlCommand cmd = new SqlCommand(QueryConsultar, conn))
                    {
                        //Abri la conexión física con la base de datos.
                        conn.Open();

                        //Enviar la consulta a la base de datos.
                        using(SqlDataReader rd = cmd.ExecuteReader())
                        {
                            //Avanzar por cada fila de los resultados extraídos de la base de datos.
                            while (rd.Read())
                            {
                                //Crear costructor que empaca todos los atributos de la fila actual.
                                CategoriasEntidad catergorias = new CategoriasEntidad(
                                    Convert.ToInt32(rd["IdCategoria"]),
                                    Convert.ToString(rd["Nombre"]) ?? string.Empty, //Si lo de la izquierda es nulo lo convierte a lo de la derecha.
                                    Convert.ToBoolean(rd["Activo"]),
                                    Convert.ToBoolean(rd["Eliminado"])
                                    );

                                //Guardar el objeto en la lista.
                                listaCategorias.Add(catergorias);
                            }
                        }
                    }
                }

                //Retornar la lista de objetos.
                return listaCategorias;
            }
            catch (Exception ex)
            {

                throw new Exception("Error al consultar Categorías", ex);
            }
        }
    }
}
