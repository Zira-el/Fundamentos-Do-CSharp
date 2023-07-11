// See https://aka.ms/new-console-template for more information
namespace Cronometro
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu();
        }

        static void Menu()
        {
            Console.WriteLine("Escolha qual o tipo de contagem digitando como o exemplo a seguir:");
            Console.WriteLine("M para Minutos => Ex: 10M");
            Console.WriteLine("S para Segundos => Ex: 10S");
            Console.WriteLine("0 para Sair");

            string data = Console.ReadLine().ToUpper();
            char typesTime = char.Parse(data.Substring(data.Length - 1, 1));
            int time = int.Parse(data.Substring(0, data.Length - 1));

            int multiplier = 1;

            if (typesTime == 'M') multiplier = 60;
            if (time == 0) System.Environment.Exit(0);

            preStart(multiplier * time);
        }

        static void preStart(int time){
            Console.Clear();
            Console.WriteLine("Ready?");
            Thread.Sleep(2000);
            Console.WriteLine("GO!");
            Thread.Sleep(1000);
            Start(time);
        }
        static void Start(int time)
        {
            int currentTime = 0;

            while (currentTime != time)
            {
                Console.Clear();
                currentTime++;
                Console.WriteLine(currentTime);
                Thread.Sleep(1000);
            }

            Console.Clear();
            Console.WriteLine("Cronômetro finalizado!");
            Thread.Sleep(1000);

            Menu();
        }

    }
}