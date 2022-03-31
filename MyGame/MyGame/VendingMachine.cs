public class VendingMachine
{
    public User Customer { get; }
    public List<string> Contents { get; } = new List<string>();
    public List<string> Commands { get; } = new List<string>
    {
        "buy",
        "browse",
        "leave"
    };
    public VendingMachine(User customer)
    {
        Customer = customer;
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
                else if (command == "browse")
                {
                    Browse();
                }

            } while (command != "leave");
        }

    public void Buy()
    {
        Console.WriteLine("What would you like to buy?");
        Console.ReadLine();
    }

    public void Add(Inventory product)
    {
        var piece = Console.ReadLine()!;

        if (piece != "")
        {
            Contents.Add(piece);
        }
    }

    public void Browse()
    {
        foreach (var thing in Contents)
        {
            Console.WriteLine(thing);
        }
    }

        public string GetCommand()
        {
            while (true)
            {
                Console.WriteLine("You can either buy, browse or leave.");
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
}