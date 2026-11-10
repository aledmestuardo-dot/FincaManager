using System;
using System.Collections.Generic;
using System.Text;

namespace FincaManager.Entities
{
    public class Categorias
    {
        private int _idCategoria;
        private string _nombre;

        public int IdCateforia
        {
            get { return _idCategoria; }
            set { _idCategoria = value; }
        }
        public string Nombre
        {
            get { return _nombre; }
            set { _nombre = value; }
        }
        public Categorias()
        {
            _idCategoria = 0;
            _nombre = string.Empty;
        }
        public Categorias(
            int idCategoria,
            string nombre)
        {
            _idCategoria = idCategoria;
            _nombre = nombre;
        }
        public Categorias(
            string nombre)
        {
            _idCategoria = 0;
            _nombre = nombre;
        }
    }
}
