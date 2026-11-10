using System;
using System.Collections.Generic;
using System.Text;

namespace FincaManager.Entities
{
    public class Marcas
    {
        private int _idMarca;
        private string _nombre;

        public int IdCateforia
        {
            get { return _idMarca; }
            set { _idMarca = value; }
        }
        public string Nombre
        {
            get { return _nombre; }
            set { _nombre = value; }
        }
        public Marcas()
        {
            _idMarca = 0;
            _nombre = string.Empty;
        }
        public Marcas(
            int idMarca,
            string nombre)
        {
            _idMarca = idMarca;
            _nombre = nombre;
        }
        public Marcas(
            string nombre)
        {
            _idMarca = 0;
            _nombre = nombre;
        }
    }
}
