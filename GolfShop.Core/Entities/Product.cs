namespace GolfShop.Core.Entities
{
    public class Product : BaseEntity
    {
        public string Name { get; private set; }
        public string Description { get; private set; }
        public double Price { get; private set; }
    }
}