using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App_de_Usuario
{
    public class Torneos
    {
        protected int _idTorneo;
        protected DateTime _fechaComienzo;
        protected DateTime _fechaFinaliza;
        protected int _idDeporteTorneo;
        protected string _nombreDeporte;
        protected string _nombreTorneo;

        public Torneos()
        {
            _idTorneo = 0;
            _fechaComienzo = new DateTime();
            _fechaFinaliza = new DateTime();
            _nombreTorneo = null;
            _idDeporteTorneo = 0;
            _nombreDeporte = null;
        }
        public Torneos(int id, DateTime fCom, DateTime fFin, string descripcion, int depo, string nDepo)
        {
            _idTorneo = id;
            _fechaComienzo = fCom;
            _fechaFinaliza = fFin;
            _nombreTorneo = descripcion;
            _idDeporteTorneo = depo;
            _nombreDeporte = nDepo;

        }
        public int idTorneo
        {
            get { return _idTorneo; }
            set { _idTorneo = value; }
        }
        public string nombreTorneo
        {
            get { return _nombreTorneo; }
            set { _nombreTorneo = value; }
        }
        public string nombreDeporte
        {
            get { return _nombreDeporte; }
            set { _nombreDeporte = value; }
        }
        public DateTime fechaComienzo
        {
            get { return _fechaComienzo; }
            set { _fechaComienzo = value; }
        }
        public DateTime fechaFinaliza
        {
            get { return _fechaFinaliza; }
            set { _fechaFinaliza = value; }
        }
        public int idDeporteTorneo
        {
            get { return _idDeporteTorneo; }
            set { _idDeporteTorneo = value; }
        }


    }
}
