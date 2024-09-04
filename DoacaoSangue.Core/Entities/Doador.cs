using DoacaoSangue.Core.Enum;

namespace DoacaoSangue.Core.Entities
{
    public class Doador
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Sobrenome { get; set; }
        public string Email { get; set; }
        public DateTime DataNascimento { get; set; }
        public EGenero Genero { get; set; }
        public int Peso { get; set; }
        public ETipoSanguinio  TipoSanguinio { get; set; }
        public EFatorRh FatorRh { get; set; }
        public Endereco Endereco { get; set; }
        public Doacao Doacoes { get; set; }
    }
}
