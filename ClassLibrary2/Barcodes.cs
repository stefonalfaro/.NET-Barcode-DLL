using NBarCodes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Drawing;

namespace Barcodes
{
    public class Image
    {
        public static System.Drawing.Image UPCA(string data, Boolean HideFont=false)
        {
            System.Drawing.Color fontColor = System.Drawing.Color.Black;
            if (HideFont)
            {
                fontColor = System.Drawing.Color.White;
            }

            BarCodeSettings settings = new BarCodeSettings{
                Type = BarCodeType.Upca,
                Data = data,
                FontColor = fontColor
            };

            BarCodeGenerator generator = new BarCodeGenerator(settings);

            using (var barcodeImage = generator.GenerateImage()){
                return barcodeImage;
            }
        }

        public static System.Drawing.Image UPCE(string data, Boolean HideFont = false)
        {
            System.Drawing.Color fontColor = System.Drawing.Color.Black;
            if (HideFont)
            {
                fontColor = System.Drawing.Color.White;
            }

            BarCodeSettings settings = new BarCodeSettings
            {
                Type = BarCodeType.Upce,
                Data = data,
                FontColor = fontColor
            };

            BarCodeGenerator generator = new BarCodeGenerator(settings);

            using (var barcodeImage = generator.GenerateImage())
            {
                return barcodeImage;
            }
        }

        public static System.Drawing.Image Code128(string data, Boolean HideFont = false)
        {
            System.Drawing.Color fontColor = System.Drawing.Color.Black;
            if (HideFont)
            {
                fontColor = System.Drawing.Color.White;
            }

            BarCodeSettings settings = new BarCodeSettings
            {
                Type = BarCodeType.Code128,
                Data = data,
                FontColor = fontColor
            };

            BarCodeGenerator generator = new BarCodeGenerator(settings);

            using (var barcodeImage = generator.GenerateImage())
            {
                return barcodeImage;
            }
        }

        public static System.Drawing.Image Code39(string data, Boolean HideFont = false)
        {
            System.Drawing.Color fontColor = System.Drawing.Color.Black;
            if (HideFont)
            {
                fontColor = System.Drawing.Color.White;
            }

            BarCodeSettings settings = new BarCodeSettings
            {
                Type = BarCodeType.Code39,
                Data = data,
                FontColor = fontColor
            };

            BarCodeGenerator generator = new BarCodeGenerator(settings);

            using (var barcodeImage = generator.GenerateImage())
            {
                return barcodeImage;
            }
        }

        public static System.Drawing.Image Interleaved25(string data, Boolean HideFont = false)
        {
            System.Drawing.Color fontColor = System.Drawing.Color.Black;
            if (HideFont)
            {
                fontColor = System.Drawing.Color.White;
            }

            BarCodeSettings settings = new BarCodeSettings
            {
                Type = BarCodeType.Interleaved25,
                Data = data,
                FontColor = fontColor
            };

            BarCodeGenerator generator = new BarCodeGenerator(settings);

            using (var barcodeImage = generator.GenerateImage())
            {
                return barcodeImage;
            }
        }

        public static System.Drawing.Image PostNet(string data, Boolean HideFont = false)
        {
            System.Drawing.Color fontColor = System.Drawing.Color.Black;
            if (HideFont)
            {
                fontColor = System.Drawing.Color.White;
            }

            BarCodeSettings settings = new BarCodeSettings
            {
                Type = BarCodeType.PostNet,
                Data = data,
                FontColor = fontColor
            };

            BarCodeGenerator generator = new BarCodeGenerator(settings);

            using (var barcodeImage = generator.GenerateImage())
            {
                return barcodeImage;
            }
        }

        public static System.Drawing.Image Standard25(string data, Boolean HideFont = false)
        {
            System.Drawing.Color fontColor = System.Drawing.Color.Black;
            if (HideFont)
            {
                fontColor = System.Drawing.Color.White;
            }

            BarCodeSettings settings = new BarCodeSettings
            {
                Type = BarCodeType.Standard25,
                Data = data,
                FontColor = fontColor
            };

            BarCodeGenerator generator = new BarCodeGenerator(settings);

            using (var barcodeImage = generator.GenerateImage())
            {
                return barcodeImage;
            }
        }
    }

    public class Base64
    {
        public static string UPCA(string data, Boolean HideFont = false)
        {
            return Convert.ToBase64String(Bytes.UPCA(data, HideFont));
        }

        public static string Code128(string data, Boolean HideFont = false)
        {
            return Convert.ToBase64String(Bytes.Code128(data, HideFont));
        }

        public static string Ean13(string data, Boolean HideFont = false)
        {
            return Convert.ToBase64String(Bytes.Ean13(data, HideFont));
        }

        public static string Ean8(string data, Boolean HideFont = false)
        {
            return Convert.ToBase64String(Bytes.Ean8(data, HideFont));
        }

        public static string Interleaved25(string data, Boolean HideFont = false)
        {
            return Convert.ToBase64String(Bytes.Interleaved25(data, HideFont));
        }

        public static string PostNet(string data, Boolean HideFont = false)
        {
            return Convert.ToBase64String(Bytes.PostNet(data, HideFont));
        }

        public static string Standard25(string data, Boolean HideFont = false)
        {
            return Convert.ToBase64String(Bytes.Standard25(data, HideFont));
        }

        public static string UPCE(string data, Boolean HideFont = false)
        {
            return Convert.ToBase64String(Bytes.UPCE(data, HideFont));
        }
    }

