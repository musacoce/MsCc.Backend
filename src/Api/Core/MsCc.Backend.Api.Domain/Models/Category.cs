namespace MsCc.Backend.Api.Domain.Models;
public class Category
{
    public int CategoryId { get; set; }
    public string CategoryName { get; set; }
    public bool IsActive { get; set; }

    public virtual ICollection<Product> Product { get; set; }
}
