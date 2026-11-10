using System;
using System.Collections.Generic;
using System.Text;

namespace FincaManager.Entities
{
    public class RegistrosJornada
    {
        private int _idRegistroJornada;
        private int _idEmpleado;
        private int _idLoteSector; // Normalizado sin 's' extra
        private int _idTipoLabor;
        private int _idPeriodoCosecha;
        private DateTime _fecha;
        private decimal _cantidadRealizada;
        private decimal _totalPagadoQuetzales;

        public int IdRegistroJornada
        {
            get { return _idRegistroJornada; }
            set { _idRegistroJornada = value; }
        }

        public int IdEmpleado
        {
            get { return _idEmpleado; }
            set { _idEmpleado = value; }
        }

        public int IdLoteSector
        {
            get { return _idLoteSector; }
            set { _idLoteSector = value; }
        }

        public int IdTipoLabor
        {
            get { return _idTipoLabor; }
            set { _idTipoLabor = value; }
        }

        public int IdPeriodoCosecha
        {
            get { return _idPeriodoCosecha; }
            set { _idPeriodoCosecha = value; }
        }

        public DateTime Fecha
        {
            get { return _fecha; }
            set { _fecha = value; }
        }

        public decimal CantidadRealizada
        {
            get { return _cantidadRealizada; }
            set { _cantidadRealizada = value; }
        }

        public decimal TotalPagadoQuetzales
        {
            get { return _totalPagadoQuetzales; }
            set { _totalPagadoQuetzales = value; }
        }

        // Constructor vacío por defecto
        public RegistrosJornada()
        {
            _idRegistroJornada = 0;
            _idEmpleado = 0;
            _idLoteSector = 0;
            _idTipoLabor = 0;
            _idPeriodoCosecha = 0;
            _fecha = DateTime.Now;
            _cantidadRealizada = 0m;
            _totalPagadoQuetzales = 0m;
        }

        // Constructor completo (ideal para consultas desde la BD)
        public RegistrosJornada(
            int idRegistroJornada,
            int idEmpleado,
            int idLoteSector,
            int idTipoLabor,
            int idPeriodoCosecha,
            DateTime fecha,
            decimal cantidadRealizada,
            decimal totalPagadoQuetzales)
        {
            _idRegistroJornada = idRegistroJornada; // Corregido el error de asignación
            _idEmpleado = idEmpleado;
            _idLoteSector = idLoteSector;
            _idTipoLabor = idTipoLabor;
            _idPeriodoCosecha = idPeriodoCosecha;
            _fecha = fecha;
            _cantidadRealizada = cantidadRealizada;
            _totalPagadoQuetzales = totalPagadoQuetzales;
        }

        // Constructor para inserción (sin ID)
        public RegistrosJornada(
            int idEmpleado,
            int idLoteSector,
            int idTipoLabor,
            int idPeriodoCosecha,
            DateTime fecha,
            decimal cantidadRealizada,
            decimal totalPagadoQuetzales)
        {
            _idRegistroJornada = 0;
            _idEmpleado = idEmpleado;
            _idLoteSector = idLoteSector;
            _idTipoLabor = idTipoLabor;
            _idPeriodoCosecha = idPeriodoCosecha;
            _fecha = fecha;
            _cantidadRealizada = cantidadRealizada;
            _totalPagadoQuetzales = totalPagadoQuetzales;
        }
    }
}