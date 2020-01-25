using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateAndTime
{
    class Program
    {
        static void Main(string[] args)
        {
            //string myString = "My \"So-Called\" life";                         //inside a string value
            //string myString = "What if I need a \nnew line?";                  // The new  line
            //string myString = "Go to the next path c:\\drive";                 // Back slash inside a string value
            //string myString = @"Go to the next path c:\drive\photos\img001.jpg"; // For many back slachs
            //string myString = string.Format("{0} is the same thing with {1}","Clavita","Ismail");
            //string myString = string.Format("The percentage {0:P}", .95);
            //string myString = string.Format("{0:C}", 2500);
            //string myString = string.Format("{0:N}", 201236); // OUTPUT: 201 236.00
            //string myString = string.Format("{0:####-###### }",1234567890); // OUTPUT: 1234-567890 // This is my format
            //string myStr = "This summer is great!";
            //myStr = myStr.ToUpper(); // OUTPUT: THIS IS A GREAT SUMMER
            //myStr = myStr.Substring(5,11); // OUTPUT: summer is // Begin in [5] and cut a [11] index after it "fifth index"
            //myStr = myStr.Substring(5); // OUTPUT: summer is great // Cut from 5 letters in the beginning
            //myStr = myStr.Replace(" ", "-");
            //myStr = myStr.Remove(2); // OUTPUT: Th // remover anything >= myStr[2]
            //myStr = myStr.Remove(6, 11); // OUTPUT: This seat // Remove anything between myStr[6] and myStr[11]
            //string name = "zakariaFarhati";
            //name = name.Remove(3,6); // Remove ariaFar
            //Console.WriteLine(name);
            //////////////////////////////////////////////////////////////////////////////////////////
            // But the problem is the string takes big place on the memory so let's try StringBulider Obj
            StringBuilder myString = new StringBuilder();
            for (int i = 0; i < 100; i++)
            {
                myString.Append("--");
                myString.Append(i.ToString());
                Console.Write(myString);
            }
            Console.ReadKey();
        }
    }
}
