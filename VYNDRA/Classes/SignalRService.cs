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

    public static event Action<int, int, string, DateTime> MensagemRecebidaPrivada;

    public static void ConfigurarListeners()
    {
        // Recebe solicitações de amizade
        Connection.On<string>("ReceberSolicitacaoAmizade", (deIdUsuario) =>
        {
            MessageBox.Show($"Nova solicitação de amizade de {deIdUsuario}");
            PedidosDeAmizade.NovaSolicitacaoRecebida?.Invoke(null, deIdUsuario);
        });

        // Recebe mensagens privadas
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

        Connection.On<int>("UsuarioConectado", (idUsuario) =>
        {
            StatusUsuarios.SetOnline(idUsuario);
            Debug.WriteLine($"[SignalR] Usuário online: {idUsuario}");
        });

        Connection.On<int>("UsuarioDesconectado", (idUsuario) =>
        {
            StatusUsuarios.SetOffline(idUsuario);
            Debug.WriteLine($"[SignalR] Usuário offline: {idUsuario}");
        });

        Connection.On<List<int>>("ListaUsuariosOnline", (idsUsuarios) =>
        {
            foreach (var id in idsUsuarios)
            {
                StatusUsuarios.SetOnline(id);
                Debug.WriteLine($"[SignalR] Usuário já estava online: {id}");
            }
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
            .WithUrl("http://18.228.153.48:5000/chatHub")
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
