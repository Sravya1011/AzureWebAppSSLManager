class Example
{
private string name;

csharp
Copy code
public Example(string name)
{
    this.name = name;
}

public void PrintName()
{
    Console.WriteLine(name);
}

public double Divide(double a, double b)
{
    if (b == 0)
    {
        throw new Exception("Division by zero");
    }
    return a / b;
}

public int Add(int a, int b)
{
    int sum = a + b;
    return sum;
}

public static void Main()
{
    Example example = new Example(null);
    example.PrintName();
    try
    {
        double result = example.Divide(10, 0);
        Console.WriteLine(result);
    }
    catch (Exception ex)
    {
        Console.WriteLine(ex.Message);
    }
}
}
class Program
{
static void Main()
{
Example.Main();
}
}
