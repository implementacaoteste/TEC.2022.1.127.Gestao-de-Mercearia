using Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
namespace DAL
{
    public class VendaDAL
    {
        public void Inserir(Venda _venda)
        {
            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
            try
            {
                SqlCommand cmd = cn.CreateCommand();
                cmd.CommandText = @"INSERT INTO Venda(Id, IdFuncionario, IdCliente, IdProduto, PrecoVenda, IdFormaPagamento, DataVenda)VALUES(@Id, @IdFuncionario, @IdCliente, @IdProduto, @PrecoVenda, @IdFormaPagamento, @DataVenda)";
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.Parameters.AddWithValue("@Id", _venda.Id);
                cmd.Parameters.AddWithValue("@IdFuncionario", _venda.IdFuncionario);
                cmd.Parameters.AddWithValue("@IdCliente", _venda.IdCliente);
                cmd.Parameters.AddWithValue("@IdProduto", _venda.IdProduto);
                cmd.Parameters.AddWithValue("@PrecoVenda", _venda.PrecoVenda);
                cmd.Parameters.AddWithValue("@IdFormaPagamento", _venda.IdFormaPagamento);
                cmd.Parameters.AddWithValue("@DataVenda", _venda.DataVenda);
                cmd.Connection = cn;
                cn.Open();
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorre um erro ao inserir uma venda no banco de dados.", ex);
            }
            finally
            {
                cn.Close();
            }
        }
        public void Alterar(Venda _venda)
        {
            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
            try
            {
                SqlCommand cmd = cn.CreateCommand();
                cmd.CommandText = @"UPDATE Venda SET IdFuncionario = @IdFuncionario, IdCliente = @IdCliente, IdProduto = @IdProduto, PrecoVenda = @PrecoVenda, IdFormaPagamento = @IdFormaPagamento, DataVenda = @DataVenda WHERE Id = @Id";
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.Parameters.AddWithValue("@Id", _venda.Id);
                cmd.Parameters.AddWithValue("@IdFuncionario", _venda.IdFuncionario);
                cmd.Parameters.AddWithValue("@IdCliente", _venda.IdCliente);
                cmd.Parameters.AddWithValue("@IdProduto", _venda.IdProduto);
                cmd.Parameters.AddWithValue("@PrecoVenda", _venda.PrecoVenda);
                cmd.Parameters.AddWithValue("@IdFormaPagamento", _venda.IdFormaPagamento);
                cmd.Parameters.AddWithValue("@DataVenda", _venda.DataVenda);
                cmd.Connection = cn;
                cn.Open();
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu um erro ao tentar alterar uma venda no banco de dados.", ex);
            }
            finally
            {
                cn.Close();
            }
        }
        public void Excluir(int _id)
        {
            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
            try
            {
                SqlCommand cmd = cn.CreateCommand();
                cmd.CommandText = @"DELETE FROM Venda WHERE Id = @Id";
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.Parameters.AddWithValue("@Id", _id);
                cmd.Connection = cn;
                cn.Open();
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu um erro ao tentar excluir uma venda no banco de dados");
            }
            finally
            {
                cn.Close();
            }
        }
        public List<Venda> BuscarTodos()
        {
            List<Venda> vendas = new List<Venda>();
            Venda venda = new Venda();
            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandText = "SELECT Id, IdFuncionario, IdCliente, IdProduto, PrecoVenda, IdFormaPagamento, DataVenda FROM Venda";
                cmd.CommandType = System.Data.CommandType.Text;
                cn.Open();
                using (SqlDataReader rd = cmd.ExecuteReader())
                {
                    while (rd.Read())
                    {
                        venda = new Venda();
                        venda.Id = Convert.ToInt32(rd["Id"]);
                        venda.IdFuncionario = Convert.ToInt32(rd["IdFuncionario"]);
                        venda.IdCliente = Convert.ToInt32(rd["IdCliente"]);
                        venda.IdProduto = Convert.ToInt32(rd["IdProduto"]);
                        venda.PrecoVenda = Convert.ToDouble(rd["PrecoVenda"]);
                        venda.IdFormaPagamento = Convert.ToInt32(rd["IdFormaPagamento"]);
                        venda.DataVenda = Convert.ToDateTime(rd["DataVenda"]);
                        vendas.Add(venda);
                    }
                    return vendas;
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu um erro ao tentar buscar por todas as vendas no banco de dados.", ex);
            }
            finally
            {
                cn.Close();
            }

        }
        public Venda BuscarPorId(int _id)
        {
            Venda venda = new Venda();
            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandText = @"SELECT Id, IdFuncionario, IdCliente, IdProduto, PrecoVenda, IdFormaPagamento, DataVenda FROM Venda WHERE Id = @Id";
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.Parameters.AddWithValue("@Id", _id);
                cn.Open();
                using (SqlDataReader rd = cmd.ExecuteReader())
                {
                    while (rd.Read())
                    {
                        venda.Id = Convert.ToInt32(rd["Id"]);
                        venda.IdFuncionario = Convert.ToInt32(rd["IdFuncionario"]);
                        venda.IdCliente = Convert.ToInt32(rd["IdCliente"]);
                        venda.IdProduto = Convert.ToInt32(rd["IdProduto"]);
                        venda.PrecoVenda = Convert.ToDouble(rd["PrecoVenda"]);
                        venda.IdFormaPagamento = Convert.ToInt32(rd["IdFormaPagamento"]);
                        venda.DataVenda = Convert.ToDateTime(rd["DataVenda"]);
                    }
                }
                return venda;
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu um erro ao tentar buscar venda por id no banco de dados");
            }
            finally
            {
                cn.Close();
            }
        }

    }
}