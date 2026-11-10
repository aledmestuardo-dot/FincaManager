using System;
using System.Collections.Generic;
using System.Text;

namespace FincaManager.Entities
{
    public class UnidadesMedida
    {
        private int _idUnidadesMedida;
        private string _nombre;
        private string _abreviatura;

        public int IdCateforia
        {
            get { return _idUnidadesMedida; }
            set { _idUnidadesMedida = value; }
        }
        public string Nombre
        {
            get { return _nombre; }
            set { _nombre = value; }
        }
        public string Abreviatura
        {
            get { return _abreviatura; }
            set { _abreviatura = value; }
        }
        public UnidadesMedida()
        {
            _idUnidadesMedida = 0;
            _nombre = string.Empty;
            _abreviatura = string.Empty;
        }
        public UnidadesMedida(
            int idMarca,
            string nombre,
            string abreviatura)
        {
            _idUnidadesMedida = idMarca;
            _nombre = nombre;
            _abreviatura = abreviatura;
        }
        public UnidadesMedida(
            string nombre,
            string abreviatura)
        {
            _idUnidadesMedida = 0;
            _nombre = nombre;
            _abreviatura = abreviatura;
        }
    }
}
