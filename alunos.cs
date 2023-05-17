using System;

public class HelloWorld
{

static void Main (string[]args){
	Console.WriteLine ("Quantos registros quer inserir: ");
	string numr = Console.ReadLine();
    int numrI = Convert.ToInt32(numr);
	
	for (int i = 0; i < numrI; i++)
	{
		Console.WriteLine("Digite o nome do aluno: ");
		string nome = Console.ReadLine();
		
		Console.WriteLine("Digite a morada do aluno: ");
		string morada = Console.ReadLine();
		
		Console.WriteLine("Digite o numero de telemovel do aluno: ");
		string tele = Console.ReadLine();
		if (tele.Length < 9)
		{ 
		    Console.WriteLine("O número precisa ter 9 dígitos.");
		   
		}
	 Console.WriteLine("O aluno " + nome + " mora em " + morada + " e tem numero de telemovel " + tele);
	}
    Console.WriteLine ("Programa encerrado. Obrigado!");
}
}
