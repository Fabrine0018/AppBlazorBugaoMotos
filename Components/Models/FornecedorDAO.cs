using AppBugaoMotoFVLE.Configs;
namespace AppBugaoMotoFVLE.Components.Models
{
    public class FornecedorDAO
    {
        private readonly Conexao _conexao;
        public FornecedorDAO(Conexao conexao)
        {
            _conexao = conexao;
        }

        public void InserirFornecedor(Fornecedor fornecedor)
        {
            try
            {
                var comando = _conexao.CreateCommand("INSERT INTO fornecedor Values (null, @nome_forne, @nome_responsa_forne, @telefoner_respon_forne, @telefoner_forne, @numero_forne, @complemento_forne, @cep_forne, @cnpj_forne, @rua_forne, @estado_forne, @cidade_forne, @bairro_forne, @razao_social_forne)");
                comando.Parameters.AddWithValue("@_", fornecedor.Responsavel);
                comando.Parameters.AddWithValue("@_", fornecedor.Nome);
                comando.Parameters.AddWithValue("@_", fornecedor.CEP);
                comando.Parameters.AddWithValue("@_", fornecedor.CNPJ);
                comando.Parameters.AddWithValue("@_", fornecedor.TelefoneRes);
                comando.Parameters.AddWithValue("@_", fornecedor.Rua);
                comando.Parameters.AddWithValue("@_", fornecedor.Bairro);
                comando.Parameters.AddWithValue("@_", fornecedor.Cidade);
                comando.Parameters.AddWithValue("@_", fornecedor.Estado);
                comando.Parameters.AddWithValue("@_", fornecedor.NumeroCasaApt);
                comando.Parameters.AddWithValue("@_", fornecedor.Complemento);
                comando.Parameters.AddWithValue("@_", fornecedor.RazaoSocial);
                comando.Parameters.AddWithValue("@_", fornecedor.TelefoneEmp);
                comando.ExecuteNonQuery();

            }
            catch (Exception)
            {
                throw;
            }
        }

        public List<Fornecedor> ListarFornecedores()
        {
            var lista = new List<Fornecedor>();
            var comando = _conexao.CreateCommand("SELECT *FROM fornecedor");
            var leitor = comando.ExecuteReader();

            while (leitor.Read())
            {
                var fornecedor = new Fornecedor
                {
                    Id = leitor.GetInt32("id_forne"),
                    Nome = leitor.GetString("nome_forne"),
                    Responsavel = leitor.GetString("nome_responsa_forne"),
                    CEP = leitor.GetString("cep_forne"),
                    CNPJ = leitor.GetString("cnpj_forne"),
                    TelefoneRes = leitor.GetString("telefoner_respon_forne"),
                    Rua = leitor.GetString("rua_forne"),
                    Bairro = leitor.GetString("bairro_forne"),
                    Cidade = leitor.GetString("cidade_forne"),
                    Estado = leitor.GetString("estado_forne"),
                    NumeroCasaApt = leitor.GetString("numero_forne"),
                    Complemento = leitor.GetString("complemento_forne"),
                    RazaoSocial = leitor.GetString("razao_social_forne"),
                    TelefoneEmp = leitor.GetString("telefoner_forne")
                };
                lista.Add(fornecedor);
            }
            return lista;
        }
    }
}
