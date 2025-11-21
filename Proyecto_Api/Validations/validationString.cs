namespace Validations
{
    public class ValidationString
    {
        // Valida una cadena ingresada por el usuario.
        // @param input   Texto ingresado por el usuario.
        // @return        La cadena validada, sin estar vacía y sin contener números.
        //                Si la entrada no es válida, se solicita nuevamente.
        public static string AskForString(string? input)
        {
            input = input?.Trim().ToLower();
            
            if (string.IsNullOrWhiteSpace(input))
            {
                Console.WriteLine("Por favor, ingresa un texto:");
                return AskForString(Console.ReadLine());
            }

            if (int.TryParse(input, out _))
            {
                Console.WriteLine("Por favor, no ingreses números:");
                return AskForString(Console.ReadLine());
            }

            return input;
        }
    }
}
