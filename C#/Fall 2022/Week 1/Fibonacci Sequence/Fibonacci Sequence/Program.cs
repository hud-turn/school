List<int> numbers = new List<int> { };

for (int i = 0, a = 0, b = 1, c = 0, len =26; i < len; i++)
{
    c = a + b;
    numbers.Add(a);
    a = b;
    b = c;
    
}

foreach(int q in numbers)
{
    Console.WriteLine(q);
}