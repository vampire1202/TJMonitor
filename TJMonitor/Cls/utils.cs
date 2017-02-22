using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Reflection;
using System.Text.RegularExpressions;
using System.Data;
using System.Collections; 
using System.Drawing;
using System.Drawing.Imaging; 
using System.Xml;
using System.Xml.XPath;
using System.Drawing.Drawing2D;
namespace TJMonitor.Cls
{
    class utils
    {
        public static bool IsNumeric(string value)
        {
            return Regex.IsMatch(value, @"^[+-]?\d*[.]?\d*$");
        }

        public static void AddText(FileStream fs, string value)
        {
            byte[] info = new UTF8Encoding(true).GetBytes(value);
            fs.Write(info, 0, info.Length);
        }

        public static int Dotvalue(double _value)
        {
            int _dotValue = 0;
            int _ten =(int)Math.Log10(_value);
            if (_value < 1000.0)
                _dotValue = 6 - _ten - 1 ;
            if (_value > 1000.0)
            {
                _dotValue = 6 - (_ten - 3)-1;            
            }
            if (_dotValue < 2)
                _dotValue = 2;
            return _dotValue; 
        }


        /// <summary>
        /// 获取缩小后的图片
        /// </summary>
        /// <param name="bm">要缩小的图片</param>
        /// <param name="times">要缩小的倍数</param>
        /// <returns></returns>
        public static Bitmap GetSmallBmp(Bitmap bm, double times)
        {
            int nowWidth = (int)(bm.Width / times);
            int nowHeight = (int)(bm.Height / times);
            Bitmap newbm = new Bitmap(nowWidth, nowHeight);//新建一个放大后大小的图片

            if (times >= 1 && times <= 1.1)
            {
                newbm = bm;
            }
            else
            {
                Graphics g = Graphics.FromImage(newbm);
                g.InterpolationMode = InterpolationMode.HighQualityBicubic;
                g.SmoothingMode = SmoothingMode.HighQuality;
                g.CompositingQuality = CompositingQuality.HighQuality;
                g.DrawImage(bm, new Rectangle(0, 0, nowWidth, nowHeight), new Rectangle(0, 0, bm.Width, bm.Height), GraphicsUnit.Pixel);
                g.Dispose();
            }
            return newbm;
        }

 
         /// <summary>
        /// 将图片Image转换成Byte[]
        /// </summary>
        /// <param name="Image">image对象</param>
        /// <param name="imageFormat">后缀名</param>
        /// <returns></returns>
        public static byte[] ImageToBytes(Image Image, System.Drawing.Imaging.ImageFormat imageFormat)
        {

            if (Image == null) { return null; }

            byte[] data = null;

            using (MemoryStream ms= new MemoryStream())
            {

                 using (Bitmap Bitmap = new Bitmap(Image))
                {

                    Bitmap.Save(ms, imageFormat);

                    ms.Position = 0;

                    data =  new byte[ms.Length];

                    ms.Read(data, 0, Convert.ToInt32(ms.Length));

                    ms.Flush();

                }

            }

            return data;

        }


            /// <summary>
            /// byte[]转换成Image
            /// </summary>
            /// <param name="byteArrayIn">二进制图片流</param>
            /// <returns>Image</returns>
            public static System.Drawing.Image byteArrayToImage(byte[] byteArrayIn)
            {
                if (byteArrayIn == null)
                    return null;
                using (System.IO.MemoryStream ms = new System.IO.MemoryStream(byteArrayIn))
                {
                    System.Drawing.Image returnImage = System.Drawing.Image.FromStream(ms);
                    ms.Flush();
                    return returnImage;
                }
            }

 

        //byte[] 转换 Bitmap
        public static Bitmap BytesToBitmap(byte[] Bytes) 
        { 
            MemoryStream stream = null; 
            try 
            { 
                stream = new MemoryStream(Bytes); 
                return new Bitmap((Image)new Bitmap(stream)); 
            } 
            catch (ArgumentNullException ex) 
            { 
                throw ex; 
            } 
            catch (ArgumentException ex) 
            { 
                throw ex; 
            } 
            finally 
            { 
                stream.Close(); 
            } 
        }  
 
