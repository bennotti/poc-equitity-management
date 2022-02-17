using EquitityManagement.Core.Dto.Equitity;
using EquitityManagement.Core.Dto.Position;
using EquitityManagement.Core.Helper;
using EquitityManagement.Windows.App.Telas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EquitityManagement.Windows.App
{
    public partial class FrmPrincipal : Form
    {
        private EquitityFileDocumentDto _equitityFileDocument;
        private readonly FrmOrdens _frmOrdens;
        public FrmPrincipal(FrmOrdens frmOrdens)
        {
            InitializeComponent();
            _frmOrdens = frmOrdens;
        }

        private void btnPainelPreco_Click(object sender, EventArgs e)
        {
            //
        }

        private void btnAtivos_Click(object sender, EventArgs e)
        {
            //
        }

        private void btnTiposAtivos_Click(object sender, EventArgs e)
        {
            //
        }

        private void btnNovaTransacao_Click(object sender, EventArgs e)
        {
            //
        }

        private void btnNovaOrdem_Click(object sender, EventArgs e)
        {
            _frmOrdens.ShowDialog();
        }

        void AtualizarGridViewPosicoes()
        {
            dgvPosicoes.DataSource = _equitityFileDocument.Positions;

        }

        private void btnNovoDocumento_Click(object sender, EventArgs e)
        {
            _equitityFileDocument = new EquitityFileDocumentDto();

            AtualizarGridViewPosicoes();

            dgvPosicoes.Enabled = true;
            btnSalvarDocumento.Enabled = true;
            btnDadosExemplo.Enabled = true;
            btnPainelPreco.Enabled = true;
            btnAtivos.Enabled = true;
            btnTiposAtivos.Enabled = true;
            btnNovaTransacao.Enabled = true;
            btnNovaOrdem.Enabled = true;
        }

        private void btnAbrirDocumento_Click(object sender, EventArgs e)
        {
            //
        }

        private void btnSalvarDocumento_Click(object sender, EventArgs e)
        {
            //
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDadosExemplo_Click(object sender, EventArgs e)
        {
            _equitityFileDocument = EquitityFileDocumentHelper.SampleFileDocument();

            AtualizarGridViewPosicoes();
        }

        private void FrmPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            //
        }
    }
}
