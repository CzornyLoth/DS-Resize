using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Drawing.Drawing2D;
using System.Globalization;
using System.Text.RegularExpressions;

namespace DataChanger_Resizer
{
    public partial class Form1 : Form
    {
        string data_wpis;
        float high;
        float wid;
        string currentDir = "";
        public Form1()
        {
            InitializeComponent();
        }
        public static double cnv(long bytes)
        {
            return (bytes / 1024f) / 1024f;
        }

        private void open_directory_Click(object sender, EventArgs e)
        {
            try
            {
                textBoxDirectory.Clear();
                Image_name.Items.Clear();
                textBoxDirectory.Refresh();
                pictureBoxImagePreview.Refresh();
                var fb = new FolderBrowserDialog();
                ;
                if (fb.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    currentDir = fb.SelectedPath; //pobierz forder
                    //dodaj wszystkie pliki z ścieżki
                    var dirInfo = new DirectoryInfo(currentDir);
                    var files = dirInfo.GetFiles()
                        .Where(c => (c.Extension.Equals(".JPG") || c.Extension.Equals(".jpg") || c.Extension.Equals(".JPEG") || c.Extension.Equals(".bmp") || c.Extension.Equals(".png") || c.Extension.Equals("////")));
                    textBoxDirectory.Text = currentDir;
                    foreach (var image in files)
                    {
                        Image_name.Items.Add(image.Name);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Wystąpił błąd: " + ex.Message + " " + ex.Source);
            }
        }

        private void Image_name_SelectedIndexChanged(object sender, EventArgs e)
        {
            label4.Text = "";
            try
            {
                var selectedImage = Image_name.SelectedItems[0].ToString();
                if (!string.IsNullOrEmpty(selectedImage) && !string.IsNullOrEmpty(currentDir))
                {
                    var fullpath = Path.Combine(currentDir, selectedImage.ToString());
                    using (var file = File.OpenRead(fullpath))
                    {
                        byte[] imageBytes = new byte[file.Length];
                        file.Read(imageBytes, 0, (int)file.Length);
                        MemoryStream ms = new MemoryStream(imageBytes);
                        pictureBoxImagePreview.Image = Image.FromStream(ms);
                    }
                }
                textBoxDirectory.Text = currentDir + "\\" + selectedImage.ToString();
                string lokal = currentDir + "\\" + selectedImage.ToString();
                FileInfo fi = new FileInfo(lokal);
                string s = cnv(fi.Length).ToString("0.00");
                label5.Text = s + " MB";
                Image img = new Bitmap(lokal);
                string H = img.Height.ToString();
                string W = img.Width.ToString();
                wid = img.Width - 400;
                img.Dispose();
                label6.Text = H.ToString() + " x " + W.ToString();
            }
            catch (Exception exc)
            {
                MessageBox.Show("Wystąpił błąd: " + exc.Message + " " + exc.Source);
            }
        }

        private void size_change_Click(object sender, EventArgs e)
        {
        }
        private void add_data_Click(object sender, EventArgs e)
        {
            label4.Text = "";
            if (pictureBoxImagePreview.Image == null) return;
            var selectedImage = Image_name.SelectedItems[0].ToString();
            string plik = selectedImage.ToString();
            string lokalizacja = currentDir + "\\" + plik;
            try
            {
                Regex r = new Regex(":");
                using (FileStream fs = new FileStream(lokalizacja, FileMode.Open, FileAccess.Read))
                using (Image myImage = Image.FromStream(fs, false, false))
                {
                    PropertyItem propItem = myImage.GetPropertyItem(36867);
                    string dateTaken = r.Replace(Encoding.UTF8.GetString(propItem.Value), "-", 2);
                    data_wpis = DateTime.Parse(dateTaken).ToString();
                    high = myImage.Height;
                    wid = myImage.Width;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Brak informacji o zdjęciu, brak posiadanej daty przez zdjęcie!!");
            }
            label4.Text = data_wpis;
          //  var ratio = wid / high;
            int resizeWidth = 1600;
            int resizeHeight = 1200;

            //if (ratio * resizeHeight <= 1600)
            //{
            //    resizeWidth = (int)Math.Floor(ratio * resizeHeight);
            //}
            //else
            //{
            //    resizeHeight = (int)Math.Floor(resizeWidth / ratio);
            //}
            var resized = ResizeImage(pictureBoxImagePreview.Image, resizeWidth, resizeHeight);
            pictureBoxImagePreview.Image = resized;
            Graphics g = Graphics.FromImage(pictureBoxImagePreview.Image);
            g.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAlias;
            Font fn = new Font("Tahoma", 32);
            SizeF measure = g.MeasureString(data_wpis, fn);
            g.DrawString(data_wpis, fn, Brushes.Red, resizeWidth - measure.Width, resizeHeight - measure.Height);
            g.Save();
            resized.Save(lokalizacja, ImageFormat.Jpeg);
            label6.Text = $"{resizeWidth} x {resizeHeight}";
            string lokal = currentDir + "\\" + selectedImage.ToString();
            FileInfo fi = new FileInfo(lokal);
            string s = cnv(fi.Length).ToString("0.00");
            label5.Text = s + " MB";
        }
        
        public static Bitmap ResizeImage(Image image, int width, int height)
        {
            var destRect = new Rectangle(0, 0, width, height);
            var destImage = new Bitmap(width, height);          
            destImage.SetResolution(image.HorizontalResolution, image.VerticalResolution);
          
            using (var graphics = Graphics.FromImage(destImage))
            {
                graphics.CompositingMode = CompositingMode.SourceCopy;
                graphics.CompositingQuality = CompositingQuality.HighQuality;
                graphics.InterpolationMode = InterpolationMode.HighQualityBicubic;
                graphics.SmoothingMode = SmoothingMode.HighQuality;
                graphics.PixelOffsetMode = PixelOffsetMode.HighQuality;
                using (var wrapMode = new ImageAttributes())
                {
                    wrapMode.SetWrapMode(WrapMode.TileFlipXY);
                    graphics.DrawImage(image, destRect, 0, 0, image.Width, image.Height, GraphicsUnit.Pixel, wrapMode);
                }
            }
            return destImage;
        }
    }
}
