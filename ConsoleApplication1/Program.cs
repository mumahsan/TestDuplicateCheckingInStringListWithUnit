using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DuplicateCheckNameSpace;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            var strList = new List<string>();
            string str;
            //var strs = DuplicateCheck.RandomString(5);

            for(int i=0; i<1000; i++)
            {
                str = DuplicateCheck.RandomString(3);
                strList.Add(str);
            }

            foreach (string str1 in strList)
            {
                Console.WriteLine(str1);
            }

            Console.WriteLine("Duplicate String *******************");
            List<string> duplicates = strList.GetDuplicates(); //method to get duplicates

            foreach (string str1 in duplicates)
            {
                Console.WriteLine(str1);
            }
            Console.WriteLine(duplicates.Count);
            Console.ReadKey();
        }
    }
}
