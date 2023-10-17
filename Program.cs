// First Run: 14.10.2023 16:00

class Program {
    public static void Main () {

        Console.Clear();
        string choiceList = "What do you want to do?"
        + "\n 1. Add \n 2. List \n 3. Edit \n 4. Delete \n 5. " 
        + $"Exit \n Enter your choice: ";
        Console.Write(choiceList);

        string? input = Console.ReadLine();
        while(input != "1" && input != "2" && input != "3" && input != "4" && input != "5")
        {
            Console.Clear();
            Console.WriteLine("Invalid input. Try again.");
            Console.Write("Please enter a valid choice: " 
            + "\n 1. Add \n 2. List \n 3. Edit \n 4. Delete \n 5. " 
            + "Exit \n Enter your choice: ");
            input = Console.ReadLine();
        }
        if (input == "1") {
            addContact.add();
        }
        else if (input == "2") {
            listContact.list();
        }
        else if (input == "3") {
            editContact.edit();
        }
        else if (input == "4") {
            deleteContact.delete();
        }
        else if (input == "5") {
            Console.WriteLine("You are exiting the program.");
        }
    }
}

class addContact {
    public static string? name, address, phone, email;

    public static void add () {
        Console.Clear();
        Console.WriteLine("You are adding a new contact.");
        Console.Write("Enter your name: ");
        name = Console.ReadLine();
        Console.Write("Enter your address: ");
        address = Console.ReadLine();
        Console.Write("Enter your phone number: ");
        phone = Console.ReadLine();
        Console.Write("Enter your email: ");
        email = Console.ReadLine();
        Program.Main();
    }
}

class listContact {
    public static void list () {
        Console.Clear();
        Console.WriteLine("You are listing all contacts.");
        Console.WriteLine("==================================");
        Console.WriteLine("Name: " + addContact.name);
        Console.WriteLine("Address: " + addContact.address);
        Console.WriteLine("Phone: " + addContact.phone);
        Console.WriteLine("Email: " + addContact.email);
        Console.WriteLine("==================================");
        Console.WriteLine("Press any key to continue...");
        Console.ReadKey();
        Program.Main();
    }
}

class editContact {
    public static void edit () {
        Console.Clear();
        Console.WriteLine("You are editing a contact.");
        Console.WriteLine("==================================");
        if (addContact.name == null) {
            Console.WriteLine("You have no contact to edit.");
        }
        else {
            Console.Write($"Name: {addContact.name} \t,"
            +$" What do you want to change: ");
            addContact.name = Console.ReadLine();        
        }
        
        if (addContact.address == null) {
            Console.WriteLine("You have no contact to edit.");
        }
        else
        {
            Console.Write($"Address: {addContact.address} \t,"
            +$" What do you want to change: ");
            addContact.address = Console.ReadLine();
        }
        
        if (addContact.phone == null) {
            Console.WriteLine("You have no contact to edit.");
        }
        else
        {
            Console.Write($"Phone: {addContact.phone} \t,"
            +$" What do you want to change: ");
            addContact.phone = Console.ReadLine();
        }
        
        if (addContact.email == null) {
            Console.WriteLine("You have no contact to edit.");
        }
        else
        {
            Console.Write($"Email: {addContact.email} \t,"
            +$" What do you want to change: ");
            addContact.email = Console.ReadLine();
        }
    
        Console.WriteLine("==================================");
        Console.WriteLine("Press any key to continue...");
        Console.ReadKey();
        Program.Main();
    }
}

class deleteContact {
    public static void delete(){
        Console.Clear();
        addContact.name = null;
        addContact.address = null;
        addContact.phone = null;
        addContact.email = null;
        Console.WriteLine("You are deleting a contact.");
        Console.WriteLine("==================================");
        Console.WriteLine("Press any key to continue...");
        Console.ReadKey();
        Program.Main();
    }
}
