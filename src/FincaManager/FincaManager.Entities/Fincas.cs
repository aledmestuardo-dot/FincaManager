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

        public Fincas()
        {
            _idFinca = 0;
            _nombre = string.Empty;
            _ubicacion = string.Empty;
            _areaTotal = 0m;
        }
        public Fincas(
            int idFinca,
            string nombre,
            string ubicacion,
            decimal areaTotal)
        {
            _idFinca = idFinca;
            _nombre = nombre;
            _ubicacion = ubicacion;
            _areaTotal = areaTotal;
        }
        public Fincas(
            string nombre,
            string ubicacion,
            decimal areaTotal)
        {
            _idFinca = 0;
            _nombre = nombre;
            _ubicacion = ubicacion;
            _areaTotal = areaTotal;
        }
    }
}
