using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackOfficeAdministracion
{
    public class EncuentrosIndividuales
    {
        protected int _idEncuentro;
        protected DateTime _fechaComienzo;
        protected DateTime _fechaFinaliza;
        protected int _deporteEncuentro;
        protected string _descripcionEncuentro;
        protected string _nombreDeporte;
        public EncuentrosIndividuales()
        {
            _idEncuentro = 0;
            _fechaComienzo = new DateTime();
            _fechaFinaliza = new DateTime();
            _descripcionEncuentro = null;
            _deporteEncuentro = 0;
            _nombreDeporte = null;
        }
        public EncuentrosIndividuales(int id, DateTime fCom, DateTime fFin, string descripcion, string depo, int idDepo)
        {
            _idEncuentro = id;
            _fechaComienzo = fCom;
            _fechaFinaliza = fFin;
            _descripcionEncuentro = descripcion;
            _deporteEncuentro = idDepo;
            _nombreDeporte = depo;

        }
        public int idEncuentro
        {
            get { return _idEncuentro; }
            set { _idEncuentro = value; }
        }
        public string descripcion
        {
            get { return _descripcionEncuentro; }
            set { _descripcionEncuentro = value; }
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
        public int deporteEncuentro
        {
            get { return _deporteEncuentro; }
            set { _deporteEncuentro = value; }
        }

        public string nombreDeporte
        {
            get { return _nombreDeporte; }
            set { _nombreDeporte = value; }
        }
    }
}
