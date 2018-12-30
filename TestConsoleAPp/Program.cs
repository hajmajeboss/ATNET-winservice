using CryptoSerice;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestConsoleAPp
{
    class Program
    {
        static void Main(string[] args)
        {
            var downloader = new BitcoinDataDownloader();
            var btc = downloader.DownloadData();
            var graphProvider = new BitcoinGraphProvider();
            graphProvider.GenerateBitcoinGraph(btc, "graphs");
        }
    }
}
