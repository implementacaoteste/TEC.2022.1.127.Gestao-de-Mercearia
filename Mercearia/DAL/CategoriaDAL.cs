﻿using Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class CategoriaDAL
    {
        public void Inserir(Categoria _categoria)
        {
            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
            try
            {
                SqlCommand cmd = cn.CreateCommand();
                cmd.CommandText = @"INSERT INTO Categoria(Categoria) 
                                    VALUES(@Categoria)";
                cmd.CommandType = System.Data.CommandType.Text;

                cmd.Parameters.AddWithValue("@Categoria", _categoria.Nome);
                cmd.Connection = cn;
                cn.Open();

                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu erro ao tentar inserir uma Categoria no banco de dados.", ex);
            }
            finally
            {
                cn.Close();
            }
        }
        public void Alterar(Categoria _Categoria)
        {
            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
            try
            {
                SqlCommand cmd = cn.CreateCommand();
                cmd.CommandText = @"UPDATE Categoria SET Id = @Id, Categoria = @Categoria WHERE Id = @Id";
                cmd.CommandType = System.Data.CommandType.Text;

                cmd.Parameters.AddWithValue("@Id", _Categoria.Id);
                cmd.Parameters.AddWithValue("@Categoria", _Categoria.Nome);

                cmd.Connection = cn;
                cn.Open();

                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao tentar alterar uma categoria no banco de dados", ex) { Data = { { "Id", 10036 } } };
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
                cmd.CommandText = @"DELETE FROM Categoria WHERE Id = @Id";
                cmd.CommandType = System.Data.CommandType.Text;

                cmd.Parameters.AddWithValue("@Id", _id);

                cmd.Connection = cn;
                cn.Open();

                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu um erro ao tentar excluir uma categoria no banco de dados.", ex) { Data = { { "Id", 10037 } } };
            }
            finally
            {
                cn.Close();
            }
        }
        public Categoria BuscarPorId(int _id)
        {
            Categoria categoria = new Categoria();
            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandText = @"SELECT Id, Categoria FROM Categoria WHERE Id = @Id";
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.Parameters.AddWithValue("@Id", _id);
                cn.Open();
                using (SqlDataReader rd = cmd.ExecuteReader())
                {
                    while (rd.Read())
                    {
                        categoria.Id = Convert.ToInt32(rd["Id"]);
                        categoria.Nome = rd["Categoria"].ToString();
                    }
                }
                return categoria;
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu um erro ao tentar buscar categorias por id no banco de dados", ex) { Data = { { "Id", 10038 } } };
            }
            finally
            {
                cn.Close();
            }
        }
        public List<Categoria> BuscarTudo()
        {
            List<Categoria> categoriaList = new List<Categoria>();
            Categoria categoria = new Categoria();
            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandText = @"SELECT Id, Categoria FROM Categoria WHERE Id = @Id";
                cmd.CommandType = System.Data.CommandType.Text;
                cn.Open();
                using (SqlDataReader rd = cmd.ExecuteReader())
                {
                    while (rd.Read())
                    {
                        categoria = new Categoria();
                        categoria.Id = (int)rd["Id"];
                        categoria.Nome = rd["Categoria"].ToString();
                        categoriaList.Add(categoria);
                    }
                }
                return categoriaList;
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu um erro ao tentar buscar uma categoria no banco de dados", ex) { Data = { { "Id", 10039 } } };
            }
            finally
            {
                cn.Close();
            }
        }
    }
}
