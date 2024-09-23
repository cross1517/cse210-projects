using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._jobTitle = "Horse Hugger";
        job1._company = "Horse Hugs Inc.";
        job1._startYear = 2010;
        job1._endYear = 2012;

        Job job2 = new Job();
        job2._jobTitle = "Horse Whisperer";
        job2._company = "Horse Whispers Inc.";
        job2._startYear = 2012;
        job2._endYear = 2014;

        //job1.DisplayJob();
        //job2.DisplayJob();

        Resume resume = new Resume();
        resume._name = "Logan McCaul";
        resume._jobs.Add(job1);
        resume._jobs.Add(job2);

        resume.DisplayResume();
    }
}