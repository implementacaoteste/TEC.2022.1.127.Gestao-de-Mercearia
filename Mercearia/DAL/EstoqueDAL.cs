using Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class EstoqueDAL
    {

        public void Inserir(Estoque _estoque)
        {
            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
            try
            {
                SqlCommand cmd = cn.CreateCommand();
                cmd.CommandText = @"INSERT INTO Estoque(Id, DatadeEntrada, DatadeSaida, EstoqueMinimo, EstoqueMaximo, IdProduto) 
                                    VALUES(@Id, @DatadeEntrada, @DatadeSaida, @EstoqueMinimo, @EstoqueMaximo, @IdProduto)";
                cmd.CommandType = System.Data.CommandType.Text;

                cmd.Parameters.AddWithValue("@Id", _estoque.Id);
                cmd.Parameters.AddWithValue("@DatadeEntrada", _estoque.DatadeEntrada);
                cmd.Parameters.AddWithValue("@DatadeSaida", _estoque.DatadeSaida);
                cmd.Parameters.AddWithValue("@EstoqueMinimo", _estoque.EstoqueMinimo);
                cmd.Parameters.AddWithValue("@EstoqueMaximo", _estoque.EstoqueMaximo);
                cmd.Parameters.AddWithValue("@IdProduto", _estoque.IdProduto);

                cmd.Connection = cn;
                cn.Open();

                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu erro ao tentar inserir algo no estoque dentro do banco de dados.", ex);
            }
            finally
            {
                cn.Close();
            }
        }
        public void Alterar(Estoque _estoque)
        {

            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
            try
            {
                SqlCommand cmd = cn.CreateCommand();
                cmd.CommandText = @"UPDATE Estoque SET (Id = @Id , DatadeEntrada = @DatadeEntrada, DatadeSaida = @DatadeSaida, EstoqueMinimo = @EstoqueMinimo, EstoqueMaximo = @EstoqueMaximo, IdProduto = @IdProduto WHERE Id = @Id)"; 
                                    
                cmd.CommandType = System.Data.CommandType.Text;

                cmd.Parameters.AddWithValue("@Id", _estoque.Id);
                cmd.Parameters.AddWithValue("@DatadeEntrada", _estoque.DatadeEntrada);
                cmd.Parameters.AddWithValue("@DatadeSaida", _estoque.DatadeSaida);
                cmd.Parameters.AddWithValue("@EstoqueMinimo", _estoque.EstoqueMinimo);
                cmd.Parameters.AddWithValue("@EstoqueMaximo", _estoque.EstoqueMaximo);
                cmd.Parameters.AddWithValue("@IdProduto", _estoque.IdProduto);

                cmd.Connection = cn;
                cn.Open();

                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao tentar alterar estoque no banco de dados", ex) { Data = { { "Id", 20 } } };
            }
            finally
            {
                cn.Close();
            }
        }
    }
}
