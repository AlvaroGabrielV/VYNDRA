using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VYNDRA.Classes;

namespace VYNDRA
{
    public partial class Relatorios : Form
    {
        public Relatorios(int IdUsuario)
        {
            InitializeComponent();
            Sessao.IdUsuario = IdUsuario;
        }

        private void Relatorios_Load(object sender, EventArgs e)
        {
            var usuario = Users.BuscarPorId(Sessao.IdUsuario); // Buscar usuário com dados completos

            if (usuario != null && usuario.FotoPerfil != null && usuario.FotoPerfil.Length > 0)
            {
                using (MemoryStream ms = new MemoryStream(usuario.FotoPerfil))
                {
                    miniFotoPerfil.Image = Image.FromStream(ms);
                }
            }
            else
            {
                miniFotoPerfil.Image = null;
            }

            CarregarCards();
        }
        public void CarregarCards()
        {
            FlowPanelConteudo.Controls.Clear();

            // Botão de adicionar tarefa
            CardAdicionarTarefa botaoAdicionar = new CardAdicionarTarefa();
            botaoAdicionar.BotaoClicado += BotaoAdicionar_Click;
            FlowPanelConteudo.Controls.Add(botaoAdicionar);

            // Carregar as tarefas do usuário
            List<RelatoriosClasse> relatorios = RelatoriosClasse.ListarPorUsuario(Sessao.IdUsuario);

            foreach (var rel in relatorios)
            {
                CardTarefas card = new CardTarefas();
                card.IdRelatorio = rel.IdRelatorio;
                card.Titulo = rel.Titulo;
                card.Descricao = rel.Descricao;
                card.DataCriacao = rel.DataCriacao;
                card.ExlcuirTarefasClicado += NovaTarefa_ExlcuirTarefasClicado;
                card.EditarTarefaClicada += NovaTarefa_EditarTarefaClicada;

                FlowPanelConteudo.Controls.Add(card);
                FlowPanelConteudo.Controls.SetChildIndex(card, FlowPanelConteudo.Controls.Count - 1);
            }
        }

        public void BotaoAdicionar_Click(object sender, EventArgs e)
        {
            int totalTarefas = FlowPanelConteudo.Controls.OfType<CardTarefas>().Count();

            if (totalTarefas >= 7)
            {
                MessageBox.Show("O espaço máximo de anotações foi atingido.", "Limite atingido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            BlocodeNotas bloco = new BlocodeNotas();
            bloco.ShowDialog();

            if (bloco.SalvoComSucesso)
            {
                RelatoriosClasse novoRelatorio = new RelatoriosClasse
                {
                    IdUsuario = Sessao.IdUsuario,
                    Titulo = bloco.Titulo,
                    Descricao = bloco.Descricao,
                    DataCriacao = DateTime.Now
                };
                novoRelatorio.Inserir();

                CardTarefas novaTarefa = new CardTarefas
                {
                    Titulo = bloco.Titulo,
                    Descricao = bloco.Descricao,
                    DataCriacao = DateTime.Now
                };



                novaTarefa.ExlcuirTarefasClicado += NovaTarefa_ExlcuirTarefasClicado;
                novaTarefa.EditarTarefaClicada += NovaTarefa_EditarTarefaClicada;

                int indexBotaoMais = FlowPanelConteudo.Controls.IndexOf((Control)sender);
                FlowPanelConteudo.Controls.Add(novaTarefa);
                FlowPanelConteudo.Controls.SetChildIndex(novaTarefa, indexBotaoMais);
                CarregarCards();
            }
        }

        private void NovaTarefa_EditarTarefaClicada(object? sender, EventArgs e)
        {
            CardTarefas tarefaSelecionada = sender as CardTarefas;

            if (tarefaSelecionada == null)
                return;

            BlocodeNotas bloco = new BlocodeNotas
            {
                Titulo = tarefaSelecionada.Titulo,
                Descricao = tarefaSelecionada.Descricao
            };

            bloco.ShowDialog();

            if (bloco.SalvoComSucesso)
            {
                tarefaSelecionada.Titulo = bloco.Titulo;
                tarefaSelecionada.Descricao = bloco.Descricao; ;

                RelatoriosClasse atualizar = new RelatoriosClasse
                {
                    IdRelatorio = tarefaSelecionada.IdRelatorio,
                    Titulo = bloco.Titulo,
                    Descricao = bloco.Descricao,
                    DataCriacao = tarefaSelecionada.DataCriacao,
                    IdUsuario = Sessao.IdUsuario
                };

                atualizar.Atualizar();
            }
        }


        private void NovaTarefa_ExlcuirTarefasClicado(object? sender, int e)
        {
            try
            {
                RelatoriosClasse relatorios = new RelatoriosClasse();
                relatorios.IdUsuario = Sessao.IdUsuario;

                if (relatorios.Excluir(e))
                {
                    FlowPanelConteudo.Controls.Remove((CardTarefas)sender);
                    MessageBox.Show("Relatório excluído com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CarregarCards();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Não foi possível excluir tarefa", "Erro - Exclusão", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            TelaPrincipal telaPrincipal = new TelaPrincipal(Sessao.IdUsuario);
            telaPrincipal.Show();
            this.Close();
        }

        private void miniFotoPerfil_Click(object sender, EventArgs e)
        {
            Perfil perfil = new Perfil(Sessao.IdUsuario);
            perfil.Show();
            this.Close();
        }

        private void btnMenssagem_Click(object sender, EventArgs e)
        {
            TelaPrincipal telaPrincipal = new TelaPrincipal(Sessao.IdUsuario);
            telaPrincipal.Show();
            this.Close();
        }

        private void btnFechar1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMinimizar1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
