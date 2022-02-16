using EquitityManagement.Core.Dto.DividendsFees;
using EquitityManagement.Core.Dto.Order;
using EquitityManagement.Core.Enum;
using System;
using System.Collections.Generic;
using System.Text;

namespace EquitityManagement.Core.Dto.Position
{
    public class PositionFileDocumentDto
    {
        public string Identificador { get; set; } = Guid.NewGuid().ToString();
        public string Asset { get; set; } = string.Empty;
        public decimal PercentRisk { get; set; } = 10;
        public decimal CurrentPrice { get; set; } = decimal.Zero;
        public CurrencyEnum Currency { get; set; } = CurrencyEnum.BRL;
        public decimal Degradation { get; set; } = decimal.Zero;
        public decimal LastPrice { get; set; } = decimal.Zero;
        public DateTime LastPriceDate { get; set; } = DateTime.Now;
        public decimal Amount { get; set; } = decimal.Zero;
        public decimal CostCurrency { get; set; } = decimal.Zero;
        public decimal CostCurrencyEquitity { get; set; } = decimal.Zero;

        public IList<OrderFileDocumentDto> Orders { get; set; } = new List<OrderFileDocumentDto>();
        public IList<DividendFeeFileDocumentDto> DividendsFees { get; set; } = new List<DividendFeeFileDocumentDto>();
    }
}
