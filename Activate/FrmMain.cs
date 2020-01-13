using QRCoder;
using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Activate
{
    /// <summary>
    /// XK3100激活二维码生成软件
    /// 作者：wuxiaojie
    /// </summary>
    public partial class FrmMain : Form
    {
        private string path = Application.StartupPath + "\\二维码";
        private const string _KEY = "12345678synogene";
        private const string _IV = "1234syno5678gene";

        public FrmMain()
        {
            InitializeComponent();
            if (!Directory.Exists(path)) Directory.CreateDirectory(path);
        }

        /// <summary>
        /// 生成二维码单击事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bCreateQRCode_Click(object sender, EventArgs e)
        {
            // 设备编号为9位数
            const string pattern = "^[0-9]{9}$";
            Regex rx = new Regex(pattern);
            string sn = tbSN.Text;
            if (rx.IsMatch(sn))
            {
                pbBitmap.Image = GetBitmap(sn);
                pbBitmap.Image.Save(path + "\\" + sn + ".png", ImageFormat.Png);
            }
            else
            {
                MessageBox.Show("设备编号不正确！", "提示");
            }
        }

        /// <summary>
        /// 通过设备编号生成二维码
        /// </summary>
        /// <param name="sn">设备编号</param>
        /// <returns></returns>
        private Bitmap GetBitmap(string sn)
        {
            string plainText = AesEncrypt_Base64(sn);
            QRCodeGenerator qrcodeGenerator = new QRCodeGenerator();
            QRCodeData qrcodeData = qrcodeGenerator.CreateQrCode(plainText, QRCodeGenerator.ECCLevel.M, true);
            QRCode qrcode = new QRCode(qrcodeData);
            Bitmap bitmap = qrcode.GetGraphic(7, Color.Black, Color.White, false);
            return bitmap;
        }

        /// <summary>
        /// AES加密 string - aesString - base64String
        /// </summary>
        /// <param name="encryptStr"></param>
        /// <returns></returns>
        private static string AesEncrypt_Base64(string encryptStr)
        {
            byte[] keyArray = Encoding.UTF8.GetBytes(_KEY);
            byte[] ivArray = Encoding.UTF8.GetBytes(_IV);
            byte[] toEncryptArray = Encoding.UTF8.GetBytes(encryptStr);

            using (RijndaelManaged rijAlg = new RijndaelManaged())
            {
                rijAlg.Key = keyArray;
                rijAlg.IV = ivArray;
                rijAlg.Mode = CipherMode.ECB;
                rijAlg.Padding = PaddingMode.PKCS7;

                ICryptoTransform encryptor = rijAlg.CreateEncryptor(rijAlg.Key, rijAlg.IV);
                byte[] resultArray = encryptor.TransformFinalBlock(toEncryptArray, 0, toEncryptArray.Length);
                return Convert.ToBase64String(resultArray, 0, resultArray.Length);
            }
        }

        /// <summary>
        /// 打开图像位置单击事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bOpenQRCode_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("explorer.exe", path);
        }
    }
}
