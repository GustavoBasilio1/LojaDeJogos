using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LojaDeJogos.Repositorio
{
    public class Conexao
    {
        MySqlConnection cn = new MySqlConnection("Server=localhost;DataBase=bdLojaJogos;user=root;pwd=10gugu10");
        public static string msg;

        public MySqlConnection ConectarBD()
        {
            try
            {
                cn.Open();
            }
            catch(Exception erro)
            {
                msg = "Ocorreu um erro ao conectar" + erro.Message;
            }
            return cn;
        }

        public MySqlConnection DesconectarBD()
        {
            try
            {
                cn.Close();
            }
            catch(Exception erro)
            {
                msg = "ocorreu um erro ao desconectar" + erro.Message;
            }
            return cn;
        }
    }
}