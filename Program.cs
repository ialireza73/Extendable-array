using System;

namespace Extendable_array
{
    class Program
    {
        static void Main(string[] args)
        {
            bool finished = false;
            int turn = 1;
            int[] even = new int[turn];
            int[] odd = new int[turn];
            int[] result_arry;

            while (finished == false)
            {
                System.Console.WriteLine("add anumber or say finish:");
                string input = Console.ReadLine();
                if (input == "finish")
                {
                    finished = true;
                }
                else
                {
                    if (turn % 2 == 0)
                    {
                        even = new int[odd.Length + 1];
                        odd.CopyTo(even, 0);
                        even[turn - 1] = Convert.ToInt32(input);
                        turn++;
                    }
                    else
                    {
                        odd = new int[even.Length + 1];
                        even.CopyTo(odd, 0);
                        odd[turn - 1] = Convert.ToInt32(input);
                        turn++;
                    }
                }

            }
            if (finished)
            {
                if (turn % 2 == 0)
                {
                    result_arry = new int[odd.Length - 1];
                    for (int i = 0; i < result_arry.Length; i++)
                    {
                        result_arry[i] = odd[i];

                    }
                }
                else
                {
                    result_arry = new int[even.Length - 1];
                    for (int i = 0; i < result_arry.Length; i++)
                    {
                        result_arry[i] = even[i];

                    }
                }
                int minimum = getTheMin(result_arry);
                System.Console.WriteLine("this is thi minimum: " + minimum);


            }

        }
        static int getTheMin(int[] result_arry)
        {
            int lastmin = result_arry[0];
            foreach (var item in result_arry)
            {

                if (lastmin > item)
                {
                    lastmin = item;
                }

            }
            return lastmin;

        }
    }

}
