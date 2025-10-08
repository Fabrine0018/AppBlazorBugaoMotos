namespace AppBugaoMotoFVLE.Components.Models;
using AppBugaoMotoFVLE.Configs;
using Microsoft.AspNetCore.Razor.TagHelpers;
using Microsoft.AspNetCore.Routing;


public class ClienteDAO
{
    private readonly Conexao _conexao;

    public ClienteDAO(Conexao conexao)
    {
        _conexao = conexao;
    }

    public void InserirCliente(Cliente cliente)
    {
        try
        {
            var comando = _conexao.CreateCommand("INSERT INTO fornecedor VALUES (null, @_nome_clie, @_telefone_clie, @_cep_clie, @_complemento_clie, @_cpf_clie, @_rua_clie, @_estado_clie, @_cidade_clie, @_bairro_clie)");
            comando.Parameters.AddWithValue("@_nome_clie", cliente.Nome);
            comando.Parameters.AddWithValue("@_telefone_clie",cliente.Telefone);
     
       
            comando.Parameters.AddWithValue("@_cep_clie", cliente.Cep);
            comando.Parameters.AddWithValue("@_complemento_clie", cliente.Completo);
            comando.Parameters.AddWithValue("@_cpf_clie", cliente.Cpf);
           
            comando.Parameters.AddWithValue("@_rua_clie", cliente.Rua);
            comando.Parameters.AddWithValue("@_estado_clie", cliente.Estado);
            comando.Parameters.AddWithValue("@_cidade_clie", cliente.Cidade);
            comando.Parameters.AddWithValue("@_bairro_clie", cliente.Bairro);
       
            comando.ExecuteNonQuery();
        }
        catch (Exception)
        {
            throw;
        }
    }

    public List<Cliente> ListarTodoClie()
    {
        var listaClie = new List<Cliente>();

        var comando = _conexao.CreateCommand("SELECT * FROM produto;");
        var leitor = comando.ExecuteReader();

        while (leitor.Read())
        {
            var cliente = new Cliente();
            cliente.IdCli = leitor.GetInt32("id_clie");
            cliente.Nome_Clie = DAOHelper.GetString(leitor, "nome_clie");
            cliente.Telefone_Clie = DAOHelper.GetString(leitor, "telefone_clie");
            cliente.Estado_Clie = DAOHelper.GetString(leitor, "estado_clie");
            cliente.Cpf_Clie = DAOHelper.GetString(leitor, "cpf_clie");
            cliente.Cidade_Clie = DAOHelper.GetString(leitor, "cidade_clie");
            cliente.Completo_Clie = DAOHelper.GetString(leitor, "complemento_clie");
            cliente.Bairro_Clie = DAOHelper.GetString(leitor, "bairro_clie");
            cliente.Rua_Clie = DAOHelper.GetString(leitor, "rua_clie");
            cliente.Cep_clie = DAOHelper.GetString(leitor, "cep_clie");



            listaClie.Add(cliente);
        }

        return listaClie;
    }
}

