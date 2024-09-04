namespace DoacaoSangue.Core.Entities
{
    public class Doacao
    {
        public Guid Id { get; set; }
        public DateTime DataDoacao { get; set; }
        public int QuantiadeMl { get; set; }
        public Doador Doador { get; set; }
    }
}
