using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App_de_Usuario
{
    public class ApiPublicidad
    {

        public static Publicidad _publicidad;

        #region constructores por defecto
        public ApiPublicidad() {
            _publicidad = new Publicidad();
        }
        public ApiPublicidad(Publicidad p) {
            _publicidad = p;
        }
        public Publicidad publicidad{
            get { return _publicidad; }
            set { _publicidad = value; }
        }
        #endregion
        public void obtenerPublicidad(string mac) {
            _publicidad.url = Logica.obtenerPublicidad(mac);
            if (_publicidad.url == null) {
                _publicidad.url = "Error34X_Publicidad";
            }
        }
    }
}
