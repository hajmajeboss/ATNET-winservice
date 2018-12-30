using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CryptoSerice
{
    public class BitcoinGraphProvider
    {
        public void GenerateBitcoinGraph(Bitcoin bitcoin, string path)
        {
            using (Bitmap bmp = new Bitmap(800, 600))
            {
                using (Graphics g = Graphics.FromImage(bmp))
                {
                    List<double> vals = new List<Double> { bitcoin.EUR, bitcoin.CNY, bitcoin.GBP, bitcoin.CZK/2, bitcoin.USD, bitcoin.JPY/5 };
                    int denominator = (int)(vals.Max() / 440);
                    g.DrawRectangle(new Pen(new SolidBrush(Color.Black), 2), new Rectangle(1, 1, 798, 598));
                    g.FillRectangle(new SolidBrush(Color.Black), new Rectangle(0, 78, 800, 2));
                    g.FillRectangle(new SolidBrush(Color.Black), new Rectangle(144, 0, 2, 800));
                    g.DrawString("Bitcoin Price Index", new Font(FontFamily.GenericSansSerif, 15), new SolidBrush(Color.Black), 190, 15);
                    g.DrawString("Currency", new Font(FontFamily.GenericSansSerif, 15), new SolidBrush(Color.Black), 50, 45);
                    g.DrawString("Price", new Font(FontFamily.GenericSansSerif, 15), new SolidBrush(Color.Black), 85, 85);
                    g.FillRectangle(new SolidBrush(Color.Blue), new Rectangle(190, 80, 60, (int)(bitcoin.EUR / denominator)));
                    g.DrawString("EUR", new Font(FontFamily.GenericSansSerif, 15), new SolidBrush(Color.Black), 190, 45);
                    g.DrawString(bitcoin.EUR.ToString(), new Font(FontFamily.GenericSansSerif, 10), new SolidBrush(Color.Black), 190, (int)(bitcoin.EUR / denominator) + 80 + 5);
                    g.FillRectangle(new SolidBrush(Color.Gold), new Rectangle(290, 80, 60, (int)(bitcoin.USD / denominator)));
                    g.DrawString(bitcoin.USD.ToString(), new Font(FontFamily.GenericSansSerif, 10), new SolidBrush(Color.Black), 290, (int)(bitcoin.USD / denominator) + 80 + 5);
                    g.DrawString("USD", new Font(FontFamily.GenericSansSerif, 15), new SolidBrush(Color.Black), 290, 45);
                    g.FillRectangle(new SolidBrush(Color.Green), new Rectangle(390, 80, 60, (int)(bitcoin.GBP / denominator)));
                    g.DrawString(bitcoin.GBP.ToString(), new Font(FontFamily.GenericSansSerif, 10), new SolidBrush(Color.Black), 390, (int)(bitcoin.GBP / denominator) + 80 + 5);
                    g.DrawString("GBP", new Font(FontFamily.GenericSansSerif, 15), new SolidBrush(Color.Black), 390, 45);
                    g.DrawString(bitcoin.CZK.ToString(), new Font(FontFamily.GenericSansSerif, 10), new SolidBrush(Color.Black), 490, (int)(bitcoin.CZK / 2 / denominator) + 80 + 5);
                    g.FillRectangle(new SolidBrush(Color.Black), new Rectangle(490, 80, 60, (int)(bitcoin.CZK / 2 / denominator)));
                    g.DrawString("CZK", new Font(FontFamily.GenericSansSerif, 15), new SolidBrush(Color.Black), 490, 45);
                    g.DrawString(bitcoin.CNY.ToString(), new Font(FontFamily.GenericSansSerif, 10), new SolidBrush(Color.Black), 590, (int)(bitcoin.CNY / denominator) + 80 + 5);
                    g.FillRectangle(new SolidBrush(Color.Red), new Rectangle(590, 80, 60, (int)(bitcoin.CNY / denominator)));
                    g.DrawString("CNY", new Font(FontFamily.GenericSansSerif, 15), new SolidBrush(Color.Black), 590, 45);
                    g.DrawString(bitcoin.JPY.ToString(), new Font(FontFamily.GenericSansSerif, 10), new SolidBrush(Color.Black), 690, (int)(bitcoin.JPY / 5 / denominator) + 80 + 5);
                    g.FillRectangle(new SolidBrush(Color.Brown), new Rectangle(690, 80, 60, (int)(bitcoin.JPY / 5 / denominator)));
                    g.DrawString("JPY", new Font(FontFamily.GenericSansSerif, 15), new SolidBrush(Color.Black), 690, 45);

                    bmp.Save(path + ".png", ImageFormat.Png);
                }
            }

        }
    }
}
