
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MJFramework.mj.connections;
using MySql.Data.MySqlClient;
using System.Data;

namespace ControladoresApp.Pruebas
{
    public class PruebasUsuarios : MJMySqlConnection
    {
        public void mostrarDatos()
        {
            string sql = "sp_usuarios_list"; //procedimiento
            List<MySqlParameter> parametros = new List<MySqlParameter>();
            parametros.Add(new MySqlParameter("ordenamiento",1));
            MySqlDataReader reader = findRecordsStoredProcedure(sql, parametros);//new List<MySqlParameter>());
            Console.Write("Datos ");
            while (reader.Read())
            {
                Console.Write("Nombre: "+ reader.GetString("Usuario"));//utilizando el nombre de la columna
                Console.Write("Rol: " + reader.GetString(2));//con el numero de la columna
                
            }
            closeConexion();
        }

        public DataTable datosParaGrid()
        {
            string sql = "sp_usuarios_list"; //procedimiento
            List<MySqlParameter> parametros = new List<MySqlParameter>();
            parametros.Add(new MySqlParameter("ordenamiento", 1));
            DataTable datos = getListQueryStoredProcedure(sql, parametros);
            return datos;
        }

        public void agregarUsuario(string clave)
        {
            string procedimiento = "sp_usuario_nuevo";
            //parametros
            List<MySqlParameter> parametros = new List<MySqlParameter>();
            parametros.Add(new MySqlParameter("pusername", "Lampard"));
            parametros.Add(new MySqlParameter("pnombre", "Edgar Eduardo Perez Huerta"));
            parametros.Add(new MySqlParameter("ppassword", "0123456789"));
            parametros.Add(new MySqlParameter("prol", 2));
            parametros.Add(new MySqlParameter("pclave", clave));

            bool res = executeStoredProcedureUpdate(procedimiento, parametros);
            if (res)
                Console.WriteLine("Se grabó");
            else
                Console.WriteLine("Algo paso");
        }
    }
}
