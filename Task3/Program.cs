using System;

class Program
{
	static void Convert(ref double amount)
	{
		double course = 77.89;
		amount = (double)amount * course;
	}

	static void Main(string[] args)
	{
		double amount = 123;
		Convert(ref amount);
		Console.WriteLine(amount);
	}
}