using Microsoft.AspNetCore.SignalR.Client;
using System.Diagnostics;
using VYNDRA;

public static class SignalRService
{
    public static HubConnection Connection { get; private set; }
    private static string _idUsuario;
    private static bool _iniciado = false;

    public static async Task IniciarAsync(string idUsuario)
    {
        _idUsuario = idUsuario;
        if (_iniciado) return;
        await CriarNovaConexaoAsync();
        ConfigurarListeners();
        _iniciado = true;
    }

    public static void ConfigurarListeners()
    {
        Connection.On<string>("ReceberSolicitacaoAmizade", (deIdUsuario) =>
        {
            // Exemplo básico com MessageBox
            MessageBox.Show($"Nova solicitação de amizade de {deIdUsuario}");

            // Opcional: notificar seu formulário com evento ou atualizar controle estático
            PedidosDeAmizade.NovaSolicitacaoRecebida?.Invoke(null, deIdUsuario);
        });
    }


    public static async Task CriarNovaConexaoAsync()
    {
        if (Connection != null)
        {
            try { await Connection.StopAsync(); }
            catch (Exception ignored) { }
            try { await Connection.DisposeAsync(); }
            catch (Exception ignored) { }
        }

        Connection = new HubConnectionBuilder()
            .WithUrl("http://localhost:5000/chatHub")
            .WithAutomaticReconnect()
            .Build();

        try
        {
            await Connection.StartAsync();
            Debug.WriteLine($"[SignalR] Conectado: {Connection.ConnectionId}");
            if (!string.IsNullOrEmpty(_idUsuario))
            {
                await Connection.InvokeAsync("RegistrarUsuario", _idUsuario);
                Debug.WriteLine($"[SignalR] Registrado: {_idUsuario}");
            }
        }
        catch (Exception ex)
        {
            Debug.WriteLine("[SignalR] Falha ao conectar: " + ex);
            throw;
        }
    }

    public static async Task VerificarConexaoAsync()
    {
        if (Connection == null || Connection.State == HubConnectionState.Disconnected)
        {
            Debug.WriteLine("[SignalR] Reconectando...");
            await CriarNovaConexaoAsync();
        }
        else
        {
            Debug.WriteLine($"[SignalR] Estado OK: {Connection.State}");
        }
    }
}
