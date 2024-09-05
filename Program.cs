using System;

class Program
{
    static void Main(string[] args)
    {
        int escolha;
        do
        {
            Console.WriteLine("Escolha um exercício para executar:");
            Console.WriteLine("1. Exercicio1");
            Console.WriteLine("2. Exercicio2");
            Console.WriteLine("3. Exercicio3");
            Console.WriteLine("4. Exercicio4");
            Console.WriteLine("5. Exercicio5");
            Console.WriteLine("0. Sair");
            Console.Write("Digite o número do exercício: ");

            escolha = Convert.ToInt32(Console.ReadLine());

            switch (escolha)
            {
                case 1:
                    Exercicio1 ex1 = new Exercicio1();
                    ex1.Execute();
                    break;
                case 2:
                    Exercicio2 ex2 = new Exercicio2();
                    ex2.Execute();
                    break;
                case 3:
                    Exercicio3 ex3 = new Exercicio3();
                    ex3.Execute();
                    break;
                case 4:
                    Exercicio4 ex4 = new Exercicio4();
                    ex4.Execute();
                    break;
                case 5:
                    Exercicio5 ex5 = new Exercicio5();
                    ex5.Execute();
                    break;
                case 0:
                    Console.WriteLine("Saindo...");
                    break;
                default:
                    Console.WriteLine("Escolha inválida.");
                    break;
            }

            Console.WriteLine(); 

        } while (escolha != 0);
    }
}
