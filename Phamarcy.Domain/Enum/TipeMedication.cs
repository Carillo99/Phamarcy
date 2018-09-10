using System.ComponentModel;

namespace Phamarcy.Domain.Enum
{
    public enum TipeMedication
    {
        [Description("Desconhecido")]
        Desconhecido,

        [Description("Brand Medication")]
        Brand,

        [Description("Generic Medication")]
        Generic
    }
}
