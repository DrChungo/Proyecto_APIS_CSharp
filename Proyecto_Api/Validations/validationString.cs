namespace Validations
{
    public class ValidationString
    {
        public static string AskForString(string? input)
        {
            input=input?.Trim().ToLower();
            
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
