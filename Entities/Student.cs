using System;

public class Student
{
    public int Id { get; set; }
	public string FirstName { get; set; } = string.Empty;
    public string LastName { get; set; } = string.Empty;
    public string Email { get; set; } = string.Empty;
    public string Password { get; set; } = string.Empty;
    public string Phone { get; set; } = string.Empty;
	public string PostalCode { get; set; } = string.Empty;
	public string Country { get; set; } = string.Empty;
	public bool IsActive { get; set; }=true;
    public DateTime CreatedAt { get; set; } = DateTime.Now;

	/*public Student(string firstName, string lastName, string email, string password, string phone, string postalCode, string country, bool isActive)
    {
        FirstName = firstName;
        LastName = lastName;
        Email = email;
        Password = password;
        Phone = phone;
        PostalCode = postalCode;
        Country = country;
        IsActive = isActive;
    }*/
}
