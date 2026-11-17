using System;
using System.Collections.Generic;
using System.Text;

namespace FincaManager.Entities
{
    public class ProveedoresEntidad
    {
        private int _idProveedor;
        private string _nit;
        private string _nombreRazonSocial;
        private string _direccion;
        private string _telefono;
        private bool _activo;
        private bool _eliminado; // Añadido para el borrado lógico

        public int IdProveedor
        {
            get { return _idProveedor; }
            set { _idProveedor = value; }
        }

        public string Nit
        {
            get { return _nit; }
            set { _nit = value; }
        }

        public string NombreRazonSocial
        {
            get { return _nombreRazonSocial; }
            set { _nombreRazonSocial = value; }
        }

        public string Direccion
        {
            get { return _direccion; }
            set { _direccion = value; }
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
        public ProveedoresEntidad()
        {
            _idProveedor = 0;
            _nit = string.Empty;
            _nombreRazonSocial = string.Empty;
            _direccion = string.Empty;
            _telefono = string.Empty;
            _activo = true;
            _eliminado = false;
        }

        // Constructor completo (ideal para consultas desde la BD)
        public ProveedoresEntidad(
            int idProveedor,
            string nit,
            string nombreRazonSocial,
            string direccion,
            string telefono,
            bool activo,
            bool eliminado)
        {
            _idProveedor = idProveedor;
            _nit = nit;
            _nombreRazonSocial = nombreRazonSocial;
            _direccion = direccion;
            _telefono = telefono;
            _activo = activo;
            _eliminado = eliminado;
        }

        // Constructor para inserción (sin ID, con estados por defecto)
        public ProveedoresEntidad(
            string nit,
            string nombreRazonSocial,
            string direccion,
            string telefono)
        {
            _idProveedor = 0;
            _nit = nit;
            _nombreRazonSocial = nombreRazonSocial;
            _direccion = direccion;
            _telefono = telefono;
            _activo = true;
            _eliminado = false;
        }
    }
}