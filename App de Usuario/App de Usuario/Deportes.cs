using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App_de_Usuario
{
    public class Deportes
    {
        protected Int32 _id;
        protected string _categoria;
        protected string _nombre;

        public Deportes()
        {
            _id = 0;
            _categoria = null;
            _nombre = null;
        }
        public Deportes(Int32 id, string categoria, string nombre)
        {
            this._id = id;
            this._categoria = categoria;
            this._nombre = nombre;
        }
        public Int32 id
        {
            get { return _id; }
            set { _id = value; }
        }
        public string categoria
        {
            get { return _categoria; }
            set { _categoria = value; }
        }
        
        public string nombre
        {
            get { return _nombre; }
            set { _nombre = value; }
        }
        
    }
}
