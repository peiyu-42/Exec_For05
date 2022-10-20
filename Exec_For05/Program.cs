using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exec_For05
{/*用迴圈呈現指定下方的結果
	++++1
	+++22
	++333
	+4444
	55555 */
	internal class Program
	{
		static void Main(string[] args)
		{
			int length = 5;
			for (int i = 1; i <= length; i++)
			{
				//加號的數量
				int countOfPlus = length - i;

				//數字的數量
				int countOfNumber = i;
				string stringOfNumber = $"{i}";
				//字串轉字元
				char charOfNumber = stringOfNumber[0];

				string row = new string('+', countOfPlus)+ new string(charOfNumber, countOfNumber);
				Console.WriteLine(row);
			}
		}
	}
}
