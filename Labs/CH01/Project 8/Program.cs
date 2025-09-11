using Project_8;

Dictionary<string, double> items = new Dictionary<string, double>();

cart cart1 = new cart("1234");
cart1.AddItem("Lollypop", 2.5);
cart1.AddItem("Gum", 1.5);
cart1.AddItem("Soda", 2.75);
Console.WriteLine(cart1);

cart1.RemoveItem("Gum");
Console.WriteLine(cart1);


cart cart2 = new cart("5678");
cart2.AddItem("Milk", 2.5);
cart2.AddItem("Bread", 1.5);
cart2.AddItem("Eggs", 2.75);
Console.WriteLine(cart2);