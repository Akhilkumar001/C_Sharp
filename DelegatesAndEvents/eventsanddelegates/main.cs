using System;

internal class ProductData{
    delegate void PurchaseOrder(int productID,int quantityToOrder);
    
    event PurchaseOrder GeneratePurchaseOrder;
    
    public int ProductID {get; set;}
    
    public string ProductName {get; set;}

    public int QuantityOnHand {get; set;}
    
    public int ReOrderLevel {get; set;}
    
    public ProductData()
    {
          GeneratePurchaseOrder+=new POServices().RaisePurchaseOrder;

        
    }
    public void Purchase(int quantity)
    {
        QuantityOnHand-=quantity;
        if(QuantityOnHand<=ReOrderLevel)
        {
            GeneratePurchaseOrder(this.ProductID,1000);
        }
    }

    

    
    
}


public class POServices{
    
    public void RaisePurchaseOrder(int ProductID,int quantityToOrder)
    {
        Console.WriteLine("Purchase Order is Raised : )");
    }
}


class HelloWorld {
  static void Main() {
      ProductData productData=new ProductData(){
          ProductID=101,
          ProductName="product001",
          QuantityOnHand=12,
          ReOrderLevel=10
          
          
      };
        productData.Purchase(10);
  }
}