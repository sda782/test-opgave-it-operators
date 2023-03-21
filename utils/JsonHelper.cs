using Newtonsoft.Json;
using test_opgave_it_operators.models;

namespace test_opgave_it_operators.utils {
    public class JsonHelper {
        private static readonly string carsJsonPath = @".\data\cars.json";
        public static List<Car> GetCarsFromJson() {
            string jsonString = File.ReadAllText(carsJsonPath);
            List<Car>? cars = JsonConvert.DeserializeObject<List<Car>>(jsonString);
            if (cars == null) throw new Exception("no data found in file");
            return cars;
        }

        public static void AddCarsToJson(List<Car> cars) {
            try {
                string jsonString = JsonConvert.SerializeObject(cars);
                File.WriteAllText(carsJsonPath, jsonString);
            } catch (Exception e) {
                Console.WriteLine(e.Message);
            }
        }
    }
}