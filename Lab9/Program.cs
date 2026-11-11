using Lab9;

List<Car> cars = new List<Car>
{
    new Car("BMW", "320i", 2014, 150, 18000),
    new Car("Toyota", "Camry", 2018, 203, 25000),
    new Car("Audi", "A4", 2020, 190, 35000),
    new Car("BMW", "X5", 2021, 340, 65000),
    new Car("Ford", "Focus", 2016, 125, 15000)
};

var carsAfter2015 = cars.Where(car => car.Year > 2015);

Console.WriteLine("Cars released after 2015:");

foreach (var car in carsAfter2015)
{
    Console.WriteLine(car);
}

var mostExpensive = cars
    .OrderByDescending(car => car.Price)
    .First();

Console.WriteLine();
Console.WriteLine("Most expensive car:");
Console.WriteLine(mostExpensive);

var groupedCars = cars.GroupBy(car => car.Brand);

Console.WriteLine();
Console.WriteLine("Cars grouped by brand:");

foreach (var group in groupedCars)
{
    Console.WriteLine(group.Key);

    foreach (var car in group)
    {
        Console.WriteLine($"  {car.Model}");
    }
}

double averagePower = cars.Average(car => car.EnginePower);

Console.WriteLine();
Console.WriteLine($"Average engine power: {averagePower} hp");