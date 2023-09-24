using ZXing;
using ZXing.Common;

namespace QRCS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnDecodeQR_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Filter = @"Image Files(*.BMP;*.JPG;*.GIF;*.PNG)|*.BMP;*.JPG;*.GIF;*.PNG",
                RestoreDirectory = true
            };

            if (openFileDialog.ShowDialog() != DialogResult.OK) return;
            try
            {
                var fileName = openFileDialog.FileName;
                var qrContent = DecodeQRCode(fileName);

                {
                    const string outputFileName = "decoded_qr_content.txt";
                    File.WriteAllText(outputFileName, qrContent);
                    MessageBox.Show($@"QR code content saved to {outputFileName}");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($@"Error: {ex.Message}");
            }
        }

        private static string DecodeQRCode(string imagePath)
        {
            using var bitmap = new Bitmap(imagePath);
            var luminanceSource = new BitmapLuminanceSource(bitmap);
            var binarizer = new HybridBinarizer(luminanceSource);
            var binaryBitmap = new BinaryBitmap(binarizer);
            var reader = new BarcodeReader<>();
            var result = reader.Decode(binaryBitmap);

            return result?.Text!;
        }
    }
}