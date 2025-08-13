namespace Exercicio01_1208
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Diite o valor 1: ");
            //int valor1 = Convert.ToInt32(Console.ReadLine());

            ////Concatenação
            //Console.WriteLine("O valor digitado foi: " + valor1);

            ////Interpolação
            //Console.WriteLine("O valor digitado foi: {0} ", valor1);

            Console.WriteLine("Num 1: ");
            int valor1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Num 2: ");
            int valor2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Escolha a operação: +, -, /, *");
            char Result = Convert.ToChar(Console.ReadLine());

            if (valor1 != 0 && valor2 != 0)
            {
                switch (Result)
                {
                    case '+':
                        Console.WriteLine("Resultado: " + (valor1 + valor2));
                        break;
                    case '-':
                        Console.WriteLine("Resultado: " + (valor1 - valor2));
                        break;
                    case '/':
                        Console.WriteLine("Resultado: " + (valor1 / valor2));
                        break;
                    case '*':
                        Console.WriteLine("Resultado: " + (valor1 * valor2));
                        break;
                }
            }
            else { Console.WriteLine("Necessário informar dois números diferentes de 0");}
        }   
    }
}
