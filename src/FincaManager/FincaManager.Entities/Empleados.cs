using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace FincaManager.Entities
{
    public class Empleados
    {
        private int _idEmpleado;
        private string _nombres;
        private string _apellidos;
        private string _dpi;
        private string _telefono;
        private bool _activo;
        private bool _eliminado; // Añadido para el borrado lógico

        public int IdEmpleado
        {
            get { return _idEmpleado; }
            set { _idEmpleado = value; }
        }

        public string Nombres
        {
            get { return _nombres; }
            set { _nombres = value; }
        }

        public string Apellidos
        {
            get { return _apellidos; }
            set { _apellidos = value; }
        }

        public string DPI
        {
            get { return _dpi; }
            set { _dpi = value; }
        }

        public string Telefono
        {
            get { return _telefono; }
            set { _telefono = value; }
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
        public Empleados()
        {
            _idEmpleado = 0;
            _nombres = string.Empty;
            _apellidos = string.Empty;
            _dpi = string.Empty;
            _telefono = string.Empty;
            _activo = true;
            _eliminado = false;
        }

        // Constructor completo (ideal para consultas que provienen de la BD)
        public Empleados(
            int idEmpleado,
            string nombres,
            string apellidos,
            string dpi,
            string telefono,
            bool activo,
            bool eliminado)
        {
            _idEmpleado = idEmpleado;
            _nombres = nombres;
            _apellidos = apellidos;
            _dpi = dpi;
            _telefono = telefono;
            _activo = activo;
            _eliminado = eliminado;
        }

        // Constructor para inserción (sin ID, con estados por defecto)
        public Empleados(
            string nombres,
            string apellidos,
            string dpi,
            string telefono)
        {
            _idEmpleado = 0;
            _nombres = nombres;
            _apellidos = apellidos;
            _dpi = dpi;
            _telefono = telefono;
            _activo = true;
            _eliminado = false;
        }
    }
}