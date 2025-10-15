using MySql.Data.MySqlClient;
using proyecto_final_OOP.InterFs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyecto_final_OOP.Objeks
{
    internal class score_repo : IBDRep<puntajescomunes>
    {
        private List<puntajescomunes> lista = new List<puntajescomunes>();
        public List<puntajescomunes> Obtener_D()
        {
            lista.Clear();
            puntajescomunes CT = new puntajescomunes
            {
                nombre = "",
                lvl1_score = 0,
                lvl2_score = 0,
                rocmaruga_score = 0,
                CC_score = 0,
                megarun_score = 0,
                lvl6_score = 0,
                lvl7_score = 0,
                total_score = 0,
            };
            lista.Add(CT);
            MySqlConnection conn = new MySqlConnection(webSetting.constr);
            MySqlCommand comm = new MySqlCommand("SELECT * FROM `puntajesglobales`", conn);
            comm.CommandType = System.Data.CommandType.Text;
            try
            {
                conn.Open();
                MySqlDataReader dr = comm.ExecuteReader();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        puntajescomunes Cat = new puntajescomunes
                        {
                            nombre = dr["Nombre"].ToString(),
                            total_score = Convert.ToInt32(dr["puntaje_total"].ToString()),
                            rocmaruga_score = Convert.ToInt32(dr["rockmaruga"].ToString()),
                            CC_score = Convert.ToInt32(dr["coin_collector"].ToString()),
                            megarun_score = Convert.ToInt32(dr["MegaRun"].ToString()),
                        };
                        lista.Add(Cat);
                    }
                }
                dr.Close();
            }
            catch (Exception ex) { }
            finally
            {
                conn.Close();
            }

            return lista;
        }
        public void Regscore(int totalp, int rocmaruga, int CC, int megarun, string nombre)
        {
            MySqlConnection conn = new MySqlConnection(webSetting.constr);
            MySqlCommand comm = new MySqlCommand($"UPDATE `puntajesglobales` SET `puntaje_total`='{totalp}',`rockmaruga`='{rocmaruga}',`coin_collector`='{CC}',`MegaRun`='{megarun}' WHERE `Nombre`='{nombre}'", conn);
            comm.CommandType = System.Data.CommandType.Text;
            try
            {
                conn.Open();
                comm.ExecuteNonQuery();
            }
            catch (Exception ex) { }
            finally
            {
                conn.Close();
            }
        }

    }
}
