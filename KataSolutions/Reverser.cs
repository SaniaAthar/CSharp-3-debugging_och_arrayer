using System;
using System.ComponentModel.DataAnnotations;

namespace KataSolutions
{
    public class Reverser
    {
        public static void Reverse(int[] arr)
        {
            //Array.Reverse(arr);
            // testa först Array.Reverse, sen testa att skriva en lösning med hjälp av en for-loop istället
            int temp;
            for (int i = 0; i < arr.Length/2 ; i++)
            {
                temp = arr[i];
                arr[i] = arr[arr.Length - 1 - i];
                arr[arr.Length - 1 - i] = temp;
            }
            //for (int i = arr.Length / 2; i > 0; i--)
            //{
            //    temp = arr[i - 1];
            //    arr[i - 1] = arr[arr.Length - i];
            //    arr[arr.Length - i] = temp;
            //}

            // throw new NotImplementedException();
        }
    }
}
