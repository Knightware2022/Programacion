using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackOfficeAdministracion
{
    public static class Logica
    {
        public static ADODB.Connection _cn = new ADODB.Connection();

        public static void abrirConexion()
        {
            try
            {
                _cn = new ADODB.Connection();
                _cn.Open("miodbc", "root", "", -1);
                _cn.CursorLocation = ADODB.CursorLocationEnum.adUseClient;
            }
            catch
            {
                throw;
            }
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
                sql = "select usuario from usuarios where usuario='" + u.nombre + "'";
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
                    sql = "select contrasenia from usuarios where usuario='" + u.nombre + "'";
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
                sql = "select rol from usuarios where usuario='" + u.nombre + "'";
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
                sql = "select correo from usuarios where usuario='" + u.nombre + "'";
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
                sql = "select url from publicidad where id=" + id;
                try
                {
                    rs = _cn.Execute(sql, out cantFilas); //out cantFilas, devuelve cantidad de filas afectadas, y cuales fueron
                }
                catch
                {
                    url = null;
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
                sql = "select usuario from usuarios where usuario='" + u.nombre + "'";
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
                    sql = "insert into usuarios(usuario, contrasenia, correo, rol) values('" + u.nombre + "', '" + u.contrasenia + "', '" + u.correo + "', " + u.rol + ")";
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
                sql = "select rol from usuarios where usuario='" + u.nombre + "'";
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
                sql = "Select usuario from usuarios";
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
                sql = "update usuarios set rol=" + u.rol + " where usuario='" + u.nombre + "'";
                try
                {
                    rs = _cn.Execute(sql, out cantFilas); //out cantFilas, devuelve cantidad de filas afectadas, y cuales fueron
                }
                catch
                {
                    return devolver = 2;
                }
                sql = "update usuarios set correo='" + u.correo + "' where usuario='" + u.nombre + "'";
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
        public static byte eliminarUsuario(string nombre)
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
                sql = "delete from usuarios where usuario='" + nombre + "'";
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
        public static byte crearUsuario(Usuario u) {
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
                sql = "insert into usuarios(usuario, contrasenia, correo, rol) values('" +u.nombre + "', '" + contraseña + "', '" + u.correo + "', " + u.rol + " )";
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
    }
}
