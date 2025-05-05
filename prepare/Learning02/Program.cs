using System;
using System.ComponentModel.DataAnnotations;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._company = "Powerside";
        job1._jobTitle = "Intern";
        job1._startYear = 2024;
        job1._endYear = 2025;

        Job job2 = new Job();
        job2._company = "Church of Jesus Christ of Latter-day Saints";
        job2._jobTitle = "Missionary";
        job2._startYear = 2019;
        job2._endYear = 2021;

        Resume myResume = new Resume();
        myResume._name = "Tyler";
        myResume.jobs.Add(job2);
        myResume.jobs.Add(job1);
        myResume.display();
    }
}