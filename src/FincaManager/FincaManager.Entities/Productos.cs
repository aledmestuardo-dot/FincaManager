using System;
using System.Collections.Generic;
using System.Text;

namespace FincaManager.Entities
{
    public class Productos
    {
        private int _idProducto;
        private int _idCategoria;
        private int _idMarca;
        private int _idUnidadMedida;
        private string _nombre;
        private decimal _pesoProducto;
        private decimal _cantidadMedidas;
        private decimal _stockMinimo;
        private bool _activo;
        public int IdProducto
        {
            get { return _idProducto; }
            set { _idProducto = value; }
        }
        public int IdCategoria
        {
            get { return _idCategoria; }
            set { _idCategoria = value; }
        }
        public int IdMarca
        {
            get { return _idMarca; }
            set { _idCategoria = value; }
        }
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
        public decimal PesoProducto
        {
            get { return _pesoProducto; }
            set { _pesoProducto = value; }
        }
        public decimal CantidadMedidas
        {
            get { return _cantidadMedidas; }
            set { _cantidadMedidas = value; }
        }
        public decimal StockMinimo
        {
            get { return _stockMinimo; }
            set { _stockMinimo = value; }
        }
        public bool Activo
        {
            get { return _activo; }
            set { _activo = value; }
        }
        public Productos()
        {
            _idProducto = 0;
            _idCategoria = 0;
            _idMarca = 0;
            _idUnidadMedida = 0;
            _nombre = string.Empty;
            _pesoProducto = 0m;
            _cantidadMedidas = 0m;
            _stockMinimo = 0m;
            _activo = true;
        }
        public Productos(
            int idProducto,
            int IdCategoria,
            int idMarca,
            int idUnidadMedida,
            string nombre,
            decimal pesoProducto,
            decimal cantidadMedidas,
            decimal stockMinimo,
            bool activo)
        {
            _idProducto = idProducto;
            _idCategoria = IdCategoria;
            _idMarca = idMarca;
            _idUnidadMedida = idUnidadMedida;
            _nombre = nombre;
            _pesoProducto = pesoProducto;
            _cantidadMedidas = cantidadMedidas;
            _stockMinimo = stockMinimo;
            _activo = activo;
        }
        public Productos(
            int IdCategoria,
            int idMarca,
            int idUnidadMedida,
            string nombre,
            decimal pesoProducto,
            decimal cantidadMedidas,
            decimal stockMinimo,
            bool activo)
        {
            _idProducto = 0;
            _idCategoria = IdCategoria;
            _idMarca = idMarca;
            _idUnidadMedida = idUnidadMedida;
            _nombre = nombre;
            _pesoProducto = pesoProducto;
            _cantidadMedidas = cantidadMedidas;
            _stockMinimo = stockMinimo;
            _activo = activo;
        }
    }
}
