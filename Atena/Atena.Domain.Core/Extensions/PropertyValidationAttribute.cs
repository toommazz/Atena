using System.ComponentModel.DataAnnotations;

namespace Atena.Domain.Core.Extensions
{
    public class PropertyValidationAttribute : ValidationAttribute
    {
        public PropertyValidationAttribute() { }

        public override bool IsDefaultAttribute()
        {
            return base.IsDefaultAttribute();   
        }
    }
}
