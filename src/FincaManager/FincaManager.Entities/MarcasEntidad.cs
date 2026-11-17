using System;
using System.Collections.Generic;
using System.Text;

namespace FincaManager.Entities
{
    public class MarcasEntidad
    {
        private int _idMarca;
        private string _nombre;
        private bool _activo;
        private bool _eliminado;

        public int IdMarca
        {
            get { return _idMarca; }
            set { _idMarca = value; }
        }

        public string Nombre
        {
            get { return _nombre; }
            set { _nombre = value; }
        }

        public bool Activo
        {
            get { return _activo; }
            set { _activo = value; }
        }

        public bool Eliminado
        {
            get { return _eliminado; }
            set { _eliminado = value; }
        }

        // Constructor vacío por defecto
        public MarcasEntidad()
        {
            _idMarca = 0;
            _nombre = string.Empty;
            _activo = true;
            _eliminado = false;
        }

        // Constructor completo (ideal para consultas desde la BD)
        public MarcasEntidad(int idMarca, string nombre, bool activo, bool eliminado)
        {
            _idMarca = idMarca;
            _nombre = nombre;
            _activo = activo;
            _eliminado = eliminado;
        }

        // Constructor para inserción (sin ID, con estados por defecto)
        public MarcasEntidad(string nombre)
        {
            _idMarca = 0;
            _nombre = nombre;
            _activo = true;
            _eliminado = false;
        }
    }
}