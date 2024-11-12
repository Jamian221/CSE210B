class Job
{
    private string jobStart;
    private string jobEnd;
    private string companyName;
    private string jobTitle;

    public Job(string jobStart, string jobEnd, string companyName, string jobTitle)
    {
        this.jobStart = jobStart;
        this.jobEnd = jobEnd;
        this.companyName = companyName;
        this.jobTitle = jobTitle;
    }
    public void Display(){
        Console.WriteLine($"Company: {companyName}, job: {jobTitle}, started: {jobStart}, ended: {jobEnd}");
    }
}