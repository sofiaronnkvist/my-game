public class VendingMachine
{
    public User Customer { get; set; }
    public List<Inventory> Inventory { get; set; }
    public List<string> Commands { get; } = new List<string>

    {
        "buy",
        "see my money",
        "leave"
    };
    public VendingMachine(User customer, List<Inventory> inventory)
    {
        Customer = customer;
        Inventory = inventory;
    }

    public void Run()
        {
            Console.WriteLine();
            Console.BackgroundColor = ConsoleColor.Magenta;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine($"Welcome to the Vending Machine, {Customer.Name}!");
            Console.WriteLine();
            Console.ResetColor();

            string command;

            do
            {
                command = GetCommand();

            if (command == "buy")
            {
                Buy();
            }
            else if (command == "see my money")
            {
                SeeMoney();
            }

            } while (command != "leave");
        }

    public void Buy()
    {
        Console.WriteLine("This is what we've got");
        foreach (var product in Inventory)
        {
            Console.WriteLine($"{product.Id} - {product.Product}, {product.Price}:-");
        }
        Console.Write("Type in the number to buy something: ");
        var answer = Console.ReadLine();
        var answerToInt = Convert.ToInt32(answer);
        //var money = Customer.Money.Money;
        //var balance = Convert.ToInt32(money);

        foreach (var item in Inventory)
        {
            if (answerToInt == item.Id && Customer.Money.Money >= item.Price)
            {
                Customer.Money.Money -= item.Price;
                Console.WriteLine($"You've bought {item.Product}");

                return;
            }
            else if (answerToInt == item.Id && Customer.Money.Money < item.Price)
            {
                Console.WriteLine("You're too poor for that. Choose something else.");
                return;

            }

        }
        Console.WriteLine("Look again, cause that one doesn't exist in the list.");
        return;
    }

        public string GetCommand()
        {
            while (true)
            {
                Console.WriteLine("You can either buy, see my money or leave.");
                Console.WriteLine("What would you like to do?");
                
                var input = Console.ReadLine()!;

                if (Commands.Contains(input))
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("OK");
                    Console.WriteLine();
                    Console.ResetColor();

                    return input;
                }

                Console.WriteLine("?");
                Console.WriteLine();
            }
        }
    public void SeeMoney()
    {
        Console.WriteLine($"You've {Customer.Money.Money}:- left.");
    }
}