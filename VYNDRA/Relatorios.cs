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
            miniFotoPerfil.SizeMode = PictureBoxSizeMode.Zoom;

            Users usuario = new Users();

            if (usuario.CarregarRedesSociais(Sessao.IdUsuario) && Sessao.FotoPerfil != null && Sessao.FotoPerfil.Length > 0)
{
                using (MemoryStream ms = new MemoryStream(Sessao.FotoPerfil))
                {
                    miniFotoPerfil.Image = Image.FromStream(ms);
                }
            }
            else
            {
                miniFotoPerfil.Image = null;
            }

            CardAdicionarTarefa botaoAdicionar = new CardAdicionarTarefa();
            botaoAdicionar.BotaoClicado += BotaoAdicionar_Click;
            FlowPanelConteudo.Controls.Add(botaoAdicionar);

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

        private void BotaoAdicionar_Click(object sender, EventArgs e)
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
            }
        }
        private void NovaTarefa_EditarTarefaClicada(object? sender, EventArgs e)
        {
            CardTarefas card = sender as CardTarefas;

            RelatoriosClasse relatorioAtualizado = new RelatoriosClasse
            {
                IdRelatorio = card.IdRelatorio,
                Titulo = card.Titulo,
                Descricao = card.Descricao,
                IdUsuario = Sessao.IdUsuario
            };

            if (relatorioAtualizado.Atualizar())
            {
                MessageBox.Show("Tarefa atualizada com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Erro ao atualizar tarefa!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            Menu menu = new Menu(Sessao.IdUsuario);
            menu.Show();
            this.Close();
        }

        private void miniFotoPerfil_Click(object sender, EventArgs e)
        {
            Perfil perfil = new Perfil(Sessao.IdUsuario);
            perfil.Show();
            this.Close();
        }
    }
}
