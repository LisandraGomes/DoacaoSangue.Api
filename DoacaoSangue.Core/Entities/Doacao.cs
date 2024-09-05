namespace DoacaoSangue.Core.Entities
{
    public class Doacao : Entitie
    {
        public DateTime DataDoacao { get; set; }
        public int QuantiadeMl { get; set; }
        public Doador Doador { get; set; }
    }
}
