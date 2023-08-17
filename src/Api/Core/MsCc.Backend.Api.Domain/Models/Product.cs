namespace MsCc.Backend.Api.Domain.Models;
public class Product
{
    public int ProductId { get; set; }
    public string ProductName { get; set; }
    public int CategoryId { get; set; }
    public decimal UnitPrice { get; set; }
    public short QuantityPerUnit { get; set; }
    public short UnitInStock { get; set; }
    public bool EmailConfirm { get; set; }

    public bool IsActive { get; set; }
    public DateTime CreatedDate { get; set; }
    public int CreatedById { get; set; }

    public virtual User CreatedBy { get; set; }
    public virtual Category Category { get; set; }

}
