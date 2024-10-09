﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;

namespace AppTournoi
{
    internal class GestionImage
    {
        public static BitmapImage ConvertByteArrayToBitmapImage(Byte[] imageByte)
        {
            try
            {
                BitmapImage bi = new BitmapImage();
                bi.BeginInit();
                bi.StreamSource = new MemoryStream(imageByte);
                bi.EndInit();
                return bi;
            }
            catch { throw; }
        }
        public static byte[] ConvertImageToByteArray(System.Drawing.Image photo)
        {
            try
            {
                using (var ms = new MemoryStream())
                {
                    photo.Save(ms, photo.RawFormat);
                    return ms.ToArray();
                }
            }
            catch { throw; }
        }
    }
}
