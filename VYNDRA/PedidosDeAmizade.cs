using Microsoft.AspNetCore.SignalR.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VYNDRA.Cards;
using VYNDRA.Classes;

namespace VYNDRA
{

    public partial class PedidosDeAmizade : Form
    {
        public static EventHandler<string> NovaSolicitacaoRecebida;
        public PedidosDeAmizade()
        {
            InitializeComponent();
            NovaSolicitacaoRecebida += PedidosDeAmizade_NovaSolicitacaoRecebida;
        }



        private void PedidosDeAmizade_Load(object sender, EventArgs e)
        {
            var dao = new PedidoAmizadeDAO();
            var solicitacoesPendentes = dao.ListarPendentes(Sessao.IdUsuario);

            foreach (var solicitacao in solicitacoesPendentes)
            {
                // Verifica se a solicitação contém o DeUsuario
                int deUsuarioId = solicitacao.ParaUsuario;
                Debug.WriteLine("Tentando buscar o usuário com id: " + deUsuarioId);

                var usuario = Users.BuscarPorId(deUsuarioId);

                
                if (usuario == null)
                {
                    MessageBox.Show("Não foi possível encontrar o usuário com ID: " + deUsuarioId);
                    Debug.WriteLine("Erro: Usuário com ID " + deUsuarioId + " não encontrado.");
                    continue;
                }
                else
                {
                    Debug.WriteLine("Usuário encontrado: " + usuario.NomeExibicao);
                }

                // Verifica se a foto não é nula antes de tentar criar o MemoryStream
                byte[] fotoBytes = usuario.FotoPerfil ?? new byte[0];
                MemoryStream fotoStream = new MemoryStream(fotoBytes);

                // Cria o cartão de solicitação
                var cartao = CriarCartaoSolicitacao(usuario.Id, usuario.Usuario, fotoStream);
                lista_layout.Controls.Add(cartao);
            }
        }



        private void voltar_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async void sendadd_btn_Click(object sender, EventArgs e)
        {
            string loginDestino = pesquisa_txt.Text.Trim();
            if (string.IsNullOrWhiteSpace(loginDestino))
            {
                MessageBox.Show("Informe o usuário destino.");
                return;
            }

            try
            {
                var usuarioDestino = Users.BuscarPorLogin(loginDestino);
                if (usuarioDestino == null)
                {
                    MessageBox.Show("Usuário não encontrado.");
                    return;
                }

                int meuId = Sessao.IdUsuario;
                int idDestino = usuarioDestino.Id;

                await SignalRService.VerificarConexaoAsync();
                Debug.WriteLine("[SignalR] Antes do InvokeAsync com estado: " + SignalRService.Connection.State);
                await SignalRService.Connection.InvokeAsync("EnviarSolicitacaoAmizade", idDestino, meuId);
                MessageBox.Show("Solicitação enviada com sucesso!");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro: {ex.GetType().Name} – {ex.Message}");
                Debug.WriteLine("[SignalR] Erro no InvokeAsync: " + ex);
            }
        }

        private void PedidosDeAmizade_NovaSolicitacaoRecebida(object sender, string deIdUsuario)
        {
            Debug.WriteLine("Evento NovaSolicitacaoRecebida disparado com id: " + deIdUsuario);

            if (this.IsHandleCreated)
            {
                this.Invoke((MethodInvoker)(() =>
                {
                    int id;
                    try
                    {
                        id = int.Parse(deIdUsuario);
                        Debug.WriteLine("Id convertido: " + id);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erro ao converter id de usuário: " + ex.Message);
                        return;
                    }

                    var usuario = Users.BuscarPorId(id);
                    Debug.WriteLine(usuario == null ? "Usuário não encontrado." : "Usuário encontrado: " + usuario.NomeExibicao);

                    try
                    {
                        if (usuario != null)
                        {
                            var FotoStream = new MemoryStream(usuario.FotoPerfil ?? new byte[0]);
                            var cardsolicitacao = CriarCartaoSolicitacao(usuario.Id,usuario.Usuario, FotoStream);
                            lista_layout.Controls.Add(cardsolicitacao);
                        }
                        else
                        {
                            MessageBox.Show("Não foi possível encontrar o usuário que enviou a solicitação.");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erro ao criar cartão de solicitação: " + ex.Message);
                        Debug.WriteLine("Erro ao criar cartão de solicitação: " + ex);
                    }
                }));
            }

            else
            {
                MessageBox.Show("Evento nao disparado!");
            }
        }


        public Control CriarCartaoSolicitacao(int UsuarioID,string usuario, Stream FotoUsuario)
        {
            var cartao = new AccRecAmizade();

            byte[] fotoBytes;

            if (FotoUsuario != null)
            {
                using (var memoryStream = new MemoryStream())
                {
                    FotoUsuario.CopyTo(memoryStream);
                    fotoBytes = memoryStream.ToArray();
                }
            }
            else
            {
                fotoBytes = Array.Empty<byte>();
            }

            cartao.Username = usuario;
            if (fotoBytes.Length > 0)
            {
                using (MemoryStream ms = new MemoryStream(fotoBytes))
                {
                    cartao.UserPhoto = Bitmap.FromStream(ms);
                }
            }

            cartao.UsuarioId = UsuarioID;

            cartao.BtnAceitar.Click += async (s, e) =>
            {
                try
                {
                    var dao = new PedidoAmizadeDAO();
                    Debug.WriteLine("Aceitando pedido de amizade para usuário ID: " + cartao.UsuarioId);
                    await dao.AceitarPedido(cartao.UsuarioId);

                    lista_layout.Controls.Remove(cartao);

                    MessageBox.Show("Solicitação aceita!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao aceitar solicitação: " + ex.Message);
                }
            };

            cartao.BtnRecusar.Click += async (s, e) =>
            {
                try
                {
                    var dao = new PedidoAmizadeDAO();
                    await dao.RemoverPedido(Sessao.IdUsuario, cartao.UsuarioId);

                    lista_layout.Controls.Remove(cartao);

                    MessageBox.Show("Solicitação recusada.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao recusar solicitação: " + ex.Message);
                }
            };

            return cartao;
        }
    }
}
