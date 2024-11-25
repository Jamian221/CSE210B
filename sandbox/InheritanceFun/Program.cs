class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Hey Bob");
        Person bob = new("bob", "Billy", 37);

        Console.WriteLine(bob.GetPersonInfo());
    }
}
