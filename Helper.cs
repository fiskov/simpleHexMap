using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace simpleHexMap
{
    public static class Helper
    {
        private static int scale = 5, divider = 1;
        private const int sizeMax = 1024*1024;

        private static int[] field = new int[sizeMax+1];

        private static Bitmap bmp = new Bitmap(512 * scale, sizeMax/512 * scale);
        private static int width = 256, height = 0, posMax = 0;

        internal static void PutPoint(int pos, int value)
        {
            if (pos >= sizeMax) return;
            if (pos > posMax) posMax = pos;

            field[pos] = value;
        }

        /// <summary>
        /// RGB332,RGB565 -> RGB32
        /// </summary>
        internal static Brush GetBrushColor(int clr)
        {
            int r, g, b;
            if (divider == 1)
            {
                r = ((clr >> 5) & 0x07) * 255 / 7;
                g = ((clr >> 2) & 0x07) * 255 / 7;
                b = (clr & 0x03) * 255 / 3;
            } else
            {
                r = ((clr & 0xf800) >> 11) * 255 / 31;
                g = ((clr & 0x07e0) >> 5) * 255 / 63;
                b =  (clr & 0x001f) * 255 / 31;
            }


            return new SolidBrush(Color.FromArgb(255, r, g, b));
        }

        internal static Rectangle GetRect(int pos) => new Rectangle(
            (pos % width) * scale, (pos / width) * scale, scale, scale);

        internal static Bitmap DrawField()
        {
            int lineTop = 0x10000 / width / divider;
            int size = width * height; //высота уже с делителем
            using (Graphics graph = Graphics.FromImage(bmp))
            {
                graph.Clear(Color.White);

                //цветные квадратики
                for (int i = 0; i < size; i++)
                {
                    int v = field[i * divider];
                    if (divider == 2) v = v * 256 + field[i * divider + 1];

                    graph.FillRectangle(GetBrushColor(v), GetRect(i));
                }

                //линия каждые 0x10000
                Pen pen = new Pen(Color.HotPink, 2);
                for (int i=1; i < size / 0x10000 / divider; i++)
                    graph.DrawLine(pen, 
                        0, i* lineTop * scale, width * scale, i * lineTop * scale);
            }

            return bmp;
        }

        internal static Size GetFieldSize()
        {
            return new Size(scale * width, scale * height);
        }

        internal static string GetValue(int x, int y)
        {
            if (height < y / scale) return "";

            int addr = (y / scale * width + x / scale) * divider;
            int value = field[addr * divider];

            if (divider == 2) value = field[addr] * 256 + field[addr + 1];

            return "Addr: 0x"+addr.ToString("X")+", Value: 0x"+value.ToString("X");
        }


        /// <summary>
        /// Загружает .hex файл в массив
        /// </summary>
        internal static void LoadField(string fileName)
        {
            Array.Clear(field, 0, field.Length);

            int offset = 0;

            string[] lines = System.IO.File.ReadAllLines(fileName);

            foreach (string line in lines)
            {

                if (line[0] == ':')
                {
                    switch (Convert.ToInt32(line.Substring(7, 2), 16))
                    {
                        case 0:
                            int addr = Convert.ToInt32(line.Substring(3, 4), 16);
                            int len = Convert.ToInt32(line.Substring(1, 2), 16);

                            for (int i = 0; i < len; i++)
                                Helper.PutPoint(offset + addr + i,
                                    Convert.ToInt32(line.Substring(9 + i * 2, 2), 16));
                            break;
                        case 2:
                            offset = Convert.ToInt32(line.Substring(9, 4), 16) * 16;
                            break;
                    }
                }
            }            
        }

        public static void DrawHexField(this PictureBox pb, 
            int _width = 256, int _scale = 2, int _divider = 1)
        {
            width = _width;
            scale = _scale;
            divider = _divider;

            height = posMax / width / divider;

            pb.Size = GetFieldSize();
            pb.Image = DrawField();
        }
    }
}
