using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConvArabigoRomano
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int intNum = 1500;
            ConversorNum conversorNum = new ConversorNum();
            Console.WriteLine(conversorNum.ConvertArabicRoman(intNum));
        }
    }
}
