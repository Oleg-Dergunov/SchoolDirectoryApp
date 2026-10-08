namespace SchoolDirectoryApp.Models;

public class School
{
    public int SchoolId { get; set; }
    public string SchoolName { get; set; } = string.Empty;
    public string Address { get; set; } = string.Empty;
    public string PhoneNo { get; set; } = string.Empty;
    public string EmailAddress { get; set; } = string.Empty;
    public string ProprietorFullName { get; set; } = string.Empty;
    public string HeadFullName { get; set; } = string.Empty;
}