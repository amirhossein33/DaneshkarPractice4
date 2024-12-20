using OnlineShop;

public class Clothing : Product , IDiscountable
{
    public string? Material { get; set; }
    public string? Size { get; set; }
    public override string GetProductDetails()
    {
        return $"{base.GetProductDetails()}, Material: {Material}, Size: {Size}";
    }
    public void ApplyDiscount(decimal discountPercentage)
    {
        Price -= Price * discountPercentage / 100;
    }
}
