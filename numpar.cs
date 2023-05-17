using System;

public class Calculo
{
	
    public static void Main(string[] args)
    {
		try{    
		Console.WriteLine ("Digite o primeiro número: ");
        string numu = Console.ReadLine();
        float num1 = Convert.ToInt32(numu);
        
        Console.WriteLine("Digite o segundo número: ");
        string numo = Console.ReadLine();
        float num2 = Convert.ToInt32(numo);
					
		//num2 = 0;     
		float numb = num1 / num2;
		float num3 = Convert.ToInt32(numb);	
			
		if(num3%2 == 0){
			throw new Exception("É par.");
		}
	   
		Console.WriteLine("O resultado da divisão é " + num3);
		}
		catch(DivideByZeroException){    
			throw new Exception("Um número não pode ser dividido por zero");
		}
		catch(Exception){
			throw new Exception("Erro: o número é par");
		
		}
         }
      }





































using System;

public class Nome
{
    public static void Main(string[] args){
		Console.WriteLine("Bem-vindo ao programa. Digite dois nomes inteiros e verá a quantidade de caracteres de cada nome e qual tem mais caracteres.");
		try
		{
			Console.WriteLine("Digite o nome completo: ");
			string nome1 = Console.ReadLine();
            string nomec = nome1.Replace(" ", "");

            Console.WriteLine("Agora o segundo nome.\n");

            Console.WriteLine("Digite o nome completo: ");
            string nome2 = Console.ReadLine();
            string nome2c = nome1.Replace(" ", "");

            bool numeros = nome1.All(Char.IsLetter) || nome1.All(Char.IsLetter);

            if (nome1.Length > nome2.Length)
			{
                Console.WriteLine("O maior nome é " + nome1 + " com " + nome1.Length + " caracteres.");
             
            }
            if (nome2.Length > nome1.Length)
            {
                Console.WriteLine("O maior nome é " + nome2 + " com " + nome2.Length + " caracteres.");

            }

            if (numeros == false)
            {
                throw Exception;
            }


        }
		catch (Exception)
		{

			throw;
		}


    }
}
    