        //Bitmap转byte[]  
        public static byte[] BitmapToBytes(Bitmap Bitmap) 
        { 
            MemoryStream ms = null; 
            try 
            { 
                ms = new MemoryStream(); 
                Bitmap.Save(ms, Bitmap.RawFormat); 
                byte[] byteImage = new Byte[ms.Length]; 
                byteImage = ms.ToArray(); 
                return byteImage; 
            } 
            catch (ArgumentNullException ex) 
            { 
                throw ex; 
            } 
            finally 
            { 
                ms.Close(); 
            } 
        }  
        
        public static Color GetRandomColor()
        {
            Random RandomNum_First = new Random((int)DateTime.Now.Ticks);
            System.Threading.Thread.Sleep(RandomNum_First.Next(50));
            Random RandomNum_Sencond = new Random((int)DateTime.Now.Ticks);
            //  为了在白色背景上显示，尽量生成深色
            int int_Red = RandomNum_First.Next(256);
            int int_Green = RandomNum_Sencond.Next(256);
            int int_Blue = (int_Red + int_Green > 400) ? 0 : 400 - int_Red - int_Green;
            int_Blue = (int_Blue > 255) ? 255 : int_Blue;
            return Color.FromArgb(int_Red, int_Green, int_Blue);
        }     

    /// <summary> 
    /// summary description for strhelper. 
    /// 命名缩写： 
    /// str: Unicode string 
    /// arr: Unicode array 
    /// hex: 二进制数据 
    /// hexbin: 二进制数据用ASCII字符表示 例 字符1的hex是0x31表示为hexbin是 31 
    /// asc: ASCII 
    /// uni: Unicode 
    /// </summary> 
 
        public static void hexbin2hex(byte[] bhexbin, byte[] bhex, int nlen)
        {
            for (int i = 0; i < nlen / 2; i++)
            {
                if (bhexbin[2 * i] < 0x41)
                {
                    bhex[i] = Convert.ToByte(((bhexbin[2 * i] - 0x30) << 4) & 0xf0);
                }
                else
                {
                    bhex[i] = Convert.ToByte(((bhexbin[2 * i] - 0x37) << 4) & 0xf0);
                }

                if (bhexbin[2 * i + 1] < 0x41)
                {
                    bhex[i] |= Convert.ToByte((bhexbin[2 * i + 1] - 0x30) & 0x0f);
                }
                else
                {
                    bhex[i] |= Convert.ToByte((bhexbin[2 * i + 1] - 0x37) & 0x0f);
                }
            }
        }

        public static byte[] hexbin2hex(byte[] bhexbin, int nlen)
        {
            if (nlen % 2 != 0)
                return null;
            byte[] bhex = new byte[nlen / 2];
            hexbin2hex(bhexbin, bhex, nlen);
            return bhex;
        }

        public static void hex2hexbin(byte[] bhex, byte[] bhexbin, int nlen)
        {
            byte c;
            for (int i = 0; i < nlen; i++)
            {
                c = Convert.ToByte((bhex[i] >> 4) & 0x0f);
                if (c < 0x0a)
                {
                    bhexbin[2 * i] = Convert.ToByte(c + 0x30);
                }
                else
                {
                    bhexbin[2 * i] = Convert.ToByte(c + 0x37);
                }
                c = Convert.ToByte(bhex[i] & 0x0f);
                if (c < 0x0a)
                {
                    bhexbin[2 * i + 1] = Convert.ToByte(c + 0x30);
                }
                else
                {
                    bhexbin[2 * i + 1] = Convert.ToByte(c + 0x37);
                }
            }
        }

        public static byte[] hex2hexbin(byte[] bhex, int nlen)
        {
            byte[] bhexbin = new byte[nlen * 2];
            hex2hexbin(bhex, bhexbin, nlen);
            return bhexbin;
        }

        public static byte[] str2arr(string s)
        {
            return (new UnicodeEncoding()).GetBytes(s);
        }

