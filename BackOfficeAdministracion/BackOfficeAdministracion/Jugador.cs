using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackOfficeAdministracion
{
    public class Jugador
    {
        protected int _idJugador;
        protected int _edad;
        protected string _nombre;
        protected string _apellido;
        protected char _sexo;
        protected string _paisNacimiento;

        public Jugador()
        {
            _idJugador = 0;
            _edad = 0;
            _nombre = null;
            _apellido = null;
            _sexo = ' ';
            _paisNacimiento = null;
        }
        public int id
        {
            get { return _idJugador; }
            set { _idJugador = value; }
        }
        public int edad
        {
            get { return _edad; }
            set { _edad = value; }
        }
        public string nombre
        {
            get { return _nombre; }
            set { _nombre = value; }
        }
        public string apelido
        {
            get { return _apellido; }
            set { _apellido = value; }
        }
        public string paisNacimiento
        {
            get { return _paisNacimiento; }
            set { _paisNacimiento = value; }
        }
        public char sexo
        {
            get { return _sexo; }
            set { _sexo = value; }
        }
    }
}
