Console.WriteLine(GC.MaxGeneration);

Console.WriteLine($"Total using memory: {GC.GetTotalMemory(false)}");

using(User user = new())
{
    Console.WriteLine($"Total using memory: {GC.GetTotalMemory(false)}");
}


class Employee
{
    public string Name { set; get; }
    public int Age { set; get; }
}

class User : IDisposable
{
    public string Name { set; get; }
    public int Age { set; get; }
    public int[] array = new int[100000];

    public void Dispose()
    {
        Console.WriteLine("Dispose user");
    }
}
