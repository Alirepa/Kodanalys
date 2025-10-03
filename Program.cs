namespace Kodanalys
{
    class Program
    {
        static List<string> users = new List<string>();

        static void Main(string[] args)
        {
            bool isRunning = true;
            while (isRunning)
            {
                Console.WriteLine("Välj ett alternativ:");
                Console.WriteLine("1. Lägg till användare");
                Console.WriteLine("2. Visa alla användare");
                Console.WriteLine("3. Ta bort användare");
                Console.WriteLine("4. Sök användare");
                Console.WriteLine("5. Avsluta");
                string userChoice = Console.ReadLine();

                if (userChoice == "1")
                {
                    AddUser();
                }
                else if (userChoice == "2")
                {
                    ShowAllUsers();
                }
                else if (userChoice == "3")
                {
                    RemoveUser();
                }
                else if (userChoice == "4")
                {
                    SearchUser();
                }
                else if (userChoice == "5")
                {
                    isRunning = false;
                }
                else
                {
                    Console.WriteLine("Ogiltigt val.");
                }
                Console.WriteLine();
            }
        }

        static void AddUser()
        {
            Console.Write("Ange namn: ");
            string userName = Console.ReadLine();
            users.Add(userName);
            Console.WriteLine("Användaren tillagd.");
        }

        static void ShowAllUsers()
        {
            Console.WriteLine("Användare:");
            foreach (string user in users) 
            {
                Console.WriteLine(user);
            }
        }

        static void RemoveUser()
        {
            Console.Write("Ange namn att ta bort: ");
            string userName = Console.ReadLine();
            
            if (users.Contains(userName)) 
            { 
                users.Remove(userName);
                Console.WriteLine("Användaren borttagen.");
            }
            else
            {
                Console.WriteLine("Användaren hittades inte.");
            }
        }

        static void SearchUser()
        {
            Console.Write("Ange namn att söka: ");
            string userName = Console.ReadLine();
            
            if (users.Contains(userName)) 
            {
            Console.WriteLine("Användaren hittades.");
            }
            else
            {
                Console.WriteLine("Användaren hittades inte.");
            }
        }

    }
}
