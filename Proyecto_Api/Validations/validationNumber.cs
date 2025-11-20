using System;

namespace Validations
{
    public class ValidationNumber
    {
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
