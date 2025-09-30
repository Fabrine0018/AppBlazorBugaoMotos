using System.Globalization;

namespace AppBugaoMotoFVLE.Components.Models
{
    public class Fornecedor
    {
        public string? Responsavel { get; set; }
        public string CEP { get; set; }
        public string CNPJ { get; set; }
        public string TelefoneRes { get; set; }
        public string Rua { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }
        public int NumeroCasaApt { get; set; }
        public string Complemento { get; set; }
        public string RazaoSocial { get; set; }
        public string TelefoneEmp { get; set; }
        
        /* endereço a decidir se será normalizado */
    }
}
