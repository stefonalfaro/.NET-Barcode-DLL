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
        public static System.Drawing.Image UPCA(string data)
        {
            BarCodeSettings settings = new BarCodeSettings{
                Type = BarCodeType.Upca,
                Data = data
            };

            BarCodeGenerator generator = new BarCodeGenerator(settings);

            using (var barcodeImage = generator.GenerateImage()){
                return barcodeImage;
            }
        }

        public static System.Drawing.Image UPCE(string data)
        {
            BarCodeSettings settings = new BarCodeSettings
            {
                Type = BarCodeType.Upce,
                Data = data
            };

            BarCodeGenerator generator = new BarCodeGenerator(settings);

            using (var barcodeImage = generator.GenerateImage())
            {
                return barcodeImage;
            }
        }

        public static System.Drawing.Image Code128(string data)
        {
            BarCodeSettings settings = new BarCodeSettings
            {
                Type = BarCodeType.Code128,
                Data = data
            };

            BarCodeGenerator generator = new BarCodeGenerator(settings);

            using (var barcodeImage = generator.GenerateImage())
            {
                return barcodeImage;
            }
        }

        public static System.Drawing.Image Code39(string data)
        {
            BarCodeSettings settings = new BarCodeSettings
            {
                Type = BarCodeType.Code39,
                Data = data
            };

            BarCodeGenerator generator = new BarCodeGenerator(settings);

            using (var barcodeImage = generator.GenerateImage())
            {
                return barcodeImage;
            }
        }

        public static System.Drawing.Image Interleaved25(string data)
        {
            BarCodeSettings settings = new BarCodeSettings
            {
                Type = BarCodeType.Interleaved25,
                Data = data
            };

            BarCodeGenerator generator = new BarCodeGenerator(settings);

            using (var barcodeImage = generator.GenerateImage())
            {
                return barcodeImage;
            }
        }

        public static System.Drawing.Image PostNet(string data)
        {
            BarCodeSettings settings = new BarCodeSettings
            {
                Type = BarCodeType.PostNet,
                Data = data
            };

            BarCodeGenerator generator = new BarCodeGenerator(settings);

            using (var barcodeImage = generator.GenerateImage())
            {
                return barcodeImage;
            }
        }

        public static System.Drawing.Image Standard25(string data)
        {
            BarCodeSettings settings = new BarCodeSettings
            {
                Type = BarCodeType.Standard25,
                Data = data
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
        public static string UPCA(string data)
        {
            return Convert.ToBase64String(Bytes.UPCA(data));
        }

        public static string Code128(string data)
        {
            return Convert.ToBase64String(Bytes.Code128(data));
        }

        public static string Ean13(string data)
        {
            return Convert.ToBase64String(Bytes.Ean13(data));
        }

        public static string Ean8(string data)
        {
            return Convert.ToBase64String(Bytes.Ean8(data));
        }

        public static string Interleaved25(string data)
        {
            return Convert.ToBase64String(Bytes.Interleaved25(data));
        }

        public static string PostNet(string data)
        {
            return Convert.ToBase64String(Bytes.PostNet(data));
        }

        public static string Standard25(string data)
        {
            return Convert.ToBase64String(Bytes.Standard25(data));
        }

        public static string UPCE(string data)
        {
            return Convert.ToBase64String(Bytes.UPCE(data));
        }
    }

    public class Bytes
    {
        public static byte[] Code128(string data)
        {
            BarCodeSettings settings = new BarCodeSettings
            {
                Type = BarCodeType.Code128,
                Data = data, 
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

        public static byte[] UPCA(string data)
        {
            BarCodeSettings settings = new BarCodeSettings
            {
                Type = BarCodeType.Upca,
                Data = data
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

        public static byte[] Ean13(string data)
        {
            BarCodeSettings settings = new BarCodeSettings
            {
                Type = BarCodeType.Ean13,
                Data = data
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

        public static byte[] Ean8(string data)
        {
            BarCodeSettings settings = new BarCodeSettings
            {
                Type = BarCodeType.Ean8,
                Data = data
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

        public static byte[] Interleaved25(string data)
        {
            BarCodeSettings settings = new BarCodeSettings
            {
                Type = BarCodeType.Interleaved25,
                Data = data
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

        public static byte[] PostNet(string data)
        {
            BarCodeSettings settings = new BarCodeSettings
            {
                Type = BarCodeType.PostNet,
                Data = data
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

        public static byte[] Standard25(string data)
        {
            BarCodeSettings settings = new BarCodeSettings
            {
                Type = BarCodeType.Standard25,
                Data = data
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

        public static byte[] UPCE(string data)
        {
            BarCodeSettings settings = new BarCodeSettings
            {
                Type = BarCodeType.Upce,
                Data = data
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
