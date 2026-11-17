using System;
using System.Collections.Generic;
using System.Text;

namespace FincaManager.Entities
{
    public class UsuariosEntidad
    {
        private int _idUsuario;
        private int _idRol;
        private string _nombre;
        private string _correo;
        private string _passwordHash;
        private bool _activo;
        private bool _eliminado; // Añadido para el borrado lógico

        public int IdUsuario
        {
            get { return _idUsuario; }
            set { _idUsuario = value; }
        }

        public int IdRol
        {
            get { return _idRol; }
            set { _idRol = value; }
        }

        public string Nombre
        {
            get { return _nombre; }
            set { _nombre = value; }
        }

        public string Correo
        {
            get { return _correo; }
            set { _correo = value; }
        }

        public string PasswordHash
        {
            get { return _passwordHash; }
            set { _passwordHash = value; }
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
        public UsuariosEntidad()
        {
            _idUsuario = 0;
            _idRol = 0;
            _nombre = string.Empty;
            _correo = string.Empty;
            _passwordHash = string.Empty;
            _activo = true;
            _eliminado = false;
        }

        // Constructor completo (ideal para consultas desde la BD)
        public UsuariosEntidad(
            int idUsuario,
            int idRol,
            string nombre,
            string correo,
            string passwordHash,
            bool activo,
            bool eliminado)
        {
            _idUsuario = idUsuario;
            _idRol = idRol;
            _nombre = nombre;
            _correo = correo;
            _passwordHash = passwordHash;
            _activo = activo;
            _eliminado = eliminado;
        }

        // Constructor para inserción (sin ID, con estados por defecto)
        public UsuariosEntidad(
            int idRol,
            string nombre,
            string correo,
            string passwordHash,
            bool activo)
        {
            _idUsuario = 0;
            _idRol = idRol;
            _nombre = nombre;
            _correo = correo;
            _passwordHash = passwordHash;
            _activo = activo;
            _eliminado = false;
        }
    }
}