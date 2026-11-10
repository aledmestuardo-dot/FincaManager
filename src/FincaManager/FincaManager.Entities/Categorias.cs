using System;
using System.Collections.Generic;
using System.Text;

namespace FincaManager.Entities
{
    public class Categorias
    {
        private int _idCategoria;
        private string _nombre;
        private bool _activo;
        private bool _eliminado;

        public int IdCategoria
        {
            get { return _idCategoria; }
            set { _idCategoria = value; }
        }

        public string Nombre
        {
            get { return _nombre; }
            set { _nombre = value; }
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

        // Constructor vacío
        public Categorias()
        {
            _idCategoria = 0;
            _nombre = string.Empty;
            _activo = true;
            _eliminado = false;
        }

        // Constructor completo (ideal para consultas que vienen de la BD)
        public Categorias(int idCategoria, string nombre, bool activo, bool eliminado)
        {
            _idCategoria = idCategoria;
            _nombre = nombre;
            _activo = activo;
            _eliminado = eliminado;
        }

        // Constructor para insertar un nuevo registro (sin ID y con valores por defecto)
        public Categorias(string nombre)
        {
            _idCategoria = 0;
            _nombre = nombre;
            _activo = true;
            _eliminado = false;
        }
    }
}