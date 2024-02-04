using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Transactions;
using System.Xml.Serialization;

public class Journal{

    public List<string> journalEntries = new List<string>();

    public void DisplayEntry(){
        foreach (Entry entry in entries) {
            entry.Display();
    }

    public string NewEntry(){
        Console.WriteLine("Please enter your new journal entry. ");
        string entry = Console.ReadLine();
        return entry;
    }

    public void SaveEntry(){
        foreach entry in Entries
        
        

    }



    
    public void RunApp()
    {
        while(true) {
        Console.WriteLine();
        Console.WriteLine("What would you like to do?");
        Console.WriteLine("[1] Create New Entry");
        Console.WriteLine("[2] Display Entry");
        Console.WriteLine("[3] Save Entry");
        Console.WriteLine("[0] Exit App");
        Console.Write("> ");
        string choice = Console.ReadLine().Trim();

        if (choice == "1") {
            NewEntry();
        } else if (choice == "2") {
            DisplayEntry();
        } else if (choice == "3"){
            SaveEntry();
        } else if (choice == "0") {
            return;
        } else {
            Console.WriteLine("Invalid choice, please try again!\n\n");}
        }       
    }
}
