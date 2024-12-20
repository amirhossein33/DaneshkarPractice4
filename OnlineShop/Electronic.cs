using OnlineShop;

public class Electronic : Product, IDiscountable
{
    public int WarrantyPeriod { get; set; }

    public override string GetProductDetails()
    {
        return $"{base.GetProductDetails()}, Warranty Period: {WarrantyPeriod} months";
    }

    public void ApplyDiscount(decimal discountPercentage)
    {
        Price -= Price * discountPercentage / 100;
    }
}
