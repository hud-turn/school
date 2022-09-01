List<int> numbers = new List<int> { };
for (int intfibone = 0, intfiblst = 0; intfiblst != 26; intfiblst++)//creating the fibonacci sequence
{
    numbers.Add(intfibone);

    if (intfiblst == 1)
    {
        intfibone++;
    }

    Console.WriteLine(intfibone);
}