using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace HashtableBasicApps
{
    class Program
    {
        static void Main(string[] args)
        {
            Hashtable aHashtable = new Hashtable();
            aHashtable.Add("200", "Asp.Net");
            aHashtable.Add("100", "Java");
            aHashtable.Add("300", "Python");

            string courseName = (string) aHashtable["100"];
            Console.WriteLine(courseName);
            Console.ReadKey();
        }
    }
}
