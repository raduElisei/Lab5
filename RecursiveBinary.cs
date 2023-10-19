namespace Lab5;

public class RecursiveBinary
{
    public static int FindIndexInSortedArray(int[] array, int number, int startIndex)
    {
        int middle = array[array.Length / 2];

        if(middle == number)
        {
            return startIndex + (array.Length / 2);
        }

        if(middle > number)
        {
            int[] newArray = new int[array.Length / 2];
            Array.Copy(array, newArray, array.Length / 2);
            return FindIndexInSortedArray(newArray, number, startIndex);
        }

        if(middle < number)
        {
            int[] newArray = new int[array.Length - (array.Length / 2) - 1];
            Array.Copy(array, array.Length / 2 + 1, newArray, 0, newArray.Length);
            return FindIndexInSortedArray(newArray, number, startIndex + array.Length / 2 + 1);
        }

        return -1;
    }
}
