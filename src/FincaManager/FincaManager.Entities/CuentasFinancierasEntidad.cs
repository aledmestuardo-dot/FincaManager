using System;
using System.Collections.Generic;
using System.Text;

namespace FincaManager.Entities
{
    public class CuentasFinancierasEntidad
    {
        private int _idCuentaFinanciera;
        private string _nombre;
        private string _tipo;
        private string _numeroCuenta;
        private string _nombreBanco;
        private bool _activo;
        private bool _eliminado; // Añadido para el borrado lógico
        private decimal _saldoActualQuetzales;

        public int IdCuentaFinanciera
        {
            get { return _idCuentaFinanciera; }
            set { _idCuentaFinanciera = value; }
        }

        public string Nombre
        {
            get { return _nombre; }
            set { _nombre = value; }
        }

        public string Tipo
        {
            get { return _tipo; }
            set { _tipo = value; }
        }

        public string NumeroCuenta
        {
            get { return _numeroCuenta; }
            set { _numeroCuenta = value; }
        }

        public string NombreBanco
        {
            get { return _nombreBanco; }
            set { _nombreBanco = value; }
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

        public decimal SaldoActualQuetzales
        {
            get { return _saldoActualQuetzales; }
            set { _saldoActualQuetzales = value; }
        }

        // Constructor vacío por defecto
        public CuentasFinancierasEntidad()
        {
            _idCuentaFinanciera = 0;
            _nombre = string.Empty;
            _tipo = string.Empty;
            _numeroCuenta = string.Empty;
            _nombreBanco = string.Empty;
            _activo = true;
            _eliminado = false;
            _saldoActualQuetzales = 0m;
        }

        // Constructor completo (ideal para consultas que provienen de la BD)
        public CuentasFinancierasEntidad(
            int idCuentaFinanciera,
            string nombre,
            string tipo,
            string numeroCuenta,
            string nombreBanco,
            bool activo,
            bool eliminado,
            decimal saldoActualQuetzales)
        {
            _idCuentaFinanciera = idCuentaFinanciera;
            _nombre = nombre;
            _tipo = tipo;
            _numeroCuenta = numeroCuenta;
            _nombreBanco = nombreBanco;
            _activo = activo;
            _eliminado = eliminado;
            _saldoActualQuetzales = saldoActualQuetzales;
        }

        // Constructor para inserción (sin ID, con estados por defecto)
        public CuentasFinancierasEntidad(
            string nombre,
            string tipo,
            string numeroCuenta,
            string nombreBanco,
            decimal saldoActualQuetzales)
        {
            _idCuentaFinanciera = 0;
            _nombre = nombre;
            _tipo = tipo;
            _numeroCuenta = numeroCuenta;
            _nombreBanco = nombreBanco;
            _activo = true;
            _eliminado = false;
            _saldoActualQuetzales = saldoActualQuetzales;
        }
    }
}