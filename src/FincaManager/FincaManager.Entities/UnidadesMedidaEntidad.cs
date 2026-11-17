using System;
using System.Collections.Generic;
using System.Text;

namespace FincaManager.Entities
{
    public class UnidadesMedidaEntidad
    {
        private int _idUnidadMedida;
        private string _nombre;
        private string _abreviatura;
        private bool _activo;
        private bool _eliminado;

        public int IdUnidadMedida
        {
            get { return _idUnidadMedida; }
            set { _idUnidadMedida = value; }
        }

        public string Nombre
        {
            get { return _nombre; }
            set { _nombre = value; }
        }

        public string Abreviatura
        {
            get { return _abreviatura; }
            set { _abreviatura = value; }
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
        public UnidadesMedidaEntidad()
        {
            _idUnidadMedida = 0;
            _nombre = string.Empty;
            _abreviatura = string.Empty;
            _activo = true;
            _eliminado = false;
        }

        // Constructor completo (ideal para consultas desde la BD)
        public UnidadesMedidaEntidad(
            int idUnidadMedida,
            string nombre,
            string abreviatura,
            bool activo,
            bool eliminado)
        {
            _idUnidadMedida = idUnidadMedida;
            _nombre = nombre;
            _abreviatura = abreviatura;
            _activo = activo;
            _eliminado = eliminado;
        }

        // Constructor para inserción (sin ID, con estados por defecto)
        public UnidadesMedidaEntidad(
            string nombre,
            string abreviatura)
        {
            _idUnidadMedida = 0;
            _nombre = nombre;
            _abreviatura = abreviatura;
            _activo = true;
            _eliminado = false;
        }
    }
}