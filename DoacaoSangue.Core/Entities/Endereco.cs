namespace DoacaoSangue.Core.Entities
{
    public class Endereco : Entitie
    {
        public string Logradouro { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }
        public string Cep { get; set; }
        public string Complemento { get; set; }
        public int numero  { get; set; }
    }
}
