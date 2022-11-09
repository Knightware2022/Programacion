using System;

using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App_de_Usuario
{
    public static class Logica
    {
        public static ADODB.Connection _cn = new ADODB.Connection();
        #region constructores

        #endregion
        public static byte abrirConexion()
        {
            byte devolver;
            try
            {
                _cn = new ADODB.Connection();
                _cn.Open("miodbc", "root", "", -1);
                _cn.CursorLocation = ADODB.CursorLocationEnum.adUseClient;
                devolver = 1;
            }
            catch
            {
                devolver = 2;
            }
            return devolver;
        }
        public static byte BuscandoUsuario(Usuario u)
        {

            byte devolver = 0;
            object cantFilas;
            string sql;
            ADODB.Recordset rs = new ADODB.Recordset();
            if (_cn.State == 0)//si esta cerrada
            {
                devolver = 1;
            }
            else
            {
                sql = "select nombre from Vip where nombre='" + u.nombre + "'";
                try
                {
                    rs = _cn.Execute(sql, out cantFilas); //out cantFilas, devuelve cantidad de filas afectadas, y cuales fueron
                }
                catch
                {
                    return devolver = 2;//error inesperado
                }

                if (rs.RecordCount == 0)
                {
                    devolver = 3; //no esta registrado
                }
                else
                {
                    sql = "select contrasenia from Vip where nombre='" + u.nombre + "'";
                    try
                    {
                        rs = _cn.Execute(sql, out cantFilas); //out cantFilas, devuelve cantidad de filas afectadas, y cuales fueron
                    }
                    catch
                    {
                        return devolver = 2;//error inesperado
                    }

                    string contrasenia = Convert.ToString(rs.Fields[0].Value);
                    if (u.contrasenia.Equals(contrasenia))
                    {
                        devolver = 0; // existe y la contraseña coincide
                    }
                    else
                    {
                        devolver = 4; //contraseñas no coinciden
                    }
                }
            }
            return devolver;
        }
        public static string obtenerPublicidad(int id)
        {
            string url = "";
            object cantFilas;
            string sql;
            ADODB.Recordset rs = new ADODB.Recordset();
            if (_cn.State == 0)//si esta cerrada
            {
                url = null;
            }
            else
            {
                sql = "select url from publicidad where idPublicidad=" + id;
                try
                {

                    rs = _cn.Execute(sql, out cantFilas); //out cantFilas, devuelve cantidad de filas afectadas, y cuales fueron
                }
                catch
                {
                    return url = null;
                }

                if (rs.RecordCount == 0)
                {
                    url = null; //no encontre
                }
                else
                {
                    url = Convert.ToString(rs.Fields[0].Value);
                }
            }
            return url;
        }
        public static byte AltaUsuarioVIP(Usuario u)
        {
            byte devolver = 0;
            string sql;
            ADODB.Recordset rs = new ADODB.Recordset();
            object cantFilas;
            abrirConexion();
            if (_cn.State == 0)//si esta cerrada
            {
                devolver = 1;
            }
            else
            {

                sql = "select nombre from Vip where nombre='" + u.nombre + "'";
                try
                {
                    rs = _cn.Execute(sql, out cantFilas); //out cantFilas, devuelve cantidad de filas afectadas, y cuales fueron
                }
                catch
                {
                    return devolver = 2;//error inesperado
                }

                if (rs.RecordCount == 0)//si no existen registros, entonces lo ingresamos
                {
                    sql = "insert into Usuarios(idUsuario) values(" + u.id + ")";
                    try
                    {
                        rs = _cn.Execute(sql, out cantFilas); //out cantFilas, devuelve cantidad de filas afectadas, y cuales fueron
                    }
                    catch
                    {
                        return devolver = 2;//error inesperado
                    }
                    sql = "insert into Vip(idUsuario, correo, contrasenia, nombre, mesesSuscritos, rol) values(" + u.id + ", '" + u.correo + "', '" + u.contrasenia + "', '" + u.nombre + "', " + u.mesesSuscritos + ", " + u.rol + ")";
                    try
                    {

                        rs = _cn.Execute(sql, out cantFilas);
                    }
                    catch
                    {
                        return devolver = 3;//error inesperado
                    }

                }
                else
                {
                    devolver = 4;// ya está registrado
                }
            }
            return devolver;
        }
        public static byte BuscarID(int id)
        {
            byte devolver = 0;
            object cantFilas;
            string sql;
            ADODB.Recordset rs = new ADODB.Recordset();
            if (_cn.State == 0)//si esta cerrada
            {
                devolver = 1;
            }
            else
            {
                sql = "select idUsuario from Usuarios where idUsuario=" + id;
                try
                {
                    rs = _cn.Execute(sql, out cantFilas); //out cantFilas, devuelve cantidad de filas afectadas, y cuales fueron
                }
                catch
                {
                    return devolver = 2;//error inesperado
                }
                if (rs.RecordCount == 0)
                {
                    devolver = 3; //id no en uso
                }
            }
            return devolver;
        }
        public static byte BuscandoDatosUsuario(Usuario u)
        {
            byte devolver = 0;
            object cantFilas;
            string sql;
            ADODB.Recordset rs = new ADODB.Recordset();
            if (_cn.State == 0)//si esta cerrada
            {
                devolver = 1;
            }
            else
            {
                sql = "select rol from Vip where nombre='" + u.nombre + "'";
                try
                {
                    rs = _cn.Execute(sql, out cantFilas); //out cantFilas, devuelve cantidad de filas afectadas, y cuales fueron
                }
                catch
                {
                    return devolver = 2;
                }
                if (rs.RecordCount == 0)
                {
                    devolver = 3;
                }
                else
                {
                    u.rol = Convert.ToInt32(rs.Fields[0].Value);
                }
                sql = "select correo from Vip where nombre='" + u.nombre + "'";
                try
                {
                    rs = _cn.Execute(sql, out cantFilas); //out cantFilas, devuelve cantidad de filas afectadas, y cuales fueron
                }
                catch
                {
                    return devolver = 2;
                }
                if (rs.RecordCount == 0)
                {
                    devolver = 3;
                }
                else
                {
                    u.correo = Convert.ToString(rs.Fields[0].Value);
                }
                sql = "select mesesSuscritos from Vip where nombre='" + u.nombre + "'";
                try
                {
                    rs = _cn.Execute(sql, out cantFilas); //out cantFilas, devuelve cantidad de filas afectadas, y cuales fueron
                }
                catch
                {
                    return devolver = 2;
                }
                if (rs.RecordCount == 0)
                {
                    devolver = 3;
                }
                else
                {
                    u.mesesSuscritos = Convert.ToInt32(rs.Fields[0].Value);
                }
                sql = "select idUsuario from Vip where nombre='" + u.nombre + "'";
                try
                {
                    rs = _cn.Execute(sql, out cantFilas); //out cantFilas, devuelve cantidad de filas afectadas, y cuales fueron
                }
                catch
                {
                    return devolver = 2;
                }
                if (rs.RecordCount == 0)
                {
                    devolver = 3;
                }
                else
                {
                    u.id = Convert.ToInt32(rs.Fields[0].Value);
                }
            }
            return devolver;
        }
        public static byte averiguandoRol(Usuario u)
        {
            byte devolver = 0;
            object cantFilas;
            string sql;
            ADODB.Recordset rs = new ADODB.Recordset();
            if (_cn.State == 0)//si esta cerrada
            {
                devolver = 1;
            }
            else
            {
                sql = "select rol from Vip where nombre='" + u.nombre + "'";
                try
                {
                    rs = _cn.Execute(sql, out cantFilas); //out cantFilas, devuelve cantidad de filas afectadas, y cuales fueron
                }
                catch
                {
                    return devolver = 2;
                }
                if (rs.RecordCount == 0)
                {
                    devolver = 3;
                }
                else
                {
                    u.rol = Convert.ToInt32(rs.Fields[0].Value);
                }
            }
            return devolver;
        }
        public static byte listarTodosUsuarios(List<string> lista)
        {
            object cantFilas;
            byte devolver = 0;
            string sql;
            ADODB.Recordset rs = new ADODB.Recordset();
            if (_cn.State == 0)//si esta cerrada
            {
                devolver = 1;
            }
            else
            {
                sql = "Select nombre from Vip";
                try
                {
                    rs = _cn.Execute(sql, out cantFilas); //out cantFilas, devuelve cantidad de filas afectadas, y cuales fueron
                }
                catch
                {
                    return 2;
                }
                while (!rs.EOF)
                {
                    lista.Add(Convert.ToString(rs.Fields[0].Value));
                    rs.MoveNext();
                }
            }
            rs = null;

            return devolver;
        }
        public static byte actualizarUsuario(Usuario u)
        {
            byte devolver = 0;
            object cantFilas;
            string sql;
            ADODB.Recordset rs = new ADODB.Recordset();
            if (_cn.State == 0)//si esta cerrada
            {
                devolver = 1;
            }
            else
            {
                sql = "update Vip set rol=" + u.rol + " where nombre='" + u.nombre + "'";
                try
                {
                    rs = _cn.Execute(sql, out cantFilas); //out cantFilas, devuelve cantidad de filas afectadas, y cuales fueron
                }
                catch
                {

                    return devolver = 2;
                }
                sql = "select correo from Vip where nombre='" + u.nombre + "'";
                try
                {
                    rs = _cn.Execute(sql, out cantFilas); //out cantFilas, devuelve cantidad de filas afectadas, y cuales fueron
                }
                catch
                {
                    return devolver = 2;
                }
                string correin = Convert.ToString(rs.Fields[0].Value);
                if (correin != u.correo)
                {
                    sql = "update Vip set correo='" + u.correo + "' where nombre='" + u.nombre + "'";
                    try
                    {
                        rs = _cn.Execute(sql, out cantFilas); //out cantFilas, devuelve cantidad de filas afectadas, y cuales fueron
                    }
                    catch
                    {
                        return devolver = 2;
                    }
                }

                sql = "update Vip set mesesSuscritos=" + u.mesesSuscritos + " where nombre='" + u.nombre + "'";
                try
                {
                    rs = _cn.Execute(sql, out cantFilas); //out cantFilas, devuelve cantidad de filas afectadas, y cuales fueron
                }

                catch
                {
                    return devolver = 2;
                }
            }
            return devolver;
        }
        public static byte eliminarUsuario(string nombre, int id)
        {
            byte devolver = 0;
            object cantFilas;
            string sql;
            ADODB.Recordset rs = new ADODB.Recordset();
            if (_cn.State == 0)//si esta cerrada
            {
                devolver = 1;
            }
            else
            {
                sql = "delete from Vip where nombre='" + nombre + "'";
                try
                {
                    rs = _cn.Execute(sql, out cantFilas); //out cantFilas, devuelve cantidad de filas afectadas, y cuales fueron
                }
                catch
                {
                    return devolver = 2;
                }
                sql = "delete from Usuarios where idUsuario=" + id + "";
                try
                {
                    rs = _cn.Execute(sql, out cantFilas); //out cantFilas, devuelve cantidad de filas afectadas, y cuales fueron
                }
                catch
                {
                    return devolver = 2;
                }
            }
            return devolver;
        }
        public static byte crearUsuario(Usuario u)
        {
            byte devolver = 0;
            object cantFilas;
            string sql;
            string contraseña = "";
            Encriptacion e = new Encriptacion();
            contraseña = e.encriptar(contraseña);
            ADODB.Recordset rs = new ADODB.Recordset();
            if (_cn.State == 0)//si esta cerrada
            {
                devolver = 1;
            }
            else
            {
                sql = "insert into Usuarios(idusuario) values( " + u.id + " )";
                try
                {
                    rs = _cn.Execute(sql, out cantFilas); //out cantFilas, devuelve cantidad de filas afectadas, y cuales fueron
                }
                catch
                {
                    return devolver = 2;
                }
                sql = "insert into Vip(idusuario, correo, contrasenia, nombre, mesesSuscritos, rol) values( " + u.id + ", '" + u.correo + "', '" + contraseña + "', '" + u.nombre + "', " + u.mesesSuscritos + ", " + u.rol + " )";
                try
                {
                    rs = _cn.Execute(sql, out cantFilas); //out cantFilas, devuelve cantidad de filas afectadas, y cuales fueron
                }
                catch
                {
                    return devolver = 2;
                }
            }
            return devolver;
        }
        public static byte AñadirPublicidad(string url)
        {
            Random r = new Random();
            byte devolver = 0;
            int idRandom = 0;
            object cantFilas;
            string sql;
            bool bandera = true;
            string contraseña = "";
            Encriptacion e = new Encriptacion();
            contraseña = e.encriptar(contraseña);
            ADODB.Recordset rs = new ADODB.Recordset();
            if (_cn.State == 0)//si esta cerrada
            {
                devolver = 1;
            }
            else
            {
                while (bandera == true)
                {
                    idRandom = r.Next();
                    switch (Logica.BuscarID(idRandom))
                    {
                        case 0:
                            break;
                        case 1:
                        case 2:
                            return 2;

                            break;
                        case 3:
                            bandera = false;
                            break;
                    }
                }
                sql = "insert into Publicidad(idPublicidad, url) values( " + idRandom + ", '" + url + "')";
                try
                {
                    rs = _cn.Execute(sql, out cantFilas); //out cantFilas, devuelve cantidad de filas afectadas, y cuales fueron
                }
                catch
                {
                    return devolver = 2;
                }
            }
            return devolver;
        }
        public static byte listarTodaPublicidad(List<string> lista)
        {
            object cantFilas;
            byte devolver = 0;
            string sql;
            ADODB.Recordset rs = new ADODB.Recordset();
            if (_cn.State == 0)//si esta cerrada
            {
                devolver = 1;
            }
            else
            {
                sql = "Select url from Publicidad";
                try
                {
                    rs = _cn.Execute(sql, out cantFilas); //out cantFilas, devuelve cantidad de filas afectadas, y cuales fueron
                }
                catch
                {
                    return 2;
                }
                while (!rs.EOF)
                {
                    lista.Add(Convert.ToString(rs.Fields[0].Value));
                    rs.MoveNext();
                }
            }
            rs = null;

            return devolver;
        }
        public static byte eliminarPublicidad(string url)
        {
            byte devolver = 0;
            object cantFilas;
            string sql;
            ADODB.Recordset rs = new ADODB.Recordset();
            if (_cn.State == 0)//si esta cerrada
            {
                devolver = 1;
            }
            else
            {
                sql = "delete from Publicidad where url='" + url + "'";
                try
                {
                    rs = _cn.Execute(sql, out cantFilas); //out cantFilas, devuelve cantidad de filas afectadas, y cuales fueron
                }
                catch
                {
                    return devolver = 2;
                }

            }
            return devolver;
        }
        public static byte modificarContraseña(string nombre, string nueva)
        {
            byte devolver = 0;
            object cantFilas;
            string sql;
            ADODB.Recordset rs = new ADODB.Recordset();
            if (_cn.State == 0)//si esta cerrada
            {
                devolver = 1;
            }
            else
            {
                sql = "update Vip set contrasenia='" + nueva + "' where nombre='" + nombre + "'";
                try
                {
                    rs = _cn.Execute(sql, out cantFilas); //out cantFilas, devuelve cantidad de filas afectadas, y cuales fueron
                }
                catch
                {
                    return devolver = 2;
                }

            }
            return devolver;
        }
        public static byte averiguarCorreo(Usuario u)
        {
            byte devolver = 0;
            object cantFilas;
            string sql, ayuda;

            ADODB.Recordset rs = new ADODB.Recordset();
            if (_cn.State == 0)//si esta cerrada
            {
                devolver = 1;
            }
            else
            {
                sql = "select correo from Vip where correo='" + u.correo + "'";
                try
                {
                    rs = _cn.Execute(sql, out cantFilas); //out cantFilas, devuelve cantidad de filas afectadas, y cuales fueron
                }
                catch
                {
                    return devolver = 2;
                }
                if (rs.RecordCount == 0)
                {
                    devolver = 3;
                }
                else
                {
                    ayuda = Convert.ToString(rs.Fields[0].Value);
                }
                sql = "select nombre from Vip where correo='" + u.correo + "'";
                try
                {
                    rs = _cn.Execute(sql, out cantFilas); //out cantFilas, devuelve cantidad de filas afectadas, y cuales fueron
                }
                catch
                {
                    return devolver = 2;
                }
                if (rs.RecordCount == 0)
                {
                    devolver = 3;
                }
                else
                {
                    u.nombre = Convert.ToString(rs.Fields[0].Value);
                }
            }
            return devolver;
        }
        public static byte averiguarDeportesFavoritos(int idUsuario, List<string> lista)
        {
            byte devolver = 0;
            object cantFilas;
            string sql;
            ADODB.Recordset rs = new ADODB.Recordset();
            if (_cn.State == 0)//si esta cerrada
            {
                devolver = 1;
            }
            else
            {
                sql = "select nombre from deportes where deportes.idDeporte IN (select deporteFavorito from deportesFavoritos where idUsuario=" + idUsuario + ")";
                try
                {
                    rs = _cn.Execute(sql, out cantFilas); //out cantFilas, devuelve cantidad de filas afectadas, y cuales fueron
                }
                catch
                {
                    return devolver = 2;
                }
                while (!rs.EOF)
                {
                    lista.Add(Convert.ToString(rs.Fields[0].Value));
                    rs.MoveNext();
                }
            }
            rs = null;
            return devolver;
        }
        public static byte crearUsuarioGuest(int idUsuario, string nombreAutogen, string mac)
        {
            byte devolver = 3;
            object cantFilas;
            string sql;
            string contraseña = "";
            Encriptacion e = new Encriptacion();
            contraseña = e.encriptar(contraseña);
            ADODB.Recordset rs = new ADODB.Recordset();
            if (_cn.State == 0)//si esta cerrada
            {
                devolver = 1;
            }
            else
            {
                sql = "insert into Usuarios(idUsuario) values( " + idUsuario + " )";
                try
                {
                    rs = _cn.Execute(sql, out cantFilas); //out cantFilas, devuelve cantidad de filas afectadas, y cuales fueron
                }
                catch
                {

                    return devolver = 2;
                }
                sql = "insert into Guest(idUsuario, nombreAutogen, mac) values( " + idUsuario + ", '" + nombreAutogen + "', '" + mac + "')";
                try
                {
                    rs = _cn.Execute(sql, out cantFilas); //out cantFilas, devuelve cantidad de filas afectadas, y cuales fueron
                }
                catch
                {

                    return devolver = 2;
                }
            }
            return devolver;
        }
        public static byte buscandoMAC(string mac)
        {
            byte devolver = 0;
            object cantFilas;
            string sql;
            ADODB.Recordset rs = new ADODB.Recordset();
            if (_cn.State == 0)//si esta cerrada
            {
                devolver = 1;
            }
            else
            {
                sql = "select mac from Guest where mac='" + mac + "'";
                try
                {
                    rs = _cn.Execute(sql, out cantFilas); //out cantFilas, devuelve cantidad de filas afectadas, y cuales fueron
                }
                catch
                {
                    return devolver = 2;//error inesperado
                }
                if (rs.RecordCount == 0)
                {
                    devolver = 3; //mac no encontrada
                }
            }
            return devolver;
        }

        public static byte EquiposEncuentrosColectivos(int idEncuentro, List<string> nombresEquipos)
        {
            byte devolver = 0;
            object cantFilas;
            string sql;
            ADODB.Recordset rs = new ADODB.Recordset();
            if (_cn.State == 0)//si esta cerrada
            {
                devolver = 1;
            }
            else
            {
                sql = "select distinct e.nombre, e.categoria from Equipos as e, Compite as c where c.idEncuentro=" + idEncuentro + " AND c.idEquipo=e.idEquipo";
                try
                {
                    rs = _cn.Execute(sql, out cantFilas);
                }
                catch
                {
                    return devolver = 2;
                }
                if (rs.RecordCount == 0)
                {
                    devolver = 3;
                }
                else
                {
                    while (!rs.EOF)
                    {
                        nombresEquipos.Add((Convert.ToString(rs.Fields[0].Value) + "/" + Convert.ToString(rs.Fields[1].Value)));
                        rs.MoveNext();
                    }
                }

            }
            rs = null;
            return devolver;
        }


        ///             metodos que no estan (se supone) en la app del backoffice

        public static byte EliminarDeporteFavorito(string deporteFav, int idUsuario)
        {
            byte devolver = 0;
            object cantFilas;
            string sql;
            ADODB.Recordset rs = new ADODB.Recordset();
            if (_cn.State == 0)//si esta cerrada
            {
                devolver = 1;
            }
            else
            {
                sql = "delete from DeportesFavoritos where idUsuario=" + idUsuario + " AND deporteFavorito=(select idDeporte from Deportes where nombre='" + deporteFav + "')";
                try
                {
                    rs = _cn.Execute(sql, out cantFilas);
                }
                catch
                {
                    return devolver = 2;
                }

            }
            return devolver;
        }
        public static byte AgregarDeporteFavorito(string deporteFav, int idUsuario)
        {
            byte devolver = 0;
            object cantFilas;
            string sql;
            ADODB.Recordset rs = new ADODB.Recordset();
            if (_cn.State == 0)//si esta cerrada
            {
                devolver = 1;
            }
            else
            {
                sql = "insert into DeportesFavoritos(idUsuario, DeporteFavorito) values(" + idUsuario + ", (select idDeporte from Deportes where nombre='" + deporteFav + "'))";
                try
                {
                    rs = _cn.Execute(sql, out cantFilas);
                }
                catch
                {
                    return devolver = 2;
                }

            }
            return devolver;
        }
        public static byte nombresDeportes(List<string> lista)
        {
            byte devolver = 0;
            object cantFilas;
            string sql;
            ADODB.Recordset rs = new ADODB.Recordset();
            if (_cn.State == 0)//si esta cerrada
            {
                devolver = 1;
            }
            else
            {
                sql = "select nombre from Deportes" +
                    " group by nombre asc";
                try
                {
                    rs = _cn.Execute(sql, out cantFilas); //out cantFilas, devuelve cantidad de filas afectadas, y cuales fueron
                }
                catch
                {
                    return devolver = 2;
                }
                if (rs.RecordCount == 0)
                {
                    devolver = 3;//no hay jugadores cargados
                }
                else
                {
                    while (!rs.EOF)
                    {
                        lista.Add(Convert.ToString(rs.Fields[0].Value));
                        rs.MoveNext();
                    }
                }
            }
            rs = null;
            return devolver;
        }

        public static byte cargarNombreEncuentrosConNombre(List<string> listaEventosColectivos, string deporte)
        {
            byte devolver = 0;
            object cantFilas;
            string sql;
            ADODB.Recordset rs = new ADODB.Recordset();
            if (_cn.State == 0)//si esta cerrada
            {
                devolver = 1;
            }
            else
            {
                sql = "select e.descripcionEncuentro, e.fechaComienzo, e.idEncuentro from Encuentros as e where e.idDeporte=(select idDeporte from Deportes where nombre='" + deporte + "') AND e.fechaComienzo>=curdate()";
                try
                {
                    rs = _cn.Execute(sql, out cantFilas);
                }
                catch
                {
                    return devolver = 2;
                }
                if (rs.RecordCount == 0)
                {
                    devolver = 3;
                }
                else
                {
                    while (!rs.EOF)
                    {
                        listaEventosColectivos.Add(Convert.ToString(rs.Fields[2].Value) + " " +Convert.ToString(rs.Fields[0].Value) + " -" + Convert.ToString(rs.Fields[1].Value));
                        rs.MoveNext();
                    }
                }
            }
            rs = null;
            return devolver;
        }

        public static byte DatosEncuentrosColectivos(EncuentrosColectivos encuentro, List<string> nombresEquipos)
        {
            byte devolver = 0;
            object cantFilas;
            string sql;
            ADODB.Recordset rs = new ADODB.Recordset();
            if (_cn.State == 0)//si esta cerrada
            {
                devolver = 1;
            }
            else
            {
                sql = "Select * from Encuentros where idEncuentro=" + encuentro.idEncuentro;
                try
                {
                    rs = _cn.Execute(sql, out cantFilas); //out cantFilas, devuelve cantidad de filas afectadas, y cuales fueron
                }
                catch

                {
                    return devolver = 2;
                }
                if (rs.RecordCount == 0)
                {
                    devolver = 3;
                }
                else
                {
                    encuentro.deporteEncuentro = Convert.ToInt32(rs.Fields[0].Value);
                    encuentro.idEncuentro = Convert.ToInt32(rs.Fields[1].Value);
                    encuentro.fechaComienzo = Convert.ToDateTime(rs.Fields[2].Value);
                    encuentro.fechaFinaliza = Convert.ToDateTime(rs.Fields[3].Value);
                    encuentro.descripcion = Convert.ToString(rs.Fields[4].Value);
                    sql = "Select d.nombre from Deportes as d where idDeporte=" + encuentro.deporteEncuentro;
                    try
                    {
                        rs = _cn.Execute(sql, out cantFilas); //out cantFilas, devuelve cantidad de filas afectadas, y cuales fueron
                    }
                    catch
                    {

                        return devolver = 2;
                    }
                    encuentro.nombreDeporte = Convert.ToString(rs.Fields[0].Value);
                    sql = "select distinct e.nombre, e.categoria from Equipos as e, Compite as c where c.idEncuentro=" + encuentro.idEncuentro + " AND c.idEquipo=e.idEquipo";
                    try
                    {
                        rs = _cn.Execute(sql, out cantFilas);
                    }
                    catch
                    {

                        return devolver = 2;
                    }
                    if (rs.RecordCount == 0)
                    {
                        devolver = 5;
                    }
                    else
                    {
                        while (!rs.EOF)
                        {
                            nombresEquipos.Add((Convert.ToString(rs.Fields[0].Value) + "/" + Convert.ToString(rs.Fields[1].Value)));
                            rs.MoveNext();
                        }
                    }

                }
            }
            rs = null;
            return devolver;
        }
        public static byte mostrarJugadoresDeEquipo(string nombreEquipo, string categoriaEquipo, int idEncuentro, List<string> jugadoresEquipo)
        {
            byte devolver = 0;
            object cantFilas;
            string sql;
            ADODB.Recordset rs = new ADODB.Recordset();
            if (_cn.State == 0)//si esta cerrada
            {
                devolver = 1;
            }
            else
            {
                sql = "select j.nombre, j.apellido from Jugador as j, Forman as f  where j.idJugador = f.idJugador AND f.idEquipo=(select idEquipo from Equipos as e2 where e2.nombre='" + nombreEquipo + "' AND e2.categoria='" + categoriaEquipo + "')";
                try
                {
                    rs = _cn.Execute(sql, out cantFilas);
                }
                catch
                {
                    return devolver = 2;
                }
                if (rs.RecordCount == 0)//equipo sin jugadores
                {
                    devolver = 3;
                }
                else
                {
                    while (!rs.EOF)
                    {
                        jugadoresEquipo.Add(Convert.ToString(rs.Fields[0].Value + " " + Convert.ToString(rs.Fields[1].Value)));
                        rs.MoveNext();
                    }
                }
            }
            rs = null;
            return devolver;
        }
        public static byte mostrarJugadoresDeEquipo(string usuario, int idEncuentro, int idDeporte)
        {
            byte devolver = 0;
            object cantFilas;
            string sql;
            ADODB.Recordset rs = new ADODB.Recordset();
            if (_cn.State == 0)//si esta cerrada
            {
                devolver = 1;
            }
            else
            {
                sql = "insert into Visualiza (idUsuario, idEncuentro, idDeporte) values ( (select idUsuario from Vip where nombre='" +usuario + "'), "+idEncuentro + ", " + idDeporte + ")" ;
                try
                {
                    rs = _cn.Execute(sql, out cantFilas);
                }
                catch
                {
                    return devolver = 2;
                }
                
            }
            rs = null;
            return devolver;
        }
        public static byte cargarNombreEncuentrosConEquipo(List<string> listaEventosColectivos, string nombre, string categoria)
        {
            byte devolver = 0;
            object cantFilas;
            string sql;
            ADODB.Recordset rs = new ADODB.Recordset();
            if (_cn.State == 0)//si esta cerrada
            {
                devolver = 1;
            }
            else
            {
                sql = "select distinct e.idEncuentro, e.descripcionEncuentro, e.fechaComienzo from encuentros as e, compite as c where e.idEncuentro=c.idEncuentro and c.idEquipo=(select idEquipo from Equipos where nombre='"+nombre +"' AND categoria='" + categoria+ "') AND e.fechaComienzo>=curdate()";
                try
                {
                    rs = _cn.Execute(sql, out cantFilas);
                }
                catch
                {
                    return devolver = 2;
                }
                if (rs.RecordCount == 0)
                {
                    devolver = 3;
                }
                else
                {
                    while (!rs.EOF)
                    {
                        listaEventosColectivos.Add(Convert.ToString(rs.Fields[0].Value) + " " + Convert.ToString(rs.Fields[1].Value) + " -" + Convert.ToString(rs.Fields[2].Value));
                        rs.MoveNext();
                    }
                }
            }
            rs = null;
            return devolver;
        }
        public static byte cargarNombreEquipos(List<string> listaEquipos)
        {
            byte devolver = 0;
            object cantFilas;
            string sql;
            ADODB.Recordset rs = new ADODB.Recordset();
            if (_cn.State == 0)//si esta cerrada
            {
                devolver = 1;
            }
            else
            {
                sql = "select nombre, categoria from Equipos";
                try
                {
                    rs = _cn.Execute(sql, out cantFilas); //out cantFilas, devuelve cantidad de filas afectadas, y cuales fueron
                }
                catch
                {
                    return devolver = 2;
                }
                if (rs.RecordCount == 0)
                {
                    devolver = 3;//no hay equipos cargados
                }
                else
                {
                    while (!rs.EOF)
                    {
                        listaEquipos.Add(Convert.ToString(rs.Fields[0].Value) + "/" + Convert.ToString(rs.Fields[1].Value));
                        rs.MoveNext();
                    }
                }
            }
            rs = null;
            return devolver;
        }
        public static byte cargarNombreEncuentrosConTodosLosFiltros(List<string> listaEventosColectivos, string nombre, string categoria, string deporte)
        {
            byte devolver = 0;
            object cantFilas;
            string sql;
            ADODB.Recordset rs = new ADODB.Recordset();
            if (_cn.State == 0)//si esta cerrada
            {
                devolver = 1;
            }
            else
            {
                sql = "select distinct e.idEncuentro, e.descripcionEncuentro, e.fechaComienzo from encuentros as e, compite as c where e.idEncuentro=c.idEncuentro and c.idEquipo=(select idEquipo from Equipos where nombre='" + nombre + "' AND categoria='" + categoria + "') AND e.fechaComienzo>=curdate() AND c.idDeporteEncuentro=(select idDeporte from Deportes where nombre='" + deporte + "')";
                try
                {
                    rs = _cn.Execute(sql, out cantFilas);
                }
                catch
                {
                    return devolver = 2;
                }
                if (rs.RecordCount == 0)
                {
                    devolver = 3;
                }
                else
                {
                    while (!rs.EOF)
                    {
                        listaEventosColectivos.Add(Convert.ToString(rs.Fields[0].Value) + " " + Convert.ToString(rs.Fields[1].Value) + " -" + Convert.ToString(rs.Fields[2].Value));
                        rs.MoveNext();
                    }
                }
            }
            rs = null;
            return devolver;
        }
        public static byte cargarNombreEncuentrosJugados(List<string> listaEventosColectivos, string deporte)
        {
            byte devolver = 0;
            object cantFilas;
            string sql;
            ADODB.Recordset rs = new ADODB.Recordset();
            if (_cn.State == 0)//si esta cerrada
            {
                devolver = 1;
            }
            else
            {
                sql = "select e.descripcionEncuentro, e.fechaComienzo, e.idEncuentro from Encuentros as e where e.idDeporte=(select idDeporte from Deportes where nombre='" + deporte + "') AND e.fechaComienzo<=curdate()";
                try
                {
                    rs = _cn.Execute(sql, out cantFilas);
                }
                catch
                {
                    return devolver = 2;
                }
                if (rs.RecordCount == 0)
                {
                    return devolver = 3;
                }
                else
                {
                    while (!rs.EOF)
                    {
                        listaEventosColectivos.Add(Convert.ToString(rs.Fields[2].Value) + " " + Convert.ToString(rs.Fields[0].Value) + " -" + Convert.ToString(rs.Fields[1].Value));
                        rs.MoveNext();
                    }
                }
            }
            rs = null;
            return devolver;
        }
        public static byte cargarNombreEncuentrosJugadosconEquipo(List<string> listaEventosColectivos, string nombre, string categoria)
        {
            byte devolver = 0;
            object cantFilas;
            string sql;
            ADODB.Recordset rs = new ADODB.Recordset();
            if (_cn.State == 0)//si esta cerrada
            {
                devolver = 1;
            }
            else
            {
                sql = "select distinct e.idEncuentro, e.descripcionEncuentro, e.fechaComienzo from encuentros as e, compite as c where e.idEncuentro=c.idEncuentro and c.idEquipo=(select idEquipo from Equipos where nombre='" + nombre + "' AND categoria='" + categoria + "') AND e.fechaComienzo<=curdate()";
                try
                {
                    rs = _cn.Execute(sql, out cantFilas);
                }
                catch
                {
                    return devolver = 2;
                }
                if (rs.RecordCount == 0)
                {
                    devolver = 3;
                }
                else
                {
                    while (!rs.EOF)
                    {
                        listaEventosColectivos.Add(Convert.ToString(rs.Fields[0].Value) + " " + Convert.ToString(rs.Fields[1].Value) + " -" + Convert.ToString(rs.Fields[2].Value));
                        rs.MoveNext();
                    }
                }
            }
            rs = null;
            return devolver;
        }
        public static byte cargarNombreEncuentrosJugadosConTodosLosFiltros(List<string> listaEventosColectivos, string nombre, string categoria, string deporte)
        {
            byte devolver = 0;
            object cantFilas;
            string sql;
            ADODB.Recordset rs = new ADODB.Recordset();
            if (_cn.State == 0)//si esta cerrada
            {
                devolver = 1;
            }
            else
            {
                sql = "select distinct e.idEncuentro, e.descripcionEncuentro, e.fechaComienzo from encuentros as e, compite as c where e.idEncuentro=c.idEncuentro and c.idEquipo=(select idEquipo from Equipos where nombre='" + nombre + "' AND categoria='" + categoria + "') AND e.fechaComienzo<=curdate() AND c.idDeporteEncuentro=(select idDeporte from Deportes where nombre='" + deporte + "')";
                try
                {
                    rs = _cn.Execute(sql, out cantFilas);
                }
                catch
                {
                    return devolver = 2;
                }
                if (rs.RecordCount == 0)
                {
                    devolver = 3;
                }
                else
                {
                    while (!rs.EOF)
                    {
                        listaEventosColectivos.Add(Convert.ToString(rs.Fields[0].Value) + " " + Convert.ToString(rs.Fields[1].Value) + " -" + Convert.ToString(rs.Fields[2].Value));
                        rs.MoveNext();
                    }
                }
            }
            rs = null;
            return devolver;
        }
        public static byte mostrarAlineaciondeEquipoYsuLogo(List<string> jNombre, List<string> jApellido, List<string> jPosicion, List<string> jEquipo, int idEncuentro, string nombreEquipo, string categoriaEquipo, EncuentrosColectivos c)
        {
            byte devolver = 0;
            object cantFilas;
            string sql;
            ADODB.Recordset rs = new ADODB.Recordset();
            if (_cn.State == 0)//si esta cerrada
            {
                devolver = 1;
            }
            else
            {
                sql = "select j.nombre, j.apellido, a.Poscion, equi.Nombre, equi.logo from Jugador as j, Alineacion as a, Encuentros as e, Utiliza as u, Equipos as equi, Forman as f where a.idAlineacion = u.idAlineacion AND u.idEncuentro = e.idEncuentro AND e.idEncuentro =" + idEncuentro + " AND j.idJugador = a.idJugador AND equi.idEquipo = f.idEquipo AND f.idJugador = j.idJugador AND equi.idEquipo =(select idEquipo from Equipos as e2 where e2.nombre='" + nombreEquipo + "' AND e2.categoria='" + categoriaEquipo + "')";
                try
                {
                    rs = _cn.Execute(sql, out cantFilas);
                }
                catch
                {
                    return devolver = 2;
                }
                if (rs.RecordCount == 0)//equipo sin Alineacion
                {
                    devolver = 3;
                }
                else
                {
                    while (!rs.EOF)
                    {
                        jNombre.Add(Convert.ToString(rs.Fields[0].Value));
                        jApellido.Add(Convert.ToString(rs.Fields[1].Value));
                        jPosicion.Add(Convert.ToString(rs.Fields[2].Value));
                        jEquipo.Add(Convert.ToString(rs.Fields[3].Value));
                        c.nombreDeporte = Convert.ToString(rs.Fields[4].Value);//aca se almacena la url del equipo
                        rs.MoveNext();
                    }
                }
            }
            rs = null;
            return devolver;
        }




    }
}