    public class Bytes
    {
        public static byte[] Code128(string data, Boolean HideFont = false)
        {
            System.Drawing.Color fontColor = System.Drawing.Color.Black;
            if (HideFont)
            {
                fontColor = System.Drawing.Color.White;
            }

            BarCodeSettings settings = new BarCodeSettings
            {
                Type = BarCodeType.Code128,
                Data = data,
                FontColor = fontColor
            };

            BarCodeGenerator generator = new BarCodeGenerator(settings);

            using (var barcodeImage = generator.GenerateImage())
            {
                using (var stream = new MemoryStream())
                {
                    barcodeImage.Save(stream, System.Drawing.Imaging.ImageFormat.Png);
                    return stream.ToArray();
                }
            }
        }

        public static byte[] UPCA(string data, Boolean HideFont = false)
        {
            System.Drawing.Color fontColor = System.Drawing.Color.Black;
            if (HideFont)
            {
                fontColor = System.Drawing.Color.White;
            }

            BarCodeSettings settings = new BarCodeSettings
            {
                Type = BarCodeType.Upca,
                Data = data,
                FontColor = fontColor
            };

            BarCodeGenerator generator = new BarCodeGenerator(settings);

            using (var barcodeImage = generator.GenerateImage())
            {
                using (var stream = new MemoryStream())
                {
                    barcodeImage.Save(stream, System.Drawing.Imaging.ImageFormat.Png);
                    return stream.ToArray();
                }
            }
        }

        public static byte[] Ean13(string data, Boolean HideFont = false)
        {
            System.Drawing.Color fontColor = System.Drawing.Color.Black;
            if (HideFont)
            {
                fontColor = System.Drawing.Color.White;
            }

            BarCodeSettings settings = new BarCodeSettings
            {
                Type = BarCodeType.Ean13,
                Data = data,
                FontColor = fontColor
            };

            BarCodeGenerator generator = new BarCodeGenerator(settings);

            using (var barcodeImage = generator.GenerateImage())
            {
                using (var stream = new MemoryStream())
                {
                    barcodeImage.Save(stream, System.Drawing.Imaging.ImageFormat.Png);
                    return stream.ToArray();
                }
            }
        }

        public static byte[] Ean8(string data, Boolean HideFont = false)
        {
            System.Drawing.Color fontColor = System.Drawing.Color.Black;
            if (HideFont)
            {
                fontColor = System.Drawing.Color.White;
            }

            BarCodeSettings settings = new BarCodeSettings
            {
                Type = BarCodeType.Ean8,
                Data = data,
                FontColor = fontColor
            };

            BarCodeGenerator generator = new BarCodeGenerator(settings);

            using (var barcodeImage = generator.GenerateImage())
            {
                using (var stream = new MemoryStream())
                {
                    barcodeImage.Save(stream, System.Drawing.Imaging.ImageFormat.Png);
                    return stream.ToArray();
                }
            }
        }

        public static byte[] Interleaved25(string data, Boolean HideFont = false)
        {
            System.Drawing.Color fontColor = System.Drawing.Color.Black;
            if (HideFont)
            {
                fontColor = System.Drawing.Color.White;
            }

            BarCodeSettings settings = new BarCodeSettings
            {
                Type = BarCodeType.Interleaved25,
                Data = data,
                FontColor = fontColor
            };

            BarCodeGenerator generator = new BarCodeGenerator(settings);

            using (var barcodeImage = generator.GenerateImage())
            {
                using (var stream = new MemoryStream())
                {
                    barcodeImage.Save(stream, System.Drawing.Imaging.ImageFormat.Png);
                    return stream.ToArray();
                }
            }
        }

        public static byte[] PostNet(string data, Boolean HideFont = false)
        {
            System.Drawing.Color fontColor = System.Drawing.Color.Black;
            if (HideFont)
            {
                fontColor = System.Drawing.Color.White;
            }

            BarCodeSettings settings = new BarCodeSettings
            {
                Type = BarCodeType.PostNet,
                Data = data,
                FontColor = fontColor
            };

            BarCodeGenerator generator = new BarCodeGenerator(settings);

            using (var barcodeImage = generator.GenerateImage())
            {
                using (var stream = new MemoryStream())
                {
                    barcodeImage.Save(stream, System.Drawing.Imaging.ImageFormat.Png);
                    return stream.ToArray();
                }
            }
        }

        public static byte[] Standard25(string data, Boolean HideFont = false)
        {
            System.Drawing.Color fontColor = System.Drawing.Color.Black;
            if (HideFont)
            {
                fontColor = System.Drawing.Color.White;
            }

            BarCodeSettings settings = new BarCodeSettings
            {
                Type = BarCodeType.Standard25,
                Data = data,
                FontColor = fontColor
            };

            BarCodeGenerator generator = new BarCodeGenerator(settings);

            using (var barcodeImage = generator.GenerateImage())
            {
                using (var stream = new MemoryStream())
                {
                    barcodeImage.Save(stream, System.Drawing.Imaging.ImageFormat.Png);
                    return stream.ToArray();
                }
            }
        }

        public static byte[] UPCE(string data, Boolean HideFont = false)
        {

            System.Drawing.Color fontColor = System.Drawing.Color.Black;
            if (HideFont)
            {
                fontColor = System.Drawing.Color.White;
            }

            BarCodeSettings settings = new BarCodeSettings
            {
                Type = BarCodeType.Upce,
                Data = data,
                FontColor = fontColor
            };

            BarCodeGenerator generator = new BarCodeGenerator(settings);

            using (var barcodeImage = generator.GenerateImage())
            {
                using (var stream = new MemoryStream())
                {
                    barcodeImage.Save(stream, System.Drawing.Imaging.ImageFormat.Png);
                    return stream.ToArray();
                }
            }
        }
    }
}
