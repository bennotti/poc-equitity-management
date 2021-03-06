using EquitityManagement.Core.Dto.Asset;
using EquitityManagement.Core.Dto.Distribuicao;
using EquitityManagement.Core.Dto.Entries;
using EquitityManagement.Core.Dto.GroupAssets;
using EquitityManagement.Core.Dto.Position;
using EquitityManagement.Core.Dto.Withdraws;
using EquitityManagement.Core.Enum;
using System;
using System.Collections.Generic;
using System.Text;

namespace EquitityManagement.Core.Dto.Equitity
{
    public class EquitityFileDocumentDto
    {
        public string Identificador { get; set; } = Guid.NewGuid().ToString();
        public CurrencyEnum Currency { get; set; } = CurrencyEnum.BRL;
        public IList<DistruibuicaoFileDocumentDto> Distribuicao { get; set; } = new List<DistruibuicaoFileDocumentDto>();
        public IList<GroupAssetFileDocumentDto> GroupAssets { get; set; } = new List<GroupAssetFileDocumentDto>();
        public IList<AssetFileDocumentDto> Assets { get; set; } = new List<AssetFileDocumentDto>();

        public IList<PositionFileDocumentDto> Positions { get; set; } = new List<PositionFileDocumentDto>();
        public IList<EntrieFileDocumentDto> Entries { get; set; } = new List<EntrieFileDocumentDto>();
        public IList<WithdrawFileDocumentDto> Withdraws {get;set; } = new List<WithdrawFileDocumentDto>();
    }
}
