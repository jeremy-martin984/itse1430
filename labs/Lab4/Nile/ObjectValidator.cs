using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Nile
{
    //Only contain static members 
    //Cannot create an instance
    // Rule 1 - Never create a type called ?Helper or ?Utility or ?Common
    // Rule 2 - No data
    // Rule 3 - Don't treat as global functions/variables
    public static class ObjectValidator
    {
        //Global functions 
        public static IEnumerable<ValidationResult> TryValidate ( object value )
        {

            var errors = new List<ValidationResult>();

            Validator.TryValidateObject(value, new ValidationContext(value), errors, true);

            return errors;
        }

        public static void Validate ( object value )
        {
            Validator.ValidateObject(value, new ValidationContext(value), true);
        }

        //Global vaiables
        //private static ObjectValidator Instance = new ObjectValidator();
    }
}
