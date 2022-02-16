using EquitityManagement.Core.Dto.Asset;
using EquitityManagement.Core.Enum;
using System;
using System.Collections.Generic;
using System.Text;

namespace EquitityManagement.Core.Dto.GroupAssets
{
    public class GroupAssetFileDocumentDto
    {
        public string Identificador { get; set; } = Guid.NewGuid().ToString();
        public string Nome { get; set; } = string.Empty;
        public string HorarioObservacao { get; set; } = "24hrs";
        public CurrencyEnum CurrencyTrade { get; set; } = CurrencyEnum.BRL;
        public IList<MarketEnum> Markets { get; set; } = new List<MarketEnum>();
        public IList<BrokerEnum> Brokers { get; set; } = new List<BrokerEnum>();
        public IList<TypeAssetEnum> TypeAssets { get; set; } = new List<TypeAssetEnum>(); 
    }
}
