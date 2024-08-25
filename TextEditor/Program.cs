﻿namespace TextEditor
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
            Console.WriteLine("O que você deseja fazer?");
            Console.WriteLine("1 - Abrir arquivo");
            Console.WriteLine("2 - Criar novo arquivo");
            Console.WriteLine("0 - Sair");
            short option = short.Parse(Console.ReadLine());

            switch (option)
            {
                case 0: System.Environment.Exit(0); break;
                case 1: Open(); break;
                case 2: Create(); break;

                default: Menu(); break;
            }
        }

        static void Open()
        {
            Console.Clear();
            Console.WriteLine("Qual o caminho do arquivo?");
            string path = Console.ReadLine();
            using(var file = new StreamReader(path)){
                string text = file.ReadToEnd();
                Console.Write(text);
            }

            Console.WriteLine("");
            Console.ReadLine();
        }

        static void Create()
        {
            Console.Clear();
            Console.WriteLine("Digite seu texto abaixo (ESC para sair)");
            Console.WriteLine("------------------------");
            string text = "";

            do
            {

                text += Console.ReadLine();
                text += Environment.NewLine;

            } while (Console.ReadKey().Key != ConsoleKey.Escape);

            Save(text);
        }

        static void Save(string text)
        {
            Console.Clear();
            Console.WriteLine("Qual caminho para salvar o arquivo?");
            string path = Console.ReadLine();

            using (var file = new StreamWriter(path))
            {
                file.Write(text);
            }

            Console.WriteLine($"Arquivo salvo com sucesso em {path}");
            Thread.Sleep(3000);
            Menu();
        }
    }
}