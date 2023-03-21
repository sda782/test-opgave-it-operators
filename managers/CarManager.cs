using test_opgave_it_operators.models;
using test_opgave_it_operators.utils;

namespace test_opgave_it_operators.managers {
    public class CarManager {
        private List<Car> _cars;
        public CarManager() {
            try {
                _cars = JsonHelper.GetCarsFromJson();
            } catch (Exception e) {
                _cars = new List<Car>();
                Console.WriteLine(e.Message);
            }
        }

        public void GetNumberOfCarsPerType() {
            var carTypes = _cars.DistinctBy(c => c.Name.Split()[0]);
            foreach (var ct in carTypes) {
                int n = _cars.Count(c => c.Name.Split()[0] == ct.Name.Split()[0]);
                Console.WriteLine($"found {n} of car type {ct.Name.Split()[0]}");
            }
        }

        public void GetFordsAfter1980() {
            DateTime cutoffDate = new DateTime(1980, 1, 1);
            var allFords = _cars.Where(c => c.Name.ToLower().StartsWith("ford") && c.Year > cutoffDate);
            var numberOfFords = allFords.Count();
            Console.WriteLine($"found {numberOfFords} from after 1/1-1980");
        }

        public void AverageHorsePowerByOrigin() {
            var carsGroupedByOrigin = _cars.GroupBy(c => c.Origin);
            foreach (var carGroup in carsGroupedByOrigin) {
                double? averageHorsePower = carGroup.Average(c => c.Horsepower != null ? c.Horsepower : 0);
                Console.WriteLine($"{carGroup.FirstOrDefault()?.Origin} average horsepower: {averageHorsePower}");
            }
        }

        public void FindKmPerLitreOnCars() {
            foreach (Car car in _cars) {
                if (car.Miles_per_Gallon == null) {
                    Console.WriteLine("skipping car, unable to calculate miles per gallon is null");
                    continue;
                }
                double kmPerLitre = (double)car.Miles_per_Gallon * 1.6;
                Console.WriteLine($"{car.Name} runs at {Math.Round(kmPerLitre, 1)} km per litre");
            }
        }

        public void GetCarsWeightInKg() {
            foreach (Car car in _cars) Console.WriteLine($"{car.Name} weights {car.Weight_in_kg} in kg");
        }

        public void AddCar(Car newCar) {
            _cars.Add(newCar);
            JsonHelper.AddCarsToJson(_cars);
        }

        public void FindMostEconomicCar() {
            try {
                var MostEconomicCar = _cars.MaxBy(c => c.Miles_per_Gallon);
                Console.WriteLine($"Most economic car is {MostEconomicCar?.Name} with {MostEconomicCar?.Miles_per_Gallon} miles per gallon");
            } catch (Exception e) {
                Console.WriteLine("Couldn't find most economic car");
                System.Console.WriteLine(e.Message);
            }
        }

        public void FindLongestNamePerYear() {

        }

        public List<Car> Cars { get => _cars; }
    }
}