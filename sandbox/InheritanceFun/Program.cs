class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Hey Bob");
        Police policeBob = new("bob", "Billy", 37, ["Tazer", "battarang", "pistol"]);

        Console.WriteLine(policeBob.GetPoliceInfo());
    }
}
