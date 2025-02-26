using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ConsultaPermissoes.DTO;
using ConsultaPermissoes.Services;
using ConsultaPermissoes.Transferencia;
using UtilsNeobetel;

namespace ConsultaPermissoes.Apresentacao {

    public partial class frmSelecionarPermissoes : Form {
        Filtros filtros = new Filtros();
        DataSet datasetDadosFiltro = new DataSet();

        List<PermissaoDTO> objLstPermissaoDTO = new List<PermissaoDTO>();


        public frmSelecionarPermissoes() {
            InitializeComponent();
        }

        private void btnSair_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void btnFechar_Click(object sender, EventArgs e) {
            this.Close();
        }



        private void CarregarDadosObjPermissoes() {
            //cursor = cursos.waitcursor;

            try {
                DadosServices dadosSevices = new DadosServices();

                var filtros = CarregarFiltros();
                datasetDadosFiltro = dadosSevices.carregaObjetoFiltro(filtros);

                //Popula lista com os dados retornados do banco de dados
                objLstPermissaoDTO = new List<PermissaoDTO>();

                objLstPermissaoDTO = datasetDadosFiltro.Tables[0].ToList<PermissaoDTO>();

                //carrega o datagriview
                UtilGeral.carregaGrid(dgvPermissao, ref objLstPermissaoDTO);

            } catch (Exception ex) {

            }

        }
        private Filtros CarregarFiltros() {

            return new Filtros {

                Tipo_IN = rdoPermissao.Checked ? 1 : 2,

                usu_usuario_IN = string.IsNullOrEmpty(txtCodUsuario.Text) ? (int?)null : Convert.ToInt32(txtCodUsuario.Text),
                per_permissao_IN = string.IsNullOrEmpty(txtCodPermissao.Text) ? (int?)null : Convert.ToInt32(txtCodPermissao.Text),

                usu_login_VC = string.IsNullOrEmpty(txtDesUsuario.Text.ToString()) ? null : txtDesUsuario.Text.ToString(),
                per_resumido_VC = string.IsNullOrEmpty(txtDesPermissao.Text.ToString()) ? null : txtDesPermissao.Text.ToString(),

            };
        }


        private void btnBuscar_Click(object sender, EventArgs e) {

            CarregarDadosObjPermissoes();

        }



        private void grdSelecionaPermissoes_CellContentClick(object sender, DataGridViewCellEventArgs e) {

        }

        private void iconButton1_Click(object sender, EventArgs e) {
            CarregarDadosObjPermissoes();
        }


        private void frmSelecionarPermissoes_Load(object sender, EventArgs e) {
            UtilGeral.formataPadrao_Grid(dgvPermissao);
            CarregarDadosObjPermissoes();   
            this.KeyPreview = true;
            this.KeyPress +=  frmSelecionarPermissoes_KeyPress;
        }

        private void dgvPermissao_CellContentClick(object sender, DataGridViewCellEventArgs e) {

        }

        private void rdoPermissao_CheckedChanged(object sender, EventArgs e) {
            if (rdoPermissao.Checked) {
                txtCodUsuario.Enabled = false;
                txtDesUsuario.Enabled = false;

                txtCodPermissao.Enabled = true;
                txtDesPermissao.Enabled = true;
                txtCodUsuario.Text = "";
                txtDesUsuario.Text = "";
            }
        }

        private void rdoUsuario_CheckedChanged(object sender, EventArgs e) {
            if (rdoUsuario.Checked) {
                txtCodPermissao.Enabled = false;
                txtDesPermissao.Enabled = false;

                txtCodUsuario.Enabled = true;
                txtDesUsuario.Enabled = true;
                txtCodPermissao.Text = "";
                txtDesPermissao.Text = "";
            }
        }

        private void txtCodPermissao_KeyPress(object sender, KeyPressEventArgs e) {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != 46) {
                e.Handled = true; // Impede a inserção de outros caracteres
            }

            if (e.KeyChar == 46 && txtCodPermissao.Text.Contains(".")) {
                e.Handled = true; // Impede a inserção de mais de um ponto
            }
        }

        private void txtDesPermissao_TextChanged(object sender, EventArgs e) {
            string filtro = txtDesPermissao.Text.ToLower();

            var listaFiltrada = objLstPermissaoDTO
            .Where(item => (item.per_resumido_VC ?? "").ToLower().Contains(filtro))
            .ToList();

            UtilGeral.carregaGrid(dgvPermissao, ref listaFiltrada);
        }

        private void txtDesUsuario_TextChanged(object sender, EventArgs e) {
            string filtro = txtDesUsuario.Text.ToLower();

            var listaFiltrada = objLstPermissaoDTO
            .Where(item => (item.usu_login_VC ?? "").ToLower().Contains(filtro))
            .ToList();

            UtilGeral.carregaGrid(dgvPermissao, ref listaFiltrada);
        }

        private void copToolStripMenuItem_Click(object sender, EventArgs e) {
            if (dgvPermissao.SelectedRows.Count > 0) {
                // Inicializa uma StringBuilder para armazenar os dados
                StringBuilder dadosParaCopiar = new StringBuilder();

                // Adiciona os cabeçalhos das colunas
                for (int i = 0; i < dgvPermissao.Columns.Count; i++) {
                    if (dgvPermissao.Columns[i].Visible) // Apenas colunas visíveis
                    {
                        dadosParaCopiar.Append(dgvPermissao.Columns[i].HeaderText + "\t");
                    }
                }
                dadosParaCopiar.AppendLine();

                // Adiciona os dados das linhas selecionadas
                foreach (DataGridViewRow row in dgvPermissao.SelectedRows) {
                    foreach (DataGridViewCell cell in row.Cells) {
                        if (cell.Visible) // Apenas células visíveis
                        {
                            dadosParaCopiar.Append(cell.Value?.ToString() + "\t");
                        }
                    }
                    dadosParaCopiar.AppendLine();
                }

                // Copia o texto gerado para a área de transferência
                Clipboard.SetText(dadosParaCopiar.ToString());
            } else {
                MessageBox.Show("Nenhuma linha selecionada para copiar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void frmSelecionarPermissoes_KeyPress(object sender, KeyPressEventArgs e) {
            if (e.KeyChar == (char)Keys.Enter) {
                CarregarDadosObjPermissoes();
                e.Handled = true;

            }
        }
    }
}