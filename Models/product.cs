namespace Inventory.Model;
public class Product{
    public Guid ID {get;set;} = Guid.NewGuid();
    public string Name{get;set;}="";
    public int Quantity{get;set;}
    public DateTime DateUpdate{get;set;}    
    public int WarehouseID{get;set;}
    public Warehouse? warehouse{get;set;}
    public List<ProductAttributeValue> value{get;set;} =new();
     
}
