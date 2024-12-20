namespace OnlineShop
{
    public abstract class Product
    {
        public string Name { get; set; } = string.Empty;
        public decimal Price { get; set; }

        public virtual string GetProductDetails()
        {
            return $"Product Name: {Name}, Price: {Price:C}";
        }
    }
}
