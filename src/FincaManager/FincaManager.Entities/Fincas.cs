using System;
using System.Collections.Generic;
using System.Text;

namespace FincaManager.Entities
{
    public class Fincas
    {
        private int _idFinca;
        private string _nombre;
        private string _ubicacion;
        private decimal _areaTotal;
        private bool _activo;
        private bool _eliminado;

        public int IdFinca
        {
            get { return _idFinca; }
            set { _idFinca = value; }
        }

        public string Nombre
        {
            get { return _nombre; }
            set { _nombre = value; }
        }

        public string Ubicacion
        {
            get { return _ubicacion; }
            set { _ubicacion = value; }
        }

        public decimal AreaTotal
        {
            get { return _areaTotal; }
            set { _areaTotal = value; }
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
        public Fincas()
        {
            _idFinca = 0;
            _nombre = string.Empty;
            _ubicacion = string.Empty;
            _areaTotal = 0m;
            _activo = true;
            _eliminado = false;
        }

        // Constructor completo (ideal para consultas que provienen de la BD)
        public Fincas(
            int idFinca,
            string nombre,
            string ubicacion,
            decimal areaTotal,
            bool activo,
            bool eliminado)
        {
            _idFinca = idFinca;
            _nombre = nombre;
            _ubicacion = ubicacion;
            _areaTotal = areaTotal;
            _activo = activo;
            _eliminado = eliminado;
        }

        // Constructor para inserción (sin ID, con estados por defecto)
        public Fincas(
            string nombre,
            string ubicacion,
            decimal areaTotal)
        {
            _idFinca = 0;
            _nombre = nombre;
            _ubicacion = ubicacion;
            _areaTotal = areaTotal;
            _activo = true;
            _eliminado = false;
        }
    }
}