using System;
using System.Collections.Generic;
using System.Text;

namespace FincaManager.Entities
{
    public class RecibosEntidad
    {
        private int _idRecibo;
        private int? _idEmpleado; // Ajustado a int? según la BD (Tbl_Recibos)
        private int? _idProveedor; // Ajustado a int? según la BD (Tbl_Recibos)
        private string _correlativoInterno;
        private DateTime _fecha;
        private decimal _montoTotalQuetzales;
        private string _concepto;

        public int IdRecibo
        {
            get { return _idRecibo; }
            set { _idRecibo = value; }
        }

        public int? IdEmpleado
        {
            get { return _idEmpleado; }
            set { _idEmpleado = value; }
        }

        public int? IdProveedor
        {
            get { return _idProveedor; }
            set { _idProveedor = value; }
        }

        public string CorrelativoInterno
        {
            get { return _correlativoInterno; }
            set { _correlativoInterno = value; }
        }

        public DateTime Fecha
        {
            get { return _fecha; }
            set { _fecha = value; }
        }

        public decimal MontoTotalQuetzales
        {
            get { return _montoTotalQuetzales; }
            set { _montoTotalQuetzales = value; }
        }

        public string Concepto
        {
            get { return _concepto; }
            set { _concepto = value; }
        }

        // Constructor vacío por defecto
        public RecibosEntidad()
        {
            _idRecibo = 0;
            _idEmpleado = null;
            _idProveedor = null;
            _correlativoInterno = string.Empty;
            _fecha = DateTime.Now;
            _montoTotalQuetzales = 0m;
            _concepto = string.Empty;
        }

        // Constructor completo (ideal para consultas desde la BD)
        public RecibosEntidad(
            int idRecibo,
            int? idEmpleado,
            int? idProveedor,
            string correlativoInterno,
            DateTime fecha,
            decimal montoTotalQuetzales,
            string concepto)
        {
            _idRecibo = idRecibo;
            _idEmpleado = idEmpleado;
            _idProveedor = idProveedor;
            _correlativoInterno = correlativoInterno;
            _fecha = fecha;
            _montoTotalQuetzales = montoTotalQuetzales;
            _concepto = concepto;
        }

        // Constructor para inserción (sin ID)
        public RecibosEntidad(
            int? idEmpleado,
            int? idProveedor,
            string correlativoInterno,
            DateTime fecha,
            decimal montoTotalQuetzales,
            string concepto)
        {
            _idRecibo = 0;
            _idEmpleado = idEmpleado;
            _idProveedor = idProveedor;
            _correlativoInterno = correlativoInterno;
            _fecha = fecha;
            _montoTotalQuetzales = montoTotalQuetzales;
            _concepto = concepto;
        }
    }
}