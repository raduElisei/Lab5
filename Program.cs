namespace Lab5;

public class Program
{
    static void Main(string[] args)
    {
        int[] myArray = { 1, 2, 3, 34, 5, 6, 7, 8, 9, -3, 11, 12, 13, 1 };

        (int, int) results = ArrayHelper.ArrayMinMax(myArray);
        Console.WriteLine(results);

        //uint[] fib10 = ArrayHelper.GenerateFib(10);
    }
}