using QRCoder;

namespace QRCodeGeneratorApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // This function will generate the QR code when the button is clicked
        private void BtnGenerateQRCode_Click(object sender, EventArgs e)
        {
            string textToEncode = txtQRCodeText.Text; // Get text from TextBox

            // Ensure text is not empty
            if (string.IsNullOrWhiteSpace(textToEncode))
            {
                MessageBox.Show("Please enter text to generate a QR Code.");
                return;
            }

            try
            {
                // Create the QR code generator
                using (QRCodeGenerator qrGenerator = new QRCodeGenerator())
                {
                    QRCodeData qrCodeData = qrGenerator.CreateQrCode(textToEncode, QRCodeGenerator.ECCLevel.Q);
                    using (QRCode qrCode = new QRCode(qrCodeData))
                    {
                        // Generate the QR code image
                        Bitmap qrCodeImage = qrCode.GetGraphic(5); // 20 is the pixel size of the QR code

                        // Resize the image to fit 200x200 px
                        Bitmap resizedImage = new Bitmap(qrCodeImage, new Size(200, 200)); // Resize

                        // Display the QR code in the PictureBox
                        pictureBoxQRCode.Image = qrCodeImage;
                        pictureBoxQRCode.Refresh(); // Refresh to make sure the PictureBox updates with the image
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error generating QR Code: {ex.Message}");
            }
        }

        private void BtnCopyToClipboard_Click(object sender, EventArgs e)
        {
            if (pictureBoxQRCode.Image != null)
            {
                Clipboard.SetImage(pictureBoxQRCode.Image);
                MessageBox.Show("QR Code copied to clipboard.");
            }
            else
            {
                MessageBox.Show("No QR Code to copy.");
            }
        }
    }
}
