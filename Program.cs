using test_opgave_it_operators.managers;
using test_opgave_it_operators.models;

Console.WriteLine("Running");


CarManager carManager = new CarManager();

// Opgave 1
Console.WriteLine("opgave 1");
Console.WriteLine($"count cars to see if json loaded correctly. cars count: {carManager.Cars.Count()}");
Console.WriteLine();

// Opgave 2
Console.WriteLine("opgave 2");
carManager.GetNumberOfCarsPerType();
Console.WriteLine();

// Opgave 3
Console.WriteLine("opgave 3");
carManager.GetFordsAfter1980();
Console.WriteLine();

// Opgave 4
Console.WriteLine("opgave 4");
carManager.AverageHorsePowerByOrigin();
Console.WriteLine();

// Opgave 5
Console.WriteLine("opgave 5");
carManager.FindKmPerLitreOnCars();
Console.WriteLine();

// Opgave 6
Console.WriteLine("opgave 6");
carManager.GetCarsWeightInKg();
Console.WriteLine();

// Opgave 7
Console.WriteLine("opgave 7");
Console.WriteLine("er udkommenteret for ikke at indsætte for mange kopier af dem samme bil");
/* Car carToAdd = new Car() {
    Name = "test",
    Miles_per_Gallon = 30,
    Cylinders = 4,
    Displacement = 100,
    Horsepower = 100,
    Weight_in_lbs = 2000,
    Year = new DateTime(1971, 1, 1),
    Origin = "USA"
};

carManager.AddCar(carToAdd);
Console.WriteLine($"added car to json file: car name {carToAdd.Name}"); */
Console.WriteLine();

// Opgave 8
Console.WriteLine("opgave 8");
carManager.FindMostEconomicCar();
Console.WriteLine();

// Opgave 9
Console.WriteLine("opgave 9");
