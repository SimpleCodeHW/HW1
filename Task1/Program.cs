using System;

class Program
{
	static int Parse(string val)
	{
		bool success = Int32.TryParse(val, out int number);
		if (success)
			Console.WriteLine("Value converted");
		else
			Console.WriteLine("Failed");
		return number;
	}

	static void Main(string[] args)
	{
		double result;
		Console.WriteLine("Enter first value");
		string value1 = Console.ReadLine();
		int number1 = Parse(value1);

		Console.WriteLine("Enter second value");
		string value2 = Console.ReadLine();
		int number2 = Parse(value2);

		result = (double)(number1 + number2) / 2;
		Console.WriteLine(result);
	}
}