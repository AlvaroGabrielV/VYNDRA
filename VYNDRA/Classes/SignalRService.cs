using Microsoft.AspNetCore.SignalR.Client;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Windows.Forms;
using VYNDRA;
using VYNDRA.Classes;

public static class SignalRService
{
    public static HubConnection Connection { get; private set; }

    private static int _idUsuario;
    private static bool _iniciado = false;

    public static async Task IniciarAsync(int idUsuario)
    {
        _idUsuario = idUsuario;

        if (_iniciado) return;

        await CriarNovaConexaoAsync();
        ConfigurarListeners();
        _iniciado = true;
    }

    public static event Action<List<Mensagem>> MensagensCarregadas;
    // Atualizado para 4 parâmetros (id remetente, id destinatário, mensagem, data)
    public static event Action<int, int, string, DateTime> MensagemRecebidaPrivada;

    public static void ConfigurarListeners()
    {
        Connection.On<string>("ReceberSolicitacaoAmizade", (deIdUsuario) =>
        {
            MessageBox.Show($"Nova solicitação de amizade de {deIdUsuario}");
            PedidosDeAmizade.NovaSolicitacaoRecebida?.Invoke(null, deIdUsuario);
        });

        // Ajuste aqui: receber 4 parâmetros e chamar o evento com os mesmos
        Connection.On<int, int, string, DateTime>("ReceberMensagemPrivada", (remetenteId, destinatarioId, mensagem, horario) =>
        {
            if (destinatarioId == _idUsuario || remetenteId == _idUsuario)
            {
                MensagemRecebidaPrivada?.Invoke(remetenteId, destinatarioId, mensagem, horario);
                Debug.WriteLine($"[SignalR] Mensagem recebida de {remetenteId}: {mensagem}");
            }
        });

        Connection.On<List<Mensagem>>("MensagensCarregadas", (mensagens) =>
        {
            Debug.WriteLine($"[SignalRService] Mensagens carregadas recebidas: {mensagens.Count} mensagens.");
            MensagensCarregadas?.Invoke(mensagens);
        });
    }

    public static async Task CriarNovaConexaoAsync()
    {
        if (Connection != null)
        {
            try { await Connection.StopAsync(); } catch { }
            try { await Connection.DisposeAsync(); } catch { }
        }

        Connection = new HubConnectionBuilder()
            .WithUrl("http://localhost:5000/chatHub")
            .WithAutomaticReconnect()
            .Build();

        try
        {
            await Connection.StartAsync();
            Debug.WriteLine($"[SignalR] Conectado: {Connection.ConnectionId}");

            if (_idUsuario != 0)
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
