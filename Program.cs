using System;

namespace CircleArea
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			double r = double.Parse(Console.ReadLine());
			Console.WriteLine("{0:f12}", Math.PI * r * r);
		}
	}
}
