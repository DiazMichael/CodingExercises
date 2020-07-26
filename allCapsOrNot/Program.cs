using System;

namespace allCapsOrNot
{
    class Program
    {
        static void Main(string[] args)
        {
			string str = "ASDFGHJHGFDSDFGHGFD";
			var isEqual = true;
			while (isEqual == true)
			{
				for (var i = 1; i < str.Length - 2; i += 2)
				{
					if ((Char.IsUpper(str[i]) != Char.IsUpper(str[i - 1])) ==
							(Char.IsUpper(str[i]) != Char.IsUpper(str[i + 1])))
								isEqual = false;
				}
			}
			Console.WriteLine(isEqual);
		}
    }
}
