using System;
using System.Collections.Generic;
using System.Text;

namespace FincaManager.Entities
{
    public class LotesSectores
    {
        private int _idLoteSector;
        private int _idFinca;
        private string _nombre;
        private decimal _areaTrabajableMetros;
        private int _totalPlantas;
        private string _variedadCultivo;
        private bool _activo;
        private bool _eliminado;

        public int IdLoteSector
        {
            get { return _idLoteSector; }
            set { _idLoteSector = value; }
        }

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

        public decimal AreaTrabajableMetros
        {
            get { return _areaTrabajableMetros; }
            set { _areaTrabajableMetros = value; }
        }

        public int TotalPlantas
        {
            get { return _totalPlantas; }
            set { _totalPlantas = value; }
        }

        public string VariedadCultivo
        {
            get { return _variedadCultivo; }
            set { _variedadCultivo = value; }
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
        public LotesSectores()
        {
            _idLoteSector = 0;
            _idFinca = 0;
            _nombre = string.Empty;
            _areaTrabajableMetros = 0m;
            _totalPlantas = 0;
            _variedadCultivo = string.Empty;
            _activo = true;
            _eliminado = false;
        }

        // Constructor completo (ideal para consultas desde la BD)
        public LotesSectores(
            int idLoteSector,
            int idFinca,
            string nombre,
            decimal areaTrabajableMetros,
            int totalPlantas,
            string variedadCultivo,
            bool activo,
            bool eliminado)
        {
            _idLoteSector = idLoteSector;
            _idFinca = idFinca;
            _nombre = nombre;
            _areaTrabajableMetros = areaTrabajableMetros;
            _totalPlantas = totalPlantas;
            _variedadCultivo = variedadCultivo;
            _activo = activo;
            _eliminado = eliminado;
        }

        // Constructor para inserción (sin ID, con estados por defecto)
        public LotesSectores(
            int idFinca,
            string nombre,
            decimal areaTrabajableMetros,
            int totalPlantas,
            string variedadCultivo)
        {
            _idLoteSector = 0;
            _idFinca = idFinca;
            _nombre = nombre;
            _areaTrabajableMetros = areaTrabajableMetros;
            _totalPlantas = totalPlantas;
            _variedadCultivo = variedadCultivo;
            _activo = true;
            _eliminado = false;
        }
    }
}