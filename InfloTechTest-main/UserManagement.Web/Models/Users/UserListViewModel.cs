namespace UserManagement.Web.Models.Users;
using System;

public class UserListViewModel
{
    public List<UserListItemViewModel> Items { get; set; } = new();

    public int CurrentPage { get; set; }
    public int TotalPages { get; set; }
    public int PageSize { get; set; }
    public int TotalItems { get; set; }

    public bool? IsActiveFilter { get; set; }
}


public class UserListItemViewModel
{
    public long Id { get; set; }
    public string? Forename { get; set; }
    public string? Surname { get; set; }
    public string? Email { get; set; }
    public DateTime DateOfBirth { get; set; }
    public bool IsActive { get; set; }
}
