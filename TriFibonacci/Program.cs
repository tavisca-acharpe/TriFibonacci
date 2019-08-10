using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TriFibonacci
{
    public class TriFibonacci1
    {
        public int Complete(int[] test)
        {
            int answer = 0; 
            if (test.ToList().IndexOf(-1)<3)
            {
                int sum = 0;
                for(int i=0;i<3;i++)
                {
                    if(test[i]!=-1)
                    {
                        sum = sum + test[i];
                    }
                }
                if (test[3] - sum > 0)
                {
                    answer = test[3] - sum;
                    test[test.ToList().IndexOf(-1)] = answer;
                }
                else
                    return -1;
            }

           for(int i=3;i<test.Length;i++)
            {     
                    if (test[i] != test[i - 1] + test[i - 2] + test[i - 3] && test[i] != -1)
                    {
                        return -1;
                    }
                    else
                    {
                        if (test[i] == -1)
                        {
                            answer = test[i - 1] + test[i - 2] + test[i - 3];
                            test[i] = answer;
                        }
                    }   
            }
           return answer; 
        }

        public static void Main(String[] args)
        {
      //      String input = Console.ReadLine();
            TriFibonacci1 triFibonacci = new TriFibonacci1();
            //do
            //{
            //    string[] values = input.Split(',');
            //    int[] numbers = Array.ConvertAll<string, int>(values, delegate (string s) { return Int32.Parse(s); });
            //    int result = triFibonacci.Complete(numbers);
            //    Console.WriteLine(result);
            //    input = Console.ReadLine();
            //} while (input != "-1");

          //  int r = triFibonacci.Complete(new int[] { 7, 9, 2, 18, 29, 49, 96, 174, 319, 589, 1082, 1990, 3661, 6733, 12384, -1, 41895, 77057, 141729 });
            int r = triFibonacci.Complete(new int[] { 1,2,3,-1 });
            Console.WriteLine("r"+r); 
        }
    }

}
