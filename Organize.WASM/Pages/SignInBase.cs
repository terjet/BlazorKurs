using Microsoft.AspNetCore.Components;
using Organize.Shared.Entities;

namespace Organize.WASM.Pages;

public class SignInBase : ComponentBase
{
    protected User User { get; set; } = new User();

    protected string Username { get; set; } = "Username";
    protected string Day { get; set; } = DateTime.Now.DayOfWeek.ToString();

    //private void HandleUsernameChanged(ChangeEventArgs changeEventArgs)
    //{
    // Username = changeEventArgs?.Value?.ToString();
    // if (string.IsNullOrEmpty(Username)) Username = "User";
    //}

    private void HandleUsernameValueChanged(string value)
    {
        Username = value;
    }
}
