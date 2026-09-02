using System.Collections;
internal class Program
{
    private static void Main(string[] args)
    {
        ArrayList JobList = new ArrayList();
        JobList.Add("Accountant");
        JobList.Add("Developer");
        JobList.Add("Tester");
        JobList.Add("Designer");
        JobList.Add("System Designer");
        JobList.Add("Analyst");
        Console.WriteLine("List of Jobs are :\n");
        foreach (var jobs in JobList)
        {
            Console.WriteLine(jobs);
        }
        JobList.Remove("Tester");
        Console.WriteLine("\nAfter Removing Tester from JobList:\n");

        foreach (var jobs in JobList)
        {
            Console.WriteLine(jobs);
        }
        JobList.RemoveAt(0);
        JobList.Sort();
        Console.WriteLine("\nAfter Removing oth postion element :");

        foreach (var jobs in JobList)
        {
            Console.WriteLine(jobs);
        }
        
    }

}