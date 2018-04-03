using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.IO;
namespace BLL
{
    public class Viladator
    {
        public string CreateCode(int codeLength)
        {
            int number;
            char code;
            string checkCode = String.Empty;
            Random ran = new Random();
            for(int i = 0; i < codeLength; i++)
            {
                number = ran.Next();
                code = (char)('0' + (char)(number % 10));
                checkCode += code;
            }
            return checkCode;
        }
        public  byte[] CreateValidatorCode(string checkCode)
        {
            System.Drawing.Bitmap image = new System.Drawing.Bitmap((int)Math.Ceiling((checkCode.Length * 12.5)), 22);
            System.Drawing.Graphics g = System.Drawing.Graphics.FromImage(image);
            try
            {
                Random ran = new Random();
                g.Clear(System.Drawing.Color.White);
                for(int i = 0; i < 2; i++)
                {
                    int x1 = ran.Next(image.Width);
                    int x2 = ran.Next(image.Width);
                    int y1 = ran.Next(image.Height);
                    int y2 = ran.Next(image.Height);
                    g.DrawLine(new System.Drawing.Pen(System.Drawing.Color.Black), x1, x2, y1, y2);
                }
                System.Drawing.Font font = new System.Drawing.Font("Arial", 12, (System.Drawing.FontStyle.Bold));
                System.Drawing.Drawing2D.LinearGradientBrush brush = new System.Drawing.Drawing2D.LinearGradientBrush(
                        new System.Drawing.Rectangle(0, 0, image.Width, image.Height),
                        System.Drawing.Color.Black,
                        System.Drawing.Color.DarkRed,
                        1.2f,
                        true
                    );
                g.DrawString(checkCode, font, brush, 2, 2);

                for(int i = 0; i < 100; i++)
                {
                    int x = ran.Next(image.Width);
                    int y = ran.Next(image.Height);
                    image.SetPixel(x, y, System.Drawing.Color.FromArgb(ran.Next()));
                }
                g.DrawRectangle(new Pen(Color.Silver), 0, 0, image.Width - 1, image.Height - 1);
                MemoryStream ms = new MemoryStream();
                image.Save(ms, System.Drawing.Imaging.ImageFormat.Gif);

                return ms.ToArray();
                
            }
            finally
            {
                g.Dispose();
                image.Dispose();
            }
        }
    }
}
