using System;

namespace Soru7;

public class FoodProduct : Product
{
    public FoodProduct(string? name, int price, int stockQuantity, string expirationDate) : base(name, price, stockQuantity)
    {
        ExpirationDate = expirationDate;
    }

    public string ExpirationDate { get; set; }

}
