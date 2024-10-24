namespace Inloggningssystem_G6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Inloggningssystem\n");

            Console.WriteLine("Användarnamn:");
            byte usernameInput = Convert.ToByte(Console.ReadLine());

            Console.WriteLine("Lösenord:");
            byte passwordInput = Convert.ToByte(Console.ReadLine());

        }
    }
}
