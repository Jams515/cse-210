using System.Security.Cryptography.X509Certificates;

public class Job {
    public string company;

    public string jobTitle;

    public int startYear;
    
    public int endYear;
    
    public void Display() {
        //Software Engineer (Microsoft) 2019-2022
        Console.WriteLine($"{jobTitle} ({company}) {startYear}-{endYear}");
    }
}