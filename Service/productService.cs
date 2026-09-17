using Inventory.Model;
namespace Inventory.Service;

public class HandleProduct
{
    
    private List<Product> warehouse = new();

    public List<Product> GetProduct()
    {
        return warehouse;
    }
    public void AddProduct(Product pr)
    {
        warehouse.Add(pr);
    }
    public void DeleteProduct(Guid id)
    {
        warehouse.RemoveAll(p => p.ID ==  id );
    }
    public void EditProduct(Product pr)
    {
        
    }
}