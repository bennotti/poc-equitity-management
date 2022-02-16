using EquitityManagement.Core.Enum;
using System;
using System.Collections.Generic;
using System.Text;

namespace EquitityManagement.Core.Dto.Asset
{
    public class AssetFileDocumentDto
    {
        public string Identificador { get; set; } = Guid.NewGuid().ToString();
        public MarketEnum Market { get; set; } = MarketEnum.NAOIDENTIFICADO;
        public BrokerEnum Boker { get; set; } = BrokerEnum.NAOIDENTIFICADO;
        public string Asset { get; set; } = string.Empty;
        public string Nome { get; set; } = string.Empty;
        public string AssetTrade { get; set; } = string.Empty;
        public TypeAssetEnum TypeAsset { get; set; } = TypeAssetEnum.NAOIDENTIFICADO;
        public string IdGroupAsset { get; set; } = string.Empty;
        public IDictionary<DateTime, decimal> Prices { get; set; } = new Dictionary<DateTime, decimal>();
    }
}
