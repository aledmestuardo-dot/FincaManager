using System;
using System.Collections.Generic;
using System.Text;

namespace FincaManager.Entities
{
    public class ParametrosSistema
    {
        private int _idParametro;
        private string _clave;
        private string _valor;
        private string _descripcion;
        private bool _activo;
        private bool _eliminado;

        public int IdParametro
        {
            get { return _idParametro; }
            set { _idParametro = value; }
        }

        public string Clave
        {
            get { return _clave; }
            set { _clave = value; }
        }

        public string Valor
        {
            get { return _valor; }
            set { _valor = value; }
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

        // Constructor vacío por defecto
        public ParametrosSistema()
        {
            _idParametro = 0;
            _clave = string.Empty;
            _valor = string.Empty;
            _descripcion = string.Empty;
            _activo = true;
            _eliminado = false;
        }

        // Constructor completo (ideal para consultas desde la BD)
        public ParametrosSistema(
            int idParametro,
            string clave,
            string valor,
            string descripcion,
            bool activo,
            bool eliminado)
        {
            _idParametro = idParametro;
            _clave = clave;
            _valor = valor;
            _descripcion = descripcion;
            _activo = activo;
            _eliminado = eliminado;
        }

        // Constructor para inserción (sin ID, con estados por defecto)
        public ParametrosSistema(
            string clave,
            string valor,
            string descripcion)
        {
            _idParametro = 0;
            _clave = clave;
            _valor = valor;
            _descripcion = descripcion;
            _activo = true;
            _eliminado = false;
        }
    }
}