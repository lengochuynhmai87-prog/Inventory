namespace Inventory.Model;

public class ProductAttribute
{
    public int Id{get;set;}
    public string name{get;set;}=string.Empty;
    public int WarehouseID{get;set;} 
    public Warehouse ? Warehouse{get;set;}

}