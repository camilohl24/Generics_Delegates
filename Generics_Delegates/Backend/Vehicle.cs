namespace Backend
{
    public class Vehicle
    {

        private int _miliage;
        private int _consumption;
        public string Brand { get; set; } = null!;
        public string Model { get; set; } = null!;
        public int Miliage
        {
            get => _miliage; 
            set => _miliage = ValidateMiliage(value);
        }
        public int Consumption
        {
            get => _consumption;
            set => _consumption = ValidateConsumption(value); 
        }

        public override string ToString() => $"Brand: {Brand,10},\t Model: {Model,10},\t Miliage: {Miliage,10}\n";

        private int ValidateMiliage(int miliage)
        {
            if (miliage < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(miliage), "Miliage cannot be negative.");
            }
            return miliage;
        }
        private int ValidateConsumption(int consumption)
        {
            if (consumption < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(consumption), "Consumpytion cannot be negative.");
            }
            return consumption;
        }


    }
}
