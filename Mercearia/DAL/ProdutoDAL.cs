using Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    internal class ProdutoDAL
    {
        public void Inserir(Produto _produto)
        {
            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
            try
            {
                SqlCommand cmd = cn.CreateCommand();
                cmd.CommandText = @"INSERT INTO Produto(Nome, Descricao, Categoria, CodigoDeBarra, Marca, Preco, QuantidadeEmEstoque, IdFornecedor) 
                                    VALUES(@Nome, @Descricao, @Categoria, @CodigoDeBarra, @Marca, @Preco, @QuantidadeEmEstoque, @IdFornecedor)";
                cmd.CommandType = System.Data.CommandType.Text;

                cmd.Parameters.AddWithValue("@Nome", _produto.Nome);
                cmd.Parameters.AddWithValue("@Descricao", _produto.Descricao);
                cmd.Parameters.AddWithValue("@Categoria", _produto.Categoria);
                cmd.Parameters.AddWithValue("@CodigoDeBarra", _produto.CodigoDeBarra);
                cmd.Parameters.AddWithValue("@Marca", _produto.Marca);
                cmd.Parameters.AddWithValue("@Preco", _produto.Preco);
                cmd.Parameters.AddWithValue("@QuantidadeEmEstoque", _produto.QuantidadeEmEstoque);
                cmd.Parameters.AddWithValue("@IdFornecedor", _produto.IdFornecedor);

                cmd.Connection = cn;
                cn.Open();

                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu erro ao tentar inserir um produto no banco de dados.", ex);
            }
            finally
            {
                cn.Close();
            }
        }
        public void Alterar(Produto _produto)
        {

            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
            try
            {
                SqlCommand cmd = cn.CreateCommand();
                cmd.CommandText = @"UPDATE Produto SET 
                                        Nome = @Nome, 
                                        Descricao = @Descricao, 
                                        Categoria = @Categoria, 
                                        CodigoDeBarra = @CodigoDeBarra, 
                                        Marca = @Marca,
                                        Preco = @Preco,
                                        QuantidadeEmEstoque = @QuantidadeEmEstoque,
                                        IdFornecedor = @IdFornecedor
                                    WHERE Id = @Id";
                cmd.CommandType = System.Data.CommandType.Text;

                cmd.Parameters.AddWithValue("@Id", _produto.Id);
                cmd.Parameters.AddWithValue("@Nome", _produto.Nome);
                cmd.Parameters.AddWithValue("@Descricao", _produto.Descricao);
                cmd.Parameters.AddWithValue("@Categoria", _produto.Categoria);
                cmd.Parameters.AddWithValue("@CodigoDeBarra", _produto.CodigoDeBarra);
                cmd.Parameters.AddWithValue("@Marca", _produto.Marca);
                cmd.Parameters.AddWithValue("@Preco", _produto.Preco);
                cmd.Parameters.AddWithValue("@QuantidadeEmEstoque", _produto.QuantidadeEmEstoque);
                cmd.Parameters.AddWithValue("@IdFornecedor", _produto.IdFornecedor);

                cmd.Connection = cn;
                cn.Open();

                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao tentar alterar produto no banco de dados", ex) { Data = { { "Id", 1001 } } };
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
                cmd.CommandText = @"DELETE FROM Produto WHERE id = @id";
                cmd.CommandType = System.Data.CommandType.Text;

                cmd.Parameters.AddWithValue("@Id", _id);

                cmd.Connection = cn;
                cn.Open();

                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu um erro ao tentar excluir Produto no banco de dados.", ex) { Data = { { "Id", 1002 } } };
            }
            finally
            {
                cn.Close();
            }
        }


    }
}
