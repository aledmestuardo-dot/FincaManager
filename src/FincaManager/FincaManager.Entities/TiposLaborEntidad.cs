using System;
using System.Collections.Generic;
using System.Text;

namespace FincaManager.Entities
{
    public class TiposLaborEntidad
    {
        private int _idTipoLabor;
        private string _nombre;
        private string _tipoPago;
        private decimal _tarifaBaseQuetzales;
        private string _horarioSugerido;
        private bool _activo;
        private bool _eliminado;

        public int IdTipoLabor
        {
            get { return _idTipoLabor; }
            set { _idTipoLabor = value; }
        }

        public string Nombre
        {
            get { return _nombre; }
            set { _nombre = value; }
        }

        public string TipoPago
        {
            get { return _tipoPago; }
            set { _tipoPago = value; }
        }

        public decimal TarifaBaseQuetzales
        {
            get { return _tarifaBaseQuetzales; }
            set { _tarifaBaseQuetzales = value; }
        }

        public string HorarioSugerido
        {
            get { return _horarioSugerido; }
            set { _horarioSugerido = value; }
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
        public TiposLaborEntidad()
        {
            _idTipoLabor = 0;
            _nombre = string.Empty;
            _tipoPago = string.Empty;
            _tarifaBaseQuetzales = 0m;
            _horarioSugerido = string.Empty;
            _activo = true;
            _eliminado = false;
        }

        // Constructor completo (ideal para consultas desde la BD)
        public TiposLaborEntidad(
            int idTipoLabor,
            string nombre,
            string tipoPago,
            decimal tarifaBaseQuetzales,
            string horarioSugerido,
            bool activo,
            bool eliminado)
        {
            _idTipoLabor = idTipoLabor;
            _nombre = nombre;
            _tipoPago = tipoPago;
            _tarifaBaseQuetzales = tarifaBaseQuetzales;
            _horarioSugerido = horarioSugerido;
            _activo = activo;
            _eliminado = eliminado;
        }

        // Constructor para inserción (sin ID, con estados por defecto)
        public TiposLaborEntidad(
            string nombre,
            string tipoPago,
            decimal tarifaBaseQuetzales,
            string horarioSugerido)
        {
            _idTipoLabor = 0;
            _nombre = nombre;
            _tipoPago = tipoPago;
            _tarifaBaseQuetzales = tarifaBaseQuetzales;
            _horarioSugerido = horarioSugerido;
            _activo = true;
            _eliminado = false;
        }
    }
}