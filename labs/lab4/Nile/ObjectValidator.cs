using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.ComponentModel.DataAnnotations;

namespace Nile;

public class ObjectValidator
{
    public static void Validate (IValidatableObject value)
    {
        var context = new ValidationContext(value);

        Validator.ValidateObject(value, context, true);
    }
}
