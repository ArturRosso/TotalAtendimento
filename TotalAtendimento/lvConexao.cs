using MetroFramework.Controls;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace TotalAtendimento
{
    public partial class lvConexao : MetroListView
    {
        public const int STATUS_CONECTADO = 1;
        public const int STATUS_DESCONECTADO = 0;

        public const int COLUNA_NOME = 0;
        public const int COLUNA_STATUS = 1;
        public const int COLUNA_NOTIFICACAOES = 2;
        public const int COLUNA_ENDERECO = 3;
        public const int COLUNA_MESA = 4;

        public const int GRUPO_CONECTADO = 1;
        public const int GRUPO_DESCONECTADO = 0;

        private string isIMEI = "";
        public string IsIMEI { get => isIMEI; }

        private string isNome = "";
        public string IsNome { get => isNome; }

        private string isEndereco = "";
        public string IsEndereco { get => isEndereco; }

        private int iiStatus = STATUS_DESCONECTADO;
        public int IiStatus { get => iiStatus; }

        private int iiNotificacoes = 0;
        public int IiNotificacoes { get => iiNotificacoes; }

        private int iiMesa = 0;
        public int IiMesa { get => iiMesa; }

        private ListViewItem ilviLinhaSelecionada;
        public ListViewItem IlviLinhaSelecionada { get => ilviLinhaSelecionada; }

        public lvConexao()
        {
            InitializeComponent();
        }

        public string GetValor(String asIMEI, int aiColuna)
        {
            if (!this.Items.ContainsKey(asIMEI)) return null;

            if (aiColuna == COLUNA_STATUS)
            {
                return this.Items[this.Items.IndexOfKey(asIMEI)].SubItems[aiColuna].Tag.ToString();
            }
            else
            {
                return this.Items[this.Items.IndexOfKey(asIMEI)].SubItems[aiColuna].Text;
            }

        }

        public bool SetIMEI(string asIMEI)
        {
            if (ilviLinhaSelecionada.Equals(null)) return false;

            isIMEI = asIMEI;

            ilviLinhaSelecionada.Name = asIMEI;

            return true;
        }

        public bool SetNome(string asNome)
        {
            if (ilviLinhaSelecionada.Equals(null)) return false;

            isNome = asNome;

            return SetNome(asNome, ilviLinhaSelecionada);
        }

        public bool SetNome(string asNome, string asIMEI)
        {
            if (!this.Items.ContainsKey(asIMEI)) return false;

            return SetNome(asNome, this.Items[this.Items.IndexOfKey(asIMEI)]);
        }

        private bool SetNome(string asNome, ListViewItem alviLinha)
        {
            alviLinha.SubItems[COLUNA_NOME].Text = asNome;

            return true;
        }

        public bool SetStatus(int aiStatus)
        {
            if (ilviLinhaSelecionada.Equals(null)) return false;

            iiStatus = aiStatus;

            return SetStatus(aiStatus, ilviLinhaSelecionada);
        }

        public bool SetStatus(int aiStatus, string asIMEI)
        {
            if (!this.Items.ContainsKey(asIMEI)) return false;

            return SetStatus(aiStatus, this.Items[this.Items.IndexOfKey(asIMEI)]);
        }

        private bool SetStatus(int aiStatus, ListViewItem alviLinha)
        {
            ListViewGroup llvgGrupo;
            Color lclStatus;

            if (aiStatus == 1)
            {
                lclStatus = Color.Green;
                llvgGrupo = this.Groups[GRUPO_CONECTADO];
            }
            else
            {
                lclStatus = Color.Red;
                llvgGrupo = this.Groups[GRUPO_DESCONECTADO];
            }

            alviLinha.SubItems[COLUNA_STATUS].ForeColor = lclStatus;
            alviLinha.SubItems[COLUNA_STATUS].Tag = aiStatus;
            alviLinha.Group = llvgGrupo;

            return true;
        }

        public bool SetEndereco(string asEndereco)
        {
            if (ilviLinhaSelecionada.Equals(null)) return false;

            isEndereco = asEndereco;

            return SetEndereco(asEndereco, ilviLinhaSelecionada);
        }

        public bool SetEndereco(string asEndereco, string asIMEI)
        {
            if (!this.Items.ContainsKey(asIMEI)) return false;

            return SetEndereco(asEndereco, this.Items[this.Items.IndexOfKey(asIMEI)]);
        }

        private bool SetEndereco(string asEndereco, ListViewItem alviLinha)
        {
            alviLinha.SubItems[COLUNA_ENDERECO].Text = asEndereco;

            return true;
        }

        public bool SetMesa(int aiMesa)
        {
            if (ilviLinhaSelecionada.Equals(null)) return false;

            iiMesa = aiMesa;

            return SetMesa(aiMesa, ilviLinhaSelecionada);
        }

        public bool SetMesa(int aiMesa, string asIMEI)
        {
            if (!this.Items.ContainsKey(asIMEI)) return false;

            return SetMesa(aiMesa, this.Items[this.Items.IndexOfKey(asIMEI)]);
        }

        private bool SetMesa(int aiMesa, ListViewItem alviLinha)
        {
            alviLinha.SubItems[COLUNA_MESA].Text = aiMesa.ToString();

            return true;
        }

        public bool AddNotificacao(string asIMEI)
        {
            int liNotificacoes = 0;
            ListViewItem llviLinha;

            if (!this.Items.ContainsKey(asIMEI)) return false;

            llviLinha = this.Items[this.Items.IndexOfKey(asIMEI)];

            if (llviLinha.SubItems[COLUNA_NOTIFICACAOES].Text != "")
                liNotificacoes = Convert.ToInt32(llviLinha.SubItems[COLUNA_NOTIFICACAOES].Text);

            liNotificacoes += 1;

            return AddNotificacao(llviLinha, liNotificacoes);
        }

        public bool AddNotificacao()
        {
            if (ilviLinhaSelecionada.Equals(null)) return false;

            iiNotificacoes += 1;

            return AddNotificacao(ilviLinhaSelecionada, iiNotificacoes);
        }

        private bool AddNotificacao(ListViewItem alviLinha, int aiNotificacoes)
        {
            int liStatus;

            alviLinha.SubItems[COLUNA_NOTIFICACAOES].Text = aiNotificacoes.ToString();
            alviLinha.Font = new Font(Font, FontStyle.Bold);

            liStatus = Convert.ToInt16(alviLinha.SubItems[COLUNA_STATUS].Tag);

            if (liStatus == STATUS_DESCONECTADO)
            {
                this.Items.RemoveByKey(alviLinha.Name);
                this.Items.Insert(0, alviLinha);
                alviLinha.Group = this.Groups[GRUPO_DESCONECTADO];
            }
            else
            {
                for (int i = 0; i < this.Items.Count; i++)
                {
                    if (Convert.ToInt16(this.Items[i].SubItems[COLUNA_STATUS].Tag) == STATUS_CONECTADO)
                    {
                        this.Items.RemoveByKey(alviLinha.Name);
                        this.Items.Insert(i, alviLinha);
                        alviLinha.Group = this.Groups[GRUPO_CONECTADO];

                        break;
                    }
                }
            }

            return true;
        }

        public bool RemoveNotificacoes()
        {
            if (ilviLinhaSelecionada == null) return false;

            iiNotificacoes = 0;

            ilviLinhaSelecionada.SubItems[COLUNA_NOTIFICACAOES].Text = "";

            ilviLinhaSelecionada.Font = new Font(Font, FontStyle.Regular);

            return true;
        }

        public void RemoveLinha()
        {
            IlviLinhaSelecionada.Remove();

            if (this.Items.Count == 0)
            {
                isIMEI = "";
                isNome = "";
                isEndereco = "";
                iiStatus = STATUS_DESCONECTADO;
                iiNotificacoes = 0;
                iiMesa = 0;
                ilviLinhaSelecionada = null;
            }
        }

        public bool SetLinhaSelecionada(string asIMEI)
        {
            if (!this.Items.ContainsKey(asIMEI))
            {
                return false;
            }

            SelecionaLinha(this.Items[this.Items.IndexOfKey(asIMEI)]);

            return true;
        }

        public string GetIMEIEndereco(string asEndereco)
        {
            foreach (ListViewItem lvi in this.Items)
                if (lvi.SubItems[COLUNA_ENDERECO].Text == asEndereco)
                    return lvi.Name;

            return "";
        }

        public void AdicionarConexao(string asIMEI, string asNome, string asEndereco, int aiMesa)
        {
            ListViewItem llviNovaLinha = new ListViewItem(new string[] { asNome, "•", "", asEndereco, aiMesa.ToString() });
            llviNovaLinha.UseItemStyleForSubItems = false;

            llviNovaLinha.SubItems[COLUNA_STATUS].ForeColor = Color.Green;
            llviNovaLinha.SubItems[COLUNA_STATUS].Font = new Font(Font.FontFamily, 40);

            llviNovaLinha.SubItems[COLUNA_STATUS].Tag = STATUS_CONECTADO;
            llviNovaLinha.Name = asIMEI;

            this.Items.Add(llviNovaLinha);

            llviNovaLinha.Group = this.Groups[GRUPO_CONECTADO];
        }

        public bool PossuiLinhaSelecionada()
        {
            return this.SelectedIndices.Count > 0;
        }

        private void SelecionaLinha(ListViewItem alviLinhaSelecionar)
        {
            if (!alviLinhaSelecionar.Selected)
                alviLinhaSelecionar.Selected = true;
            ilviLinhaSelecionada = alviLinhaSelecionar;
            isIMEI = alviLinhaSelecionar.Name;
            isNome = alviLinhaSelecionar.SubItems[COLUNA_NOME].Text;
            isEndereco = alviLinhaSelecionar.SubItems[COLUNA_ENDERECO].Text;
            iiStatus = Convert.ToInt16(alviLinhaSelecionar.SubItems[COLUNA_STATUS].Tag);
            iiMesa = Convert.ToInt32(alviLinhaSelecionar.SubItems[COLUNA_MESA].Text);

            RemoveNotificacoes();
        }

        public void MoverItemGrupo(ListViewItem alviLinha, ListViewGroup alvpGrupo, int aiIndexInGroup)
        {
            alvpGrupo.ListView.BeginUpdate();
            ListViewItem[] items = new ListViewItem[alvpGrupo.Items.Count + 1];
            alvpGrupo.Items.CopyTo(items, 0);
            Array.Copy(items, aiIndexInGroup, items, aiIndexInGroup + 1, alvpGrupo.Items.Count - aiIndexInGroup);
            items[aiIndexInGroup] = alviLinha;
            for (int i = 0; i < items.Length; i++)
                items[i].Group = null;
            for (int i = 0; i < items.Length; i++)
                alvpGrupo.Items.Add(items[i]);
            alvpGrupo.ListView.EndUpdate();
        }

        private void lvConexao_ColumnWidthChanging(object sender, ColumnWidthChangingEventArgs e)
        {
            e.NewWidth = this.Columns[e.ColumnIndex].Width;
            e.Cancel = true;
        }

        private void lvConexao_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {

            if (e.IsSelected)
            {
                this.SelecionaLinha(e.Item);
            }
        }
    }
}
