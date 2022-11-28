

using TreinandoCsharp.Models.People;

public class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("======= IDADE PARA HABILITAÇÃO ======= \n ==== Digite Enter ==== ");
        Console.ReadLine();

        {
            Console.WriteLine("Digite o seu cpf:");
            double cpf = double.Parse(Console.ReadLine());


            Console.WriteLine("Digite o seu nome");
            string name = Console.ReadLine();


            Console.WriteLine("Digite a sua idade");
            int age = int.Parse(Console.ReadLine());


            if (age >= 18)
            {
                Console.WriteLine("Apto(a) para Habilitação!");
                Console.ReadLine();
            }

            else
            {
                Console.WriteLine("Cliente menor de idade e não está apto para Habilitação!");
                Console.ReadLine();
            }

        }



    }
}