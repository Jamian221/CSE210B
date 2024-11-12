using System;

class Program
{
    static void Main(string[] args)
    {   
        Resume myResume = new Resume("Ian Olson");
        Job job1 = new Job("2009", "2015", "Amazon", "Evil Scientist");
        myResume.AddJob(job1);

        Job job2 = new Job("2015", "2020", "Evil Inc.", "Eviler Scientist");
        myResume.AddJob(job2);
        myResume.Display();

    }
}