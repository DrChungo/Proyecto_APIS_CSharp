using System;

namespace Validations
{
    public class ValidationNumber
    {
        // Solicita y valida que el valor ingresado sea un número entero.
        // @param input   Cadena ingresada por el usuario.
        // @return        El número entero validado. Si el valor no es válido,
        //                se solicita nuevamente de forma recursiva.
        public static int AskForNumber(string? input)
        {
            if (!int.TryParse(input, out int number))
            {
                Console.WriteLine("Por favor, ingresa un número:");
                input = Console.ReadLine();
                return AskForNumber(input); 
            }

            return number; 
        }
    }
}
