using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lab5;

public class RecursiveBinary
{
    public static int FindIndexInSortedArray(int[] array, int number)
    {
        int middle = array[array.Length/2];

        // FIXME: fix method returning the index of the subarray of the last method call
        if(middle == number)
        {
            return Array.IndexOf(array, number);
        }

        if(middle > number)
        {
            int[] newArray = new int[array.Length/2+1];
            Array.Copy(array, newArray, array.Length/2);
            return FindIndexInSortedArray(newArray, number);
        }

        if(middle < number)
        {
            int[] newArray = new int[array.Length/2+1];
            Array.Copy(array, array.Length/2, newArray, 0, array.Length/2);
            return FindIndexInSortedArray(newArray, number);
        }

        return -1;
    }
}
