using System.ComponentModel.Design;

bool exit = false;
Dictionary<string, string> phoneBook = new();
phoneBook.Add("Evan", "123-456-7890");
phoneBook.Add("John", "098-765-4321");
phoneBook.Add("Jane", "321-654-0987");

do
{
    Console.WriteLine("\n 1. Add Contact \n 2. View Contact \n 3. Update Contact \n 4. Delete Contact");
    Console.Write("Enter choice: ");
    string? choice = Console.ReadLine();
    if (choice.Equals("6"))
    {
        exit = true;
    }
    else if (choice.Equals("1"))
    {
        Console.Write("Enter Name:   ");
        string name = Console.ReadLine();
        
        string phoneNumber = Console.ReadLine();
        phoneBook.Add(name, phoneNumber);
    }
} while  (exit == false);


