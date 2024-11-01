using QRCoder;


namespace DiemDanhSV.PAL.Forms.InstructorView
{
    public partial class FormQRCoder : Form
    {
        private string link;
        public FormQRCoder(string link)
        {       
            this.link = link;
            InitializeComponent();
        }

        private void FormQRCoder_Load(object sender, EventArgs e)
        {
            pictureBox1.Image = GenerateQRCode(link); 
        }
        private Bitmap GenerateQRCode(string link)
        {
            QRCodeGenerator qrGenerator = new QRCodeGenerator();
            QRCodeData qrCodeData = qrGenerator.CreateQrCode(link, QRCodeGenerator.ECCLevel.Q);
            QRCode qrCode = new QRCode(qrCodeData);
            return qrCode.GetGraphic(5);
        }
    }
}
