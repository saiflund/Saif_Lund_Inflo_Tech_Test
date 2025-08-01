using System;
using System.ComponentModel.DataAnnotations;

namespace UserManagement.Web.Models.Users;
public class EditUserViewModel
{
    public long Id { get; set; }
    public string Forename { get; set; } = string.Empty;
    public string Surname { get; set; } = string.Empty;
    [Required]
    [EmailAddress]
    public string Email { get; set; } = string.Empty;
    [NotInFuture(ErrorMessage = "Date of birth cannot be in the future.")]
    public DateTime DateOfBirth { get; set; }
    public bool IsActive { get; set; }
}
