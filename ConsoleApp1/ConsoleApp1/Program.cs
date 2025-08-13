namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("escreva seu produto: ");
            string nomeProduto = Console.ReadLine();
            int qtdeProduto = 0;
            Console.WriteLine("Digite a quantidade do Produto a ser comprada: ");
            qtdeProduto = int.Parse(Console.ReadLine());

            if (qtdeProduto <= 0)
            {
                Console.WriteLine("Não é possível comprar 0 ou quantidade negativa");
            }
            else
            {
                Console.WriteLine("Você consegue comprar");
                Console.WriteLine(nomeProduto);
                Console.WriteLine("A quantidade a ser comprada é: " + qtdeProduto);

            }
        }
    }
}
