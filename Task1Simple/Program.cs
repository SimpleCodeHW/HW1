using System;

class Program
{
	static void Main(string[] args)
	{
		double result;

		string value1 = "5";
		bool success1 = Int32.TryParse(value1, out int number1);
		if (success1)
			Console.WriteLine("Value converted");
		else
			Console.WriteLine("Failed");

		string value2 = "10";
		bool success2 = Int32.TryParse(value2, out int number2);
		if (success2)
			Console.WriteLine("Value converted");
		else
			Console.WriteLine("Failed");

		result = (double)(number1 + number2) / 2;
		Console.WriteLine(result);
	}
}