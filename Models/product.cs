namespace Inventory.Model;
public class Product{
    public Guid ID {get;set;} = Guid.NewGuid();
    public string Name{get;set;}="";
    public int Quantity{get;set;}
    public string Unit{get;set;}="";
    public DateTime DateUpdate{get;set;}
     
}
