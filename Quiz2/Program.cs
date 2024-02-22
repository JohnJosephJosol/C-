using System;

class Program
{
    static List<OrderItem> orderList = new List<OrderItem>();

    static void Main()
    {
        Console.WriteLine("Ordering Application");

        bool exit = false;

        while (!exit)
        {
            Console.WriteLine("1. Add Item to Order");
            Console.WriteLine("2. View Order Summary");
            Console.WriteLine("3. Place Order");
            Console.WriteLine("4. Exit");

            Console.Write("\nEnter your choice: ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    AddItemToOrder();
                    break;
                case "2":
                    ViewOrderSummary();
                    break;
                case "3":
                    PlaceOrder();
                    break;
                case "4":
                    exit = true;
                    Console.WriteLine("--------------------------------------Thankyou for your Order-------------------------------------");
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        }
    }

    static void AddItemToOrder()
    {
        Console.Write("Enter item name: ");
        string itemName = Console.ReadLine();

        Console.Write("Enter item price: ");
        if (decimal.TryParse(Console.ReadLine(), out decimal itemPrice))
        {
            OrderItem newItem = new OrderItem(itemName, itemPrice);
            orderList.Add(newItem);

            Console.WriteLine($"\nItem '{itemName}' added to the order.\n");
        }
        else
        {
            Console.WriteLine("Invalid price. Please enter a valid number.");
        }
    }

    static void ViewOrderSummary()
    {
        if (orderList.Any())
        {
            Console.WriteLine("\nOrder Summary:");
            foreach (var item in orderList)
            {
                Console.WriteLine($"- {item.Name}: P{item.Price}");
            }
            Console.WriteLine("");
        }
        else
        {
            Console.WriteLine("Order is empty. Add items to view the summary.");
        }
    }

    static void PlaceOrder()
    {
        if (orderList.Any())
        {
            decimal totalPrice = orderList.Sum(item => item.Price);
            Console.WriteLine($"Total Price of Order: P{totalPrice}");

            // Clear the order list
            orderList.Clear();

            Console.WriteLine("Order placed successfully. Order list cleared.\n");
        }
        else
        {
            Console.WriteLine("Cannot place an empty order. Add items to the order first.");
        }
    }
}

class OrderItem
{
    public string Name { get; }
    public decimal Price { get; }

    public OrderItem(string name, decimal price)
    {
        Name = name;
        Price = price;
    }
}
