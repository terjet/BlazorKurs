using Microsoft.AspNetCore.Components;

namespace Organize.WASM.Controls;

public class ValidationInputBase : ComponentBase
{
    [Parameter]
    public EventCallback<string> ValueChanged { get; set; }

    [Parameter]
    public string Value { get; set; }
}
