using Model.Entity;
using System.Data.SqlClient;
using System.Collections.Generic;
using System;

namespace Model.Dao
{
    public class ClienteDao : Obrigatorio<Cliente>
    {
        private ConexaoDB objConexaoDB;
        private SqlCommand comando;

        public ClienteDao()
        {
            objConexaoDB = ConexaoDB.saberEstado();
        }

        public void create(Cliente objCliente)
        {
            string create = "INSERT INTO cliente(nome, endereco, telefone, cpf) VALUES('"+ objCliente.Nome +"', '"+objCliente.Endereco+"', '"+objCliente.Telefone+"', '"+objCliente.Cpf+"')";
            try
            {
                comando = new SqlCommand(create, objConexaoDB.getCon());
                objConexaoDB.getCon().Open();
                comando.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                objCliente.Estado = 1;
            }
            finally
            {
                objConexaoDB.getCon().Close();
                objConexaoDB.CloseDB();
            }
        }

        public void delete(Cliente obj)
        {
            throw new System.NotImplementedException();
        }

        public bool find(Cliente obj)
        {
            throw new System.NotImplementedException();
        }

        public List<Cliente> findAll()
        {
            throw new System.NotImplementedException();
        }

        public void update(Cliente obj)
        {
            throw new System.NotImplementedException();
        }
    }
}
