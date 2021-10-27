using ClassLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cv7_kub0649
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] text1 = new string[3];

            text1[0] = "1";
            text1[1] = "2";
            text1[2] = "3";

            for (int i = 0; i < text1.Length; i++)
            {
                Console.WriteLine(text1[i]);
            }

            Console.WriteLine("\n");

            ArrayHelper<string>.Swap(text1, 0, 1);

            for (int i = 0; i < text1.Length; i++)
            {
                Console.WriteLine(text1[i]);
            }


            string[] concat_arr1 = new string[1];
            concat_arr1[0] = "KUB";
            string[] concat_arr2 = new string[1];
            concat_arr2[0] = "0649";

            string[] tst = ArrayHelper<string>.Concat(concat_arr1, concat_arr2);

            Console.Write("\n");

            foreach (var item in tst)
            {
                Console.Write(item);
            }
            






            

        }
    }
}
