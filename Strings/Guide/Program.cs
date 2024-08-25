namespace MyApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Guid é um "Global User Identifier" que é um indentificador único criado usando o C#.

            // Para gerar um grid aleatório basta usar a sintaxe
            var id = Guid.NewGuid();
            Console.WriteLine(id);

            // Também é possível inicializar um Guid com valores pré-definidos da seguinte forma:
            id = new Guid("ec49135f-17a0-44dd-9b5f-2d44938c7dbc");
            Console.WriteLine(id);
        }
    }
}