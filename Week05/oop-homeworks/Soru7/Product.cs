using System;

namespace Soru7;

public class Product
{
    public Product(string? name, int price, int stockQuantity)
    {
        Name = name;
        Price = price;
        StockQuantity = stockQuantity;
    }

    public string? Name { get; set; }

public int Price { get; set; }

public int StockQuantity { get; set; }

public void CheckStock (){
System.Console.WriteLine("Stok kontrol edildi");
}

public void UpdateStock (){
    System.Console.WriteLine("Stok durumu güncellendi.");
}

}
