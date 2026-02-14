namespace Assignment_3
{
    internal class Program
    {
        static void Main(string[] args)
        {

			#region Question 1
			/*It will print 9. Int will cut the numbers that are after the . */
			#endregion
			#region Question 2
			/*d2= double(n)/2
			 why wouldn't it work? double should be bigger that int, so it should work. */
			#endregion
			#region Question 3
			/**/
			#endregion
			#region Question 4 
			/*It will throw an exception, as it cannot convert 'a' into a number*/
			#endregion
			#region Question 5
			string s = "12a";
			bool x = int.TryParse( s , out int r);
			Console.WriteLine("Parssed: "+s);
			Console.WriteLine("Failed: " + r);

			#endregion
			#region Question 6
			/*It will print 11, as it will unboxing the O into an int =10, and then we will add 1, so the result will be 11*/
			#endregion
			#region Question 7
			/*It will throw an exception, as the object was initialized as an int, so we cannot unbox it using long value type*/
			#endregion
			#region Question 8
			object o = 10;
			long l = (int)o;
			Console.WriteLine(l);

			#endregion
			#region Question 9
			/*It will print null, as name is a nullable value and it is indeed = null*/
			#endregion
			#region Question 10
			/*Throws an exception as name2 and length are two didn't types*/
			#endregion
			#region Question 11
			/*Bec x is not nullable. We can solve it by making int? x = ....*/
			#endregion
			#region Question 12
			//It will throw an exception. Replace s! with s?
			#endregion
			#region Question 13
			//Throw an exception, as X cannot be = null
			#endregion
			#region Question 14
			//Don't know I believe both will throw an exception.
			#endregion
			#region Question 15
			string? user = null;
			Console.WriteLine(user?.ToUpper() ?? "Guest");
			#endregion

		}
	}
}
