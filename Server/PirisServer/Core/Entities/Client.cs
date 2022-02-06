namespace Core.Entities;
public class Client
{
    public long Id {get;set;}
    public string Firstname {get;set;}
    public string Lastname {get;set;}
    public string Middlename { get; set; }
    public DateTime DateOfBirth { get; set; }
    public string PassportSeries { get; set; }
    public string PassportNumber { get; set; }
    public string Issuer { get; set; }
    public DateTime DateOfIssue { get; set; }
    public int CityId { get; set; }
    public string Address { get; set; }
    public string? PhoneNumber { get; set; }
    public string? MobilePhoneNumber { get; set; }
    public string? Email { get; set; }
    public string? Workplace { get; set; }
    public string? Position { get; set; }
    public int RegistrationCityId { get; set; }
    public int MaritalStatusid { get; set; }
    public int CitizenshipId{ get; set; }
    public int DisabilityId { get; set; }
    public bool IsPensioner { get; set; }
    public decimal? Salary { get; set; }

    public City City { get; set; }
    public City RegistrationCity { get; set; }
    public MaritalStatus MaritalStatus { get; set; }
    public Citizenship Citizenship { get; set; }
    public Disability Disability { get; set; }
}
