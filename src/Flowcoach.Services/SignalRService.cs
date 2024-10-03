namespace FlowCoach.App;
using Microsoft.AspNetCore.Components;

public class SignalRService : IAsyncDisposable
{
    public SignalRService(NavigationManager navigationManager)
    {

    }
    public ValueTask DisposeAsync()
    {
        return default;
    }


}



