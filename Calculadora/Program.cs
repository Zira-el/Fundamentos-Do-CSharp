

namespace Calculadora
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu();
        }
        static void Menu()
        {
            Console.Clear();
            Console.WriteLine("Qual operação deseja fazer?");
            Console.WriteLine("");
            Console.WriteLine("1 - Soma");
            Console.WriteLine("2 - Subtração");
            Console.WriteLine("3 - Multiplicação");
            Console.WriteLine("4 - Divisão");
            Console.WriteLine("5 - Sair");
            Console.WriteLine("---------------------------");
            Console.WriteLine("");

            short operation = short.Parse(Console.ReadLine());
            if (operation != 1 && operation != 2 && operation != 3 && operation != 4 && operation != 5)
            {
                Menu();
            }
            else if (operation == 5)
            {
                System.Environment.Exit(0);

            }
            else
            {
                operationChoise(operation);
            }
        }

        static void Sum(float value1, float value2)
        {
            Console.WriteLine($"O resultado da soma é {value1 + value2}");
            Console.ReadKey();
            Menu();
        }
        static void Subtraction(float value1, float value2)
        {
            Console.WriteLine($"O resultado da subtração é {value1 - value2}");
            Console.ReadKey();
            Menu();
        }
        static void Multiplication(float value1, float value2)
        {
            Console.WriteLine($"O resultado da multiplicação é {value1 * value2}");
            Console.ReadKey();
            Menu();
        }
        static void Division(float value1, float value2)
        {
            Console.WriteLine($"O resultado da divisão é {value1 / value2}");
            Console.ReadKey();
            Menu();
        }

        static void operationChoise(short operation)
        {
            Console.Clear();
            Console.WriteLine("Escolha o primeiro valor: ");

            float value1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Escolha o segundo valor: ");
            float value2 = float.Parse(Console.ReadLine());

            switch (operation)
            {
                case 1: Sum(value1, value2); break;
                case 2: Subtraction(value1, value2); break;
                case 3: Multiplication(value1, value2); break;
                case 4: Division(value1, value2); break;
            }
        }
    }
}