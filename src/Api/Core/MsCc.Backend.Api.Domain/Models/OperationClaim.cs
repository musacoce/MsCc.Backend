namespace MsCc.Backend.Api.Domain.Models;
public class OperationClaim
{
    public int OperationClaimID { get; set; }
    public string OperationClaimName { get; set; }
    public bool IsActive { get; set; }
    public int CreatedById { get; set; }
    public DateTime CreatedDate { get; set; }

    public virtual ICollection<UserOperationClaim> UserOperationClaims { get; set; }
}
