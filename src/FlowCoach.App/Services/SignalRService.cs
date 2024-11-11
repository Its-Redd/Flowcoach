using Microsoft.AspNetCore.SignalR.Client;

namespace FlowCoach.App.wwwroot.Services
{
    public class SignalRService
    {
        private readonly HubConnection hubConnection;
        public SignalRService(string HubUrl)
        {
            hubConnection = new HubConnectionBuilder()
                .WithUrl(HubUrl)
                .Build();

        }

        public async Task Connect()
        {
            await hubConnection.StartAsync();
        }

        public async Task Disconnect()
        {
            await hubConnection.StopAsync();
        }




    }
}
