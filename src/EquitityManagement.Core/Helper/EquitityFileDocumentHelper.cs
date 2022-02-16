using EquitityManagement.Core.Dto.Asset;
using EquitityManagement.Core.Dto.Equitity;
using EquitityManagement.Core.Dto.GroupAssets;
using EquitityManagement.Core.Dto.Order;
using EquitityManagement.Core.Dto.Position;
using EquitityManagement.Core.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EquitityManagement.Core.Helper
{
    public static class EquitityFileDocumentHelper
    {
        public static PositionFileDocumentDto SamplePositionFileDocument(
            string asset,
            CurrencyEnum currency,
            IList<OrderFileDocumentDto> orders
        )
        {
            decimal currentPrice = 0;
            var costCurrency = orders.Sum(p => p.Payment);
            var amount = orders.Sum(p => p.Amount);

            try
            {
                currentPrice = costCurrency / amount;
            }catch
            {

            }

            return new PositionFileDocumentDto
            {
                Orders = orders,
                Asset = asset,
                CurrentPrice = currentPrice,
                Currency = currency,
                Degradation = 0,
                Amount = amount,
                CostCurrency = costCurrency,
                CostCurrencyEquitity = costCurrency,
            };
        }
        public static IList<PositionFileDocumentDto> SampleListPositionFileDocument()
        {
            var ordensCiel3f = new List<OrderFileDocumentDto> { 
                new OrderFileDocumentDto
                {
                    Price = 2.40m,
                    Amount = 10,
                    Date = new DateTime(2021, 12, 13),
                    Cost = 48m,
                    Payment = 48m,
                    AvailableDate = new DateTime(2021, 12, 13)
                },
                new OrderFileDocumentDto
                {
                    Price = 2.04m,
                    Amount = 10,
                    Date = new DateTime(2022, 01, 12),
                    Cost = 20.40m,
                    Payment = 20.40m,
                    AvailableDate = new DateTime(2022, 01, 12)
                },
            };
            var ordensItub3f = new List<OrderFileDocumentDto> {
                new OrderFileDocumentDto
                {
                    Price = 19.38m,
                    Amount = 2,
                    Date = new DateTime(2022, 01, 03),
                    Cost = 96.90m,
                    Payment = 96.90m,
                    AvailableDate = new DateTime(2022, 01, 03)
                },
            };
            var ordensAaple = new List<OrderFileDocumentDto> {
                new OrderFileDocumentDto
                {
                    Price = 170.99m,
                    Amount = 1,
                    Date = new DateTime(2022, 01, 10),
                    Cost = 170.99m,
                    Payment = 171.99m,
                    AvailableDate = new DateTime(2022, 01, 10)
                },
            };
            var ordensDolar = new List<OrderFileDocumentDto> {
                new OrderFileDocumentDto
                {
                    Price = 5.77m,
                    Amount = 85.6m,
                    Date = new DateTime(2021, 12, 27),
                    Cost = 493.91m,
                    Payment = 500m,
                    AvailableDate = new DateTime(2021, 12, 18)
                },
                new OrderFileDocumentDto
                {
                    Price = 5.3963m,
                    Amount = 183.3m,
                    Date = new DateTime(2022, 02,02),
                    Cost = 989.14m,
                    Payment = 1000m,
                    AvailableDate = new DateTime(2022, 02,03)
                },
            };
            var ordensBtc = new List<OrderFileDocumentDto> {
                new OrderFileDocumentDto
                {
                    Price = 26777.39m,
                    Amount = 0.0007416600m,
                    Date = new DateTime(2021, 12,30),
                    Cost = 198.60m,
                    Payment = 200m,
                    AvailableDate = new DateTime(2021, 12,30)
                },
                new OrderFileDocumentDto
                {
                    Price = 196602.99m,
                    Amount = 0.00050507m,
                    Date = new DateTime(2021, 02,03),
                    Cost = 99.30m,
                    Payment = 100m,
                    AvailableDate = new DateTime(2021, 02,03)
                },
            };

            return new List<PositionFileDocumentDto>
            {
                SamplePositionFileDocument(
                    "CIEL3F",
                    CurrencyEnum.BRL,
                    ordensCiel3f
                ),
                SamplePositionFileDocument(
                    "ITUB3F",
                    CurrencyEnum.BRL,
                    ordensItub3f
                ),
                SamplePositionFileDocument(
                    "AAPLE",
                    CurrencyEnum.USD,
                    ordensAaple
                ),
                SamplePositionFileDocument(
                    "BRLUSD",
                    CurrencyEnum.BRL,
                    ordensDolar
                ),
                SamplePositionFileDocument(
                    "BTCBRL",
                    CurrencyEnum.BRL,
                    ordensBtc
                ),
            };
        }
        public static IList<AssetFileDocumentDto> SampleListAssetFileDocument()
        {
            var idGroupAssetAcoesBRL = "c8ad796d-7983-4029-9587-fbe182903756";
            var idGroupAssetAcoesURL = "802bee02-6605-446d-98bb-c88eaf4be0b5";
            var idGroupAssetMoedaExtrangeira = "6b1e8bce-6bcb-4b6c-85f1-36372f1bff52";
            var idGroupAssetCriptomoedas = "cda3ad78-cae2-4286-95bf-eeaba208d8d5";

            return new List<AssetFileDocumentDto>
            {
                #region CIEL3F
                new AssetFileDocumentDto()
                {
                    Market = MarketEnum.B3,
                    Nome = "Cielo",
                    Asset = "CIEL3",
                    AssetTrade = "CIEL3F",
                    TypeAsset = TypeAssetEnum.ACAO_FRACIONADA,
                    IdGroupAsset = idGroupAssetAcoesBRL
                },
                #endregion CIEL3F

                #region ITUB3F
                new AssetFileDocumentDto()
                {
                    Market = MarketEnum.B3,
                    Nome = "Itaú Unibanco",
                    Asset = "ITUB3",
                    AssetTrade = "ITUB3F",
                    TypeAsset = TypeAssetEnum.ACAO_FRACIONADA,
                    IdGroupAsset = idGroupAssetAcoesBRL
                },
                #endregion ITUB3F

                #region AAPLE
                new AssetFileDocumentDto()
                {
                    Market = MarketEnum.NASDAQ,
                    Nome = "Apple",
                    Asset = "AAPLE",
                    AssetTrade = "AAPLE",
                    TypeAsset = TypeAssetEnum.ACAO_EXTERIOR,
                    IdGroupAsset = idGroupAssetAcoesURL,
                },
                #endregion AAPLE

                #region BRLUSD
                new AssetFileDocumentDto()
                {
                    Market = MarketEnum.MOEDAS,
                    Boker = BrokerEnum.AVENUE,
                    Nome = "DOLAR",
                    Asset = "USDBRL",
                    AssetTrade = "USDBRL",
                    TypeAsset = TypeAssetEnum.MOEDA_ESTRANGEIRA,
                    IdGroupAsset = idGroupAssetMoedaExtrangeira,
                },
                #endregion BRLUSD

                #region BTCBRL
                new AssetFileDocumentDto()
                {
                    Market = MarketEnum.CRYPTO,
                    Boker = BrokerEnum.MERCADOBITCOIN,
                    Nome = "Bitcoin",
                    Asset = "BTCBRL",
                    AssetTrade = "BTCBRL",
                    TypeAsset = TypeAssetEnum.CRIPTOMOEDA,
                    IdGroupAsset = idGroupAssetCriptomoedas,
                },
                #endregion BTCBRL
            };
        }
        public static IList<GroupAssetFileDocumentDto> SampleListGroupAssetFileDocument()
        {
            return new List<GroupAssetFileDocumentDto> {
                #region Ações BRL
                new GroupAssetFileDocumentDto
                {
                    Identificador = "c8ad796d-7983-4029-9587-fbe182903756",
                    Nome = "Ações BRL",
                    HorarioObservacao = "10:00 até 17:00",
                    Markets = new List<MarketEnum>(),
                    Brokers = new List<BrokerEnum>(),
                    TypeAssets = new List<TypeAssetEnum>(),
                },
                #endregion Ações BRL
                
                #region Derivativos
                new GroupAssetFileDocumentDto
                {
                    Identificador = "0eefd7df-872c-429a-a000-8384cf27595b",
                    Nome = "Derivativos",
                    HorarioObservacao = "10:00 até 17:00",
                    Markets = new List<MarketEnum>(),
                    Brokers = new List<BrokerEnum>(),
                    TypeAssets = new List<TypeAssetEnum>(),
                },
                #endregion Derivativos
                
                #region Ações USD
                new GroupAssetFileDocumentDto
                {
                    Identificador = "802bee02-6605-446d-98bb-c88eaf4be0b5",
                    Nome = "Ações USD",
                    HorarioObservacao = "12:30 até 18:00",
                    CurrencyTrade = CurrencyEnum.USD,
                    Markets = new List<MarketEnum>(),
                    Brokers = new List<BrokerEnum>(),
                    TypeAssets = new List<TypeAssetEnum>(),
                },
                #endregion Ações USD
                
                #region Moedas estrangeiras
                new GroupAssetFileDocumentDto
                {
                    Identificador = "6b1e8bce-6bcb-4b6c-85f1-36372f1bff52",
                    Nome = "Moedas estrangeiras",
                    HorarioObservacao = "09:30 até 15:00",
                    Markets = new List<MarketEnum>(),
                    Brokers = new List<BrokerEnum>(),
                    TypeAssets = new List<TypeAssetEnum>(),
                },
                #endregion Moedas estrangeiras
                
                #region Criptomoedas
                new GroupAssetFileDocumentDto
                {
                    Identificador = "cda3ad78-cae2-4286-95bf-eeaba208d8d5",
                    Nome = "Criptomoedas",
                    HorarioObservacao = "24hrs",
                    Markets = new List<MarketEnum>(),
                    Brokers = new List<BrokerEnum>(),
                    TypeAssets = new List<TypeAssetEnum>(),
                },
                #endregion Criptomoedas
            };
        }
        public static EquitityFileDocumentDto SampleFileDocument()
        {
            return new EquitityFileDocumentDto
            {
                Positions = SampleListPositionFileDocument(),
                GroupAssets = SampleListGroupAssetFileDocument(),
                Assets = SampleListAssetFileDocument(),
            };
        }
    }
}
