namespace Inventory.Model;

public class ProductAttributeValue
{
    public int Id{get;set;}
    public Guid ProductId{get;set;} = Guid.NewGuid();
    public Product ? product{get;set;}
    public int AttributeId{get;set;}
    public ProductAttribute? Attribute{get;set;}
    public string value{get;set;}=string.Empty;

}