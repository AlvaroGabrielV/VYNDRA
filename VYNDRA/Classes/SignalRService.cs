using Microsoft.AspNetCore.SignalR.Client;
using System.Diagnostics;
using VYNDRA;
using VYNDRA.Cards;

public static class SignalRService
{
    public static HubConnection Connection { get; private set; }
    private static int _idUsuario;
    private static bool _iniciado = false;
    private static int _idContatoAtivo;

    public static async Task IniciarAsync(int idUsuario)
    {
        _idUsuario = idUsuario;
        if (_iniciado) return;
        await CriarNovaConexaoAsync();
        ConfigurarListeners();
        _iniciado = true;
    }

    public static event Action<int, string, DateTime> MensagemRecebidaPrivada;

    public static void ConfigurarListeners()
    {
        Connection.On<string>("ReceberSolicitacaoAmizade", (deIdUsuario) =>
        {
            MessageBox.Show($"Nova solicitação de amizade de {deIdUsuario}");
            PedidosDeAmizade.NovaSolicitacaoRecebida?.Invoke(null, deIdUsuario);
        });

        Connection.On<int, string, DateTime>("ReceberMensagemPrivada", (remetenteId, texto, data) =>
        {
            
            MensagemRecebidaPrivada?.Invoke(remetenteId, texto, data);
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
            if (_idUsuario != null)
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

    // Adicione um método para definir o Id do contato ativo
    public static void DefinirIdContatoAtivo(int idContato)
    {
        _idContatoAtivo = idContato;
    }
}
