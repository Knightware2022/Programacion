using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BackOfficeAdministracion
{
    public static class Logica
    {
        public static ADODB.Connection _cn = new ADODB.Connection();

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
            rs = null;
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
            rs = null;
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
            rs = null;
            return devolver;
        }
        public static byte BuscandoUsuarioGuest(string nombreGuest) {
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
                sql = "select nombreAutogen from Guest where nombreAutogen='" + nombreGuest + "'";
                try
                {
                    rs = _cn.Execute(sql, out cantFilas); //out cantFilas, devuelve cantidad de filas afectadas, y cuales fueron
                }
                catch
                {
                    return devolver = 2;
                }
                if (rs.RecordCount == 0)//no hay usuario guest con ese nombre
                {
                    devolver = 3;
                }
            }
            return devolver;
        }
        public static byte eliminarUsuarioGuest(string nombre)
        {
            byte devolver = 0;
            object cantFilas;
            int id;
            string sql;
            ADODB.Recordset rs = new ADODB.Recordset();
            if (_cn.State == 0)//si esta cerrada
            {
                devolver = 1;
            }
            else
            {
                sql = "select idUsuario from Guest where nombreAutogen='" + nombre + "'";
                try
                {
                    rs = _cn.Execute(sql, out cantFilas); //out cantFilas, devuelve cantidad de filas afectadas, y cuales fueron
                }
                catch
                {
                    throw;
                    return devolver = 2;
                }
                if (rs.RecordCount == 0) {//no hay un usuario guest con ese nombre
                    devolver = 3;
                }
                else {
                    id = Convert.ToInt32(rs.Fields[0].Value);
                    /*sql = "delete from Guest where idUsuario=" + id;
                    try
                    {
                        rs = _cn.Execute(sql, out cantFilas); //out cantFilas, devuelve cantidad de filas afectadas, y cuales fueron
                    }
                    catch
                    {
                        throw;

                        return devolver = 2;
                    }*/
                    sql = "delete from Usuarios where idUsuario=" + id;
                    try
                    {
                        rs = _cn.Execute(sql, out cantFilas); //out cantFilas, devuelve cantidad de filas afectadas, y cuales fueron
                    }
                    catch
                    {
                        throw;

                        return devolver = 2;
                    }
                }

            }
            rs = null;
            return devolver;
        }//faltaParaEliminarGuest
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
            rs = null;
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
                sql = "insert into Usuarios(idUsuario) values(" + u.id + ")";
                try
                {
                    rs = _cn.Execute(sql, out cantFilas); //out cantFilas, devuelve cantidad de filas afectadas, y cuales fueron
                }
                catch
                {
                    return devolver = 2;//error inesperado
                }
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
            rs = null;
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
            rs = null;
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
                sql = "Select nombreAutogen from Guest";
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
            rs = null;

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
                /*  sql = "delete from Vip where nombre='" + nombre + "'";
                  try
                  {
                      rs = _cn.Execute(sql, out cantFilas); //out cantFilas, devuelve cantidad de filas afectadas, y cuales fueron
                  }
                  catch
                  {
                      throw;
                      return devolver = 2;
                  }*/
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
            rs = null;
            return devolver;
        }//faltaParaEliminarGuest
        public static byte crearUsuario(Usuario u)
        {
            byte devolver = 0;
            object cantFilas;
            string sql;
            string contraseña = "0123456789";
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
                    sql = "select correo from Vip where correo='" + u.correo + "'";
                    try
                    {
                        rs = _cn.Execute(sql, out cantFilas); //out cantFilas, devuelve cantidad de filas afectadas, y cuales fueron
                    }
                    catch
                    {
                        return devolver = 2;
                    }
                    if (rs.RecordCount != 0)
                    {
                        devolver = 3; //correo ya existente
                    }

                }
            }
            rs = null;
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
            rs = null;
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
            rs = null;
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
            rs = null;
            return devolver;
        }
        public static byte averiguarCorreo(Usuario u) {
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
                else {
                    u.nombre = Convert.ToString(rs.Fields[0].Value);
                }
            }
            rs = null;
            return devolver;
        }
        public static byte averiguarDeportesFavoritos(int idUsuario, List<string> lista) {
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
                if (rs.RecordCount == 0)
                {
                    devolver = 3;//no tiene deportes favoritos
                }
                else {
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
        public static byte cargarNombreEquipos(List<string> listaEquipos) {
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
        public static byte cargarDatosEquipo(Equipos equipo, Deportes d) {
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
                sql = "select idEquipo from Equipos where nombre='" + equipo.nombre + "' AND categoria ='" + equipo.categoria + "'";
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
                    devolver = 3;//no hay equipo con ese nombre
                }
                else
                {

                    equipo.id = Convert.ToInt32(rs.Fields[0].Value);

                    sql = "select nombre from Equipos where idEquipo=" + equipo.id;
                    try
                    {
                        rs = _cn.Execute(sql, out cantFilas); //out cantFilas, devuelve cantidad de filas afectadas, y cuales fueron
                    }
                    catch
                    {
                        return devolver = 2;
                    }
                    equipo.categoria = Convert.ToString(rs.Fields[0].Value);

                    sql = "select pais from Equipos where idEquipo=" + equipo.id;
                    try
                    {
                        rs = _cn.Execute(sql, out cantFilas); //out cantFilas, devuelve cantidad de filas afectadas, y cuales fueron
                    }
                    catch
                    {
                        return devolver = 2;
                    }
                    equipo.pais = Convert.ToString(rs.Fields[0].Value);

                    sql = "select logo from Equipos where idEquipo=" + equipo.id;
                    try
                    {
                        rs = _cn.Execute(sql, out cantFilas); //out cantFilas, devuelve cantidad de filas afectadas, y cuales fueron
                    }
                    catch
                    {
                        return devolver = 2;
                    }
                    equipo.logo = Convert.ToString(rs.Fields[0].Value);

                    sql = "select categoria from Equipos where idEquipo=" + equipo.id;
                    try
                    {
                        rs = _cn.Execute(sql, out cantFilas); //out cantFilas, devuelve cantidad de filas afectadas, y cuales fueron
                    }
                    catch
                    {
                        return devolver = 2;
                    }
                    equipo.categoria = Convert.ToString(rs.Fields[0].Value);

                    sql = "select idDeporte from Equipos where idEquipo=" + equipo.id;
                    try
                    {
                        rs = _cn.Execute(sql, out cantFilas); //out cantFilas, devuelve cantidad de filas afectadas, y cuales fueron
                    }
                    catch
                    {
                        return devolver = 2;
                    }
                    equipo.idDeporte = Convert.ToInt32(rs.Fields[0].Value);
                    sql = "select d.nombre from Deportes as d, Equipos as e where d.idDeporte = " + equipo.idDeporte;
                    try
                    {
                        rs = _cn.Execute(sql, out cantFilas); //out cantFilas, devuelve cantidad de filas afectadas, y cuales fueron
                    }
                    catch
                    {
                        return devolver = 2;
                    }
                        d.nombre = Convert.ToString(rs.Fields[0].Value);
                    
                }
            }
            rs = null;
            return devolver;

        }
        public static byte cargarNombreJugadores(List<string> listaJugadores)
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
                sql = "select nombre, apellido from Jugador" +
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
                        listaJugadores.Add(Convert.ToString(rs.Fields[0].Value) + " " + Convert.ToString(rs.Fields[1].Value));
                        rs.MoveNext();
                    }
                }
            }
            rs = null;
            return devolver;
        }
        public static byte cargarJugadoresParticipaEquipo(List<string> listaJugadores, int idEquipo)
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
                sql = "select nombre, apellido from jugador where jugador.idJugador IN (select idJugador from Forman where idEquipo=" + idEquipo + ") order by nombre asc";

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
                        listaJugadores.Add(Convert.ToString(rs.Fields[0].Value) + " " + Convert.ToString(rs.Fields[1].Value));
                        rs.MoveNext();
                    }
                }
            }
            rs = null;
            return devolver;
        }
        public static byte contarJugadoresdeEquipo(int idEquipo, List<int> cantidad)
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
                sql = "select count(nombre) from jugador where jugador.idJugador IN (select idJugador from Forman where idEquipo=" + idEquipo + ")";

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
                    cantidad.Add(Convert.ToInt32(rs.Fields[0].Value));
                }
            }
            rs = null;
            return devolver;

        }
        public static byte añadirJugadoraEquipo(int idEquipo, int idJugador, int idDeporte) {
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
                sql = "insert into Forman(idJugador, idEquipo, idDeporte) values ( " + idJugador + ", " + idEquipo +", "+  + idDeporte+")";
                try
                {
                    rs = _cn.Execute(sql, out cantFilas); //out cantFilas, devuelve cantidad de filas afectadas, y cuales fueron
                }
                catch
                {
                    return devolver = 2;
                }

            }
            rs = null;
            return devolver;
        }
        public static byte averiguarIDjugador(string nombre, string apellido, Jugador j) {
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
                sql = "select idJugador from Jugador where nombre='" + nombre + "' AND apellido='" + apellido + "'";
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
                    devolver = 3; //no encontre
                }
                else {
                    j.id = Convert.ToInt32(rs.Fields[0].Value);
                }
            }
            rs = null;
            return devolver;
        }
        public static byte quitarJugadorEquipo(int idEquipo, int idJugador, int idDeporte)
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
                sql = "delete from Forman where idJugador=" + idJugador + " AND idEquipo=" + idEquipo + "AND IdDeporte=" + idDeporte;
                try
                {
                    rs = _cn.Execute(sql, out cantFilas); //out cantFilas, devuelve cantidad de filas afectadas, y cuales fueron
                }
                catch
                {
                    return devolver = 2;
                }

            }
            rs = null;
            return devolver;
        }
        public static byte crearEquipo(Equipos equipo)
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
                sql = "insert into Equipos(idDeporte, idEquipo, categoria, logo, nombre, pais) values( "+equipo.idDeporte+", " + equipo.id + ", '" + equipo.categoria + "' ,'" + equipo.logo + "' ,'" + equipo.nombre + "' ,'" + equipo.pais + "')";
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
        public static byte BuscarIDequipo(int id)
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
                sql = "select idEquipo from Equipos where idEquipo =" + id;
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
            rs = null;
            return devolver;
        }
        public static byte buscarDatosJugador(Jugador jugador) {
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
                sql = "select * from Jugador where nombre='" + jugador.nombre + "' AND apellido= '" + jugador.apelido + "'";
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
                    jugador.id = Convert.ToInt32(rs.Fields[0].Value);
                    jugador.nombre = Convert.ToString(rs.Fields[1].Value);
                    jugador.apelido = Convert.ToString(rs.Fields[2].Value);
                    jugador.edad = Convert.ToInt32(rs.Fields[3].Value);
                    jugador.sexo = Convert.ToChar(rs.Fields[4].Value);
                    jugador.paisNacimiento = Convert.ToString(rs.Fields[5].Value);
                }
            }
            rs = null;
            return devolver;
        }
        public static byte actualizarJugador(Jugador jugador)
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
                sql = "update Jugador set nombre='" + jugador.nombre + "' where idJugador=" + jugador.id;
                try
                {
                    rs = _cn.Execute(sql, out cantFilas); //out cantFilas, devuelve cantidad de filas afectadas, y cuales fueron
                }
                catch
                {

                    return devolver = 2;
                }
                sql = "update Jugador set apellido='" + jugador.apelido + "' where idJugador=" + jugador.id;
                try
                {
                    rs = _cn.Execute(sql, out cantFilas); //out cantFilas, devuelve cantidad de filas afectadas, y cuales fueron
                }
                catch
                {

                    return devolver = 2;
                }
                sql = "update Jugador set sexo='" + jugador.sexo + "' where idJugador=" + jugador.id;
                try
                {
                    rs = _cn.Execute(sql, out cantFilas); //out cantFilas, devuelve cantidad de filas afectadas, y cuales fueron
                }
                catch
                {

                    return devolver = 2;
                }
                sql = "update Jugador set paisNacimiento='" + jugador.paisNacimiento + "' where idJugador=" + jugador.id;
                try
                {
                    rs = _cn.Execute(sql, out cantFilas); //out cantFilas, devuelve cantidad de filas afectadas, y cuales fueron
                }
                catch
                {

                    return devolver = 2;
                }
                sql = "update Jugador set edad=" + jugador.edad + " where idJugador=" + jugador.id;
                try
                {
                    rs = _cn.Execute(sql, out cantFilas); //out cantFilas, devuelve cantidad de filas afectadas, y cuales fueron
                }
                catch
                {

                    return devolver = 2;
                }
            }
            rs = null;

            return devolver;
        }
        public static byte crearJugador(Jugador jugador) {
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
                sql = "insert into Jugador(idJugador, nombre, apellido, edad, sexo, paisNacimiento) values( " + jugador.id + ", '" + jugador.nombre + "', '" + jugador.apelido + "', " + jugador.edad + ", '" + jugador.sexo + "', '" + jugador.paisNacimiento + "' )";
                try
                {
                    rs = _cn.Execute(sql, out cantFilas); //out cantFilas, devuelve cantidad de filas afectadas, y cuales fueron
                }
                catch
                {
                    return devolver = 2;
                }
            }
            rs = null;
            return devolver;
        }
        public static byte buscarIdJugador(int id)
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
                sql = "select idJugador from Jugador where idJugador =" + id;
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
            rs = null;
            return devolver;
        }
        public static byte BorrarJugador(int idjugador)
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
                sql = "delete from Jugador where idJugador=" + idjugador;
                try
                {
                    rs = _cn.Execute(sql, out cantFilas); //out cantFilas, devuelve cantidad de filas afectadas, y cuales fueron
                }
                catch
                {
                    return devolver = 2;
                }

            }
            rs = null;
            return devolver;
        }
        public static byte actualizarEquipo(Equipos equipo, string deporte)
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
                sql = "update Equipos set nombre='" + equipo.nombre + "' where idEquipo=" + equipo.id;
                try
                {
                    rs = _cn.Execute(sql, out cantFilas); //out cantFilas, devuelve cantidad de filas afectadas, y cuales fueron
                }
                catch
                {

                    return devolver = 2;
                }
                sql = "update Equipos set categoria='" + equipo.categoria + "' where idEquipo=" + equipo.id;
                try
                {
                    rs = _cn.Execute(sql, out cantFilas); //out cantFilas, devuelve cantidad de filas afectadas, y cuales fueron
                }
                catch
                {

                    return devolver = 2;
                }
                sql = "update Equipos set logo='" + equipo.logo + "' where idEquipo=" + equipo.id;
                try
                {
                    rs = _cn.Execute(sql, out cantFilas); //out cantFilas, devuelve cantidad de filas afectadas, y cuales fueron
                }
                catch
                {

                    return devolver = 2;
                }
                sql = "update Equipos set pais='" + equipo.pais + "' where idEquipo=" + equipo.id;
                try
                {
                    rs = _cn.Execute(sql, out cantFilas); //out cantFilas, devuelve cantidad de filas afectadas, y cuales fueron
                }
                catch
                {

                    return devolver = 2;
                }
                sql = "update Equipos set idDeporte='" + equipo.idDeporte + "' where idEquipo=" + equipo.id;
                try
                {
                    rs = _cn.Execute(sql, out cantFilas); //out cantFilas, devuelve cantidad de filas afectadas, y cuales fueron
                }
                catch
                {

                    return devolver = 2;
                }


            }
            rs = null;

            return devolver;
        }
        public static byte BorrarEquipo(int idEquipo, int idDeporte)
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
                sql = "delete from Equipos where idEquipo=" + idEquipo + " AND idDeporte=" + idDeporte;
                try
                {
                    rs = _cn.Execute(sql, out cantFilas); //out cantFilas, devuelve cantidad de filas afectadas, y cuales fueron
                }
                catch
                {
                    return devolver = 2;
                }

            }
            rs = null;
            return devolver;
        }
        public static byte nombresDeportes(List<string> lista) {
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
        public static byte DatosDeporte(List<string> lista, Deportes deporte)
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
                sql = "select * from Deportes where nombre='" + deporte.nombre + "'";
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
                    devolver = 3;//no hay equipos cargados con ese nombre y categoria
                }
                else
                {
                    deporte.id = Convert.ToInt32(rs.Fields[0].Value);
                    deporte.categoria = Convert.ToString(rs.Fields[1].Value);
                    deporte.nombre = Convert.ToString(rs.Fields[2].Value);
                    sql = "select e.nombre, e.categoria from Equipos as e where e.idDeporte =" + deporte.id;
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
                        devolver = 4;//no hay equipos cargados con ese nombre y categoria
                    }
                    else
                    {
                        while (!rs.EOF)
                        {
                            lista.Add(Convert.ToString(rs.Fields[0].Value) + "/" + Convert.ToString(rs.Fields[1].Value));
                            rs.MoveNext();
                        }
                    }
                }

            }
            rs = null;
            return devolver;
        }
        public static byte crearDeporte(Deportes deporte)
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
                sql = "insert into Deportes(idDeporte, categoria, nombre) values( " + deporte.id + ", '" + deporte.categoria + "', '" + deporte.nombre + "')";
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
        public static byte BuscarIDdeporte(int id)
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
                sql = "select idDeporte from Deportes where idDeporte=" + id;
                try
                {
                    rs = _cn.Execute(sql, out cantFilas);
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
            rs = null;
            return devolver;
        }
        public static byte BorrarDeporte(int idDeporte)
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
                sql = "delete from Deportes where idDeporte=" + idDeporte;
                try
                {
                    rs = _cn.Execute(sql, out cantFilas); //out cantFilas, devuelve cantidad de filas afectadas, y cuales fueron
                }
                catch
                {
                    throw;
                    return devolver = 2;
                }

            }
            rs = null;
            return devolver;
        }
        public static byte actualizarDeporte(Deportes deporte)
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
                sql = "update Deportes set categoria='" + deporte.categoria + "' where idDeporte=" + deporte.id;
                try
                {
                    rs = _cn.Execute(sql, out cantFilas); //out cantFilas, devuelve cantidad de filas afectadas, y cuales fueron
                }
                catch
                {

                    return devolver = 2;
                }
                sql = "update Deportes set nombre='" + deporte.nombre + "' where idDeporte=" + deporte.id;
                try
                {
                    rs = _cn.Execute(sql, out cantFilas); //out cantFilas, devuelve cantidad de filas afectadas, y cuales fueron
                }
                catch
                {

                    return devolver = 3;
                }
            }
            rs = null;

            return devolver;
        }
        public static byte cargarNombreEncuentros(List<string> listaEventosColectivos)
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
                sql = "select e.descripcionEncuentro, e.idEncuentro from Competencia_Colectiva as c, Encuentros as e where e.idEncuentro=c.idEncuentro";
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
                        listaEventosColectivos.Add("ID:" + Convert.ToString(rs.Fields[1].Value) + " -" + Convert.ToString(rs.Fields[0].Value));
                        rs.MoveNext();
                    }
                }
            }
            rs = null;
            return devolver;
        }
        public static byte DatosEncuentrosColectivos(EncuentrosColectivos encuentro, List<string> nombresEquipos) {
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
                    throw;
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
                        throw;

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
                        throw;

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
        public static byte quitarEquipoEncuentroColectivo(string nombreEquipo, string categoriaEquipo, int idEncuentro, int idDeporte)
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
                sql = "delete from Compite where idEncuentro="+ idEncuentro+" AND idEquipo=(select idEquipo from Equipos as e where e.nombre='"+nombreEquipo +"' AND e.categoria='"+categoriaEquipo+"') AND idDeporteEncuentro=idDeporteEquipo=" + idDeporte;
                try
                {
                    rs = _cn.Execute(sql, out cantFilas); //out cantFilas, devuelve cantidad de filas afectadas, y cuales fueron
                }
                catch
                {
                    return devolver = 2;
                }               
            }
            rs = null;
            return devolver;
        }
        public static byte AgregarEquipoEncuentroColectivo(string nombreEquipo, string categoriaEquipo, EncuentrosColectivos en)
        {
            int idEquipo = 0, idDeporteEquipo = 0;
            ArrayList jugadoresEquipo = new ArrayList();
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
                sql = "select j.idJugador, f.idEquipo, f.idDeporteEquipo from Jugador as j, Forman as f  where j.idJugador = f.idJugador AND f.idEquipo=(select idEquipo from Equipos as e2 where e2.nombre='" +nombreEquipo+"' AND e2.categoria='"+ categoriaEquipo+"')";
                try
                {
                    rs = _cn.Execute(sql, out cantFilas); 
                }
                catch
                {
                    throw;
                    return devolver = 2;
                }
                if (rs.RecordCount == 0)//equipo sin jugadores
                {
                    devolver = 3;
                }
                else
                {
                    idEquipo = Convert.ToInt32(rs.Fields[1].Value);
                    idDeporteEquipo = Convert.ToInt32(rs.Fields[2].Value);

                    while (!rs.EOF)
                    {
                        jugadoresEquipo.Add(Convert.ToString(rs.Fields[0].Value));
                        rs.MoveNext();                      
                    }
                    for (int i = 0; i < jugadoresEquipo.Count; i++)
                    {
                        sql = "insert into Compite(idDeporteEncuentro, idEncuentro,idEquipo, idJugador, idDeporteEquipo) values(" +en.deporteEncuentro +", "+ en.idEncuentro+", " +idEquipo +", "+jugadoresEquipo[i] +", " + idDeporteEquipo + ")";
                        try
                        {
                            rs = _cn.Execute(sql, out cantFilas);
                        }
                        catch
                        {
                            throw;
                            return devolver = 2;
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
        public static byte mostrarNombresIncidencias(List<string> incidencias)
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
                sql = "select nombre from Ocurrencias";
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
                        incidencias.Add(Convert.ToString(rs.Fields[0].Value));
                        rs.MoveNext();
                    }
                }
            }
            rs = null;
            return devolver;
        }
        public static byte mostrarNombrePosicion(List<string> alineacion)
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
                sql = "select distinct Poscion from Alineacion";
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
                        alineacion.Add(Convert.ToString(rs.Fields[0].Value));
                        rs.MoveNext();
                    }
                }
            }
            rs = null;
            return devolver;
        }
        public static byte mostrarAlineaciondeEquipo(List<string> jNombre, List<string> jApellido, List<string> jPosicion, List<string> jEquipo, int idEncuentro, string nombreEquipo, string categoriaEquipo)
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
                sql = "select j.nombre, j.apellido, a.Poscion, equi.Nombre from Jugador as j, Alineacion as a, Encuentros as e, Utiliza as u, Equipos as equi, Forman as f where a.idAlineacion = u.idAlineacion AND u.idEncuentro = e.idEncuentro AND e.idEncuentro ="+idEncuentro+ " AND j.idJugador = a.idJugador AND equi.idEquipo = f.idEquipo AND f.idJugador = j.idJugador AND equi.idEquipo =(select idEquipo from Equipos as e2 where e2.nombre='" + nombreEquipo + "' AND e2.categoria='" + categoriaEquipo + "')";                
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
                        jNombre.Add(Convert.ToString(rs.Fields[0].Value) );
                        jApellido.Add(Convert.ToString(rs.Fields[1].Value));
                        jPosicion.Add(Convert.ToString(rs.Fields[2].Value));
                        jEquipo.Add(Convert.ToString(rs.Fields[3].Value));
                        rs.MoveNext();
                    }
                }
            }
            rs = null;
            return devolver;
        }
        public static byte BuscarIDIncidencias(int id)
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
                sql = "select idIncidencia from Incidencias where idIncidencia=" + id;
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
                    devolver = 3; //id no en uso
                }

            }
            rs = null;
            return devolver;
        }
        public static byte InsertarenPuntosNotifica(int idEncuentro, int idDeporteEncuentro, int idIncidencia, int minuto, string nombreJ, string apellidoJ, string ocurrencia)
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
                sql = "insert into Incidencias(idIncidencia) values("+ idIncidencia +")";
                try
                {
                    rs = _cn.Execute(sql, out cantFilas);
                }
                catch
                {
                    return devolver = 2;
                }
                sql = "insert into Puntos(idIncidencia, minuto, idJugador) values(" + idIncidencia + ", " + minuto + ", (select j.idJugador from Jugador as j where j.nombre='" + nombreJ + "' AND j.apellido='" + apellidoJ + "'))";
                try
                {
                    rs = _cn.Execute(sql, out cantFilas);
                }
                catch
                {

                    return devolver = 2;
                }

                sql = "select o.idOcurrencia from Ocurrencias as o where o.nombre = '" + ocurrencia + "'";
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
                    bool bandera = true;
                    Random r = new Random();
                    int idRandom = 0;
                    while (bandera == true) {
                        idRandom = r.Next();
                        sql = "select idOcurrencia from Ocurrencias where idOcurrencia=" + idRandom;
                        try
                        {
                            rs = _cn.Execute(sql, out cantFilas);
                        }
                        catch
                        {

                            return devolver = 2;
                        }
                        if (rs.RecordCount == 0) {
                            bandera = false;
                        }
                    }
                    sql = "insert into Ocurrencias(idOcurrencia, nombre) values("+idRandom +", '"+ ocurrencia+"')";
                    try
                    {
                        rs = _cn.Execute(sql, out cantFilas);
                    }
                    catch
                    {

                        return devolver = 3;
                    }
                    sql = "insert into Hacen(idIncidencia, idOcurrencia) values(" + idIncidencia + ", " + idRandom + ")";
                    try
                    {

                        rs = _cn.Execute(sql, out cantFilas);
                    }
                    catch
                    {

                        return devolver = 3;
                    }
                    sql = "insert into Notifica(idIncidencia, idOcurrencia, idEncuentro, idDeporte) values(" + idIncidencia + ", " + idRandom + ", " + idEncuentro + ", "+ idDeporteEncuentro+")";
                    try
                    {
                        rs = _cn.Execute(sql, out cantFilas);
                    }
                    catch
                    {
                        return devolver = 4;
                    }

                }
                else {
                    sql = "insert into Hacen(idIncidencia, idOcurrencia) values(" + idIncidencia + ", (select o.idOcurrencia from Ocurrencias as o where o.nombre='" + ocurrencia + "'))";
                    try
                    {

                        rs = _cn.Execute(sql, out cantFilas);
                    }
                    catch
                    {

                        return devolver = 3;
                    }
                    sql = "insert into Notifica(idIncidencia, idOcurrencia, idEncuentro, idDeporte) values(" + idIncidencia + ", (select o.idOcurrencia from Ocurrencias as o where o.nombre='" + ocurrencia + "'), " + idEncuentro + ", " + idDeporteEncuentro+")";
                    try
                    {
                        rs = _cn.Execute(sql, out cantFilas);
                    }
                    catch
                    {

                        return devolver = 4;
                    }
                }



                

            }
            rs = null;
            return devolver;
        }
        public static byte BuscarIDalineacion(int id)
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
                sql = "select idAlineacion from Alineacion where idAlineacion=" + id;
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
                    devolver = 3; //id no en uso
                }

            }
            rs = null;
            return devolver;
        }
        public static byte insertarAlineacion(int idEncuentro, int idDeporteEncuentro, string nombreJ, string apellidoJ, string posicion, int idAlineacion)
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
                sql = "insert into Alineacion(idAlineacion,Poscion,idJugador) values("+ idAlineacion + ", '" + posicion + "', " + "(select j.idJugador from Jugador as j where j.nombre='" + nombreJ + "' AND j.apellido='" + apellidoJ + "'))";
                try
                {
                    rs = _cn.Execute(sql, out cantFilas);
                }
                catch
                {
                    return devolver = 2;
                }

                sql = "select a.idAlineacion from Alineacion as a, Encuentros as e, Utiliza as u where e.idEncuentro="+ idEncuentro+ "=u.idEncuentro AND a.idJugador=(select j.idJugador from Jugador as j where j.nombre='" + nombreJ + "' AND j.apellido='" + apellidoJ + "') AND a.idAlineacion = u.idAlineacion";
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
                    sql = "insert into Utiliza(idAlineacion, idEncuentro, idDeporte)) values(" + idAlineacion + ", " + idEncuentro + ", " +idDeporteEncuentro+")";
                    try
                    {
                        rs = _cn.Execute(sql, out cantFilas);
                    }
                    catch
                    {
                        return devolver = 3;
                    }
                }
                else
                {
                    int idAlineacionVieja = Convert.ToInt32(rs.Fields[0].Value);
                    sql = "delete from Utiliza where idEncuentro=" + idEncuentro + " AND idAlineacion=" + idAlineacionVieja + " AND idDeporte="+idDeporteEncuentro;
                    try
                    {
                        rs = _cn.Execute(sql, out cantFilas);
                    }
                    catch
                    {
                        return devolver = 2;
                    }
                    sql = "insert into Utiliza (idEncuentro, idAlineacion, idDeporte) values (" + idEncuentro + ", " + idAlineacion + ", " + idDeporteEncuentro+")";
                    try
                    {
                        rs = _cn.Execute(sql, out cantFilas);

                    }
                    catch
                    {
                        return devolver = 2;
                    }
                }
            }
            rs = null;
            return devolver;
        }
        public static byte BuscarIDEvento(int id)
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
                sql = "select idEncuentro from Encuentros where idEncuentro=" + id;
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
                    devolver = 3; //id no en uso
                }

            }
            rs = null;
            return devolver;
        }
        public static byte insertarEventoColectivo(EncuentrosColectivos encuentros, string fechaComienzo, string fechaFin)
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
                sql = "insert into Encuentros(idDeporte, idEncuentro, fechaComienzo, fechaFinaliza, descripcionEncuentro) values("+encuentros.deporteEncuentro+", "+ encuentros.idEncuentro+", '" + fechaComienzo + "', '"+ fechaFin + "', '"+ encuentros.descripcion+"')"; 
                try
                {

                    rs = _cn.Execute(sql, out cantFilas);
                }
                catch
                {
                    return devolver = 2;
                }
                sql = "insert into Competencia_Colectiva(idEncuentro, idDeporte) values(" + encuentros.idEncuentro + ", "+ encuentros.deporteEncuentro+")";
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
        public static byte EliminarEncuentro(int idEncuentro, int idDeporte)
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
                sql = "delete from Encuentros where idEncuentro=" + idEncuentro + "AND idDeporte=" + idDeporte;
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
        public static byte ActualizarEventoColectivo(EncuentrosColectivos en, string fechaC, string fechaF)
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
                sql = "update Encuentros set fechaComienzo='"+fechaC +"' where idEncuentro=" + en.idEncuentro;
                try
                {
                    rs = _cn.Execute(sql, out cantFilas);
                }
                catch
                {
                    return devolver = 2;
                }
                sql = "update Encuentros set fechaFinaliza='" + fechaF + "' where idEncuentro=" + en.idEncuentro;
                try
                {
                    rs = _cn.Execute(sql, out cantFilas);
                }
                catch
                {
                    return devolver = 2;
                }
                sql = "update Encuentros set descripcionEncuentro='" + en.descripcion + "' where idEncuentro=" + en.idEncuentro;
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
        public static byte cargarNombreEncuentrosIndividuales(List<string> listaEventosIndividuales)
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
                sql = "select e.descripcionEncuentro, e.idEncuentro from Competencia_Individual as c, Encuentros as e where e.idEncuentro=c.idEncuentro";
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
                        listaEventosIndividuales.Add("ID:" + Convert.ToString(rs.Fields[1].Value) + " -" + Convert.ToString(rs.Fields[0].Value));
                        rs.MoveNext();
                    }
                }
            }
            rs = null;
            return devolver;
        }
        public static byte DatosEncuentroIndividual(EncuentrosIndividuales encuentro, List<string> nombresParticipantes)
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
                    throw;
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
                    sql = "Select d.nombre from Deportes as d where d.idDeporte="+ encuentro.deporteEncuentro;
                    try
                    {
                        rs = _cn.Execute(sql, out cantFilas); //out cantFilas, devuelve cantidad de filas afectadas, y cuales fueron
                    }
                    catch
                    {
                        throw;

                        return devolver = 2;
                    }         
                        encuentro.nombreDeporte = Convert.ToString(rs.Fields[0].Value);                   
                    sql = "select distinct p.nombre, p.apellido from Participa as parti, Participantes as p where parti.idEncuentro=" + encuentro.idEncuentro + " AND p.idParticipante=parti.idParticipante AND parti.idDeporteEncuentro=p.idDeporte AND parti.idDeporteEncuentro=" + encuentro.deporteEncuentro;
                    try
                    {
                        rs = _cn.Execute(sql, out cantFilas);
                    }
                    catch
                    {
                        throw;

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
                            nombresParticipantes.Add((Convert.ToString(rs.Fields[0].Value) + " " + Convert.ToString(rs.Fields[1].Value)) );
                            rs.MoveNext();
                        }
                    }

                }
            }
            rs = null;
            return devolver;
        }
        public static byte ParticipantesEnSistema(List<string> nombresParticipantes)
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
                sql = "select distinct p.nombre, p.apellido from Participantes as p";
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
                        nombresParticipantes.Add((Convert.ToString(rs.Fields[0].Value) + " " + Convert.ToString(rs.Fields[1].Value)));
                        rs.MoveNext();
                    }
                }

            }
            rs = null;
            return devolver;
        }
        public static byte AgregarParticipanteEncuentro(int idEncuentro, int idDeporteEncuentro, string nombre, string apellido)
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
                sql = "insert into Participa(idDeporteEncuentro,idEncuentro,idParticipante, idDeporteParticipante) values (" + idDeporteEncuentro +", "+ idEncuentro + ",(select idParticipante from Participantes where nombre='" + nombre + "' AND apellido='" + apellido + "' ), (select idDeporte from Participantes where nombre='" + nombre + "' AND apellido='" + apellido + "' ))";
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
        public static byte participantesEncuentrosIndividuales(int idEncuentro, List<string> nombresParticipantes)
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
               
                    sql = "select distinct p.nombre, p.apellido from Participa as parti, Participantes as p where parti.idEncuentro=" + idEncuentro + " AND p.idParticipante=parti.idParticipante";
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
                            nombresParticipantes.Add((Convert.ToString(rs.Fields[0].Value) + " " + Convert.ToString(rs.Fields[1].Value)));
                            rs.MoveNext();
                        }
                    }

                
            }
            rs = null;
            return devolver;
        }      
        public static byte EliminarParticipanteEncuentro(int idEncuentro, int idDeporteEncuentro, string nombre, string apellido)
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
                sql = "delete from Participa where idEncuentro=" + idEncuentro + " AND idParticipante = (select idParticipante from Participantes where nombre='" + nombre + "' AND apellido='" + apellido + "' ) AND idDeporteEncuentro="+ idDeporteEncuentro;
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
        public static byte ActualizarEncuentroIndividual(EncuentrosIndividuales en, string fechaC, string fechaF)
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
                sql = "update Encuentros set fechaComienzo='" + fechaC + "' where idEncuentro=" + en.idEncuentro;
                try
                {
                    rs = _cn.Execute(sql, out cantFilas);
                }
                catch
                {
                    return devolver = 2;
                }
                sql = "update Encuentros set fechaFinaliza='" + fechaF + "' where idEncuentro=" + en.idEncuentro;
                try
                {
                    rs = _cn.Execute(sql, out cantFilas);
                }
                catch
                {
                    return devolver = 2;
                }
                sql = "update Encuentros set descripcionEncuentro='" + en.descripcion + "' where idEncuentro=" + en.idEncuentro;
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
        public static byte insertarEventoIndividual(EncuentrosIndividuales encuentros, string fechaComienzo, string fechaFin)
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
                sql = "insert into Encuentros(idDeporte, idEncuentro, fechaComienzo, fechaFinaliza, descripcionEncuentro) values("+encuentros.deporteEncuentro + ", " + encuentros.idEncuentro + ", '" + fechaComienzo + "', '" + fechaFin + "', '" + encuentros.descripcion + "')";
                try
                {

                    rs = _cn.Execute(sql, out cantFilas);
                }
                catch
                {
                    return devolver = 2;
                }
                sql = "insert into Competencia_Individual(idDeporte, idEncuentro) values("+encuentros.deporteEncuentro +", "+ encuentros.idEncuentro + ")";
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
        public static byte cargarNombreTorneosColectivos(List<string> listaTorneosColectivos)
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
                sql = "select t.idTorneo, t.nombreTorneo from Torneos as t, torneosColectivos as tc where t.idTorneo = tc.idTorneo";
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
                        listaTorneosColectivos.Add("ID:" + Convert.ToString(rs.Fields[0].Value) + " -" + Convert.ToString(rs.Fields[1].Value));
                        rs.MoveNext();
                    }
                }
            }
            rs = null;
            return devolver;
        }
        public static byte datosTorneosColectivos(Torneos torneo, List<string> equiposenEncuentro)
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
                sql = "Select t.* from Torneos as t, torneosColectivos as tc where t.idTorneo=" + torneo.idTorneo +" AND t.idTorneo=tc.idTorneo";
                try
                {
                    rs = _cn.Execute(sql, out cantFilas); 
                }
                catch
                {
                    throw;
                    return devolver = 2;
                }
                if (rs.RecordCount == 0)
                {
                    sql = "Select * from Torneos where idTorneo=" + torneo.idTorneo ;

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
                    else {
                        devolver = 6;
                    }
                }
                else
                {
                    torneo.idTorneo = Convert.ToInt32(rs.Fields[0].Value);
                    torneo.idDeporteTorneo = Convert.ToInt32(rs.Fields[1].Value);
                    torneo.fechaComienzo = Convert.ToDateTime(rs.Fields[2].Value);
                    torneo.fechaFinaliza = Convert.ToDateTime(rs.Fields[3].Value);
                    torneo.nombreTorneo = Convert.ToString(rs.Fields[4].Value);
                    sql = "Select d.nombre from Deportes as d where idDeporte=" + torneo.idDeporteTorneo;
                    try
                    {
                        rs = _cn.Execute(sql, out cantFilas); //out cantFilas, devuelve cantidad de filas afectadas, y cuales fueron
                    }
                    catch
                    {
                        throw;

                        return devolver = 2;
                    }
                    
                        torneo.nombreDeporte = Convert.ToString(rs.Fields[0].Value);
                    
                    sql = "select distinct e.nombre, e.categoria from Equipos as e, torneosTienenEncuentrosEquipos as tc where tc.idTorneo=" + torneo.idTorneo + " AND tc.idDeporteTorneo=" + torneo.idDeporteTorneo + " AND tc.idEquipo = e.idEquipo";
                    try
                    {
                        rs = _cn.Execute(sql, out cantFilas);
                    }
                    catch
                    {
                        throw;

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
                            equiposenEncuentro.Add((Convert.ToString(rs.Fields[0].Value) + "/" + Convert.ToString(rs.Fields[1].Value)));
                            rs.MoveNext();
                        }
                    }

                }
            }
            rs = null;
            return devolver;
        }
        public static byte ActualizarTorneoColectivo(Torneos torneos, string fechaC, string fechaF)
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
                sql = "update Torneos set fechaComienzo='" + fechaC + "' where idTorneo=" + torneos.idTorneo;
                try
                {
                    rs = _cn.Execute(sql, out cantFilas);
                }
                catch
                {
                    return devolver = 2;
                }
                sql = "update Torneos set fechaFinalizado='" + fechaF + "' where idTorneo=" + torneos.idTorneo;
                try
                {
                    rs = _cn.Execute(sql, out cantFilas);
                }
                catch
                {
                    return devolver = 2;
                }
                sql = "update Torneos set nombreTorneo='" + torneos.nombreTorneo + "' where idTorneo=" + torneos.idTorneo;
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
        public static byte insertarTorneoColectivo(Torneos torneo, string fechaComienzo, string fechaFin)
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
                sql = "insert into Torneos(idDeporte, idTorneo, fechaComienzo, fechaFinalizado, nombreTorneo) values( (select idDeporte from Deportes where nombre="+torneo.nombreTorneo + "), " + torneo.idTorneo + ", '" + fechaComienzo + "', '" + fechaFin + "', '" + torneo.nombreTorneo + "')";
                try
                {

                    rs = _cn.Execute(sql, out cantFilas);
                }
                catch
                {
                    throw;
                    return devolver = 2;
                }
                sql = "insert into torneosColectivos(idTorneo, idDeporte) values(" + torneo.idTorneo + ", (select idDeporte from Deportes where nombre = "+torneo.nombreTorneo +  "))";
                try
                {
                    rs = _cn.Execute(sql, out cantFilas);
                }
                catch
                {
                    throw;

                    return devolver = 2;
                }
            }
            rs = null;
            return devolver;
        }
        public static byte insertarParticularNotifica(int idEncuentro, int idDeporteEncuentro, int idIncidencia, int setsGanados, int puntosObtenidos, string nombreJ, string apellidoJ, string ocurrencia)
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
                sql = "insert into Incidencias(idIncidencia) values(" + idIncidencia + ")";
                try
                {
                    rs = _cn.Execute(sql, out cantFilas);
                }
                catch
                {
                    throw;
                    return devolver = 2;
                }
                sql = "insert into Particular(idIncidencia, setsGanados,puntosObtenidos,idParticipante) values(" + idIncidencia + ", " + setsGanados + ", "+ puntosObtenidos+ ", (select j.idJugador from Jugador as j where j.nombre='" + nombreJ + "' AND j.apellido='" + apellidoJ + "'))";
                try
                {
                    rs = _cn.Execute(sql, out cantFilas);
                }
                catch
                {
                    throw;

                    return devolver = 2;
                }

                sql = "select o.idOcurrencia from Ocurrencias as o where o.nombre = '" + ocurrencia + "'";
                try
                {
                    rs = _cn.Execute(sql, out cantFilas);
                }
                catch
                {
                    throw;


                    return devolver = 2;
                }
                if (rs.RecordCount == 0)
                {
                    bool bandera = true;
                    Random r = new Random();
                    int idRandom = 0;
                    while (bandera == true)
                    {
                        idRandom = r.Next();
                        sql = "select idOcurrencia from Ocurrencias where idOcurrencia=" + idRandom;
                        try
                        {
                            rs = _cn.Execute(sql, out cantFilas);
                        }
                        catch
                        {
                            throw;

                            return devolver = 2;
                        }
                        if (rs.RecordCount == 0)
                        {
                            bandera = false;
                        }
                    }
                    sql = "insert into Ocurrencias(idOcurrencia, nombre) values(" + idRandom + ", '" + ocurrencia + "')";
                    try
                    {
                        rs = _cn.Execute(sql, out cantFilas);
                    }
                    catch
                    {

                        return devolver = 3;
                    }
                    sql = "insert into Hacen(idIncidencia, idOcurrencia) values(" + idIncidencia + ", " + idRandom + ")";
                    try
                    {

                        rs = _cn.Execute(sql, out cantFilas);
                    }
                    catch
                    {

                        return devolver = 3;
                    }
                    sql = "insert into Notifica(idIncidencia, idOcurrencia, idEncuentro, idDeporte) values(" + idIncidencia + ", " + idRandom + ", " + idEncuentro + ", " + idDeporteEncuentro + ")";
                    try
                    {
                        rs = _cn.Execute(sql, out cantFilas);
                    }
                    catch
                    {
                        return devolver = 4;
                    }

                }
                else
                {
                    sql = "insert into Hacen(idIncidencia, idOcurrencia) values(" + idIncidencia + ", (select o.idOcurrencia from Ocurrencias as o where o.nombre='" + ocurrencia + "'))";
                    try
                    {

                        rs = _cn.Execute(sql, out cantFilas);
                    }
                    catch
                    {

                        return devolver = 3;
                    }
                    sql = "insert into Notifica(idIncidencia, idOcurrencia, idEncuentro, idDeporte) values(" + idIncidencia + ", (select o.idOcurrencia from Ocurrencias as o where o.nombre='" + ocurrencia + "'), " + idEncuentro + ", " + idDeporteEncuentro + ")";
                    try
                    {
                        rs = _cn.Execute(sql, out cantFilas);
                    }
                    catch
                    {

                        return devolver = 4;
                    }
                }





            }
            rs = null;
            return devolver;
        }
        public static byte insertarRankingNotifica(int idEncuentro, int idDeporteEncuentro, int idIncidencia, int puntos, string tiempo, string nombreJ, string apellidoJ, string ocurrencia)
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
                sql = "insert into Incidencias(idIncidencia) values(" + idIncidencia + ")";
                try
                {
                    rs = _cn.Execute(sql, out cantFilas);
                }
                catch
                {
                    throw;
                    return devolver = 2;
                }
                sql = "insert into Rankings(idIncidencia, tiempo_Transcurrido,puntos,idParticipante) values(" + idIncidencia + ", '" + tiempo + "', " + puntos + ", (select j.idJugador from Jugador as j where j.nombre='" + nombreJ + "' AND j.apellido='" + apellidoJ + "'))";
                try
                {
                    rs = _cn.Execute(sql, out cantFilas);
                }
                catch
                {
                    throw;

                    return devolver = 2;
                }

                sql = "select o.idOcurrencia from Ocurrencias as o where o.nombre = '" + ocurrencia + "'";
                try
                {
                    rs = _cn.Execute(sql, out cantFilas);
                }
                catch
                {
                    throw;


                    return devolver = 2;
                }
                if (rs.RecordCount == 0)
                {
                    bool bandera = true;
                    Random r = new Random();
                    int idRandom = 0;
                    while (bandera == true)
                    {
                        idRandom = r.Next();
                        sql = "select idOcurrencia from Ocurrencias where idOcurrencia=" + idRandom;
                        try
                        {
                            rs = _cn.Execute(sql, out cantFilas);
                        }
                        catch
                        {
                            throw;

                            return devolver = 2;
                        }
                        if (rs.RecordCount == 0)
                        {
                            bandera = false;
                        }
                    }
                    sql = "insert into Ocurrencias(idOcurrencia, nombre) values(" + idRandom + ", '" + ocurrencia + "')";
                    try
                    {
                        rs = _cn.Execute(sql, out cantFilas);
                    }
                    catch
                    {

                        return devolver = 3;
                    }
                    sql = "insert into Hacen(idIncidencia, idOcurrencia) values(" + idIncidencia + ", " + idRandom + ")";
                    try
                    {

                        rs = _cn.Execute(sql, out cantFilas);
                    }
                    catch
                    {

                        return devolver = 3;
                    }
                    sql = "insert into Notifica(idIncidencia, idOcurrencia, idEncuentro, idDeporte) values(" + idIncidencia + ", " + idRandom + ", " + idEncuentro + ", " + idDeporteEncuentro + ")";
                    try
                    {
                        rs = _cn.Execute(sql, out cantFilas);
                    }
                    catch
                    {
                        return devolver = 4;
                    }

                }
                else
                {
                    sql = "insert into Hacen(idIncidencia, idOcurrencia) values(" + idIncidencia + ", (select o.idOcurrencia from Ocurrencias as o where o.nombre='" + ocurrencia + "'))";
                    try
                    {

                        rs = _cn.Execute(sql, out cantFilas);
                    }
                    catch
                    {

                        return devolver = 3;
                    }
                    sql = "insert into Notifica(idIncidencia, idOcurrencia, idEncuentro, idDeporte) values(" + idIncidencia + ", (select o.idOcurrencia from Ocurrencias as o where o.nombre='" + ocurrencia + "'), " + idEncuentro + ", " + idDeporteEncuentro + ")";
                    try
                    {
                        rs = _cn.Execute(sql, out cantFilas);
                    }
                    catch
                    {

                        return devolver = 4;
                    }
                }





            }
            rs = null;
            return devolver;
        }

        public static byte InsertarenPuntosNotificaIndi(int idEncuentro, int idDeporteEncuentro, int idIncidencia, int minuto, string nombreJ, string apellidoJ, string ocurrencia)
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
                sql = "insert into Incidencias(idIncidencia) values(" + idIncidencia + ")";
                try
                {
                    rs = _cn.Execute(sql, out cantFilas);
                }
                catch
                {
                    return devolver = 2;
                }
                sql = "insert into Puntos(idIncidencia, minuto, idJugador) values(" + idIncidencia + ", " + minuto + ", (select j.idParticipante from Participantes as j where j.nombre='" + nombreJ + "' AND j.apellido='" + apellidoJ + "'))";
                try
                {
                    rs = _cn.Execute(sql, out cantFilas);
                }
                catch
                {
                    return devolver = 2;
                }

                sql = "select o.idOcurrencia from Ocurrencias as o where o.nombre = '" + ocurrencia + "'";
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
                    bool bandera = true;
                    Random r = new Random();
                    int idRandom = 0;
                    while (bandera == true)
                    {
                        idRandom = r.Next();
                        sql = "select idOcurrencia from Ocurrencias where idOcurrencia=" + idRandom;
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
                            bandera = false;
                        }
                    }
                    sql = "insert into Ocurrencias(idOcurrencia, nombre) values(" + idRandom + ", '" + ocurrencia + "')";
                    try
                    {
                        rs = _cn.Execute(sql, out cantFilas);
                    }
                    catch
                    {
                        return devolver = 3;
                    }
                    sql = "insert into Hacen(idIncidencia, idOcurrencia) values(" + idIncidencia + ", " + idRandom + ")";
                    try
                    {

                        rs = _cn.Execute(sql, out cantFilas);
                    }
                    catch
                    {

                        return devolver = 3;
                    }
                    sql = "insert into Notifica(idIncidencia, idOcurrencia, idEncuentro, idDeporte) values(" + idIncidencia + ", " + idRandom + ", " + idEncuentro + ", " + idDeporteEncuentro + ")";
                    try
                    {
                        rs = _cn.Execute(sql, out cantFilas);
                    }
                    catch
                    {
                        return devolver = 4;
                    }

                }
                else
                {
                    sql = "insert into Hacen(idIncidencia, idOcurrencia) values(" + idIncidencia + ", (select o.idOcurrencia from Ocurrencias as o where o.nombre='" + ocurrencia + "'))";
                    try
                    {

                        rs = _cn.Execute(sql, out cantFilas);
                    }
                    catch
                    {

                        return devolver = 3;
                    }
                    sql = "insert into Notifica(idIncidencia, idOcurrencia, idEncuentro, idDeporte) values(" + idIncidencia + ", (select o.idOcurrencia from Ocurrencias as o where o.nombre='" + ocurrencia + "'), " + idEncuentro + ", " + idDeporteEncuentro + ")";
                    try
                    {
                        rs = _cn.Execute(sql, out cantFilas);
                    }
                    catch
                    {

                        return devolver = 4;
                    }
                }





            }
            rs = null;
            return devolver;
        }
        public static byte insertarParticularNotificaIndi(int idEncuentro, int idDeporteEncuentro, int idIncidencia, int setsGanados, int puntosObtenidos, string nombreJ, string apellidoJ, string ocurrencia)
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
                sql = "insert into Incidencias(idIncidencia) values(" + idIncidencia + ")";
                try
                {
                    rs = _cn.Execute(sql, out cantFilas);
                }
                catch
                {
                    throw;
                    return devolver = 2;
                }
                sql = "insert into Particular(idIncidencia, setsGanados,puntosObtenidos,idParticipante) values(" + idIncidencia + ", " + setsGanados + ", " + puntosObtenidos + ", (select j.idParticipante from Participantes as j where j.nombre='" + nombreJ + "' AND j.apellido='" + apellidoJ + "'))";
                try
                {
                    rs = _cn.Execute(sql, out cantFilas);
                }
                catch
                {
                    throw;

                    return devolver = 2;
                }

                sql = "select o.idOcurrencia from Ocurrencias as o where o.nombre = '" + ocurrencia + "'";
                try
                {
                    rs = _cn.Execute(sql, out cantFilas);
                }
                catch
                {
                    throw;


                    return devolver = 2;
                }
                if (rs.RecordCount == 0)
                {
                    bool bandera = true;
                    Random r = new Random();
                    int idRandom = 0;
                    while (bandera == true)
                    {
                        idRandom = r.Next();
                        sql = "select idOcurrencia from Ocurrencias where idOcurrencia=" + idRandom;
                        try
                        {
                            rs = _cn.Execute(sql, out cantFilas);
                        }
                        catch
                        {
                            throw;

                            return devolver = 2;
                        }
                        if (rs.RecordCount == 0)
                        {
                            bandera = false;
                        }
                    }
                    sql = "insert into Ocurrencias(idOcurrencia, nombre) values(" + idRandom + ", '" + ocurrencia + "')";
                    try
                    {
                        rs = _cn.Execute(sql, out cantFilas);
                    }
                    catch
                    {
                        throw;

                        return devolver = 3;
                    }
                    sql = "insert into Hacen(idIncidencia, idOcurrencia) values(" + idIncidencia + ", " + idRandom + ")";
                    try
                    {

                        rs = _cn.Execute(sql, out cantFilas);
                    }
                    catch
                    {
                        throw;

                        return devolver = 3;
                    }
                    sql = "insert into Notifica(idIncidencia, idOcurrencia, idEncuentro, idDeporte) values(" + idIncidencia + ", " + idRandom + ", " + idEncuentro + ", " + idDeporteEncuentro + ")";
                    try
                    {
                        rs = _cn.Execute(sql, out cantFilas);
                    }
                    catch
                    {
                        throw;

                        return devolver = 4;
                    }

                }
                else
                {
                    sql = "insert into Hacen(idIncidencia, idOcurrencia) values(" + idIncidencia + ", (select o.idOcurrencia from Ocurrencias as o where o.nombre='" + ocurrencia + "'))";
                    try
                    {

                        rs = _cn.Execute(sql, out cantFilas);
                    }
                    catch
                    {
                        throw;

                        return devolver = 3;
                    }
                    sql = "insert into Notifica(idIncidencia, idOcurrencia, idEncuentro, idDeporte) values(" + idIncidencia + ", (select o.idOcurrencia from Ocurrencias as o where o.nombre='" + ocurrencia + "'), " + idEncuentro + ", " + idDeporteEncuentro + ")";
                    try
                    {
                        rs = _cn.Execute(sql, out cantFilas);
                    }
                    catch
                    {
                        throw;

                        return devolver = 4;
                    }
                }





            }
            rs = null;
            return devolver;
        }
        public static byte insertarRankingNotificaIndi(int idEncuentro, int idDeporteEncuentro, int idIncidencia, int puntos, string tiempo, string nombreJ, string apellidoJ, string ocurrencia)
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
                sql = "insert into Incidencias(idIncidencia) values(" + idIncidencia + ")";
                try
                {
                    rs = _cn.Execute(sql, out cantFilas);
                }
                catch
                {
                    return devolver = 2;
                }
                sql = "insert into Rankings(idIncidencia, tiempo_Transcurrido,puntos,idParticipante) values(" + idIncidencia + ", '" + tiempo + "', " + puntos + ", (select j.idParticipante from Participantes as j where j.nombre='" + nombreJ + "' AND j.apellido='" + apellidoJ + "'))";
                try
                {
                    rs = _cn.Execute(sql, out cantFilas);
                }
                catch
                {

                    return devolver = 2;
                }

                sql = "select o.idOcurrencia from Ocurrencias as o where o.nombre = '" + ocurrencia + "'";
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
                    bool bandera = true;
                    Random r = new Random();
                    int idRandom = 0;
                    while (bandera == true)
                    {
                        idRandom = r.Next();
                        sql = "select idOcurrencia from Ocurrencias where idOcurrencia=" + idRandom;
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
                            bandera = false;
                        }
                    }
                    sql = "insert into Ocurrencias(idOcurrencia, nombre) values(" + idRandom + ", '" + ocurrencia + "')";
                    try
                    {
                        rs = _cn.Execute(sql, out cantFilas);
                    }
                    catch
                    {
                        return devolver = 3;
                    }
                    sql = "insert into Hacen(idIncidencia, idOcurrencia) values(" + idIncidencia + ", " + idRandom + ")";
                    try
                    {

                        rs = _cn.Execute(sql, out cantFilas);
                    }
                    catch
                    {
                        return devolver = 3;
                    }
                    sql = "insert into Notifica(idIncidencia, idOcurrencia, idEncuentro, idDeporte) values(" + idIncidencia + ", " + idRandom + ", " + idEncuentro + ", " + idDeporteEncuentro + ")";
                    try
                    {
                        rs = _cn.Execute(sql, out cantFilas);
                    }
                    catch
                    {
                        return devolver = 4;
                    }

                }
                else
                {
                    sql = "insert into Hacen(idIncidencia, idOcurrencia) values(" + idIncidencia + ", (select o.idOcurrencia from Ocurrencias as o where o.nombre='" + ocurrencia + "'))";
                    try
                    {

                        rs = _cn.Execute(sql, out cantFilas);
                    }
                    catch
                    { 

                        return devolver = 3;
                    }
                    sql = "insert into Notifica(idIncidencia, idOcurrencia, idEncuentro, idDeporte) values(" + idIncidencia + ", (select o.idOcurrencia from Ocurrencias as o where o.nombre='" + ocurrencia + "'), " + idEncuentro + ", " + idDeporteEncuentro + ")";
                    try
                    {
                        rs = _cn.Execute(sql, out cantFilas);
                    }
                    catch
                    {

                        return devolver = 4;
                    }
                }
            }
            rs = null;
            return devolver;
        }

    }

}



    

