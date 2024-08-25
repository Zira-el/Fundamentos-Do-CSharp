namespace MySpace
{
    class Interpolacao
    {
        static void Main(string[] args)
        {
            // A maneira mais simples de fazer uma interpolação (junção de informações transformando em string) é da maneira abaixo. Não é a melhor maneira nem a mais performática.
            // Essa maneira de interpolação funciona também para booleans
            var number = 10.2;
            var texto = "O número é " + number + "no momento.";
            Console.WriteLine(texto);

            // Outra maneira é usando o string.Format, dessa maneira:
            // Dessa maneira os valores representados pelas chaves são substituidos pelos dados que vem depois da virgula em ordem.
            var price = 15;
            var texto2 = string.Format("O preço do produto é {0} apenas na promoção {1}", price, true);
            Console.WriteLine(texto2);

            // O terceiro modo é usando o $.
            // Se usarmos o $@ podemos quebrar a linha que o C# vai entender que o texto é uma linha só.
            var price2 = 25;
            var texto3 = $"O preço do produto é {price2}";
            Console.WriteLine(texto3);
        }
    }
}