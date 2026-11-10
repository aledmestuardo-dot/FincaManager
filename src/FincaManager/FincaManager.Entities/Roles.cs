using System;
using System.Collections.Generic;
using System.Text;

namespace FincaManager.Entities
{
    public class Roles
    {
        private int _idRol;
        private string _nombre;
        private string _descripcion;
        private bool _activo;
        private bool _eliminado;

        public int IdRol
        {
            get { return _idRol; }
            set { _idRol = value; }
        }

        public string Nombre
        {
            get { return _nombre; }
            set { _nombre = value; }
        }

        public string Descripcion
        {
            get { return _descripcion; }
            set { _descripcion = value; }
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

        // Constructor por defecto
        public Roles()
        {
            _idRol = 0;
            _nombre = string.Empty;
            _descripcion = string.Empty;
            _activo = true;
            _eliminado = false;
        }

        // Constructor para Consultar (ideal para registros provenientes de la BD)
        public Roles(
            int idRol,
            string nombre,
            string descripcion,
            bool activo,
            bool eliminado)
        {
            _idRol = idRol;
            _nombre = nombre;
            _descripcion = descripcion;
            _activo = activo;
            _eliminado = eliminado;
        }

        // Constructor para Agregar / Insertar (sin ID, con estados por defecto)
        public Roles(
            string nombre,
            string descripcion)
        {
            _idRol = 0;
            _nombre = nombre;
            _descripcion = descripcion;
            _activo = true;
            _eliminado = false;
        }
    }
}