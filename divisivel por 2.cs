using System;

public class Calculo {

	public static void Main (string[]args){
	Console.WriteLine("Bem vindo ao programa.\nPor favor, digite a quantidade de números a serem verificados (se são divisíveis por 2 ou não).");
	string numeros = Console.ReadLine();
	int numerosr = Convert.ToInt32(numeros);
	
	for (int i = 0; i < numerosr; i++)
	{
		Console.WriteLine("Digite o número a ser verificado: ");
		string num = Console.ReadLine();
		int numr = Convert.ToInt32(num);
	if (numr%2==0) {
		Console.WriteLine("O número é divisível por 2.");
	}
		else {
		Console.WriteLine("O número não é divisível por 2.");
			}
	}
	Console.WriteLine("Programa encerrado. Obrigado.");
}
}