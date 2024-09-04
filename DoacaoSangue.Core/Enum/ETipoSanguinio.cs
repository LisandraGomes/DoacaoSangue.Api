using System.ComponentModel;

namespace DoacaoSangue.Core.Enum
{
    public enum ETipoSanguinio
    {
        [Description("Tipo A")]
        TipoA,

        [Description("Tipo B")]
        TipoB,

        [Description("Tipo AB")]
        TipoAB,

        [Description("Tipo O")]
        TipoO
    }
}
