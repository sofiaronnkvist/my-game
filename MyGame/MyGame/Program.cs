// Vending Machine game

var money = new Bank(20);
var customer = new User("Sofia", money);

    var products = new List<Inventory>()
    {
        new Inventory()
        {
            Product = "Banana skids",
            Price = 10,
            Id = 1
        },
        new Inventory()
       {
           Product = "Toffee",
           Price = 5,
           Id = 2
       },
        new Inventory()
       {
           Product = "Rollo",
           Price = 10,
           Id = 3
       },
       new Inventory()
       {
           Product = "Pralines",
           Price = 30,
           Id = 4
       },
       new Inventory()
       {
           Product = "Candy corn",
           Price = 8,
           Id = 5
       },
       new Inventory()
       {
           Product = "Lollipop",
           Price = 7,
           Id = 6
       },
       new Inventory()
       {
           Product = "Sour patch",
           Price = 11,
           Id = 7
       },
       new Inventory()
       {
           Product = "Nerds",
           Price = 20,
           Id = 8
       },
       new Inventory()
       {
           Product = "Willy wonka chocolate",
           Price = 35,
           Id = 9
       },
    };
var vendingMachine = new VendingMachine(customer, products);

vendingMachine.Run();
