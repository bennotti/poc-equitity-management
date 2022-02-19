using EquitityManagement.Core.Dto.Equitity;
using EquitityManagement.Core.Dto.Order;
using EquitityManagement.Core.Dto.Position;
using EquitityManagement.Core.Enum;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace EquitityManagement.Windows.App.Telas
{
    public partial class FrmOrdens : Form
    {
        private EquitityFileDocumentDto _equitityFileDocument;
        private PositionFileDocumentDto _position;
        public FrmOrdens()
        {
            InitializeComponent();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            //
            this.DialogResult = DialogResult.OK;
        }

        public DialogResult ShowDialog(EquitityFileDocumentDto equitityFileDocument, int rowIndex, string valor = "")
        {
            _equitityFileDocument = equitityFileDocument;
            if (rowIndex < 0)
            {
                _position = new PositionFileDocumentDto();
            }else
            {
                _position = _equitityFileDocument.Positions[rowIndex];
            }

            AtualizarInformacaoTela();

            return base.ShowDialog();
        }

        void Limpar()
        {
            txtVolume.Text = String.Empty;
            txtValorPago.Text = String.Empty;
            txtCustoAquisicao.Text = String.Empty;
            txtPrecoExecutado.Text = String.Empty;
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            _position.Orders.Add(new OrderFileDocumentDto
            {
                Amount = Convert.ToDecimal(txtVolume.Text),
                Payment = Convert.ToDecimal(txtValorPago.Text),
                AvailableDate = DateTime.Now,
                Boker = BrokerEnum.NAOIDENTIFICADO,
                Cost = Convert.ToDecimal(txtCustoAquisicao.Text),
                Date = DateTime.Now,
                Price = Convert.ToDecimal(txtPrecoExecutado.Text)
            }); ;
            Limpar();
            CalcularPosicao();
            AtualizarInformacaoTela();
        }

        void AtualizarInformacaoTela()
        {
            txtAtivo.Text = _position.Asset;
            txtAtivoOperado.Text = _position.AssetTrade;
            txtVolumeTotal.Text = _position.Amount.ToString();
            txtPrecoMedio.Text = _position.CurrentPrice.ToString();

            dgvOrdens.DataSource = new BindingList<OrderFileDocumentDto>(_position.Orders);
            Application.DoEvents();
        }

        void CalcularPosicao()
        {
            decimal currentPrice = 0;
            var costCurrency = _position.Orders.Sum(p => p.Payment);
            var amount = _position.Orders.Sum(p => p.Amount);

            try
            {
                currentPrice = costCurrency / amount;
            }
            catch
            {

            }
            _position.CostCurrency = costCurrency;
            _position.Amount = amount;
            _position.CurrentPrice = currentPrice;
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            Limpar();
        }

        private void txtAtivoOperado_Leave(object sender, EventArgs e)
        {
            // buscar ativo
        }
    }
}
