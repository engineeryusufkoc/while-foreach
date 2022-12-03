using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loops
{
    class Program
    {
        static void Main(string[] args)
        {

          char letter1 = 'a';
                      while (letter1<'z'+1)
                      {
                          Console.WriteLine(letter1);
                          letter1++;
                      }
        }
   }
}
