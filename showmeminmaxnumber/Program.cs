using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace showmeminmaxnumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] num = new int[5];
            int max = 0, min = 0;
            for(int i=0; i<num.Length; i++)
            {
                Console.Write("숫자를 입력해주세요: ");
                num[i] = int.Parse(Console.ReadLine());
            }

            max = num[0]; min = num[0];
            for(int i = 0; i<num.Length; i++)
            {
                if (max < num[i]) max = num[i];
                else if (min > num[i]) min = num[i];
            }
            

            Console.WriteLine("---------------------------");
            Console.WriteLine("가장 큰 수 : " + max);
            Console.WriteLine("가장 작은 수 : " + min);
        }
    }
}
