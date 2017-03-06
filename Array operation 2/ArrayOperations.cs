using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NYPL25032016
{
    class ArrayOperations
    {
        public int findMaxIndex(int[] array)
        {
            int max = array[0];
            int maxIndex = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (max < array[i])
                {
                    max = array[i];
                    maxIndex = i;
                }
            }
            return maxIndex;
        }
        public void swapMaxWithFirst(int[] array)
        {
            int maxIndex = findMaxIndex(array);
            int temp = array[0];
            array[0] = array[maxIndex];
            array[maxIndex] = temp;
        }

        public void display(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }
            Console.WriteLine();
        }
        public int[] arrayJoin(int[] arr1, int[] arr2)
        {
            int[] arr3 = new int[arr1.Length + arr2.Length];
            for (int i = 0; i < arr1.Length; i++)
            {
                arr3[i] = arr1[i];
            }
            for (int i = 0; i < arr2.Length; i++)
            {
                arr3[arr1.Length+i]=arr2[i];
            }
            return arr3;

        }

        public bool search(int[] array,int val)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == val)
                    return true;
            }
            return false;
        }

        public int countValue(int[] array, int val)
        {
            int count = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == val)
                    count++;
            }
            return count;
        }

    }
}