        public static string arr2str(byte[] buffer)
        {
            return (new UnicodeEncoding()).GetString(buffer, 0, buffer.Length);
        }

        public static byte[] str2ascarr(string s)
        {
            return System.Text.UnicodeEncoding.Convert(System.Text.Encoding.Unicode,
            System.Text.Encoding.ASCII,
            str2arr(s));
        }

        public static byte[] str2hexascarr(string s)
        {
            byte[] hex = str2ascarr(s);
            byte[] hexbin = hex2hexbin(hex, hex.Length);
            return hexbin;
        }

        public static string ascarr2str(byte[] b)
        {
            return System.Text.UnicodeEncoding.Unicode.GetString(
            System.Text.ASCIIEncoding.Convert(System.Text.Encoding.ASCII,System.Text.Encoding.Unicode,b));
        }

        public static string hexascarr2str(byte[] buffer)
        {
            byte[] b = hex2hexbin(buffer, buffer.Length);
            return ascarr2str(b);
        }

        public static Int32 GetRoundEbOfBend(double _eb)
        {
            int eb = 0;
            //结果修约
            //≤150000 修约到 500MPa,>150000修约到1000MPa
            if (_eb <= 150000)
                eb = (int)(_eb / 500) * 500;
            else if (_eb > 150000)
                eb = (int)(_eb / 1000) * 1000;
            return eb;
        }

        public static Int32 GetRoundStressOfBend(double _stress)
        {
            int stress = 0;
            if (_stress <= 200)
                stress = (int)_stress;
            else if (_stress > 200 && _stress <= 1000)
                stress = (int)(_stress / 5) * 5;
            else if (_stress > 1000)
                stress = (int)(_stress / 10) * 10;
            return stress;
        }

        /// <summary>
        /// 将一个字节数组转换为8bit灰度位图
        /// </summary>
        /// <param name="rawValues">显示字节数组</param>
        /// <param name="width">图像宽度</param>
        /// <param name="height">图像高度</param>
        /// <returns>位图</returns>
        public static Bitmap ToGrayBitmap(int[] rawValues, int width, int height)
        {
            //// 申请目标位图的变量，并将其内存区域锁定
            Bitmap bmp = new Bitmap(width, height, PixelFormat.Format8bppIndexed);
            BitmapData bmpData = bmp.LockBits(new Rectangle(0, 0, width, height),
                ImageLockMode.WriteOnly, PixelFormat.Format8bppIndexed);

            //// 获取图像参数
            int stride = bmpData.Stride;  // 扫描线的宽度
            int offset = stride - width;  // 显示宽度与扫描线宽度的间隙
            IntPtr iptr = bmpData.Scan0;  // 获取bmpData的内存起始位置
            int scanBytes = stride * height;   // 用stride宽度，表示这是内存区域的大小

            //// 下面把原始的显示大小字节数组转换为内存中实际存放的字节数组
            int posScan = 0, posReal = 0;   // 分别设置两个位置指针，指向源数组和目标数组
            byte[] pixelValues = new byte[scanBytes];  //为目标数组分配内存
            for (int h = 0; h < height; h++)
            {
                //// 下面的循环节是模拟行扫描
                for (int w = 0; w < width;w++)
                {
                    pixelValues[posScan++] = (byte)(rawValues[posReal++]/16);
                }
                posScan += offset;  //行扫描结束，要将目标位置指针移过那段“间隙”
            }

            //// 用Marshal的Copy方法，将刚才得到的内存字节数组复制到BitmapData中
            System.Runtime.InteropServices.Marshal.Copy(pixelValues, 0, iptr, scanBytes);
            bmp.UnlockBits(bmpData);  // 解锁内存区域

            //// 下面的代码是为了修改生成位图的索引表，从伪彩修改为灰度
            ColorPalette tempPalette;
            using (Bitmap tempBmp = new Bitmap(1, 1, PixelFormat.Format8bppIndexed))
            {
                tempPalette = tempBmp.Palette;
            }
            for (int i = 0; i < 256; i++)
            {
                tempPalette.Entries[i] = Color.FromArgb(i, i, i);
            }
            bmp.Palette = tempPalette;
            //// 算法到此结束，返回结果
            return bmp;
        }

