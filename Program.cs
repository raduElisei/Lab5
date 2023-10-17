namespace Lab5;

public class Program
{
    static void Main(string[] args)
    {
        int[] myArray = { 1, 2, 3, 34, 5, 6, 7, 8, 9, -3, 11, 12, 13, 1 };

        (int, int) results = ArrayHelper.ArrayMinMax(myArray);
        Console.WriteLine(results);

        //uint[] fib10 = ArrayHelper.GenerateFib(10);

        int[] sortedArray = { -400, -300, -234, -5 -1, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 44, 56, 98, 1111, 2000};
        int recursiveSolution = RecursiveBinary.FindIndexInSortedArray(sortedArray, -300);
        System.Console.WriteLine(recursiveSolution);
        int recursiveSolution2 = RecursiveBinary.FindIndexInSortedArray(sortedArray, 13);
        System.Console.WriteLine(recursiveSolution2);
        int recursiveSolution3 = RecursiveBinary.FindIndexInSortedArray(sortedArray, 2000);
        System.Console.WriteLine(recursiveSolution3);
    }
}