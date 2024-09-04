using DoacaoSangue.Core.Enum;

namespace DoacaoSangue.Core.Entities
{
    public class Sangue
    {
        public ETipoSanguinio Tipo { get; set; }
        public EFatorRh FatorRh { get; set; }
    }
}
