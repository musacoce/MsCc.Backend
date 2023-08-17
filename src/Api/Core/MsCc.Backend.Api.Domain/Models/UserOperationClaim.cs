﻿namespace MsCc.Backend.Api.Domain.Models;
public class UserOperationClaim
{
    public int Id { get; set; }
    public int UserId { get; set; }
    public int OperationClaimId { get; set; }

    public virtual User User { get; set; }
    public virtual OperationClaim OperationClaim { get; set; }
}
