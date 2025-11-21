namespace Validations
{
    public class ValidationOption
    {
        public static bool AskForOption(string? input)
        {

            input=input?.Trim().ToLower();
            
            if (input=="s")
            {
               return true;

            }else if (input=="n")
            {
                return false;
            }
            else
            {
                Console.WriteLine("Solo pede ser (s/n)");
                return AskForOption(Console.ReadLine());
            }

        }
    }
}
