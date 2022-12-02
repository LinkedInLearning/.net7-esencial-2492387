using System.Runtime.CompilerServices;

var theValue = string.Empty;
Validations.Validate(theValue);


public static class Validations
{
   public static void Validate(string? name, 
   [CallerArgumentExpression(nameof(name))] string parameterName = null)
   {
        if (name?.Length <= 0)
        {
            throw new Exception($"Valor no válido en: {parameterName}");
        }
   }
}