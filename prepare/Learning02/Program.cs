using System;
using System.Security.Cryptography.X509Certificates;

class Program

{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._jobTitle = "Software Engineer";
        job1._company = "Microsoft";
        job1.startYear = 2019;
        job1.endYear = 2022;

        Job job2 = new Job();
        job2._jobTitle = "Graphics Designer";
        job2._company = "Udemy";
        job2.startYear = 2022;
        job2.endYear = 2023;

        Resume myResume = new Resume();
        myResume._name = "Deborah Sarah Okon";

        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);

        myResume.Display();

    }
}