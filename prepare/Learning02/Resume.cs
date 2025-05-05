class Resume
{
    public string _name;
    public List <Job> jobs = new List<Job> ();
    public void display()
    {
        Console.WriteLine($"Name: {_name} \nJobs:");
        foreach (Job job in jobs) {
            job.display();
        }
    }
}