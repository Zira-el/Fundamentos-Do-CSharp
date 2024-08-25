namespace MySpace
{
    class Comparacao
    {
        static void Main(string[] args)
        {
            // O primeiro método usa o CompareTo que vai retornar um número que diz se um texto é ou não igual ao outro
            var texto = "Testando";
            // Aqui retorna o número 0 (zero) que quer dizer que os valores são iguais
            Console.WriteLine(texto.CompareTo("Testando"));
            // Aqui retorna o número 1 (um) que quer dizer que os valores são diferentes
            Console.WriteLine(texto.CompareTo("testando"));

            // Outro método é usando o Contains que retorna se uma string contém um pedaço de um texto
            var texto2 = "Mais um teste";
            // Isso irá retornar um true pois existe a palavra teste no texto2
            Console.WriteLine(texto2.Contains("teste"));
            // Para ignorar o case sensitive basta fazer o seguinte e o resultado também retornará true para "Teste"
            Console.WriteLine(texto2.Contains("Teste", StringComparison.OrdinalIgnoreCase));

            // Outro método de comparação é se o texto começa com ou termina com alguma string e retorna um booleano
            var textStart = "Este exemplo começa com";
            Console.WriteLine(textStart.StartsWith("Este")); // Retorn um true
            var textEnds = "Este exemplo termina com";
            Console.WriteLine(textEnds.EndsWith("com")); // Retorna um true

            // Existe um outro método que testa se um texto é exatamente igual ao outro
            // Este teste funciona para qualquer tipo de dado (objeto, boolean, números e etc)
            var isEqual = "Mais um teste";
            Console.WriteLine(isEqual.Equals("Mais um teste")); // Retorna True
        }
    }
}