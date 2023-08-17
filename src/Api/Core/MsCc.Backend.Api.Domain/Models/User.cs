namespace MsCc.Backend.Api.Domain.Models;
public class User
{
    public int UserId { get; set; }
    public string FirtName { get; set; }
    public string LastName { get; set; }
    public string UserName { get; set; }
    public string Email { get; set; }
    public string CepTel { get; set; }
    public byte[] PasswordSalt { get; set; }
    public byte[] PasswordHash { get; set; }

    public bool IsActive { get; set; }
    public DateTime CreatedDate { get; set; }

    public virtual ICollection<Product> Products { get; set; }
    public virtual ICollection<UserOperationClaim> UserOperationClaims { get; set; }
}
