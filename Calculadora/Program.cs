

namespace Calculadora
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Console.WriteLine("Digite o primeiro valor: ");
            float value1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Digite a operação desejada: ");
            String operation = Console.ReadLine();
            if (operation != "+" && operation != "-" && operation != "/" && operation != "*")
            {
                Console.WriteLine("Operação incorreta!");
            }
            else
            {
                Console.WriteLine("Digite o segundo valor: ");
                float value2 = float.Parse(Console.ReadLine());

                if (operation == "+")
                {
                    Console.WriteLine("A Soma é: " + (value1 + value2));
                }
                else if (operation == "-")
                {
                    Console.WriteLine("A subtração é: " + (value1 - value2));
                } else if (operation == "*")
                {
                    Console.WriteLine("A multiplicação é: " + (value1 * value2));
                } else if (operation == "/")
                {
                    Console.WriteLine("A divisão é: " + (value1 / value2));
                }
            }
        }


    }
}