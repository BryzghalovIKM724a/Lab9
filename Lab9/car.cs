namespace Lab9
{
    public class Car
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public int EnginePower { get; set; }
        public decimal Price { get; set; }

        public Car(string brand, string model, int year, int enginePower, decimal price)
        {
            Brand = brand;
            Model = model;
            Year = year;
            EnginePower = enginePower;
            Price = price;
        }

        public override string ToString()
        {
            return $"{Brand} {Model}, {Year}, {EnginePower} hp, ${Price}";
        }
    }
}