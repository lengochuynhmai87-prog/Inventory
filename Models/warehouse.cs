namespace Inventory.Model;
public class Warehouse
{
    public int Id{get;set;}
    public string Name{get;set;} =string.Empty;
    public string address{get;set;}=string.Empty;
    public DateTime CreatTime {get;set;} = DateTime.Now;
    public  List<Product> warehouse {get;set;} =new();
}