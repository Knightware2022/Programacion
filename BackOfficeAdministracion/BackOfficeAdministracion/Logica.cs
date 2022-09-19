﻿using System;
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
            rs = null;
            return devolver;
        }
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
                sql = "select correo from Vip where correo='"+ u.correo + "'";
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
                sql = "select nombre from deportes where deportes.idDeporte IN (select deporteFavorito from deportesFavoritos where idUsuario=" + idUsuario + ")" ;
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
                sql = "select nombre from Equipos";
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
                        listaEquipos.Add(Convert.ToString(rs.Fields[0].Value));
                        rs.MoveNext();
                    }
                }
            }
            rs = null;
            return devolver;
        }
        public static byte cargarDatosEquipo(Equipos equipo) {
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
                sql = "select nombre from Equipos where nombre='" + equipo.nombre + "'";
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
                    equipo.categoria = Convert.ToString(rs.Fields[0].Value);

                    sql = "select categoria from Equipos where nombre='" + equipo.nombre + "'";
                    try
                    {
                        rs = _cn.Execute(sql, out cantFilas); //out cantFilas, devuelve cantidad de filas afectadas, y cuales fueron
                    }
                    catch
                    {
                        return devolver = 2;
                    }
                    equipo.categoria = Convert.ToString(rs.Fields[0].Value);

                    sql = "select pais from Equipos where nombre='" + equipo.nombre + "'";
                    try
                    {
                        rs = _cn.Execute(sql, out cantFilas); //out cantFilas, devuelve cantidad de filas afectadas, y cuales fueron
                    }
                    catch
                    {
                        return devolver = 2;
                    }
                    equipo.pais = Convert.ToString(rs.Fields[0].Value);

                    sql = "select logo from Equipos where nombre='" + equipo.nombre + "'";
                    try
                    {
                        rs = _cn.Execute(sql, out cantFilas); //out cantFilas, devuelve cantidad de filas afectadas, y cuales fueron
                    }
                    catch
                    {
                        return devolver = 2;
                    }
                    equipo.logo = Convert.ToString(rs.Fields[0].Value);

                    sql = "select idEquipo from Equipos where nombre='" + equipo.nombre + "'";
                    try
                    {
                        rs = _cn.Execute(sql, out cantFilas); //out cantFilas, devuelve cantidad de filas afectadas, y cuales fueron
                    }
                    catch
                    {
                        return devolver = 2;
                    }
                    equipo.id = Convert.ToInt32(rs.Fields[0].Value);
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
        public static byte añadirJugadoraEquipo(int idEquipo, int idJugador) {
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
                sql = "insert into Forman(idJugador, idEquipo) values ( " + idJugador + ", "+ idEquipo+ ")";
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
    }
         

}
    

