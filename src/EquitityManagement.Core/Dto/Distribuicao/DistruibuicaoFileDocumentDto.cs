using System;
using System.Collections.Generic;
using System.Text;

namespace EquitityManagement.Core.Dto.Distribuicao
{
    public class DistruibuicaoFileDocumentDto
    {
        public string GroupAssetName { get; set; }
        public decimal Cost { get; set; }
        public decimal CostCurrencyEquitity { get; set; }
        public decimal Retorno { get; set; }
        public decimal RetornoCurrencyEquitity { get; set; }
        public decimal Variacao { get; set; }
    }
}
