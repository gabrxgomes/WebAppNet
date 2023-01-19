namespace WebAppNet.Domain.Products;

public class Product
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public Category Categoryy { get; set; }
    public string Description { get; set; }
    public bool MyProperty { get; set; }

}
