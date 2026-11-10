using System;
using System.Collections.Generic;
using System.Text;

namespace FincaManager.Entities
{
    public class Kardex
    {
        private int _idKardex;
        private int _idProducto;
        private string _tipoMovimiento;
        private decimal _cantidadUnidades;
        private decimal _pesoAparente;
        private decimal _pesoReal;
        private decimal _costoUnitarioQuetzales;
        private DateTime _fecha;

        public int IdKardex
        {
            get { return _idKardex; }
            set { _idKardex = value; }
        }

        public int IdProducto
        {
            get { return _idProducto; }
            set { _idProducto = value; }
        }

        public string TipoMovimiento
        {
            get { return _tipoMovimiento; }
            set { _tipoMovimiento = value; }
        }

        public decimal CantidadUnidades
        {
            get { return _cantidadUnidades; }
            set { _cantidadUnidades = value; }
        }

        public decimal PesoAparente
        {
            get { return _pesoAparente; }
            set { _pesoAparente = value; }
        }

        public decimal PesoReal
        {
            get { return _pesoReal; }
            set { _pesoReal = value; }
        }

        public decimal CostoUnitarioQuetzales
        {
            get { return _costoUnitarioQuetzales; }
            set { _costoUnitarioQuetzales = value; }
        }

        public DateTime Fecha
        {
            get { return _fecha; }
            set { _fecha = value; }
        }

        // Constructor vacío por defecto
        public Kardex()
        {
            _idKardex = 0;
            _idProducto = 0;
            _tipoMovimiento = string.Empty;
            _cantidadUnidades = 0m;
            _pesoAparente = 0m;
            _pesoReal = 0m;
            _costoUnitarioQuetzales = 0m;
            _fecha = DateTime.Now;
        }

        // Constructor completo (ideal para consultas desde la BD)
        public Kardex(
            int idKardex,
            int idProducto,
            string tipoMovimiento,
            decimal cantidadUnidades,
            decimal pesoAparente,
            decimal pesoReal,
            decimal costoUnitarioQuetzales,
            DateTime fecha)
        {
            _idKardex = idKardex;
            _idProducto = idProducto;
            _tipoMovimiento = tipoMovimiento;
            _cantidadUnidades = cantidadUnidades;
            _pesoAparente = pesoAparente;
            _pesoReal = pesoReal;
            _costoUnitarioQuetzales = costoUnitarioQuetzales;
            _fecha = fecha;
        }

        // Constructor para inserción (sin ID)
        public Kardex(
            int idProducto,
            string tipoMovimiento,
            decimal cantidadUnidades,
            decimal pesoAparente,
            decimal pesoReal,
            decimal costoUnitarioQuetzales,
            DateTime fecha)
        {
            _idKardex = 0;
            _idProducto = idProducto;
            _tipoMovimiento = tipoMovimiento;
            _cantidadUnidades = cantidadUnidades;
            _pesoAparente = pesoAparente;
            _pesoReal = pesoReal;
            _costoUnitarioQuetzales = costoUnitarioQuetzales;
            _fecha = fecha;
        }
    }
}