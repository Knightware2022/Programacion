using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackOfficeAdministracion
{
    public class Usuario
    {
        protected string _nombre;
        protected string _correo;
        protected Int32 _rol;
        protected ADODB.Connection _connection;
        protected string _contrasenia;
        protected Int32 _mesesSuscriptos;
        protected Int32 _idUsuario;

        #region constructores
        public Usuario()
        {//constructor por defecto
            _rol = 0;
            _nombre = "";
            _correo = "";
            _contrasenia = "";
            _connection = new ADODB.Connection();
            _mesesSuscriptos = 0;
            _idUsuario = 0;
        }

        public Usuario(Int32 r, string n, string c, ADODB.Connection con, string pswd, int m, int id)
        {
            _rol = r;
            _nombre = n;
            _correo = c;
            _contrasenia = pswd;
            _connection = con;
            _mesesSuscriptos = m;
            _idUsuario = id;
        }
        public int id
        {
            get { return _idUsuario; }
            set { _idUsuario = value; }
        }
        public int mesesSuscritos
        {
            get { return _mesesSuscriptos; }
            set { _mesesSuscriptos = value; }
        }
        public Int32 rol
        {
            get { return _rol; }
            set { _rol = value; }
        }
        public string nombre
        {
            get { return _nombre; }
            set { _nombre = value; }
        }
        public string correo
        {
            get { return _correo; }
            set { _correo = value; }
        }
        public ADODB.Connection connection
        {
            get { return _connection; }
            set { _connection = value; }
        }
        public string contrasenia
        {
            get { return _contrasenia; }
            set { _contrasenia = value; }
        }
        #endregion

    }

}
   
