using System.ComponentModel.DataAnnotations;

namespace Assignment_5
{
	internal class Program
	{
		static void Main(string[] args)
		{
			#region Part 1
			//Days daysOfWeek = new Days();
			//Days currentDay;
			//Console.Write("Enter a day number from 0 to 6: ");
			//bool isParsed = int.TryParse(Console.ReadLine(),  out int number);
			//if (Enum.IsDefined(typeof(Days), number)) 
			//{
			//	currentDay = (Days)number;
			//	switch (currentDay) 
			//	{
			//		case Days.Sunday:
			//		case Days.Monday:
			//		case Days.Tuesday:
			//		case Days.Wednesday:
			//		case Days.Thursday: Console.WriteLine("WorkDay"); break;
			//		case Days.Friday:
			//		case Days.Saturday: Console.WriteLine("WeekEnd"); break;
			//	}
			
			//} ;

			#endregion

			#region Part 2
			#region Question 1
			//Console.WriteLine("Enter the array size: ");
			//bool isParsed = int.TryParse(Console.ReadLine(), out int size);
			//int[] arr = new int[size];
			//int sum = 0, min = 999999, max = 0;
			//double avr = 0;
			//string rev = "";
			//for (int i = 0; i < size; i++)
			//{
			//	Console.WriteLine($"Enter the element number {i + 1}: ");
			//	bool isParesed = int.TryParse(Console.ReadLine(), out arr[i]);
			//	if (isParesed)
			//	{
			//		sum += arr[i];
			//	}
			//	avr = sum / size;
			//}
			//foreach (int value in arr)
			//{
			//	if (value > max)
			//	{
			//		max = value;
			//	}
			//	else if (value < min)
			//	{
			//		min = value;
			//	}
			//}
			//Console.WriteLine($"Sum = {sum}, Average = {avr}, Maximum = {max}, Minimum = {min}");
			////problem here
			//for (int i = size - 1; i > 0; i--)
			//{
			//	rev = $"{arr[i]}";
			//}
			//Console.Write($"Reversed: {rev}");
			#endregion
			#region Question 2

			//int[,] grades = new int[3, 4];
			//int row = 0, sum=0, total=0;

			//for (int i = 0; i < 3; i++)
			//{
			//	Console.WriteLine($"Enter the {i + 1} student grade: ");
			//	for(int x=0; x < 4; x++) 
			//	{
			//		bool isParsed = int.TryParse(Console.ReadLine(), out int score);
			//		if (isParsed)
			//		{
			//			grades[row, x] = score;
			//			sum += score;
			//		}
			//	}
			//	total += sum;
			//	Console.WriteLine($"The Average score of the {i+1} student is : {sum/4}" );
			//	row++;
			//}
			//Console.WriteLine($"The total average of the class is: {total/3}");
			#endregion
			#endregion

			#region Part 3
			#region Question 1

			//Console.Write("Enter the first number: ");
			//bool isParsed = double.TryParse(Console.ReadLine(), out double x);

			//Console.Write("Enter the second number: ");
			//bool isParsed02 = double.TryParse(Console.ReadLine(), out double y);


			//Console.Write("Choose the operation needed (+ , - , * , /) ");
			//string operation = Console.ReadLine();


			//switch (operation) 
			//{
			//	case "+": Console.WriteLine(add(x, y)); break;
			//	case "-": Console.WriteLine(subtract(x, y)); break;
			//	case "*": Console.WriteLine(Multiply(x, y)); break;
			//	case "/": try { Console.WriteLine(division(x, y)); } catch(Exception ex) { Console.WriteLine(ex.Message); }; break;
			//	default: Console.WriteLine("Unknown oeration"); break;
			//}
			#endregion

			#region Question 2
			//Console.WriteLine("Enter the radius");
			//bool isParsed = double.TryParse(Console.ReadLine(), out double r);
			//circle(out double a, out double c, r);
			//Console.WriteLine($"Area = {a}");
			//Console.WriteLine($"Circumference = {c}");
			#endregion

			#endregion

			#region Project

			int[] arr = new int[5];
			int sum = 0, min = 955095, max = 0;

			for (int i = 0; i < arr.Length; i++)
			{
				Console.Write($"Enter the score for student number {i + 1}: ");
				bool isPArsed = int.TryParse(Console.ReadLine(), out int score);
				arr[i] = score;
				sum += score;

			};
			getGrade(arr);
			Avr(arr);
			getMAxMin(arr, out int maxy, out int mini);

			#endregion

		}
		#region Methods
		static double add(double x , double y) 
		{
			return x + y;
		}
		static double subtract(double x, double y)
		{
			return x - y;
		}
		static double Multiply(double x, double y)
		{
			return x * y;
		}
		static double division(double x, double y)
		{
			return x / y;
		}
		static void circle(out double area, out double circ, double r) 
		{

			const double pi = 3.14;
			 area = pi * r * r;
			 circ = 2 * pi * r;
		
		}
		static void getGrade(int[] arr)
		{

			Console.WriteLine("======REPORT=========");
			for(int i=0; i < arr.Length; i++) 
			{

				switch (arr[i])
				{
					case >= 90: Console.WriteLine($"Student {i + 1} score = {arr[i]} & his grade is: {Grade.A}"); break;
					case >= 80: Console.WriteLine($"Student {i + 1} score = {arr[i]} & his grade is: {Grade.B}"); break;
					case >= 70: Console.WriteLine($"Student {i + 1} score = {arr[i]} & his grade is: {Grade.C}"); break;
					case >= 60: Console.WriteLine($"Student {i + 1} score = {arr[i]} & his grade is: {Grade.D}"); break;
					case < 60: Console.WriteLine($"Student {i + 1} score = {arr[i]} & his grade is: {Grade.F}"); break;

				}


				
			}
		}
		static void Avr(int[] ar) 
		{
			double total=0;
			foreach(int number in ar) 
			{
				total += number;
			}
			Console.WriteLine($"Average = {total / ar.Length}");
			;
		}
		static void getMAxMin(int[] a, out int max , out int min) 
		{
			max = 0;
			min = 9999999;
			foreach(int score in a) 
			{ 
				if(score > max) 
				{
					 max = score;
				}
				else if(score < min) 
				{
					min = score;
				}
			}
			Console.WriteLine($"Highest score = {max} \n Lowest score = {min}");
		}
		#endregion
	}


}
