using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace moves_zeros
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] newArr = { 1, 2, 0, 1, 0, 1, 0, 3, 0, 1 };
            newArr = MoveZeroes(newArr);
            for (int i = 0; i < newArr.Length; i++)
            {
                Console.WriteLine(newArr[i]);
            }
            Console.ReadLine();
        }
        public static int[] MoveZeroes(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr.Length - 1; j++)
                {
                    if(arr[j] == 0)
                    {
                        arr[j] = arr[j + 1];
                        arr[j + 1] = 0;
                    }
                }
            }
            return arr;
        }
    }
}
