﻿/*Jeremy Martin
 * ITSE 1430
 * Lab 3
 * 4/6/2020
 */

using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CharacterCreator
{
    public static class ObjectValidator
    {
        public static IEnumerable<ValidationResult> Validate ( object value )
        {
            var errors = new List<ValidationResult>();
            Validator.TryValidateObject(value, new ValidationContext(value), errors, true);

            return errors;
        }
    }
}
