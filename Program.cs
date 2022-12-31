using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project
{
    class program
    {
		static void Main(string[] args)
		{ int n, i, sum;
			int a = 2, b = 30;

			 for (n = a; n <= b; n++) {
				i = 1;
				sum = 0;

				while (i < n) {
					if (n % i == 0) {
						sum += i;
					}
					i++;
				}
				{
                    if (sum == n)
						Console.WriteLine(n);











