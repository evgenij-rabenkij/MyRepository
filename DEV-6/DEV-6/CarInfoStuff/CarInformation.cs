
namespace DEV_6
{
    class CarInformation//class, which presents car information form 
    {
        public string Type { get;}
        public string Model { get; }
        public int Amount { get; }
        public int Price { get; }

        public CarInformation(string type, string model, int amount, int price)
        {
            Type = type;
            Model = model;
            Amount = amount;
            Price = price;
        }

        public override bool Equals(object obj)
        {
            return Type == (obj as CarInformation).Type && Model == (obj as CarInformation).Model;
        }
    }
}
