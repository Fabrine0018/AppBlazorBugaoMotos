using AppBugaoMotoFVLE.Components.Models;
using AppBugaoMotoFVLE.Configs;


namespace AppBugaoMotoFVLE.Components.Models
{
    public class ServicoDAO
    {
        private readonly Conexao _conexao;

        public ServicoDAO(Conexao conexao)
        {
            _conexao = conexao;
        }

        public void InserirServico(Serviço servico)
        {
            try
            {
                var comando = _conexao.CreateCommand("INSERT INTO Servico VALUES (null, @_nome_ser, @_codigo_ser, @_prestador_ser, @_valor_ser)");
                comando.Parameters.AddWithValue("@_nome_ser", servico.Nome);
                comando.Parameters.AddWithValue("@_nome_ser", servico.Codigo);


                comando.Parameters.AddWithValue("@_prestador_ser", servico.Prestador);
                comando.Parameters.AddWithValue("@_nome_ser", servico.Valor);


                comando.ExecuteNonQuery();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public List<Serviço> ListarServico()
        {
            var lista = new List<Serviço>();

            var comando = _conexao.CreateCommand("SELECT * FROM Serviço ;");
            var leitor = comando.ExecuteReader();

            while (leitor.Read())
            {
                var servico = new Serviço
                {
                    IdSer = leitor.GetInt32("id_ser"),
                    Nome = DAOHelper.GetString(leitor, "nome_ser"),
                    Codigo = DAOHelper.GetString(leitor, "codigo_ser"),
                    Prestador = DAOHelper.GetString(leitor, "prestador_ser"),
                    Valor = leitor.GetDouble("valor_ser"),

                };
                //IdSer = leitor.GetInt32("id_ser");
                //servico.Nome = DAOHelper.GetString(leitor, "nome_ser");
                //servico.Codigo = DAOHelper.GetString(leitor, "codigo_ser");
                //servico.Prestador = DAOHelper.GetString(leitor, "prestador_ser");
                //servico.Valor = leitor.GetDouble("valor_ser");

                lista.Add(servico);
            }
            return lista;
        }
    }
}

