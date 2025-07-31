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
                var usuario = Users.BuscarPorLogin(solicitacao.DeUsuario);
                var cartao = CriarCartaoSolicitacao(usuario);
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

                string meuId = Sessao.IdUsuario.ToString();
                string idDestino = usuarioDestino.Id.ToString();

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
            if (this.IsHandleCreated)
            {
                this.Invoke((MethodInvoker)(() =>
                {
                    var usuario = Users.BuscarPorLogin(Sessao.UsuarioLogin);
                    var cardsolicitacao = CriarCartaoSolicitacao(usuario);
                    lista_layout.Controls.Add(cardsolicitacao);
                }));
            }
        }

        public Control CriarCartaoSolicitacao(Users usuario)
        {

            var cartao = new AccRecAmizade();

            
            cartao.Username = usuario.NomeExibicao;

            
            if (usuario.FotoPerfil != null)
            {
                using (var ms = new MemoryStream(usuario.FotoPerfil))
                {
                    cartao.UserPhoto = Image.FromStream(ms); 
                }
            }
            else
            {
                
                cartao.foto_user.Image = Properties.Resources.danger;
            }

            // Guarda o ID do usuário no Tag para referência
            cartao.Tag = usuario.Id;

            cartao.BtnAceitar.Click += async (s, e) =>
            {
                try
                {
                    var dao = new PedidoAmizadeDAO();
                    await dao.AceitarPedido(usuario.Id);

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
                    await dao.RemoverPedido(Sessao.IdUsuario, usuario.Id);

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
