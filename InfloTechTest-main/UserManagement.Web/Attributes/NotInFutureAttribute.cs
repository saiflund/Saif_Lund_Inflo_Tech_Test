using System;
using System.ComponentModel.DataAnnotations;
public class NotInFutureAttribute : ValidationAttribute
{
    public override bool IsValid(object? value)
    {
        if (value is DateTime date)
        {
            return date <= DateTime.Today;
        }

        return true;
    }

    public override string FormatErrorMessage(string name)
    {
        return $"{name} cannot be in the future.";
    }
}
