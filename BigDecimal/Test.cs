using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BigDecimal;
namespace BigDecimal
{
	class Test
	{
		public static void Main(string[] args)
		{
			BigDecimal firstNum;
			BigDecimal secondNum;                   //Variables for equation
			string operation;
			BigDecimal answer;

			Console.WriteLine("Hello, Welcome To Sambit Calculator!");
			Console.WriteLine("It Can Calculate Any-Length Numbers");
			Console.WriteLine("");
			Console.Write("Enter The First Number : ");
			firstNum = new BigDecimal(Convert.ToString(Console.ReadLine()));

			//User input for equation
			Console.Write("Now Enter The Second Number: ");
			secondNum = new BigDecimal(Convert.ToString(Console.ReadLine()));
			Console.Write("Now Enter Your Operation ( * , / , +, -) : ");
			operation = Console.ReadLine();
			Console.WriteLine("");
			if (operation == "*")
			{
				answer = firstNum * secondNum;
				Console.WriteLine("First Number :  " + firstNum + "\nx\n" + "Second Number : "+secondNum + "\n=\n" + "Result :       " + answer);
				Console.ReadLine();
			}
			else if (operation == "/")
			{
				answer = firstNum / secondNum;
				Console.WriteLine("First Number :  " + firstNum + "\n/\n" + "Second Number : " + secondNum + "\n=\n" + "Result :       " + answer);
				Console.ReadLine();
			}
			//Getting answers
			else if (operation == "+")
			{
				answer = firstNum + secondNum;
				Console.WriteLine("First Number :  " + firstNum + "\n+\n" + "Second Number : " + secondNum + "\n=\n" + "Result :       " + answer);
				Console.ReadLine();
			}
			else if (operation == "-")
			{
				answer = firstNum - secondNum;
				Console.WriteLine("First Number :  " + firstNum + "\n-\n" + "Second Number : " + secondNum + "\n=\n" + "Result :       " + answer);
				Console.ReadLine();
			}
			else
			{
				Console.WriteLine("Sorry That Is Not In Correct Format! Please Restart!");     //Catch
				Console.ReadLine();
			}
		}
	}
}
