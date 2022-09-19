using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackOfficeAdministracion
{
    public class Equipos
    {
        protected int _id;
        protected string _categoria;
        protected string _logo;
        protected string _nombre;
        protected string _país;

        public Equipos() {
            _id = 0;
            _categoria = null;
            _logo = null;
            _nombre = null;
            _país = null;
        }
        public Equipos(int id, string categoria, string logo, string nombre, string pais) {
            this._id = id;
            this._logo = logo;
            this._categoria = categoria;
            this._nombre = nombre;
            this._país = pais;
        }
        public int id
        {
            get { return _id; }
            set { _id = value; }
        }
        public string categoria
        {
            get { return _categoria; }
            set { _categoria = value; }
        }
        public string logo
        {
            get { return _logo; }
            set { _logo = value; }
        }
        public string nombre
        {
            get { return _nombre; }
            set { _nombre = value; }
        }
        public string pais
        {
            get { return _país; }
            set { _país = value; }
        }
    }
}
