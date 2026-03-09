namespace Backend
{
    public class Vehicle
    {

        private int _miliage;
        public string Brand { get; set; } = null!;
        public string Model { get; set; } = null!;
        public int Miliage
        {
            get => _miliage; 
            set => _miliage = value;
        }

        public override string ToString() => $"Brand: {Brand,10},\t Model: {Model,10},\t Miliage: {Miliage,10}\n";

        private int validateMiliage(int miliage)
        {
            if (miliage < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(miliage), "Miliage cannot be negative.");
            }
            return miliage;
        }




    }
}
