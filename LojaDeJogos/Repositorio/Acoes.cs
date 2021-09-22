using MySql.Data.MySqlClient;
using LojaDeJogos.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LojaDeJogos.Repositorio
{
    public class Acoes
    {
        Conexao con = new Conexao();
        MySqlCommand cmd = new MySqlCommand();

        public void CadastrarFuncionario(Funcionario func)
        {
            string data_sistema = Convert.ToDateTime(func.DataNasc).ToString("yyyy/MM/dd");
            MySqlCommand cmd = new MySqlCommand("insert into tbfuncionario values (@FuncionarioID,@Nome,@CPF,@RG,@DataNasc,@Endereco,@Celular,@Email,@Cargo)", con.ConectarBD());
            cmd.Parameters.Add("@FuncionarioID", MySqlDbType.VarChar).Value = func.FuncionarioID;
            cmd.Parameters.Add("@Nome", MySqlDbType.VarChar).Value = func.Nome;
            cmd.Parameters.Add("@CPF", MySqlDbType.VarChar).Value = func.CPF;
            cmd.Parameters.Add("@RG", MySqlDbType.VarChar).Value = func.RG;
            cmd.Parameters.Add("@DataNasc", MySqlDbType.DateTime).Value = data_sistema;
            cmd.Parameters.Add("@Endereco", MySqlDbType.VarChar).Value = func.Endereco;
            cmd.Parameters.Add("@Email", MySqlDbType.VarChar).Value = func.Email;
            cmd.Parameters.Add("@Celular", MySqlDbType.VarChar).Value = func.Celular;
            cmd.Parameters.Add("@Cargo", MySqlDbType.VarChar).Value = func.Cargo;
            
            cmd.ExecuteNonQuery();
            con.DesconectarBD();

        }

        public Funcionario ListarCodFuncionario(int cod)
        {
            var comando = String.Format("select * from tbfuncionario where FuncionarioID = {0}", cod);
            MySqlCommand cmd = new MySqlCommand(comando, con.ConectarBD());
            var DadosCodFunc = cmd.ExecuteReader();
            return ListarCodFunc(DadosCodFunc).FirstOrDefault();
        }

        public List<Funcionario> ListarCodFunc(MySqlDataReader dt)
        {
            var AltAl = new List<Funcionario>();
            while (dt.Read())
            {
                var AlTemp = new Funcionario()
                {
                    FuncionarioID = dt["FuncionarioID"].ToString(),
                    Nome = dt["Nome"].ToString(),
                    CPF = dt["CPF"].ToString(),
                    RG = dt["RG"].ToString(),
                    DataNasc = DateTime.Parse(dt["DataNasc"].ToString()),
                    Endereco = dt["Endereco"].ToString(),
                    Email = dt["Email"].ToString(),
                    Celular = dt["Celular"].ToString(),
                    Cargo = dt["Cargo"].ToString()
                    
                };
                AltAl.Add(AlTemp);
            }

            dt.Close();
            return AltAl;


        }

        public List<Funcionario> ListarFuncionario()
        {
            MySqlCommand cmd = new MySqlCommand("select * from tbfuncionario", con.ConectarBD());
            var DadosFuncionario = cmd.ExecuteReader();
            return ListarTodosFuncionario(DadosFuncionario);
        }

        public List<Funcionario> ListarTodosFuncionario(MySqlDataReader dt)
        {
            var TodosFuncionarios = new List<Funcionario>();
            while (dt.Read())
            {
                var FuncionarioTemp = new Funcionario()
                {
                    FuncionarioID = dt["FuncionarioID"].ToString(),
                    Nome = dt["Nome"].ToString(),
                    CPF = dt["CPF"].ToString(),
                    RG = dt["RG"].ToString(),
                    DataNasc = DateTime.Parse(dt["DataNasc"].ToString()),
                    Endereco = dt["Endereco"].ToString(),
                    Email = dt["Email"].ToString(),
                    Celular = dt["Celular"].ToString(),
                    Cargo = dt["Cargo"].ToString()
                };
                TodosFuncionarios.Add(FuncionarioTemp);
            }

            dt.Close();
            return TodosFuncionarios;
        }

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
            var comando2 = String.Format("select * from tbcliente where CPF = {0}", cpf);
            MySqlCommand cmd = new MySqlCommand(comando2, con.ConectarBD());
            var DadosCPFCli = cmd.ExecuteReader();
            return ListarCPFCli(DadosCPFCli).FirstOrDefault();
        }
        public List<Cliente> ListarCPFCli(MySqlDataReader dt2)
        {
            var AltAl2 = new List<Cliente>();
            while (dt2.Read())
            {
                var AlTemp2 = new Cliente()
                {
                    CPF = dt2["CPF"].ToString(),
                    Nome = dt2["Nome"].ToString(),
                    DataNasc = DateTime.Parse(dt2["DataNasc"].ToString()),
                    Email = dt2["Email"].ToString(),
                    Celular = dt2["Celular"].ToString(),
                    Endereco = dt2["Endereco"].ToString()

                };
                AltAl2.Add(AlTemp2);
            }

            dt2.Close();
            return AltAl2;


        }

        public List<Cliente> ResultadoCliente()
        {
            MySqlCommand cmd = new MySqlCommand("select * from tbcliente", con.ConectarBD());
            var DadosCliente = cmd.ExecuteReader();
            return ListarTodosCliente(DadosCliente);
        }

        public List<Cliente> ListarTodosCliente(MySqlDataReader dt2)
        {
            var TodosClientes = new List<Cliente>();
            while (dt2.Read())
            {
                var ClienteTemp = new Cliente()
                {
                    CPF = dt2["CPF"].ToString(),
                    Nome = dt2["Nome"].ToString(),
                    DataNasc = DateTime.Parse(dt2["DataNasc"].ToString()),
                    Email = dt2["Email"].ToString(),
                    Celular = dt2["Celular"].ToString(),
                    Endereco = dt2["Endereco"].ToString()
                };
                TodosClientes.Add(ClienteTemp);
            }

            dt2.Close();
            return TodosClientes;
        }
    }
}