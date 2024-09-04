namespace DoacaoSangue.Core.Entities
{
    public class EstoqueSangue
    {
        public int Id { get; set; }
        public Sangue Sangue { get; set; }
        public int QuantidadeMl { get; set; }
    }
}
