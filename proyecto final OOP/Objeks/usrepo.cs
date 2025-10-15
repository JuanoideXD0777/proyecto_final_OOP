using MySql.Data.MySqlClient;
using Mysqlx.Cursor;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace proyecto_final_OOP.Objeks
{
    internal class usrepo
    {
        public static usuarios Login(string username)
        {
            usuarios guest = new usuarios();
            guest.Nombre = "";
            MySqlConnection conn = new MySqlConnection(webSetting.constr);
            MySqlCommand comm = new MySqlCommand($"SELECT * FROM `usuarios` WHERE `Nombre`= '{username}';", conn);
            comm.CommandType = System.Data.CommandType.Text;
            try
            {
                conn.Open();
                MySqlDataReader dr = comm.ExecuteReader();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        guest.Nombre = dr["Nombre"].ToString();
                    }
                }
            }
            catch (Exception ex) { }
            finally
            {
                conn.Close();
            }
            return guest;
        }
        public void register (string nombreUsr)
        {
            MySqlConnection conn = new MySqlConnection(webSetting.constr);
            MySqlCommand comm = new MySqlCommand($"INSERT INTO `usuarios`(`Nombre`) VALUES ('{nombreUsr}')", conn);
            MySqlCommand comm2 = new MySqlCommand($"INSERT INTO `puntajesglobales`(`Nombre`, `puntaje_total`, `rockmaruga`, `coin_collector`, `MegaRun`) VALUES ('{nombreUsr}','0','0','0','0')", conn);
            comm.CommandType = System.Data.CommandType.Text;
            comm2.CommandType = System.Data.CommandType.Text;
            try
            {
                conn.Open();
                comm.ExecuteNonQuery();
                comm2.ExecuteNonQuery();
            }
            catch (Exception ex) { }
            finally
            {
                conn.Close();
            }
        }
        public void getname()
        {

        }
    }
}
