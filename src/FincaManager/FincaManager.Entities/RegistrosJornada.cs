using System;
using System.Collections.Generic;
using System.Text;

namespace FincaManager.Entities
{
    public class RegistrosJornada
    {
        private int _idRegistroJornada;
        private int _idEmpleado;
        private int _idLotesSector;
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
            get { return _idLotesSector; }
            set { _idLotesSector = value; }
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
        public decimal TotalPagadosQuetzales
        {
            get { return _totalPagadoQuetzales; }
            set { _totalPagadoQuetzales = value; }
        }

        public RegistrosJornada()
        {
            _idRegistroJornada = 0;
            _idEmpleado = 0;
            _idLotesSector = 0;
            _idTipoLabor = 0;
            _idPeriodoCosecha = 0;
            _fecha = DateTime.Now;
            _cantidadRealizada = 0m;
            _totalPagadoQuetzales = 0m;
        }
        public RegistrosJornada(
            int idRegistroJornada,
            int idEmpleado,
            int idLotesSector,
            int idTipoLabor,
            int idPeriodoCosecha,
            DateTime fecha,
            decimal cantidadRealizada,
            decimal totalPagadosQuetzales)
        {
            _idRegistroJornada = IdRegistroJornada;
            _idEmpleado = idEmpleado;
            _idLotesSector = idLotesSector;
            _idTipoLabor = idTipoLabor;
            _idPeriodoCosecha = idPeriodoCosecha;
            _fecha = fecha;
            _cantidadRealizada = cantidadRealizada;
            _totalPagadoQuetzales = totalPagadosQuetzales;
        }
        public RegistrosJornada(
            int idEmpleado,
            int idLotesSector,
            int idTipoLabor,
            int idPeriodoCosecha,
            DateTime fecha,
            decimal cantidadRealizada,
            decimal totalPagadosQuetzales)
        {
            _idRegistroJornada = 0;
            _idEmpleado = idEmpleado;
            _idLotesSector = idLotesSector;
            _idTipoLabor = idTipoLabor;
            _idPeriodoCosecha = idPeriodoCosecha;
            _fecha = fecha;
            _cantidadRealizada = cantidadRealizada;
            _totalPagadoQuetzales = totalPagadosQuetzales;
        }
    }
}
