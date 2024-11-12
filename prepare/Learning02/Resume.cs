class Resume 
{
    private List<Job> jobs;
    private string name;
    public void AddJob(Job job)
    {
        jobs.Add(job);
    }
    public void SetName(string inputName)
    {
        name = inputName;
    }
    public void DisplayResume()
    {
        Console.WriteLine($"{name}");
        foreach(Job job in jobs)
        {

            job.Display();
        }
    }
}