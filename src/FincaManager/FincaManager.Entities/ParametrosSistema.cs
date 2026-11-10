using System;
using System.Collections.Generic;
using System.Text;

namespace FincaManager.Entities
{
    public class ParametrosSistema
    {
        private int _idParametro;
        private string _clave;
        private string _valor;
        private string _descripcion;

        public int IdParametro
        {
            get { return _idParametro; }
            set { _idParametro = value; }
        }
        public string Clave
        {
            get { return _clave; }
            set { _clave = value; }
        }
        public string Valor
        {
            get { return _valor; }
            set { _valor = value; }
        }
        public string Descripcion
        {
            get { return _descripcion; }
            set { _descripcion = value; }
        }
        public ParametrosSistema()
        {
            _idParametro = 0;
            _clave = string.Empty;
            _valor = string.Empty;
            _descripcion = string.Empty;
        }
        public ParametrosSistema(
            int idParametro,
            string clave,
            string valor,
            string descripcion)
        {
            _idParametro = idParametro;
            _clave = clave;
            _valor = valor;
            _descripcion = descripcion;
        }
        public ParametrosSistema(
            string clave,
            string valor,
            string descripcion)
        {
            _idParametro = 0;
            _clave = clave;
            _valor = valor;
            _descripcion = descripcion;
        }
    }
}
