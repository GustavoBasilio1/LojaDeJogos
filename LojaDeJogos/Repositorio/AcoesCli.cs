using MySql.Data.MySqlClient;
using LojaDeJogos.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LojaDeJogos.Repositorio
{
    public class AcoesCli
    {
        Conexao con = new Conexao();
        MySqlCommand cmd = new MySqlCommand();

        public void CadastrarCliente(Cliente cli)
        {
            string data_sistema = Convert.ToDateTime(cli.DataNasc).ToString("yyyy/MM/dd");
            MySqlCommand cmd = new MySqlCommand("insert into tbcliente values (@CPF,@Nome,@DataNasc,@Email,@Celular,Endereco)", con.ConectarBD());
            cmd.Parameters.Add("@CPF", MySqlDbType.VarChar).Value = cli.CPF;
            cmd.Parameters.Add("@Nome", MySqlDbType.VarChar).Value = cli.Nome;
            cmd.Parameters.Add("@DataNasc", MySqlDbType.DateTime).Value = data_sistema;
            cmd.Parameters.Add("@Email", MySqlDbType.VarChar).Value = cli.Email;
            cmd.Parameters.Add("@Celular", MySqlDbType.VarChar).Value = cli.Celular;
            cmd.Parameters.Add("@Endereco", MySqlDbType.VarChar).Value = cli.Endereco;
            cmd.ExecuteNonQuery();
            con.DesconectarBD();
        }

        public Cliente ListarCPFCli(int cpf)
        {
            var comando = String.Format("select * from tbcliente where CPF = {0}", cpf);
            MySqlCommand cmd = new MySqlCommand(comando, con.ConectarBD());
            var DadosCPFCli = cmd.ExecuteReader();
            return ListarCPFCli(DadosCPFCli).FirstOrDefault();
        }
        public List<Cliente> ListarCPFCli(MySqlDataReader dt)
        {
            var AltAl = new List<Cliente>();
            while (dt.Read())
            {
                var AlTemp = new Cliente()
                {
                    CPF = dt["CPF"].ToString(),
                    Nome = dt["Nome"].ToString(),
                    DataNasc = DateTime.Parse(dt["DataNasc"].ToString()),
                    Email = dt["Email"].ToString(),
                    Celular = dt["Celular"].ToString(),
                    Endereco = dt["Endereco"].ToString()
                };
                AltAl.Add(AlTemp);
            }

            dt.Close();
            return AltAl;


        }

        public List<Cliente> ListarCliente()
        {
            MySqlCommand cmd = new MySqlCommand("select * from tbcliente", con.ConectarBD());
            var DadosCliente = cmd.ExecuteReader();
            return ListarTodosCliente(DadosCliente);
        }

        public List<Cliente> ListarTodosCliente(MySqlDataReader dt)
        {
            var TodosClientes = new List<Cliente>();
            while (dt.Read())
            {
                var ClienteTemp = new Cliente()
                {
                    CPF = dt["CPF"].ToString(),
                    Nome = dt["Nome"].ToString(),
                    DataNasc = DateTime.Parse(dt["DataNasc"].ToString()),
                    Email = dt["Email"].ToString(),
                    Celular = dt["Celular"].ToString(),
                    Endereco = dt["Endereco"].ToString()
                };
                TodosClientes.Add(ClienteTemp);
            }

            dt.Close();
            return TodosClientes;
        }
    }
}