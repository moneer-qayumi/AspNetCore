namespace Infrastructure.Entities;

public class AddressEntity
{
  
    public string UserId { get; set; } = null!;
    public int Id { get; set; }
    public string StreetName { get; set; } = null!;
    public string PostalCode { get; set; } = null!;
    public string City { get; set; } = null!;
    public string? AddressLine_1 { get; set; }
    public string? AddressLine_2 { get; set; }

    public ICollection<UserEntity> Users { get; set; } = [];
}
