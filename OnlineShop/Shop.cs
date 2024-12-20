using OnlineShop;
using System;
using System.Collections.Generic;

public class Shop
{
    private List<Product> products;

    public Shop()
    {
        products = new List<Product>();
    }

    public void AddProduct(Product product)
    {
        products.Add(product);
    }

    public void ShowProductDetails()
    {
        foreach (var product in products)
        {
            Console.WriteLine(product.GetProductDetails());
        }
    }

    public void ApplyDiscountToProduct(string productName, decimal discountPercentage)
    {
        var product = products
            .OfType<Product>() 
            .FirstOrDefault(p => p.Name.Equals(productName, StringComparison.OrdinalIgnoreCase) && p is IDiscountable); // بررسی نام محصول و این که آیا تخفیف‌پذیر است

        if (product != null && product is IDiscountable discountableProduct)
        {
            discountableProduct.ApplyDiscount(discountPercentage); 
        }
    }

}
