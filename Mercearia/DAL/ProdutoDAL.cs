using Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class ProdutoDAL
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
        public List<Produto> BuscarTodos()
        {
            List<Produto> produtos = new List<Produto>();
            Produto produto = new Produto();

            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandText = "SELECT Id, Nome, Descricao, Categoria, CodigoDeBarra, Marca, Preco, QuantidadeEmEstoque, IdFornecedor FROM Produto";
                cmd.CommandType = System.Data.CommandType.Text;

                cn.Open();

                using (SqlDataReader rd = cmd.ExecuteReader())
                {
                    while (rd.Read())
                    {
                        produto = new Produto();
                        produto.Id = Convert.ToInt32(rd["Id"]);
                        produto.Nome = rd["Nome"].ToString();
                        produto.Descricao = rd["Descricao"].ToString();
                        produto.Categoria = rd["Categoria"].ToString();
                        produto.CodigoDeBarra = rd["CodigoDeBarra"].ToString();
                        produto.Marca = rd["Marca"].ToString();
                        produto.Preco = Convert.ToDouble(rd["Preco"]);
                        produto.QuantidadeEmEstoque = Convert.ToInt32(rd["QuantidadeEmEstoque"]);
                        produto.IdFornecedor = Convert.ToInt32(rd["IdFornecedor"]);
                        produtos.Add(produto);

                    }
                    return produtos;
                }

            }
            catch(Exception ex)
            {
                throw new Exception("Ocorreu um erro ao tentar buscar todos os produtos no banco de dados", ex);

            }
            finally
            {
                cn.Close();
            }
        }
        public List<Produto>BuscarPorNome(string _nome)
        {
            List<Produto> produtos = new List<Produto>();
            Produto produto = new Produto();
            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
            try
            {
                SqlCommand cmd = cn.CreateCommand();
                cmd.Connection = cn;
                cmd.CommandText = "SELECT Id, Nome, Descricao, CodigoDeBarra, Marca, Preco, QuantidadeEmEstoque, IdFornecedor";
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.Parameters.AddWithValue("@Nome", "%" + _nome + "%");
                cn.Open();
                using (SqlDataReader rd = cmd.ExecuteReader())
                {
                    while (rd.Read())
                    {
                        produto = new Produto();
                        produto.Id = Convert.ToInt32(rd["Id"]);
                        produto.Nome = rd["Nome"].ToString();
                        produto.Descricao = rd["Descricao"].ToString();
                        produto.Categoria = rd["Categoria"].ToString();
                        produto.CodigoDeBarra = rd["CodigoDeBarra"].ToString();
                        produto.Marca = rd["Marca"].ToString();
                        produto.Preco = Convert.ToDouble(rd["Preco"]);
                        produto.QuantidadeEmEstoque = Convert.ToInt32(rd["QuantidadeEmEstoque"]);
                        produto.IdFornecedor = Convert.ToInt32(rd["IdFornecedor"]);
                        produtos.Add(produto);
                    }
                }
                return produtos;
            }
            catch(Exception ex)
            {
                throw new Exception("Ocorreu um erro ao tentar buscar por nome no banco de dados", ex);
            }
            finally
            {
                cn.Close();
            }

        }
        public Produto BuscarPorId(int _id)
        {
            Produto produto = new Produto();

            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandText = @"SELECT Id, Nome, Descricao, Categoria, CodigoDeBarra, Marca, Preco, QuantidadeEmEstoque, IdFornecedor FROM Produto WHERE Id = @Id";
                cmd.CommandType = System.Data.CommandType.Text;

                cmd.Parameters.AddWithValue("@Id", _id);

                cn.Open();

                using (SqlDataReader rd = cmd.ExecuteReader())
                {
                    produto = new Produto();
                    produto.Id = Convert.ToInt32(rd["Id"]);
                    produto.Nome = rd["Nome"].ToString();
                    produto.Descricao = rd["Descricao"].ToString();
                    produto.Categoria = rd["Categoria"].ToString();
                    produto.CodigoDeBarra = rd["CodigoDeBarra"].ToString();
                    produto.Marca = rd["Marca"].ToString();
                    produto.Preco = Convert.ToDouble(rd["Preco"]);
                    produto.QuantidadeEmEstoque = Convert.ToInt32(rd["QuantidadeEmEstoque"]);
                    produto.IdFornecedor = Convert.ToInt32(rd["IdFornecedor"]);
                    
                }
                return produto;
            }
            catch(Exception ex)
            {
                throw new Exception("Ocorreu um erro ao tentar buscar por id no banco de dados",ex);
            }
            finally
            {
                cn.Close();
            }
        }
    }
}
