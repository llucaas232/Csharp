using System;

public class Nome
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Bem-vindo ao programa. Digite dois nomes inteiros e verá a quantidade de caracteres de cada nome e qual tem mais caracteres.");
        try
        {
            Console.WriteLine("Digite o nome completo: ");   // perguntando ao utilizador o nome
            string nome1 = Console.ReadLine();              // lendo o que foi digitado na linha 10
            string nomec = nome1.Replace(" ", "");          // deixando o espaço como nada pra não contar no length

            Console.WriteLine("Agora o segundo nome.\n");

            Console.WriteLine("Digite o nome completo: ");
            string nome2 = Console.ReadLine();
            string nome2c = nome1.Replace(" ", "");

            bool numeros = nomec.All(Char.IsLetter);       // verifica se todos os caracteres são letras, se não, false
            bool numeros2 = nome2c.All(Char.IsLetter);      


            if (numeros == false || numeros2 == false)      // se numeros = falso ou numeros 2 = falso....
            {
                throw new Exception();                      //vai jogar  pra exceção, dizendo que não se pode ter números (linha 48)
            }

            if (nome1.Length > nome2.Length)                // checando há mais caracteres em nome1 do que em nome2
            {
                Console.WriteLine("O maior nome é " + nome1 + " com " + nome1.Length + " caracteres.");

            }
            if (nome2.Length > nome1.Length)                // checando há mais caracteres em nome2 do que em nome1
            {
                Console.WriteLine("O maior nome é " + nome2 + " com " + nome2.Length + " caracteres.");

            }
            if (nome2.Length == nome1.Length)               // vendo se os caracteres sao iguais
            {
                Console.WriteLine("\nOs nomes tem o mesmo tamanho.");

            }

        }
        catch (Exception)
        {
            Console.WriteLine("Não é possivel continuar. Não se pode ter um número no nome.");
        }


    }
}
