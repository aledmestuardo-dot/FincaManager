namespace FincaManager.Entities
{
    public class Roles
    {
        private int _idRol;
        private string _nombre;
        private string _descripcion;

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
        public string Descripcion
        {
            get { return _descripcion; }
            set { _descripcion = value; }
        }

        //Constructor por defecto.
        public Roles()
        {
            _idRol = 0;
            _nombre = string.Empty;
            _descripcion = string.Empty;
        }

        //Contructor Consultar
        public Roles(
            int idRol,
            string nombre,
            string descripcion)
        {
            _idRol = idRol;
            _nombre = nombre;
            _descripcion = descripcion;
        }

        //Contructor Agregar
        public Roles(
            string nombre,
            string descripcion)
        {
            _idRol = 0;
            _nombre = nombre;
            _descripcion = descripcion;
        }
    }
}
