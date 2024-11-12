class Resume 
{
    public List<Job> jobs = new List<Job>();
    private string name;
    public Resume(string name)
    {
        this.name = name;
    }
    public void AddJob(Job job)
    {
        jobs.Add(job);
    }
    public void Display()
    {
        Console.WriteLine($"{name}");
        foreach(Job job in jobs)
        {

            job.Display();
        }
    }
}