        /// <summary>
        /// 将一个反数组转换为8bit灰度位图
        /// </summary>
        /// <param name="rawValues">显示字节数组</param>
        /// <param name="width">图像宽度</param>
        /// <param name="height">图像高度</param>
        /// <returns>位图</returns>
        public static Bitmap ToGrayBitmap(List<int[]> lstRawValues, int width, int height)
        {
            //// 申请目标位图的变量，并将其内存区域锁定
            Bitmap bmp = new Bitmap(width, height, PixelFormat.Format8bppIndexed);
            BitmapData bmpData = bmp.LockBits(new Rectangle(0, 0, width, height),
                ImageLockMode.WriteOnly, PixelFormat.Format8bppIndexed);

            //// 获取图像参数
            int stride = bmpData.Stride;  // 扫描线的宽度
            int offset = stride - width;  // 显示宽度与扫描线宽度的间隙
            IntPtr iptr = bmpData.Scan0;  // 获取bmpData的内存起始位置
            int scanBytes = stride * height;   // 用stride宽度，表示这是内存区域的大小

            //// 下面把原始的显示大小字节数组转换为内存中实际存放的字节数组
            int posScan = 0; 
            byte[] pixelValues = new byte[scanBytes];  //为目标数组分配内存
            for (int h = 0; h < height;h++)
            {
                // 下面的循环节是模拟行扫描
                for (int w = 0; w < width; w++)
                {
                    pixelValues[posScan] = (byte)(lstRawValues[h][w] / 16); 
                    posScan++;
                }
                posScan += offset;  //行扫描结束，要将目标位置指针移过那段“间隙”
            }

            // 用Marshal的Copy方法，将刚才得到的内存字节数组复制到BitmapData中
            System.Runtime.InteropServices.Marshal.Copy(pixelValues, 0, iptr, scanBytes);
            bmp.UnlockBits(bmpData);  // 解锁内存区域

            //// 下面的代码是为了修改生成位图的索引表，从伪彩修改为灰度
            ColorPalette tempPalette;
            using (Bitmap tempBmp = new Bitmap(1, 1, PixelFormat.Format8bppIndexed))
            {
                tempPalette = tempBmp.Palette;
            }
            for (int i = 0; i < 256; i++)
            {
                tempPalette.Entries[i] = Color.FromArgb(i, i, i);
            }
            bmp.Palette = tempPalette;
            //// 算法到此结束，返回结果
            return bmp;
        }

        private void LockUnlockBitsExample(System.Windows.Forms.PaintEventArgs e)
        {
            // Create a new bitmap.
            Bitmap bmp = new Bitmap("c:\\fakePhoto.jpg");

            // Lock the bitmap's bits.  
            Rectangle rect = new Rectangle(0, 0, bmp.Width, bmp.Height);
            System.Drawing.Imaging.BitmapData bmpData =
                bmp.LockBits(rect, System.Drawing.Imaging.ImageLockMode.ReadWrite,
                bmp.PixelFormat);

            // Get the address of the first line.
            IntPtr ptr = bmpData.Scan0;

            // Declare an array to hold the bytes of the bitmap.
            // This code is specific to a bitmap with 24 bits per pixels.
            int bytes = bmp.Width * bmp.Height * 3;
            byte[] rgbValues = new byte[bytes];

            // Copy the RGB values into the array.
            System.Runtime.InteropServices.Marshal.Copy(ptr, rgbValues, 0, bytes);

            // Set every red value to 255.  
            for (int counter = 0; counter < rgbValues.Length; counter += 3)
                rgbValues[counter] = 255;

            // Copy the RGB values back to the bitmap
            System.Runtime.InteropServices.Marshal.Copy(rgbValues, 0, ptr, bytes);

            // Unlock the bits.
            bmp.UnlockBits(bmpData);

            // Draw the modified image.
            e.Graphics.DrawImage(bmp, 0, 150);

        }

