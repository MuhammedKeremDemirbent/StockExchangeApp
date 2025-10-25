using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YahooFinanceApi;

namespace StockExchangeApp.yahoo_api
{
    internal class pull_datas
    {
        public static async Task<string> GetQuoteAsync(string symbol)
        {
            try
            {
                var securities = await Yahoo.Symbols(symbol)
                    .Fields(Field.Symbol, Field.RegularMarketPrice, Field.Currency, Field.RegularMarketTime)
                    .QueryAsync();

                var data = securities[symbol];

                var price = data[Field.RegularMarketPrice];
                var currency = data[Field.Currency];
                var time = data[Field.RegularMarketTime];

                return $"{symbol} : {price} {currency} ";
            }
            catch (Exception ex)
            {
                return $"Hata: {ex.Message}";
            }
        }
    }
}
