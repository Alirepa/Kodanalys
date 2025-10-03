namespace Kodanalys
{
    class Program
    {
        static string[] users = new string[10];
        static int userCount = 0;

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
            if (userCount < 10)
            {
                users[userCount] = userName;
                userCount++;
                Console.WriteLine("Användaren tillagd.");
            }
            else
            {
                Console.WriteLine("Listan är full!");
            }
        }

        static void ShowAllUsers()
        {
            Console.WriteLine("Användare:");
            for (int i = 0; i < userCount; i++)
            {
                Console.WriteLine(users[i]);
            }
        }

        static void RemoveUser()
        {
            Console.Write("Ange namn att ta bort: ");
            string userName = Console.ReadLine();
            int userIndex = -1;
            for (int i = 0; i < userCount; i++)
            {
                if (users[i] == userName)
                {
                    userIndex = i;
                    break;
                }
            }

            if (userIndex != -1)
            {
                for (int i = userIndex; i < userCount - 1; i++)
                {
                    users[i] = users[i + 1];
                }
                userCount--;
                Console.WriteLine("Användaren togs bort");
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
            bool userFound = false;
            for (int i = 0; i < userCount; i++)
            {
                if (users[i] == userName)
                {
                    userFound = true;
                    break;
                }
            }
            if (userFound)
            {
                Console.WriteLine("Användaren finns i listan.");
            }
            else
            {
                Console.WriteLine("Användaren hittades inte.");
            }
        }

    }
}
