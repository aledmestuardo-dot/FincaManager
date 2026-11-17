using System;
using System.Collections.Generic;
using System.Text;

namespace FincaManager.Entities
{
    public class PeriodosCosechaEntidad
    {
        private int _idPeriodo;
        private string _nombre;
        private DateTime _fechaInicio;
        private DateTime _fechaFin;
        private bool _activo;
        private bool _eliminado; // Añadido para el borrado lógico

        public int IdPeriodo
        {
            get { return _idPeriodo; }
            set { _idPeriodo = value; }
        }

        public string Nombre
        {
            get { return _nombre; }
            set { _nombre = value; }
        }

        public DateTime FechaInicio
        {
            get { return _fechaInicio; }
            set { _fechaInicio = value; }
        }

        public DateTime FechaFin
        {
            get { return _fechaFin; }
            set { _fechaFin = value; }
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
        public PeriodosCosechaEntidad()
        {
            _idPeriodo = 0;
            _nombre = string.Empty;
            _fechaInicio = DateTime.Now;
            _fechaFin = DateTime.Now;
            _activo = true;
            _eliminado = false;
        }

        // Constructor completo (ideal para consultas desde la BD)
        public PeriodosCosechaEntidad(
            int idPeriodo,
            string nombre,
            DateTime fechaInicio,
            DateTime fechaFin,
            bool activo,
            bool eliminado)
        {
            _idPeriodo = idPeriodo;
            _nombre = nombre;
            _fechaInicio = fechaInicio;
            _fechaFin = fechaFin;
            _activo = activo;
            _eliminado = eliminado;
        }

        // Constructor para inserción (sin ID, con estados por defecto)
        public PeriodosCosechaEntidad(
            string nombre,
            DateTime fechaInicio,
            DateTime fechaFin,
            bool activo)
        {
            _idPeriodo = 0;
            _nombre = nombre;
            _fechaInicio = fechaInicio;
            _fechaFin = fechaFin;
            _activo = activo;
            _eliminado = false;
        }
    }
}