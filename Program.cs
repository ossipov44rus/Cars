using Cars;

List<Car> myCars = new List<Car>
{
    new Car{Model = "BMW 745i", Color="Red",Description="A little scrath on the window."},
    new Car{Model="Mersedes s350",Color="Black", Description="Some issues with the engine."},
    new Car{Model="Audi A4",Color="White",Description="Need to change the oil."}
};
Car myNewCar = new Car { Model = "BMW 745i", Color = "Red", Description = "333 h.p." };
Console.WriteLine(myCars[0].Equals(myNewCar));
Console.WriteLine(myCars.GetHashCode());
Console.WriteLine(myNewCar.GetHashCode());
