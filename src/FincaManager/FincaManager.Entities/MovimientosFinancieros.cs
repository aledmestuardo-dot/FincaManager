using System;
using System.Collections.Generic;
using System.Text;

namespace FincaManager.Entities
{
    public class MovimientosFinancieros
    {
        private int _idMovimientoFinanciero;
        private int _idCuentaFinanciera;
        private string _tipoMovimiento;
        private string _metodoPago;
        private string _numeroBoletaReferencia;
        private decimal _montoQuetzales;
        private DateTime _fecha;
        private string _concepto;

        public int IdMovimientoFinanciero
        {
            get { return _idMovimientoFinanciero; }
            set { _idMovimientoFinanciero = value; }
        }

        public int IdCuentaFinanciera
        {
            get { return _idCuentaFinanciera; }
            set { _idCuentaFinanciera = value; }
        }

        public string TipoMovimiento
        {
            get { return _tipoMovimiento; }
            set { _tipoMovimiento = value; }
        }

        public string MetodoPago
        {
            get { return _metodoPago; }
            set { _metodoPago = value; }
        }

        public string NumeroBoletaReferencia
        {
            get { return _numeroBoletaReferencia; }
            set { _numeroBoletaReferencia = value; }
        }

        public decimal MontoQuetzales
        {
            get { return _montoQuetzales; }
            set { _montoQuetzales = value; }
        }

        public DateTime Fecha
        {
            get { return _fecha; }
            set { _fecha = value; }
        }

        public string Concepto
        {
            get { return _concepto; }
            set { _concepto = value; }
        }

        // Constructor vacío por defecto
        public MovimientosFinancieros()
        {
            _idMovimientoFinanciero = 0;
            _idCuentaFinanciera = 0;
            _tipoMovimiento = string.Empty;
            _metodoPago = string.Empty;
            _numeroBoletaReferencia = string.Empty;
            _montoQuetzales = 0m;
            _fecha = DateTime.Now;
            _concepto = string.Empty;
        }

        // Constructor completo (ideal para consultas desde la BD)
        public MovimientosFinancieros(
            int idMovimientoFinanciero,
            int idCuentaFinanciera,
            string tipoMovimiento,
            string metodoPago,
            string numeroBoletaReferencia,
            decimal montoQuetzales,
            DateTime fecha,
            string concepto)
        {
            _idMovimientoFinanciero = idMovimientoFinanciero;
            _idCuentaFinanciera = idCuentaFinanciera;
            _tipoMovimiento = tipoMovimiento;
            _metodoPago = metodoPago;
            _numeroBoletaReferencia = numeroBoletaReferencia;
            _montoQuetzales = montoQuetzales;
            _fecha = fecha;
            _concepto = concepto;
        }

        // Constructor para inserción (sin ID)
        public MovimientosFinancieros(
            int idCuentaFinanciera,
            string tipoMovimiento,
            string metodoPago,
            string numeroBoletaReferencia,
            decimal montoQuetzales,
            DateTime fecha,
            string concepto)
        {
            _idMovimientoFinanciero = 0;
            _idCuentaFinanciera = idCuentaFinanciera;
            _tipoMovimiento = tipoMovimiento;
            _metodoPago = metodoPago;
            _numeroBoletaReferencia = numeroBoletaReferencia;
            _montoQuetzales = montoQuetzales;
            _fecha = fecha;
            _concepto = concepto;
        }
    }
}