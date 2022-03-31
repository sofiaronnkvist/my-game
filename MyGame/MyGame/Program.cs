// Vending Machine spel

// Skapa en user. Skapa en ny vending machine.
// Loggar först: välkommen user till vending machine! du har xx antal kronor.
// Vad vill du köpa? Skriv produkt och antal såhär: Twix, 2
// Lista iventory: beskrivning, kostnad, antal kvar
// Input = Twix, 2
// Du har köpt 2 Twix.
// Du har nu: 2 Twix
// Så här mycket pengar har du kvar: 16 kr

// Vad vill du köpa? Skriv produkt och antal såhär: Twix, 2

var customer = new User("Sofia", 20);
var twix = new Inventory("Twix");
var cookie = new Inventory("Cookie");

var vendingMachine = new VendingMachine(customer);

vendingMachine.Add(twix);
vendingMachine.Add(cookie);

vendingMachine.Run();