        /// <summary>
        /// 使用byte[]数据，生成256色灰度　BMP 位图
        /// </summary>
        /// <param name="originalImageData"></param>
        /// <param name="originalWidth"></param>
        /// <param name="originalHeight"></param>
        /// <returns></returns>
        public static Bitmap CreateBitmap(byte[] originalImageData, int originalWidth, int originalHeight)
        {
            //指定8位格式，即256色
            Bitmap resultBitmap = new Bitmap(originalWidth, originalHeight, System.Drawing.Imaging.PixelFormat.Format8bppIndexed);

            //将该位图存入内存中
            MemoryStream curImageStream = new MemoryStream();
            resultBitmap.Save(curImageStream, System.Drawing.Imaging.ImageFormat.Bmp);
            curImageStream.Flush();

            //由于位图数据需要DWORD对齐（4byte倍数），计算需要补位的个数
            int curPadNum = ((originalWidth * 8 + 31) / 32 * 4) - originalWidth;

            //最终生成的位图数据大小
            int bitmapDataSize = ((originalWidth * 8 + 31) / 32 * 4) * originalHeight;

            //数据部分相对文件开始偏移，具体可以参考位图文件格式
            int dataOffset = ReadData(curImageStream, 10, 4);


            //改变调色板，因为默认的调色板是32位彩色的，需要修改为256色的调色板
            int paletteStart = 54;
            int paletteEnd = dataOffset;
            int color = 0;

            for (int i = paletteStart; i < paletteEnd; i += 4)
            {
                byte[] tempColor = new byte[4];
                tempColor[0] = (byte)color;
                tempColor[1] = (byte)color;
                tempColor[2] = (byte)color;
                tempColor[3] = (byte)0;
                color++;

                curImageStream.Position = i;
                curImageStream.Write(tempColor, 0, 4);
            }

            //最终生成的位图数据，以及大小，高度没有变，宽度需要调整
            byte[] destImageData = new byte[bitmapDataSize];
            int destWidth = originalWidth + curPadNum;

            //生成最终的位图数据，注意的是，位图数据 从左到右，从下到上，所以需要颠倒
            for (int originalRowIndex = originalHeight - 1; originalRowIndex >= 0; originalRowIndex--)
            {
                int destRowIndex = originalHeight - originalRowIndex - 1;

                for (int dataIndex = 0; dataIndex < originalWidth; dataIndex++)
                {
                    //同时还要注意，新的位图数据的宽度已经变化destWidth，否则会产生错位
                    destImageData[destRowIndex * destWidth + dataIndex] = originalImageData[originalRowIndex * originalWidth + dataIndex];
                }
            }


            //将流的Position移到数据段   
            curImageStream.Position = dataOffset;

            //将新位图数据写入内存中
            curImageStream.Write(destImageData, 0, bitmapDataSize);

            curImageStream.Flush();

            //将内存中的位图写入Bitmap对象
            resultBitmap = new Bitmap(curImageStream);

            return resultBitmap;
        }

        /// <summary>
        /// 从内存流中指定位置，读取数据
        /// </summary>
        /// <param name="curStream"></param>
        /// <param name="startPosition"></param>
        /// <param name="length"></param>
        /// <returns></returns>
        public static int ReadData(MemoryStream curStream, int startPosition, int length)
        {
            int result = -1;

            byte[] tempData = new byte[length];
            curStream.Position = startPosition;
            curStream.Read(tempData, 0, length);
            result = BitConverter.ToInt32(tempData, 0);

            return result;
        }

        /// <summary>
        /// 向内存流中指定位置，写入数据
        /// </summary>
        /// <param name="curStream"></param>
        /// <param name="startPosition"></param>
        /// <param name="length"></param>
        /// <param name="value"></param>
        public static void WriteData(MemoryStream curStream, int startPosition, int length, int value)
        {
            curStream.Position = startPosition;
            curStream.Write(BitConverter.GetBytes(value), 0, length);
        }

    }
}
