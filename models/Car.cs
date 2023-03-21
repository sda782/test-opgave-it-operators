

namespace test_opgave_it_operators.models {
    public class Car {
        public string Name = "";
        public double? Miles_per_Gallon;
        public int Cylinders;
        public double Displacement;
        public int? Horsepower;
        public int Weight_in_lbs;
        public double Acceleration;
        public DateTime Year;
        public string Origin = "";

        public int Weight_in_kg => (int)(Weight_in_lbs * 2.2);

        public override string ToString() {
            return $"Name {Name}, Origin {Origin}";
        }

    }
}