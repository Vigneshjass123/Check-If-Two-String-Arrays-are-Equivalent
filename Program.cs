using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace Check_If_Two_String_Arrays_are_Equivalent
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //input word1= ["ab", "c"], word2 = ["a", "bc"]
            // check two string are equal or not
            string[] word1 = {"ab","c" };
            string[] word2 = {"a","bc" };
            string temp = " ";
            string temp1 = " ";
            for(int i =0;i<word1.Length;i++)
            {
                temp = temp + word1[i];
            }
            for (int j = 0; j < word2.Length; j++)
            {
                temp1 = temp1 + word2[j];
            }
            if(temp==temp1)
            {
                Console.WriteLine(" This two string array are equivalent");
            }
            else
            {
                Console.WriteLine("This two string array are not  equivalent ");
            }
            Console.ReadLine();
        }
    }
}
