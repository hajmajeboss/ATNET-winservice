using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CryptoSerice
{
    public class BitcoinGraphProvider
    {
        public void GenerateBitcoinGraph(Bitcoin bitcoin, string path)
        {
            Bitmap bmp = new Bitmap(path);

            Graphics g = Graphics.FromImage(bmp);
            g.DrawRectangle(new Pen(Brushes.Red), new Rectangle(20,0,25,50));
            g.Save();

        }
    }
}
