namespace GerarSenha
{
    internal class GeradorDeSenha
    {
        static void Main()
        {
            Console.WriteLine("Quantos caracteres a senha deve possuir?: ");
            int passwordLenght = Convert.ToInt32(Console.ReadLine());

            string password = GeneratePassword(passwordLenght);
            Console.Clear();
            Console.WriteLine("Senha gerada: ");
            Console.WriteLine(password);
            Console.ReadLine();
            Environment.Exit(0);
            
        }

        static string GeneratePassword(int passwordLenght)
        {
            const string allowedCharacters = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890!@#$%&*+-?";
            Random random = new Random();
            char[] password = new char[passwordLenght];

            for (int i = 0; i < passwordLenght; i++)
            {
                password[i] = allowedCharacters[random.Next(allowedCharacters.Length)];
            }

            return new string(password);
        }
    }
}