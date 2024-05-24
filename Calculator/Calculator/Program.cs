using System;

class Program
{
	static void Main(string[] args)
	{
		Console.WriteLine("Калькулятор!!!!");

		while (true)
		{
			Console.WriteLine("Введите первое число:");
			double num1 = Convert.ToDouble(Console.ReadLine());

			Console.WriteLine("Введите второе число:");
			double num2 = Convert.ToDouble(Console.ReadLine());

			Console.WriteLine("Введите операцию (+, -, *, /):");
			string op = Console.ReadLine();

			double result = 0;

			switch (op)
			{
				case "+":
					result = num1 + num2;
					break;
				case "-":
					result = num1 - num2;
					break;
				case "*":
					result = num1 * num2;
					break;
				case "/":
					if (num2 != 0)
					{
						result = num1 / num2;
					}
					else
					{
						Console.WriteLine("Ошибка деления на ноль.");
					}
					break;
				default:
					Console.WriteLine("Неправильная операция.");
					break;
			}

			Console.WriteLine("Результат: " + result);
			Console.WriteLine("Продолжить вычисления ? (y/n)");
			string answer = Console.ReadLine();
			if (answer.ToLower() != "y")
			{
				break;
			}
		}
	}
}
