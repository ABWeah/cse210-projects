using System;
using System.ComponentModel.DataAnnotations;

public class Resume
{
    public string _name;
    public List<Job> _jobslist = new List<Job>();

    public void ShowStaffResume()
    {
        Console.WriteLine($"Staff Name: {_name}.");
        Console.WriteLine($"Jobs:");

        foreach (Job j in _jobslist)
        {
            j.Display();
        }
    }

}