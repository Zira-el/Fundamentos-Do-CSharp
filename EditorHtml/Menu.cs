using System;

namespace EditorHtml
{
    class Menu
    {
        public static void Show()
        {
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.ForegroundColor = ConsoleColor.Black;
            DrawScreen();
            WriteOptions();

            var option = short.Parse(Console.ReadLine());
        }

        public static void DrawScreen()
        {
            CreateHeaderAndFooter();
            CreateLinesAndSpaces();
            CreateHeaderAndFooter();
        }

        public static void CreateHeaderAndFooter() {
            Console.Write("+");
            for(int index = 0; index <= 50; index++) Console.Write("-");
            Console.Write("+");
            Console.Write("\n");
        }

        public static void CreateLinesAndSpaces() {

            for (int lines = 0; lines <= 10; lines++) {
                Console.Write("|");
                for (int space = 0; space <= 50; space++) Console.Write(" ");
                Console.Write("|");
                Console.Write("\n");
            }
        }

        public static void WriteOptions() {
            ConfigCursorAndOptions(2, 2, "Editor HTML");
            ConfigCursorAndOptions(2, 3, "============================");
            ConfigCursorAndOptions(2, 4, "Selecione uma opção abaixo");
            ConfigCursorAndOptions(2, 6, "1 - Novo Arquivo");
            ConfigCursorAndOptions(2, 7, "2 - Abrir");
            ConfigCursorAndOptions(2, 9, "0 - Sair");
            ConfigCursorAndOptions(2, 10, "Opção:");
            Console.SetCursorPosition(2, 10);
            Console.Write("Opção: ");
        }

        public static void ConfigCursorAndOptions(int initial, int final, string message ) {
            Console.SetCursorPosition(initial, final);
            Console.WriteLine(message);
        }
    }


}