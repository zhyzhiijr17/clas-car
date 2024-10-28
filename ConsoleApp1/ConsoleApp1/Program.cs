class Car
{
    public string Name { get; set; }
    public string Color { get; set; }
    public double Price { get; set; }
    public const string CompanyName = "AutoCompany";

    public Car()
    {
        Name = "Unnamed";
        Color = "Unknown";
        Price = 0.0;
    }

    public Car(string name, string color, double price)
    {
        Name = name;
        Color = color;
        Price = price;
    }

    public void Input()
    {
        Console.Write("Введіть назву автомобіля: ");
        Name = Console.ReadLine();
        Console.Write("Введіть колір автомобіля: ");
        Color = Console.ReadLine();
        Console.Write("Введіть ціну автомобіля: ");
        Price = Convert.ToDouble(Console.ReadLine());
    }

    public void Print()
    {
        Console.WriteLine($"Назва: {Name}, Колір: {Color}, Ціна: {Price}, Виробник: {CompanyName}");
    }

    public void ChangePrice(double percentage)
    {
        Price += Price * (percentage / 100);
    }

    public string PrintInfo()
    {
        return $"Назва: {Name}, Колір: {Color}, Ціна: {Price}, Виробник: {CompanyName}";
    }

    public void Paint(string newColor)
    {
        if (Color.Equals("white", StringComparison.OrdinalIgnoreCase))
        {
            Color = newColor;
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        Car[] cars = new Car[3];

        for (int i = 0; i < cars.Length; i++)
        {
            cars[i] = new Car();
            cars[i].Input();
        }

        foreach (var car in cars)
        {
            car.ChangePrice(-10);
            car.Print();
        }

        Console.Write("Введіть новий колір для автомобілів білого кольору: ");
        string newColor = Console.ReadLine();

        foreach (var car in cars)
        {
            car.Paint(newColor);
        }

        Console.WriteLine("\nДані про автомобілі після фарбування:");
        foreach (var car in cars)
        {
            Console.WriteLine(car.PrintInfo());
        }
    }
}