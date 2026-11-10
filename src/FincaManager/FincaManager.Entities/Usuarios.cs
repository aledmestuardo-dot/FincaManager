using System;
using System.Collections.Generic;
using System.Text;

namespace FincaManager.Entities
{
    public class Usuarios
    {
        private int _idUsuario;
        private int _idRol;
        private string _nombre;
        private string _correo;
        private string _passwordHash;
        private bool _activo;

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

        public Usuarios()
        {
            _idUsuario = 0;
            _idRol = 0;
            _nombre = string.Empty;
            _correo = string.Empty;
            _passwordHash = string.Empty;
            _activo = true;
        }
        public Usuarios(
            int idUsuario,
            int idRol,
            string nombre,
            string correo,
            string passwordhash,
            bool activo)
        {
            _idUsuario = idUsuario;
            _idRol = idRol;
            _nombre = nombre;
            _correo = correo;
            _passwordHash = passwordhash;
            _activo = activo;
        }
        public Usuarios(
            int idRol,
            string nombre,
            string correo,
            string passwordhash,
            bool activo)
        {
            _idUsuario = 0;
            _idRol = idRol;
            _nombre = nombre;
            _correo = correo;
            _passwordHash = passwordhash;
            _activo = activo;
        }
    }
}
