namespace Lab5;

public static class Fibonacci
{
    private static uint[] Generate(int n)
    {
        if (n == 1)
        {
            return new uint[] { 0 };
        }
        else if (n == 2)
        {
            return new uint[] { 0, 1 };
        }
        else
        {
            uint[] previousSequence = Generate(n - 1);
            uint[] newSequence = new uint[n];
            Array.Copy(previousSequence, newSequence, n - 1);
            newSequence[n - 1] = previousSequence[n - 2] + previousSequence[n - 3];

            return newSequence;
        }
    }

    public static uint[] GenerateFib(int n)
    {
        if (n < 1)
        {
            throw new ArgumentOutOfRangeException("n", "Chosen n is out of range");
        }
        else
        {
            return Generate(n);
        }
    }
}
