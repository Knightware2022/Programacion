using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App_de_Usuario
{
    public class Publicidad
    {
        protected int _id;
        protected string _url;

        public Publicidad() {
            _id = 0;
            _url = "";
        }
        public Publicidad(int i, string u) {
            _id = i;
            _url = u;
        }
        public int id {
            get {return _id;}
            set { _id = value; }
        }
        public string url {
            get { return _url; }
            set { _url = value; }
        }
    }
}
