using System;

namespace Soru7;

public class ElectronicProduct : Product
{
    public ElectronicProduct(string? name, int price, int stockQuantity, int guaranteeTerm) : base(name, price, stockQuantity)
    {
       GuaranteeTerm=guaranteeTerm;
    }

    public int GuaranteeTerm { get; set; }

    

}
