using System;
using System.IO;
using System.Text;

namespace EditorHtml {
    public static class Editor 
    {
        public static void Show() {
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Clear();
            Console.WriteLine("MODO EDITOR");
            Console.WriteLine("-----------");
            Start();
        }
        public static void Start() {
            var file = new StringBuilder();

            do {
                file.Append(Console.ReadLine());
                file.Append(Environment.NewLine);
            } while (Console.ReadKey().Key != ConsoleKey.Escape);

            Console.WriteLine("-----------");
            Console.WriteLine("  Deseja salvar o arquivo?");
            var option = Console.ReadLine();
            HandlerSaveArquive(option.ToLower(), file.ToString());
            Viewer.Show(file.ToString());
        }

        public static void HandlerSaveArquive(string option, string file) 
        {
            switch(option) {
                case "sim": Salvar(file); break;
            }
        }

        public static void Salvar(string text) {
            Console.Clear();
            Console.WriteLine("Qual o caminho que deseja salvar o arquivo?");
            var path = Console.ReadLine();

            using (var file = new StreamWriter(path)) {
                file.Write(text);
            }

            Console.WriteLine($"Arquivo salvo com sucesso em {path}.");
        }
    }
}