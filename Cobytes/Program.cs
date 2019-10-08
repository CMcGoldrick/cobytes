using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cobytes
{
    class Program
    {
        static void Main(string[] args)
        {
            var easy = CoBytes.Easy.SecondGreatLow(new int[] {90, 4 });
            //var easy = CoBytes.Easy.LetterCountI("applesandpapplesgrapples");

            Console.WriteLine(easy);
        }
    }
}
