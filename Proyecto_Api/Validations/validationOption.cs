namespace Validations
{
    public class ValidationOption
    {
        // Valida una opción ingresada por el usuario (s/n).
        // @param input   Cadena ingresada por el usuario.
        // @return        true si la opción es "s", false si es "n".
        //                Si la entrada no es válida, vuelve a pedir una opción.
        public static bool AskForOption(string? input)
        {
            input = input?.Trim().ToLower();
            
            if (input == "s")
            {
                return true;
            }
            else if (input == "n")
            {
                return false;
            }
            else
            {
                Console.WriteLine("Solo puede ser (s/n)");
                return AskForOption(Console.ReadLine());
            }
        }
    }
}
