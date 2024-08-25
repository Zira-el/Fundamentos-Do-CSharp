using System.Text;

namespace MyApp
{
    class Metodos
    {
        static void Main(string[] args)
        {
            // Exemplo de como retornar o indice de uma string
            var texto = "Qual é o índice";
            Console.WriteLine(texto.IndexOf("é")); // Vai retornar o indice da palavra "é"
            Console.WriteLine(texto.LastIndexOf("e")); // Vai retorna o índice do último "e" na string

            // Métodos para transformar um texto em maiúsculo ou minúsculo
            Console.WriteLine(texto.ToLower());
            Console.WriteLine(texto.ToUpper());

            // Métodos para inserir e retirar palavras de um texto a partir de um indice pré definido
            Console.WriteLine(texto.Insert(5, "AQUI ")); // Coloca a palavra a partir do índice 5
            Console.WriteLine(texto.Remove(5, 5)); // Retira 5 letras a partir do índice 5

            // Método para substituir um caractere por outro
            Console.WriteLine(texto.Replace("índice", "posição")); // Substitui a palavra "indice" pela palavra "posição".

            // Método para dividir um texto a partir de um referencial e criar um array de palavras
            var arrayOfWords = texto.Split(" "); // Divide usando o espaço vazio como referencial
            Console.WriteLine(arrayOfWords[0]);

            // O substring pega partes de caracteres usando o indice inicial e quantos caracteres queremos
            var sub = texto.Substring(0, 4);
            Console.WriteLine(sub); // Retorna a palavra "Qual"

            Console.WriteLine(texto.Trim()); // Retira espaços do inicio e do fim de um texto

            // Método stringBuilder é usado para concatenar textos de maneira dinâmica e sem criar várias copias de um texto em memória
            var textBuild = new StringBuilder();
            textBuild.Append("Juntando");
            textBuild.Append(" vários");
            textBuild.Append(" textos em um.");

            textBuild.ToString();
            Console.WriteLine(textBuild);
        }
    }
}