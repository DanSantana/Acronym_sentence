using System;
					
public class Program
{
	public static void Main()
	{	//Acronym sentence
		
		string acr=null, input = null,letter = null;
		Console.WriteLine("Insert the sentence to create an acronym: ");
		input = Console.ReadLine();
		string[] stcArray = input.Split(' ');
		foreach(string word in stcArray){
		letter = word.Substring(0,1).ToUpper();
		acr = acr+letter;	
		}
		Console.WriteLine(acr);
	}
}
