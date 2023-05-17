using System.IO;
using System;

class Restaurante
{
    public class Global {


       public static string nome = "";
        public static string quant = "";
        public static int prato = 0;


    }



    public static void Main()
    {
    
        try
        {
            Console.WriteLine("Seja bem-vindo ao programa de pesquisa do restaurante.\n");

            Console.WriteLine("Por favor, digite seu nome: ");
            Global.nome = Console.ReadLine();

            Console.WriteLine("Quantos pratos você comeu: ");
            Global.quant = Console.ReadLine();
            int quantpratos = Convert.ToInt32(Global.quant);

            for (int i = 0; i < quantpratos; i++)               // Vai pegar quantos pratos foram comidos e fazer um for loop com a mesma quantidade
            {
                Console.WriteLine("Digite o(s) prato(s) que comeu. 1 para peixe, 2 para carne e 3 para vegetais: ");
                Global.prato = Convert.ToInt32(Console.ReadLine());                // Aqui ele vai resgatar só um dos pratos (o último que foi colocado) visto que é um for loop

                if (Global.prato == 3)                                             // Se o prato é "3", vegetariano, ele irá guardar o txt
                {
                    using StreamWriter File = new StreamWriter("Ambiente de trabalho\\cliente.txt");
                    {
                        File.WriteLine("Nome do cliente: " + Global.nome + "\nQuantidade de pratos: " + quantpratos + "\nTipo do prato:"); // Aqui o código não parece funcionar, mesmo colocando 3 ele será jogado pro catch 
                    }
                }
                else                                                     // No else o código não faz o que tenho em mente. No momento que ele reconhece "1" ou "2" ele encerra automaticamente o código e não dá hipótese de se colocar um "3". Seria melhor criar uma array mas desconheço a syntax
                {
                    throw new Exception();
                }
            }

        }
        catch (Exception)
        {
            Console.WriteLine("Obrigado!");

        }
    }
}