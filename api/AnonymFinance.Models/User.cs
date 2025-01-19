namespace AnonymFinance.Models;

public class User
{
    public Guid Id { get; set; }
    public required string Email { get; set; }
    public required string PasswordHash { get; set; }
    public long CreatedTs { get; set; }
    public long LastUpddatedTs { get; set; }
}
