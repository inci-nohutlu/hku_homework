class Product
{
    public string ProductCode { get; }
    public string Name { get; set; }
    public int Stock { get; private set; }

    private double price;
    public double Price
    {
        get => price;
        set
        {
            if (value <= 0) Console.WriteLine($"Invalid price: {value}");
            price = value > 0 ? value : 1.0;
        }
    }

    public Product(string code, string name, double price, int stock)
    {
        (ProductCode, Name, Price, Stock) = (code, name, price, stock);
    }

    public void Restock(int amount) { if (amount > 0) Stock += amount; }
    public string Info() => $"[{ProductCode}] {Name} - ${Price:F2} (Stock: {Stock})";
}

class Program
{
    static void Main()
    {
        Product[] products =
        [
            new("P101", "Wireless Mouse", 25.50, 10),
            new("P102", "Mechanical Keyboard", 85.00, 10),
            new("P103", "USB-C Cable", -15, 50),
            new("P104", "Monitor", 200.00, 5)
        ];

        products[0].Restock(5);
        foreach (var p in products) Console.WriteLine(p.Info());

        double[] prices = products.Select(p => p.Price).ToArray();
        Console.WriteLine($"Minimum price: ${prices.Min():F2}");
        Console.WriteLine($"Maximum price: ${prices.Max():F2}");
        Console.WriteLine($"Average price: ${prices.Average():F2}");
        Console.WriteLine($"Products costing $50 or more: {prices.Count(p => p >= 50)}");

        double[] sorted = (double[])prices.Clone();
        Array.Sort(sorted);
        Console.WriteLine($"Sorted prices: {string.Join(", ", sorted)}");
        Console.WriteLine($"BinarySearch for 85; found at index {Array.BinarySearch(sorted, 85.00)}");
    }
}
