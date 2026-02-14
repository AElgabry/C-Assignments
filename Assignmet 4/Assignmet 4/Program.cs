using System.Diagnostics;
using System.Diagnostics.Metrics;
using System.Text;

namespace Assignmet_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
			#region Question 1
			////a: Bec it will create 5000 new objects in the memory
			////b:

			//var watch1 = Stopwatch.StartNew();
			//var productList = new StringBuilder();
			//for(int i = 1; i <= 5000; i++)
			//{
			//	productList.Append("PROD - " + i + " , ");
			//}
			//productList.ToString();
			//watch1.Stop();
			//Console.WriteLine("String Builder timer: " + watch1);

			//var watch2 = Stopwatch.StartNew();
			//string productList2 = "";
			//for (int i = 1; i >= 5000; i++) 
			//{
			//	productList2 += "PROD - " + i + " , ";
			//}
			//watch2.Stop();
			//Console.WriteLine("String timer: " + watch2);
			#endregion
			#region Question 2 
			//int age;
			//int price;
			//int day;
			//bool validID;

			//Console.Write("Enter your age: ");
			//bool isParsed = int.TryParse(Console.ReadLine(), out age);
			//Console.Write("Enter the booking day: ");
			//bool isParsed2 = int.TryParse(Console.ReadLine(), out day);
			//Console.Write("Do you have a student ID? ");
			//bool isParsed3 = bool.TryParse(Console.ReadLine(), out validID);

			//if (age < 5)
			//	price = 0;
			//else if (age >= 5 && age <= 12)
			//	price = 30;
			//else if(age >= 13 && age <= 59)
			//	price = 50;
			//else
			//	price = 25;

			//switch(day)
			//{
			//	case 1:
			//	case 2:
			//	case 3:
			//	case 4:
			//	case 5:
			//		price = price; break;
			//	case 6:
			//	case 7:
			//		price += 10;
			//		break;
			//}

			//if (validID)
			//	price = Convert.ToInt32(price - (price * 0.2));
			//Console.WriteLine("The price is: " + price);



			#endregion
			#region Question 3
			//a:
			//string fileExtention = ".pdf";
			//string fileType;

			//switch (fileExtention) 
			//{
			//	case ".pdf":
			//		fileType = "PDF Document";
			//		break;
			//	case ".docx" or ".doc":
			//		fileType = "Word Document";
			//		break;
			//	case ".xlsx" or ".xls":
			//		fileType = "Excell Sheet";
			//		break;
			//	case ".jpg" or ".png" or ".gif":
			//		fileType = "Image";
			//		break;
			//	default: 
			//		fileType="Unknown File type";
			//		break;

			//}
			////b:
			//string fileType2 = fileExtention switch
			//{
			//	".pdf" => "PDF Document",
			//	".docx" or ".doc" => "Word Document",
			//	".xlsx" or "xls" => "Excell sheet",
			//	".jpg" or ".png" or ".gif" => "Image",
			//	_=>"Unknwon file type"
			//};

			#endregion
			#region Question 4
			//int temp = 34;
			//string weatherAdvice = temp < 0 ? "Frezzing" : temp < 15 ? "Cold" : temp < 25 ? "Pleasant" : "Hot";
			////less readable. We use it when there is no nested if statement.


			#endregion
			#region Question 5
			//int count = 1;
			//do
			//{
			//	Console.Write("Enter your password:");
			//	string pass = Console.ReadLine();

			//	if (pass.Length < 8)
			//	{
			//		Console.WriteLine("Password must be greater than 8 characters");
			//	}
			//	else
			//	{
			//		foreach (char p in pass)
			//		{
			//			switch (p)
			//			{
			//				case ' ':
			//					Console.WriteLine("No spaces are allowed in your password");
			//					break;
			//			}
			//		}
			//		Console.WriteLine("Password accepted");
			//	}
			//	;
			//	count++;
			//} while (count <= 5);

			//Console.WriteLine("Account Locked");




			#endregion
			#region Question 6
			////a
			//int[] scores = { 85, 42, 91, 67, 55, 78, 39, 88, 72, 95, 60, 48 };
			//var sheet = new StringBuilder();
			//foreach(int score in scores) 
			//{
			//	if (score < 50)
			//	{
			//		sheet.Append($"{score}, ");
			//	}
			//}
			//sheet.ToString();
			//Console.WriteLine(sheet);

			//b
			//int[] scores = { 85, 42, 91, 67, 55, 78, 39, 88, 72, 95, 60, 48 };
			//foreach(int score in scores) 
			//{
			//	if (score > 90)
			//		break;
			//}

			//c
			//int[] scores = { 85, 42, 91, 67, 55, 78, 39, 88, 72, 95, 60, 48 };
			//int total=0;
			//foreach(int score in scores) 
			//{
			//	if (score < 40)
			//	{
			//		continue;
			//	}
			//	else
			//	{
			//		total += score;
			//	}
			//}
			//Console.WriteLine($"Average = {total/scores.Length}");


			//d
			//int[] scores = { 85, 42, 91, 67, 55, 78, 39, 88, 72, 95, 60, 48 };
			//int a=0, b=0, c=0, d=0, f = 0;
			//foreach (int score in scores)
			//{
			//	switch (score) 
			//	{
			//		case >= 90: a++; break;
			//		case >= 80 and <90: b++; break;
			//		case >= 70 and < 80: c++; break;
			//		case >= 60 and < 70: d++; break;
			//		default: f++; break;
			//	}
			//}
			//Console.WriteLine($"Students with A = {a}, with B = {b}, with C = {c}, with D = {d} and who failed are {f}");
				#endregion

			}
	}
}
