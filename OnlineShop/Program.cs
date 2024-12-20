class Program
{
    static void Main()
    {

        var shop = new Shop();


        var electronicProduct = new Electronic
        {
            Name = "Laptop",
            Price = 1000m,
            WarrantyPeriod = 24
        };

        var clothingProduct = new Clothing
        {
            Name = "T-Shirt",
            Price = 50m,
            Material = "Cotton",
            Size = "M"
        };


        shop.AddProduct(electronicProduct);
        shop.AddProduct(clothingProduct);


        Console.WriteLine("Before Discount:");
        shop.ShowProductDetails();


        shop.ApplyDiscountToProduct("Laptop", 10);
        shop.ApplyDiscountToProduct("T_Shirt", 3);


        Console.WriteLine("\nAfter Discount:");
        shop.ShowProductDetails();
    }
}
