using System;
using System.Drawing;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Drawing.Imaging;
using Emgu.CV;
using Emgu.CV.Structure;

namespace Laba4
{
    public partial class Form1 : MetroFramework.Forms.MetroForm
    {
        private Bitmap pic;
        private Bitmap bmp;
        private bool Guassin = false;
        private bool Canny = false;

        Image<Bgr, Byte> InputImage;
        Image<Bgr, Byte> InputImage2;

        Image<Gray, Byte> R;
        Image<Gray, Byte> R2;
        public Form1()
        {
            InitializeComponent();
            this.StyleManager = metroStyleManager1;
        }

        private void Form1_Load(object sender, EventArgs e) { }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                bmp = (Bitmap)Bitmap.FromFile(openFileDialog1.FileName);
                Bitmap display = ScaleImage(bmp);
                pictureBox1.Image = display;
                this.pic = (Bitmap)pictureBox1.Image;

                InputImage = new Image<Bgr, byte>(this.pic);
                R = InputImage[0];
                imageBox1.Image = R;
                histogramBox1.ClearHistogram();
                histogramBox1.GenerateHistograms(R, 256);
                histogramBox1.Refresh();
            }
            textBox1.Visible = true;
            textBox2.Visible = true;
            label1.Visible = true;
            label2.Visible = true;
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image != null)
            {
                SaveFileDialog savedialog = new SaveFileDialog();
                savedialog.Title = "Сохранить картинку как...";
                savedialog.OverwritePrompt = true;
                savedialog.CheckPathExists = true;
                savedialog.Filter = "Image Files(*.BMP)|*.BMP|Image Files(*.JPG)|*.JPG|Image Files(*.GIF)|*.GIF|Image Files(*.PNG)|*.PNG|All files (*.*)|*.*";
                savedialog.ShowHelp = true;

                if (savedialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        pictureBox1.Image.Save(savedialog.FileName, System.Drawing.Imaging.ImageFormat.Jpeg);
                    }
                    catch
                    {
                        MessageBox.Show("Невозможно сохранить изображение", "Ошибка",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void startToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Guassin = true;
            this.Canny =  false;
            if (pictureBox1.Image != null)
            {
                metroLabel1.Visible = true;
                metroLabel2.Visible = true;
                metroTextBox2.Visible = true;
                metroTextBox3.Visible = true;
                metroButton1.Visible = true;

                metroLabel2.Text = "Input size of kernel:";
                metroLabel1.Text = "Input sigma:";
            }
            else
            {
                MessageBox.Show("Choose a picture!");
            }        
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            if (this.Guassin)
            { 
                if (!int.TryParse(metroTextBox2.Text, out int kernelSize))
                {
                    MessageBox.Show("Input correct data!");
                    return;
                }
                if (!double.TryParse(metroTextBox3.Text, out double standardDeviation))
                {
                    MessageBox.Show("Input correct data");
                    return;
                }

                Bitmap transform = Convolve(bmp, GaussianKernel(kernelSize, standardDeviation));
                Bitmap display = ScaleImage(transform);
                pictureBox1.Image = display;
            }
            if (Canny)
            {
                if (!int.TryParse(metroTextBox2.Text, out int threshold))
                {
                    MessageBox.Show("Input correct data!");
                    return;
                }

                Canny canny = new Canny();
                canny.CannyEdgeDetection(threshold, pictureBox1);
                pictureBox1.Image.Save(@"C:\Users\alesy\Pictures\Saved Pictures" + System.Guid.NewGuid() + ".jpeg", System.Drawing.Imaging.ImageFormat.Jpeg);
            }
        }

        public static double[,] GaussianKernel(int lenght, double weight)
        {
            double[,] kernel = new double[lenght, lenght];
            double kernelSum = 0;
            int foff = (lenght - 1) / 2;
            double distance;
            double constant = 1d / (2 * Math.PI * weight * weight);

            for (int y = -foff; y <= foff; y++)
            {
                for (int x = -foff; x <= foff; x++)
                {
                    distance = ((y * y) + (x * x)) / (2 * weight * weight);
                    kernel[y + foff, x + foff] = constant * Math.Exp(-distance);
                    kernelSum += kernel[y + foff, x + foff];
                }
            }
            for (int y = 0; y < lenght; y++)
            {
                for (int x = 0; x < lenght; x++)
                {
                    kernel[y, x] = kernel[y, x] * 1d / kernelSum;
                }
            }
            return kernel;
        }
        private static Bitmap Convolve(Bitmap srcImage, double[,] kernel)
        {
            int width = srcImage.Width;
            int height = srcImage.Height;
            BitmapData srcData = srcImage.LockBits(new Rectangle(0, 0, width, height),
                ImageLockMode.ReadOnly, PixelFormat.Format32bppArgb);
            int bytes = srcData.Stride * srcData.Height;
            byte[] buffer = new byte[bytes];
            byte[] result = new byte[bytes];
            Marshal.Copy(srcData.Scan0, buffer, 0, bytes);
            srcImage.UnlockBits(srcData);
            int colorChannels = 3;
            double[] rgb = new double[colorChannels];
            int foff = (kernel.GetLength(0) - 1) / 2;
            int kcenter;
            int kpixel;

            for (int y = foff; y < height - foff; y++)
            {
                for (int x = foff; x < width - foff; x++)
                {
                    for (int c = 0; c < colorChannels; c++)
                    {
                        rgb[c] = 0.0;
                    }
                    kcenter = y * srcData.Stride + x * 4;
                    for (int fy = -foff; fy <= foff; fy++)
                    {
                        for (int fx = -foff; fx <= foff; fx++)
                        {
                            kpixel = kcenter + fy * srcData.Stride + fx * 4;
                            for (int c = 0; c < colorChannels; c++)
                            {
                                rgb[c] += (double)(buffer[kpixel + c]) * kernel[fy + foff, fx + foff];
                            }
                        }
                    }
                    for (int c = 0; c < colorChannels; c++)
                    {
                        if (rgb[c] > 255)
                        {
                            rgb[c] = 255;
                        }
                        else if (rgb[c] < 0)
                        {
                            rgb[c] = 0;
                        }
                    }
                    for (int c = 0; c < colorChannels; c++)
                    {
                        result[kcenter + c] = (byte)rgb[c];
                    }
                    result[kcenter + 3] = 255;
                }
            }
            Bitmap resultImage = new Bitmap(width, height);
            BitmapData resultData = resultImage.LockBits(new Rectangle(0, 0, width, height),
                ImageLockMode.WriteOnly, PixelFormat.Format32bppArgb);
            Marshal.Copy(result, 0, resultData.Scan0, bytes);
            resultImage.UnlockBits(resultData);
            return resultImage;
        }
        private Bitmap ScaleImage(Bitmap image)
        {
            double ratioX = (double)pictureBox1.Width / image.Width;
            double ratioY = (double)pictureBox1.Height / image.Height;
            double ratio = Math.Min(ratioX, ratioY);
            int w = (int)(image.Width * ratio);
            int h = (int)(image.Height * ratio);
            Bitmap result = new Bitmap(image, new Size(w, h));
            return result;
        }

        private void grayToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image != null)
            {
                Bitmap bmap = (Bitmap)pictureBox1.Image;
                Color c;

                for (int i = 0; i < bmap.Width; i++)
                {
                    for (int j = 0; j < bmap.Height; j++)
                    {
                        c = bmap.GetPixel(i, j);
                        byte gray = (byte)(.299 * c.R + .587 * c.G + .114 * c.B);

                        bmap.SetPixel(i, j, Color.FromArgb(gray, gray, gray));
                    }
                }
                pictureBox1.Image = (Bitmap)bmap.Clone();
            }
            else
            {
                MessageBox.Show("Please, choose the picture!");
            }
        }

        private void startToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image != null)
            {
                this.Guassin = false;
                this.Canny = true;
                metroTextBox2.Visible = true;
                metroLabel1.Visible = true;
                metroButton1.Visible = true;
                metroLabel2.Visible = true;
                metroTextBox3.Visible = true;

                metroLabel2.Text = "Up treshold:";
                metroLabel1.Text = "Down threshold:";
            }
            else
            {
                MessageBox.Show("Please, choose the picture!");
            }
        }
        private void showToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            InputImage2 = new Image<Bgr, byte>((Bitmap)pictureBox1.Image);
            R2 = InputImage2[0];

            imageBox2.Image = R2;
            histogramBox2.ClearHistogram();

            histogramBox2.GenerateHistograms(R2, 256);

            histogramBox2.Refresh();
        }
        private void sawtoothContrastingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image != null)
            {
                if (!int.TryParse(textBox1.Text, out int min))
                {
                    MessageBox.Show("Please, input correct value!");
                    return;
                }

                if (!int.TryParse(textBox2.Text, out int max))
                {
                    MessageBox.Show("Please, input correct value!");
                    return;
                }

                Bitmap matrixImage = new Bitmap(pictureBox1.Image.Width, pictureBox1.Image.Height);

                Color p;
                int g;

                for (int i = 0; i < pictureBox1.Image.Width; i++)
                {
                    for (int j = 0; j < pictureBox1.Image.Height; j++)
                    {
                        p = ((Bitmap)pictureBox1.Image).GetPixel(i, j);

                        if (p.G < min)
                        {
                            matrixImage.SetPixel(i, j, Color.Black);
                        }
                        else if (p.G > max)
                        {
                            matrixImage.SetPixel(i, j, Color.Black);
                        }
                        else
                        {
                            g = 255 * (p.G - min) / (max - min);
                            matrixImage.SetPixel(i, j, Color.FromArgb(g, g, g));
                        }
                    }
                }
                pictureBox1.Image = matrixImage;
            }
            else
            {
                MessageBox.Show("Please, choose the picture");
            }
        }

        private void sawtoothContrastingзToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image != null)
            {
                if (!int.TryParse(textBox1.Text, out int min))
                {
                    MessageBox.Show("Please, input correct value!");
                    return;
                }

                if (!int.TryParse(textBox2.Text, out int max))
                {
                    MessageBox.Show("Please, input correct value!");
                }

                Bitmap matrixImage = new Bitmap(pictureBox1.Image.Width, pictureBox1.Image.Height);

                Color p;
                int g;

                for (int i = 0; i < pictureBox1.Image.Width; i++)
                {
                    for (int j = 0; j < pictureBox1.Image.Height; j++)
                    {
                        p = ((Bitmap)pictureBox1.Image).GetPixel(i, j);

                        if (p.G < min)
                        {
                            matrixImage.SetPixel(i, j, Color.White);
                        }
                        else if (p.G > max)
                        {
                            matrixImage.SetPixel(i, j, Color.White);
                        }
                        else
                        {
                            g = 255 * (p.G - min) / (max - min);
                            matrixImage.SetPixel(i, j, Color.FromArgb(g, g, g));
                        }
                    }
                }
                pictureBox1.Image = matrixImage;
            }
            else
            {
                MessageBox.Show("Please, choose the picture");
            }
        }

        private void sawtoothContrastingToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image != null)
            {
                if (!int.TryParse(textBox1.Text, out int min))
                {
                    MessageBox.Show("Please, input correct value!");
                    return;
                }

                if (!int.TryParse(textBox2.Text, out int max))
                {
                    MessageBox.Show("Please, input correct value!");
                    return;
                }

                Bitmap matrixImage = new Bitmap(pictureBox1.Image.Width, pictureBox1.Image.Height);

                Color p;
                int g;

                for (int i = 0; i < pictureBox1.Image.Width; i++)
                {
                    for (int j = 0; j < pictureBox1.Image.Height; j++)
                    {
                        p = ((Bitmap)pictureBox1.Image).GetPixel(i, j);

                        if (p.G < min)
                        {
                            matrixImage.SetPixel(i, j, matrixImage.GetPixel(i, j));
                        }
                        else if (p.G > max)
                        {
                            matrixImage.SetPixel(i, j, matrixImage.GetPixel(i,j));
                        }
                        else
                        {
                            g = 255 * (p.G - min) / (max - min);
                            matrixImage.SetPixel(i, j, Color.FromArgb(g, g, g));
                        }
                    }
                }
                pictureBox1.Image = matrixImage;
            }
            else
            {
                MessageBox.Show("Please, choose the picture");
            }

        }

        private void sawtoothContrastingToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image != null)
            {
                label1.Text = "N";

                if (!decimal.TryParse(textBox1.Text, out decimal n))
                {
                    MessageBox.Show("Input correct value!");
                    return;
                }

                int dim = Convert.ToInt32(Math.Floor(256.0M / n));
                int x = 0;
                int y = dim - 1;
                int pldim;

                Bitmap matrixImage = new Bitmap(pictureBox1.Image.Width, pictureBox1.Image.Height);

                Color p;
                int g;

                for (int i = 0; i < pictureBox1.Image.Width; i++)
                {
                    for (int j = 0; j < pictureBox1.Image.Height; j++)
                    {
                        p = ((Bitmap)pictureBox1.Image).GetPixel(i, j);
                        g = p.G - dim;
                        pldim = 0;
                        while (g > dim)
                        {
                            g = p.G - dim;
                            matrixImage.SetPixel(i, j, Color.FromArgb(g, g, g));
                            pldim = pldim + 1;
                        }

                        g = p.G + 1;

                        matrixImage.SetPixel(i, j, Color.FromArgb(g, g, g));
                        g = Math.Abs(255 - (255 * (p.G - x) / (y - x)));
                        matrixImage.SetPixel(i, j, Color.FromArgb(g, g, g));

                        while (pldim > 0)
                        {
                            g = p.G + dim;
                            matrixImage.SetPixel(i, j, Color.FromArgb(g, g, g));
                            pldim = pldim - 1;
                        }
                    }
                }
                pictureBox1.Image = matrixImage;
            }
            else
            {
                MessageBox.Show("Please, choose the picture");
            }
        }

        private void curveImageToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            if (pictureBox1.Image != null)
            {
                Bitmap matrixImage = new Bitmap(pictureBox1.Image.Width, pictureBox1.Image.Height);

                Color p = ((Bitmap)pictureBox1.Image).GetPixel(0, 0);
                int g;
                int max = p.G;
                int min = p.G;

                for (int i = 0; i < pictureBox1.Image.Width; i++)
                {
                    for (int j = 0; j < pictureBox1.Image.Height; j++)
                    {
                        p = ((Bitmap)pictureBox1.Image).GetPixel(i, j);
                        if (p.G < min)
                        {
                            min = p.G;
                        }
                        if (p.G > max)
                        {
                            max = p.G;
                        }
                    }
                }

                for (int i = 0; i < pictureBox1.Image.Width; i++)
                {
                    for (int j = 0; j < pictureBox1.Image.Height; j++)
                    {
                        p = ((Bitmap)pictureBox1.Image).GetPixel(i, j);

                        g = 255 - (255 * (p.G - min) / (max - min));
                        matrixImage.SetPixel(i, j, Color.FromArgb(g, g, g));

                    }
                }
                pictureBox1.Image = matrixImage;
            }
            else
            {
                MessageBox.Show("Please, choose the picture");
            }
        }
        private void binarizationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image != null)
            {
                if (!double.TryParse(textBox1.Text, out double treshold))
                {
                    MessageBox.Show("Input correct value!");
                    return;
                }

                Bitmap dst = new Bitmap(pictureBox1.Image.Width, pictureBox1.Image.Height);
                Bitmap picture = (Bitmap)pictureBox1.Image;

                for (int i = 0; i < picture.Width; i++)
                {
                    for (int j = 0; j < picture.Height; j++)
                    {
                        dst.SetPixel(i, j, picture.GetPixel(i, j).GetBrightness() < treshold ? System.Drawing.Color.Black : System.Drawing.Color.White);
                    }
                }

                pictureBox1.Image = dst;
            }
            else
            {
                MessageBox.Show("Please, choose the picture!");
            }
        }

        private void lumaSliceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image != null)
            {
                if (!double.TryParse(textBox1.Text, out double downTreshold))
                {
                    MessageBox.Show("Input correct value!");
                    return;
                }

                if (!double.TryParse(textBox2.Text, out double upTreshold))
                {
                    MessageBox.Show("Input correct value!");
                    return;
                }

                Bitmap picture = (Bitmap)pictureBox1.Image;
                Bitmap matrixImage = new Bitmap(pictureBox1.Image.Width, pictureBox1.Image.Height);

                for (int i = 0; i < picture.Width; i++)
                {
                    for (int j = 0; j < picture.Height; j++)
                    {
                        if (picture.GetPixel(i, j).GetBrightness() > downTreshold && picture.GetPixel(i, j).GetBrightness() < upTreshold)
                        {
                            matrixImage.SetPixel(i, j, System.Drawing.Color.White);
                        }
                        else
                        {
                            matrixImage.SetPixel(i, j, System.Drawing.Color.Black);
                        }
                    }
                }
                pictureBox1.Image = matrixImage;
            }
            else
            {
                MessageBox.Show("Please, choose the picture!");
            }
        }

        private void lumaSlicelinearContrastToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image != null)
            {
                if (!double.TryParse(textBox1.Text, out double downTreshold))
                {
                    MessageBox.Show("Input correct value!");
                    return;
                }

                if (!double.TryParse(textBox2.Text, out double upTreshold))
                {
                    MessageBox.Show("Input correct value!");
                    return;
                }

                Bitmap picture = (Bitmap)pictureBox1.Image;
                Bitmap matrixImage = new Bitmap(pictureBox1.Image.Width, pictureBox1.Image.Height);

                for (int i = 0; i < picture.Width; i++)
                {
                    for (int j = 0; j < picture.Height; j++)
                    {
                        if (picture.GetPixel(i, j).GetBrightness() > downTreshold && picture.GetPixel(i, j).GetBrightness() < upTreshold)
                        {
                            matrixImage.SetPixel(i, j, System.Drawing.Color.White);
                        }
                        else
                        {
                            matrixImage.SetPixel(i, j, picture.GetPixel(i, j));
                        }
                    }
                }
                pictureBox1.Image = matrixImage;
            }
            else
            {
                MessageBox.Show("Please, choose the picture!");
            }
        }

        private void linearContrastStretchгToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image != null)
            {

                Bitmap matrixImage = new Bitmap(pictureBox1.Image.Width, pictureBox1.Image.Height);

                Color p = ((Bitmap)pictureBox1.Image).GetPixel(0, 0);
                int g;
                int max = p.G;
                int min = p.G;

                for (int i = 0; i < pictureBox1.Image.Width; i++)
                {
                    for (int j = 0; j < pictureBox1.Image.Height; j++)
                    {
                        p = ((Bitmap)pictureBox1.Image).GetPixel(i, j);
                        if (p.G < min)
                        {
                            min = p.G;
                        }
                        if (p.G > max)
                        {
                            max = p.G;
                        }
                    }
                }

                for (int i = 0; i < pictureBox1.Image.Width; i++)
                {
                    for (int j = 0; j < pictureBox1.Image.Height; j++)
                    {
                        p = ((Bitmap)pictureBox1.Image).GetPixel(i, j);

                        g = 255 * (p.G - min) / (max - min);
                        matrixImage.SetPixel(i, j, Color.FromArgb(g, g, g));
                        
                    }
                }
                pictureBox1.Image = matrixImage;
            }
            else
            {
                MessageBox.Show("Please, choose the picture");
            }
        }
    }
}
