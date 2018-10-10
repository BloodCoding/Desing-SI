using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MJFramework.mj.connections;
using MySql.Data.MySqlClient;
using System.Data;

namespace BackenApp.Pruebas
{
    public class PruebaUsuarios : MJMySqlConnection
    {

        public void agregarUsuario(string clave){
            string procedimiento = "sp_usuario_nuevo";
            List<MySqlParameter> parametros = new List<MySqlParameter>();
            parametros.Add(new MySqlParameter("pusername","oraora"));
            parametros.Add(new MySqlParameter("pnombre", "Peyuso Caluso"));
            parametros.Add(new MySqlParameter("ppassword", "Piripitiflautica"));
            parametros.Add(new MySqlParameter("prol", 2));
            parametros.Add(new MySqlParameter("pclave", clave));
            //bool res = executeQueryUpdate(SqlQuery, new List<MySqlParameter>());
            bool res = executeStoredProcedureUpdate(procedimiento, parametros);
            if (res)
            {
                Console.WriteLine("Se Grabó");
            }
            else
            {
                Console.WriteLine("Algo paso Aiiiuuuudddaaaaaa");
            }

        }

        public void mostrardatos() 
        {
            string sql = "SELECT * FROM  usuarios";
            MySqlDataReader reader = findRecordsSQL(sql, new List<MySqlParameter>());
            Console.WriteLine("Datos");
            while (reader.Read())
            {
                Console.WriteLine("ID: "+ reader.GetString("idusuarios"));
                Console.WriteLine("Username: " + reader.GetString("username"));
                Console.WriteLine("Nombre: " + reader.GetString("nombre"));
            }
            closeConexion();
        }

        public void mostrardatos(int p)
        {
            string sql = "sp_usuarios_list";
            List<MySqlParameter> parametros = new List<MySqlParameter>();
            parametros.Add(new MySqlParameter("ordenamiento",p));

            MySqlDataReader reader = findRecordsStoredProcedure(sql, parametros);
            Console.WriteLine("Datos");
            while (reader.Read())
            {
                Console.WriteLine("Username: " + reader.GetString("Usuario"));
                Console.WriteLine("Nombre: " + reader.GetString("Nombre"));
            }
            closeConexion();
        }

        public DataTable datosParaGrid()
        {
            string sql = "SELECT idusuarios, username, nombre, rol FROM usuarios";
            DataTable datos = getListQuerySQL(sql, new List<MySqlParameter>());
            return datos;
        }

        public DataTable filtroParaGrid(string pf)
        {
            string sql = "SELECT idusuarios, username, nombre, rol FROM usuarios WHERE idusuarios like ('%" + pf + "%') or username like ('%" + pf + "%') or nombre like ('%" + pf + "%') or rol like ('%" + pf + "%')";
            DataTable datos = getListQuerySQL(sql, new List<MySqlParameter>());
            return datos;
        }



    }
}
