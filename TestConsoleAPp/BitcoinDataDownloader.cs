using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace CryptoSerice
{
    public class BitcoinDataDownloader
    {
        public Bitcoin DownloadData()
        {
            WebClient wc = new WebClient();
            byte[] data = wc.DownloadData("https://min-api.cryptocompare.com/data/pricemulti?fsyms=BTC&tsyms=BTC,USD,EUR,GBP,CNY,JPY,CZK&api_key=02c104ca42549c53eb8ec9d752626997e5f287a162ae86f30e33b1f5c3bd637a");
            string dataJson = System.Text.Encoding.UTF8.GetString(data);

            dynamic dataParsed = JsonConvert.DeserializeObject(dataJson);

            Bitcoin curr = new Bitcoin
            {
                CNY = dataParsed.BTC.CNY,
                EUR = dataParsed.BTC.EUR,
                USD = dataParsed.BTC.USD,
                GBP = dataParsed.BTC.GBP,
                CZK = dataParsed.BTC.CZK,
                JPY = dataParsed.BTC.JPY
            };

            return curr;
        }
    }
}
