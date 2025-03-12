using System;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._company = "West African Examinations Council-Liberia";
        job1._jobTitle = "Data Entry Clerk";
        job1._startYear = 2022;
        job1._endYear = 2024;

        Job job2 = new Job();
        job2._company = "Temple of Justice, Repubic of Liberia";
        job2._jobTitle = "Clerk of Court";
        job2._startYear = 2019;
        job2._endYear = 2022;

        //job1.DisplayJobTitle();
        //job2.DisplayJobTitle();

        // job1.Display();
        // job2.Display();

        Resume staffResume = new Resume();
        staffResume._name = "Amos Bobby Weah";

        staffResume._jobslist.Add(job1);
        staffResume._jobslist.Add(job2);

        staffResume.ShowStaffResume();
       
        string firstJob = staffResume._jobslist[0]._jobTitle;
        // Console.WriteLine(firstJob);

    }

}
