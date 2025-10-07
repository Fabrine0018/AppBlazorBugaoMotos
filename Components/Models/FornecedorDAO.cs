namespace AppBugaoMotoFVLE.Components.Models
{
    public class FornecedorDAO
    {
        //private readonly Conexao _conexao;
        //public FornecedorDAO(Conexao conexao)
        //{
        //    _conexao = conexao;
        //}

        //public void InserirFornecedor(Fornecedor fornecedor)
        //{
        //    try
        //    {
        //        var comando = _conexao.CreateCommand("INSERT INTO fornecedor Values (null, null, @...)");
        //        comando.Parameters.AddWithValue("@_", fornecedor.Responsavel);
        //        comando.Parameters.AddWithValue("@_", fornecedor.CEP);
        //        comando.Parameters.AddWithValue("@_", fornecedor.CNPJ);
        //        comando.Parameters.AddWithValue("@_", fornecedor.TelefoneRes);
        //        comando.Parameters.AddWithValue("@_", fornecedor.Rua);
        //        comando.Parameters.AddWithValue("@_", fornecedor.Bairro);
        //        comando.Parameters.AddWithValue("@_", fornecedor.Cidade);
        //        comando.Parameters.AddWithValue("@_", fornecedor.Estado);
        //        comando.Parameters.AddWithValue("@_", fornecedor.NumeroCasaApt);
        //        comando.Parameters.AddWithValue("@_", fornecedor.Complemento);
        //        comando.Parameters.AddWithValue("@_", fornecedor.RazaoSocial);
        //        comando.Parameters.AddWithValue("@_", fornecedor.TelefoneEmp);
        //        comando.ExecuteNonQuery();

        //    }
        //    catch (Exception)
        //    {
        //        throw;
        //    }
        //}

        //public List<Fornecedor> ListarFornecedores()
        //{
        //    var lista = new List<Fornecedor>();
        //    var comando = _conexao.CreateComando("SELECT *FROM forncedor");
        //    var leitor = comando.ExecuteReader();

        //    while (leitor.Reade())
        //    {
        //        var fornecedor = new Fornecedor
        //        {
        //            Id = leitor.GetInt32("id_for"),
        //            Responsavel = leitor.GetString("nome_res_for"),
        //            CEP = leitor.GetString("CEP_for"),
        //            CNPJ = leitor.GetString("CNPJ_for"),
        //            TelefoneRes = leitor.GetString("telefone_res_for"),
        //            Rua = leitor.GetString("rua_for"),
        //            Bairro = leitor.GetString("Bairro_for"),
        //            Cidade = leitor.GetString("Cidade_for"),
        //            Estado = leitor.GetString("estado_for"),
        //            NumeroCasaApt = leitor.GetString("numero_ca_for"),
        //            Complemento = leitor.GetString("complemento_for"),
        //            RazaoSocial = leitor.GetString("razao_social_for"),
        //            TelefoneEmp = leitor.GetString("telefone_emp_for")
        //        };
        //        lista.Add(fornecedor);
        //    }
        //    return lista;
        //}
    }
}
