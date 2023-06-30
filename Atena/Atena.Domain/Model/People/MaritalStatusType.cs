using System.ComponentModel;

namespace Atena.Domain.Model
{
    public enum MaritalStatusType
    {
        [Description("MARRIED")]
        Casado = 1,
        [Description("DIVORCED")]
        Divorciado = 2,
        [Description("SINGLE")]
        Solteiro = 3,
        [Description("WIDOWER")]
        Viuvo = 4,
        [Description("SEPARATE")]
        Separado = 5,
        [Description("UNINFORMED")]
        NaoInformado = 6
    }
}
