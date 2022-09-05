using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Labb2_Azure_AnalyseImage
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //Open 1 picture file
        private void browseBtn_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog dlg = new OpenFileDialog())
            {
                openFileDialog1.Multiselect = false;
                openFileDialog1.Filter = "Image Files(*.png;*.jpg)|*.png;*.jpg|All files (*.*)|*.*";

                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    //Do something
                    localPictureTextbox.Text = dlg.FileName.ToString();
                    beforeAnalyse.Image = Image.FromFile(dlg.FileName);
                    beforeAnalyse.SizeMode = PictureBoxSizeMode.StretchImage;
                }
            }
        }

        private void downloadBtn_Click(object sender, EventArgs e)
        {
            try
            {
                beforeAnalyse.Image = null;

                string imageUrlString = urlTextbox.Text;

                using (WebClient webClient = new WebClient())
                {
                    byte[] data = webClient.DownloadData(imageUrlString);

                    using (MemoryStream mem = new MemoryStream(data))
                    {
                        // Deletes the file if new comes in.
                        if (File.Exists("DownloadedImage.png"))
                        {
                            File.Delete("DownloadedImage.png");
                        }

                        using (var yourImage = Image.FromStream(mem))
                        {
                            // Saves the file as .png from url
                            yourImage.Save("DownloadedImage.png", ImageFormat.Png);
                            yourImage.Dispose();
                            beforeAnalyse.Image = Image.FromFile("DownloadedImage.png");
                            beforeAnalyse.SizeMode = PictureBoxSizeMode.StretchImage;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private async void analyseBtn_Click(object sender, EventArgs e)
        {
            // Decides which one it should use, if it's from URL or a local file
            if (urlRadioBtn.Checked)
            {
                AnalyseUrlImage url = new AnalyseUrlImage();
                await url.StartAnalyseUrl(urlTextbox.Text);
                afterAnalyse.Image = Image.FromFile("objectsUrl.png");
                afterAnalyse.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            else if (localRadioBtn.Checked)
            {
                AnalyseLocalImage local = new AnalyseLocalImage();
                await local.Start(localPictureTextbox.Text);
                afterAnalyse.Image = Image.FromFile("objectsLocal.png");
                afterAnalyse.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }
    }
}
