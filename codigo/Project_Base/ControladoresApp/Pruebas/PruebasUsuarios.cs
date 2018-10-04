
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MJFramework.mj.connections;
using MySql.Data.MySqlClient;

namespace ControladoresApp.Pruebas
{
    public class PruebasUsuarios : MJMySqlConnection
    {
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
