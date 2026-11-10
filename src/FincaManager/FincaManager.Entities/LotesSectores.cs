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
        public LotesSectores()
        {
            _idLoteSector = 0;
            _idFinca = 0;
            _nombre = string.Empty;
            _areaTrabajableMetros = 0m;
            _totalPlantas = 0;
            _variedadCultivo = string.Empty;
        }
        public LotesSectores(
            int idLoteSector,
            int idFinca,
            string nombre,
            decimal areaTrabajableMetros,
            int totalPlantas,
            string variedadCultivo)
        {
            _idLoteSector = idLoteSector;
            _idFinca = idFinca;
            _nombre = nombre;
            _areaTrabajableMetros = areaTrabajableMetros;
            _totalPlantas = totalPlantas;
            _variedadCultivo = variedadCultivo;
        }
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
        }
    }
}
