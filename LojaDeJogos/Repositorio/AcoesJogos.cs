using MySql.Data.MySqlClient;
using LojaDeJogos.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LojaDeJogos.Repositorio
{
    public class AcoesJogo
    {
        Conexao con = new Conexao();
        MySqlCommand cmd = new MySqlCommand();

        public void CadastrarJogo(Jogos jogo)
        {

            MySqlCommand cmd = new MySqlCommand("insert into tbjogo values (@JogoID,@Nome,@Versao,@Desenvolvedor,@Genero,@FaixaEtaria,@Plataforma,@AnoLanc,@Sinopse)", con.ConectarBD());
            cmd.Parameters.Add("@JogoID", MySqlDbType.Int32).Value = jogo.JogoID;
            cmd.Parameters.Add("@Nome", MySqlDbType.VarChar).Value = jogo.Nome;
            cmd.Parameters.Add("@Versao", MySqlDbType.VarChar).Value = jogo.Versao;
            cmd.Parameters.Add("@Desenvolvedor", MySqlDbType.VarChar).Value = jogo.Desenvolvedor;
            cmd.Parameters.Add("@Genero", MySqlDbType.VarChar).Value = jogo.Genero;
            cmd.Parameters.Add("@FaixaEtaria", MySqlDbType.VarChar).Value = jogo.FaixaEtaria;
            cmd.Parameters.Add("@Plataforma", MySqlDbType.VarChar).Value = jogo.Plataforma;
            cmd.Parameters.Add("@AnoLanc", MySqlDbType.DateTime).Value = jogo.AnoLanc;
            cmd.Parameters.Add("@Sinopse", MySqlDbType.VarChar).Value = jogo.Sinopse;
            
            cmd.ExecuteNonQuery();
            con.DesconectarBD();
        }

        public Jogos ListarCodJogo(int jg)
        {
            var comando = String.Format("select * from tbjogo where JogoID = {0}", jg);
            MySqlCommand cmd = new MySqlCommand(comando, con.ConectarBD());
            var DadosJogo = cmd.ExecuteReader();
            return ListarCodJogo(DadosJogo).FirstOrDefault();
        }

        public List<Jogos> ListarCodJogo(MySqlDataReader dt)
        {
            var AltAl = new List<Jogos>();
            while (dt.Read())
            {
                var AlTemp = new Jogos()
                {
                    JogoID = dt["JogoID"].ToString(),
                    Nome = dt["Nome"].ToString(),
                    Versao = dt["Versao"].ToString(),
                    Desenvolvedor = dt["Desenvolvedor"].ToString(),
                    Genero = dt["Genero"].ToString(),
                    FaixaEtaria = dt["FaixaEtaria"].ToString(),
                    Plataforma = dt["Plataforma"].ToString(),
                    AnoLanc = DateTime.Parse(dt["AnoLanc"].ToString()),
                    Sinopse = dt["Sinopse"].ToString(),
                    
                };
                AltAl.Add(AlTemp);
            }

            dt.Close();
            return AltAl;
        }

        public List<Jogos> ListarJogos()
        {
            MySqlCommand cmd = new MySqlCommand("select * from tbjogo", con.ConectarBD());
            var DadosJogo = cmd.ExecuteReader();
            return ListarTodosJogo(DadosJogo);
        }

        public List<Jogos> ListarTodosJogo(MySqlDataReader dt)
        {
            var TodosJogos = new List<Jogos>();
            while (dt.Read())
            {
                var JogoTemp = new Jogos()
                {
                    JogoID = dt["JogoID"].ToString(),
                    Nome = dt["Nome"].ToString(),
                    Versao = dt["Versao"].ToString(),
                    Desenvolvedor = dt["Desenvolvedor"].ToString(),
                    Genero = dt["Genero"].ToString(),
                    FaixaEtaria = dt["FaixaEtaria"].ToString(),
                    Plataforma = dt["Plataforma"].ToString(),
                    AnoLanc = DateTime.Parse(dt["AnoLanc"].ToString()),
                    Sinopse = dt["Sinopse"].ToString(),
                };
                TodosJogos.Add(JogoTemp);
            }

            dt.Close();
            return TodosJogos;
        }
    }
}