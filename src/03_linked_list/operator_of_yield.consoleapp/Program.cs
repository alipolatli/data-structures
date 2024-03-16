namespace operator_of_yield;

class Program
{
    static void Main(string[] args)
    {
        Generator generator = new Generator();
        var oddNumbers = generator.GetOddNumbers();
        var oddNumbersEnumerator = oddNumbers.GetEnumerator();
        while (oddNumbersEnumerator.MoveNext())
        {
            System.Console.WriteLine(oddNumbersEnumerator.Current);
        }

        var oddNumbersV1 = generator.GetOddNumbers();
        oddNumbersV1 = oddNumbersV1.ToList(); //genaretes all. 
        var oddNumbersV1Enumerator = oddNumbers.GetEnumerator();
        while (oddNumbersV1Enumerator.MoveNext())
        {
            System.Console.WriteLine(oddNumbersV1Enumerator.Current);
        }


        var oddNumbersV2 = generator.GetOddNumbersV2().Take(10); //only 10
        foreach (var item in oddNumbersV2)
        {
            System.Console.WriteLine(item);
        }
    }
}

class Generator
{

    public IEnumerable<int> GetOddNumbers()
    {
        yield return 1;
        yield return 3;
        yield return 5;
        yield return 7;
        yield return 9;
    }

    public IEnumerable<int> GetOddNumbersV2()
    {
        for (int i = 1; i < 1000; i += 2)
        {
            yield return i;
        }
    }

}
