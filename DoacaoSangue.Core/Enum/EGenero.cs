using System.ComponentModel;

namespace DoacaoSangue.Core.Enum
{
    public enum EGenero
    {
        [Description("Feminino")]
        Feminino,
        [Description("Masculino")]
        Masculino,
        [Description("Não-binário")]
        NaoBinario,
        [Description("Transgênero")]
        Transgenero,
        [Description("Outro")]
        Outro
    }
}
