using System;
using System.Collections.Generic;
using System.Text;

namespace FincaManager.Entities
{
    public class Facturas
    {
        private int _idFactura;
        private int? _idVenta;   // Cambiado a int? porque es NULL en la BD
        private int? _idCompra;  // Cambiado a int? porque es NULL en la BD
        private string _uuidFel;
        private string _serie;
        private string _numero;
        private DateTime _fechaEmision;
        private decimal _montoTotal;

        public int IdFactura
        {
            get { return _idFactura; }
            set { _idFactura = value; }
        }

        public int? IdVenta
        {
            get { return _idVenta; }
            set { _idVenta = value; }
        }

        public int? IdCompra
        {
            get { return _idCompra; }
            set { _idCompra = value; }
        }

        public string UuidFel
        {
            get { return _uuidFel; }
            set { _uuidFel = value; }
        }

        public string Serie
        {
            get { return _serie; }
            set { _serie = value; }
        }

        public string Numero
        {
            get { return _numero; }
            set { _numero = value; }
        }

        public DateTime FechaEmision
        {
            get { return _fechaEmision; }
            set { _fechaEmision = value; }
        }

        public decimal MontoTotal
        {
            get { return _montoTotal; }
            set { _montoTotal = value; }
        }

        // Constructor vacío por defecto
        public Facturas()
        {
            _idFactura = 0;
            _idVenta = null;
            _idCompra = null;
            _uuidFel = string.Empty;
            _serie = string.Empty;
            _numero = string.Empty;
            _fechaEmision = DateTime.Now;
            _montoTotal = 0m;
        }

        // Constructor completo (ideal para consultas desde la BD)
        public Facturas(
            int idFactura,
            int? idVenta,
            int? idCompra,
            string uuidFel,
            string serie,
            string numero,
            DateTime fechaEmision,
            decimal montoTotal)
        {
            _idFactura = idFactura;
            _idVenta = idVenta;
            _idCompra = idCompra;
            _uuidFel = uuidFel;
            _serie = serie;
            _numero = numero;
            _fechaEmision = fechaEmision;
            _montoTotal = montoTotal;
        }

        // Constructor para inserción (sin ID)
        public Facturas(
            int? idVenta,
            int? idCompra,
            string uuidFel,
            string serie,
            string numero,
            DateTime fechaEmision,
            decimal montoTotal)
        {
            _idFactura = 0;
            _idVenta = idVenta;
            _idCompra = idCompra;
            _uuidFel = uuidFel;
            _serie = serie;
            _numero = numero;
            _fechaEmision = fechaEmision;
            _montoTotal = montoTotal;
        }
    }
}