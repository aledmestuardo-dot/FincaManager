using System;
using System.Collections.Generic;
using System.Text;

namespace FincaManager.Entities
{
    public class TiposLabor
    {
        private int _idTipoLabor;
        private string _nombre;
        private string _tipoPago;
        private decimal _tarifaBaseQuetzales;
        private string _horarioSugerido;
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
        public TiposLabor()
        {
            _idTipoLabor = 0;
            _nombre = string.Empty;
            _tipoPago = string.Empty;
            _tarifaBaseQuetzales = 0m;
            _horarioSugerido = string.Empty;
        }
        public TiposLabor(
            int idTipoLabor,
            string nombre,
            string tipoPago,
            decimal tarifaBaseQuetzales,
            string horarioSugerido)
        {
            _idTipoLabor = idTipoLabor;
            _nombre = nombre;
            _tipoPago = tipoPago;
            _tarifaBaseQuetzales = tarifaBaseQuetzales;
            _horarioSugerido = horarioSugerido;
        }
        public TiposLabor(
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
        }
    }
}
