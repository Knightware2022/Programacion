using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackOfficeAdministracion
{
    public class EncuentrosColectivos
    {
        protected int _idEncuentro;
        protected DateTime _fechaComienzo;
        protected DateTime _fechaFinaliza;
        protected string _deporteEncuentro;
        protected string _descripcionEncuentro;

        public EncuentrosColectivos()
        {
            _idEncuentro = 0;
            _fechaComienzo = new DateTime();
            _fechaFinaliza = new DateTime();
            _descripcionEncuentro = null;
            _deporteEncuentro = null;
        }
        public EncuentrosColectivos(int id, DateTime fCom, DateTime fFin, string descripcion, string depo)
        {
            _idEncuentro = id;
            _fechaComienzo = fCom;
            _fechaFinaliza = fFin;
            _descripcionEncuentro = descripcion;
            _deporteEncuentro = depo;

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
        public string deporteEncuentro
        {
            get { return _deporteEncuentro; }
            set { _deporteEncuentro = value; }
        }

    }
}
