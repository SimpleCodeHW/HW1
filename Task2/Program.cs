using System;

class Program
{
	static int Multiply(int mult1, int mult2)
	{
		return mult1 * mult2;
	}
	//static int Multiply(int mult1, int mult2) => mult1 * mult2;

	static int Summarize(int sum1, int sum2)
	{
		return sum1 + sum2;
	}
	//static int Summarize(int sum1, int sum2) => sum1 + sum2;

	static void Main(string[] args)
	{
		Console.WriteLine(Multiply(5, 12));
		Console.WriteLine(Summarize(2, 45));
	}
}