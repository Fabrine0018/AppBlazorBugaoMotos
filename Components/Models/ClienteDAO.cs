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

