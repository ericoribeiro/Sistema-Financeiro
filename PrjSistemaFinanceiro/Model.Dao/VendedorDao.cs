using Model.Entity;
using System.Data.SqlClient;
using System.Collections.Generic;
using System;

namespace Model.Dao
{
    public class VendedorDao : Obrigatorio<Vendedor>
    {
        private ConexaoDB objConexaoDB;
        private SqlCommand comando;

        public VendedorDao()
        {
            objConexaoDB = ConexaoDB.saberEstado();
        }

        public void create(Vendedor obj)
        {
            throw new System.NotImplementedException();
        }

        public void delete(Vendedor obj)
        {
            throw new System.NotImplementedException();
        }

        public bool find(Vendedor obj)
        {
            throw new System.NotImplementedException();
        }

        public List<Vendedor> findAll()
        {
            List<Vendedor> listVendedores = new List<Vendedor>();
            string query = "@SELECT * FROM vendedor ORDER BY ASC";

            try
            {
                comando = new SqlCommand(query, objConexaoDB.getCon());
                objConexaoDB.getCon().Open();
                SqlDataReader reader = comando.ExecuteReader();

                while (reader.Read())
                {
                    Vendedor vendedor = new Vendedor();
                    vendedor.IdVendedor = Convert.ToInt64(reader[0].ToString());
                    vendedor.Nome = reader[1].ToString();
                    vendedor.CPF = reader[2].ToString();
                    vendedor.Telefone = reader.ToString();
                    listVendedores.Add(vendedor);
                }
            }
            catch (Exception ex)
            {
                var mensagem = String.Format("Não foi possível listar os Vendedores");
                throw new Exception(mensagem, ex);
            }
            finally
            {
                objConexaoDB.getCon().Close();
                objConexaoDB.CloseDB();
            }

            return listVendedores;
        }

        public void procedureCreate(Vendedor obj)
        {
            throw new System.NotImplementedException();
        }

        public void update(Vendedor obj)
        {
            throw new System.NotImplementedException();
        }
    }
}
