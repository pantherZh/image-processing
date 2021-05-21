namespace Laba4
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.metroStyleManager1 = new MetroFramework.Components.MetroStyleManager(this.components);
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.imageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gaussianFilterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.startToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cannyEdgeDetectorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.startToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.showToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.magePreparationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.binarizationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lumaSliceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lumaSlicelinearContrastToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.linearContrastStretchгToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.curveImageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sawtoothContrastingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sawtoothContrastingзToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sawtoothContrastingToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.sawtoothContrastingToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.grayToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.imageBox2 = new Emgu.CV.UI.ImageBox();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroTextBox2 = new MetroFramework.Controls.MetroTextBox();
            this.metroTextBox3 = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.imageBox1 = new Emgu.CV.UI.ImageBox();
            this.histogramBox2 = new Emgu.CV.UI.HistogramBox();
            this.histogramBox1 = new Emgu.CV.UI.HistogramBox();
            this.helpProvider1 = new System.Windows.Forms.HelpProvider();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imageBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // metroStyleManager1
            // 
            this.metroStyleManager1.Owner = null;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.Filter = "Images|*.bmp;*.jpg;*.png";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.imageToolStripMenuItem,
            this.gaussianFilterToolStripMenuItem,
            this.cannyEdgeDetectorToolStripMenuItem,
            this.showToolStripMenuItem,
            this.magePreparationToolStripMenuItem,
            this.grayToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(20, 60);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1352, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // imageToolStripMenuItem
            // 
            this.imageToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem});
            this.imageToolStripMenuItem.Name = "imageToolStripMenuItem";
            this.imageToolStripMenuItem.Size = new System.Drawing.Size(65, 26);
            this.imageToolStripMenuItem.Text = "Image";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(128, 26);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(128, 26);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // gaussianFilterToolStripMenuItem
            // 
            this.gaussianFilterToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.startToolStripMenuItem});
            this.gaussianFilterToolStripMenuItem.Name = "gaussianFilterToolStripMenuItem";
            this.gaussianFilterToolStripMenuItem.Size = new System.Drawing.Size(120, 26);
            this.gaussianFilterToolStripMenuItem.Text = "Gaussian filter ";
            // 
            // startToolStripMenuItem
            // 
            this.startToolStripMenuItem.Name = "startToolStripMenuItem";
            this.startToolStripMenuItem.Size = new System.Drawing.Size(123, 26);
            this.startToolStripMenuItem.Text = "Start";
            this.startToolStripMenuItem.Click += new System.EventHandler(this.startToolStripMenuItem_Click);
            // 
            // cannyEdgeDetectorToolStripMenuItem
            // 
            this.cannyEdgeDetectorToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.startToolStripMenuItem1});
            this.cannyEdgeDetectorToolStripMenuItem.Name = "cannyEdgeDetectorToolStripMenuItem";
            this.cannyEdgeDetectorToolStripMenuItem.Size = new System.Drawing.Size(163, 26);
            this.cannyEdgeDetectorToolStripMenuItem.Text = "Canny Edge Detector";
            // 
            // startToolStripMenuItem1
            // 
            this.startToolStripMenuItem1.Name = "startToolStripMenuItem1";
            this.startToolStripMenuItem1.Size = new System.Drawing.Size(123, 26);
            this.startToolStripMenuItem1.Text = "Start";
            this.startToolStripMenuItem1.Click += new System.EventHandler(this.startToolStripMenuItem1_Click);
            // 
            // showToolStripMenuItem
            // 
            this.showToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showToolStripMenuItem1});
            this.showToolStripMenuItem.Name = "showToolStripMenuItem";
            this.showToolStripMenuItem.Size = new System.Drawing.Size(97, 24);
            this.showToolStripMenuItem.Text = "Histogram ";
            // 
            // showToolStripMenuItem1
            // 
            this.showToolStripMenuItem1.Name = "showToolStripMenuItem1";
            this.showToolStripMenuItem1.Size = new System.Drawing.Size(224, 26);
            this.showToolStripMenuItem1.Text = "Show(modified)";
            this.showToolStripMenuItem1.Click += new System.EventHandler(this.showToolStripMenuItem1_Click);
            // 
            // magePreparationToolStripMenuItem
            // 
            this.magePreparationToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.binarizationToolStripMenuItem,
            this.lumaSliceToolStripMenuItem,
            this.lumaSlicelinearContrastToolStripMenuItem,
            this.linearContrastStretchгToolStripMenuItem,
            this.curveImageToolStripMenuItem,
            this.sawtoothContrastingToolStripMenuItem,
            this.sawtoothContrastingзToolStripMenuItem,
            this.sawtoothContrastingToolStripMenuItem1,
            this.sawtoothContrastingToolStripMenuItem2});
            this.magePreparationToolStripMenuItem.Name = "magePreparationToolStripMenuItem";
            this.magePreparationToolStripMenuItem.Size = new System.Drawing.Size(150, 26);
            this.magePreparationToolStripMenuItem.Text = "Image Preparation ";
            // 
            // binarizationToolStripMenuItem
            // 
            this.binarizationToolStripMenuItem.Name = "binarizationToolStripMenuItem";
            this.binarizationToolStripMenuItem.Size = new System.Drawing.Size(259, 26);
            this.binarizationToolStripMenuItem.Text = "Binarization(а)";
            this.binarizationToolStripMenuItem.Click += new System.EventHandler(this.binarizationToolStripMenuItem_Click);
            // 
            // lumaSliceToolStripMenuItem
            // 
            this.lumaSliceToolStripMenuItem.Name = "lumaSliceToolStripMenuItem";
            this.lumaSliceToolStripMenuItem.Size = new System.Drawing.Size(259, 26);
            this.lumaSliceToolStripMenuItem.Text = "Luma Slice(б)";
            this.lumaSliceToolStripMenuItem.Click += new System.EventHandler(this.lumaSliceToolStripMenuItem_Click);
            // 
            // lumaSlicelinearContrastToolStripMenuItem
            // 
            this.lumaSlicelinearContrastToolStripMenuItem.Name = "lumaSlicelinearContrastToolStripMenuItem";
            this.lumaSlicelinearContrastToolStripMenuItem.Size = new System.Drawing.Size(259, 26);
            this.lumaSlicelinearContrastToolStripMenuItem.Text = "Luma Slice(в)";
            this.lumaSlicelinearContrastToolStripMenuItem.Click += new System.EventHandler(this.lumaSlicelinearContrastToolStripMenuItem_Click);
            // 
            // linearContrastStretchгToolStripMenuItem
            // 
            this.linearContrastStretchгToolStripMenuItem.Name = "linearContrastStretchгToolStripMenuItem";
            this.linearContrastStretchгToolStripMenuItem.Size = new System.Drawing.Size(259, 26);
            this.linearContrastStretchгToolStripMenuItem.Text = "Linear contrast stretch(д) ";
            this.linearContrastStretchгToolStripMenuItem.Click += new System.EventHandler(this.linearContrastStretchгToolStripMenuItem_Click);
            // 
            // curveImageToolStripMenuItem
            // 
            this.curveImageToolStripMenuItem.Name = "curveImageToolStripMenuItem";
            this.curveImageToolStripMenuItem.Size = new System.Drawing.Size(259, 26);
            this.curveImageToolStripMenuItem.Text = "Linear contrast stretch(e)";
            this.curveImageToolStripMenuItem.Click += new System.EventHandler(this.curveImageToolStripMenuItem_Click_1);
            // 
            // sawtoothContrastingToolStripMenuItem
            // 
            this.sawtoothContrastingToolStripMenuItem.Name = "sawtoothContrastingToolStripMenuItem";
            this.sawtoothContrastingToolStripMenuItem.Size = new System.Drawing.Size(259, 26);
            this.sawtoothContrastingToolStripMenuItem.Text = "Sawtooth contrasting(ж) ";
            this.sawtoothContrastingToolStripMenuItem.Click += new System.EventHandler(this.sawtoothContrastingToolStripMenuItem_Click);
            // 
            // sawtoothContrastingзToolStripMenuItem
            // 
            this.sawtoothContrastingзToolStripMenuItem.Name = "sawtoothContrastingзToolStripMenuItem";
            this.sawtoothContrastingзToolStripMenuItem.Size = new System.Drawing.Size(259, 26);
            this.sawtoothContrastingзToolStripMenuItem.Text = "Sawtooth contrasting(з)";
            this.sawtoothContrastingзToolStripMenuItem.Click += new System.EventHandler(this.sawtoothContrastingзToolStripMenuItem_Click);
            // 
            // sawtoothContrastingToolStripMenuItem1
            // 
            this.sawtoothContrastingToolStripMenuItem1.Name = "sawtoothContrastingToolStripMenuItem1";
            this.sawtoothContrastingToolStripMenuItem1.Size = new System.Drawing.Size(259, 26);
            this.sawtoothContrastingToolStripMenuItem1.Text = "Sawtooth contrasting(и)";
            this.sawtoothContrastingToolStripMenuItem1.Click += new System.EventHandler(this.sawtoothContrastingToolStripMenuItem1_Click);
            // 
            // sawtoothContrastingToolStripMenuItem2
            // 
            this.sawtoothContrastingToolStripMenuItem2.Name = "sawtoothContrastingToolStripMenuItem2";
            this.sawtoothContrastingToolStripMenuItem2.Size = new System.Drawing.Size(259, 26);
            this.sawtoothContrastingToolStripMenuItem2.Text = "Sawtooth contrasting(к)";
            this.sawtoothContrastingToolStripMenuItem2.Click += new System.EventHandler(this.sawtoothContrastingToolStripMenuItem2_Click);
            // 
            // grayToolStripMenuItem
            // 
            this.grayToolStripMenuItem.Name = "grayToolStripMenuItem";
            this.grayToolStripMenuItem.Size = new System.Drawing.Size(53, 26);
            this.grayToolStripMenuItem.Text = "Gray";
            this.grayToolStripMenuItem.Click += new System.EventHandler(this.grayToolStripMenuItem_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(20, 88);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.imageBox2);
            this.splitContainer1.Panel1.Controls.Add(this.metroButton1);
            this.splitContainer1.Panel1.Controls.Add(this.metroLabel2);
            this.splitContainer1.Panel1.Controls.Add(this.metroTextBox2);
            this.splitContainer1.Panel1.Controls.Add(this.metroTextBox3);
            this.splitContainer1.Panel1.Controls.Add(this.metroLabel1);
            this.splitContainer1.Panel1.Controls.Add(this.pictureBox1);
            this.splitContainer1.Panel1.Controls.Add(this.imageBox1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.histogramBox2);
            this.splitContainer1.Panel2.Controls.Add(this.histogramBox1);
            this.splitContainer1.Size = new System.Drawing.Size(1352, 674);
            this.splitContainer1.SplitterDistance = 692;
            this.splitContainer1.TabIndex = 1;
            // 
            // imageBox2
            // 
            this.imageBox2.Location = new System.Drawing.Point(3, 3);
            this.imageBox2.Name = "imageBox2";
            this.imageBox2.Size = new System.Drawing.Size(686, 474);
            this.imageBox2.TabIndex = 2;
            this.imageBox2.TabStop = false;
            this.imageBox2.Visible = false;
            // 
            // metroButton1
            // 
            this.metroButton1.Location = new System.Drawing.Point(259, 648);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(75, 23);
            this.metroButton1.TabIndex = 6;
            this.metroButton1.Text = "Run";
            this.metroButton1.Visible = false;
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(9, 571);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(83, 20);
            this.metroLabel2.TabIndex = 5;
            this.metroLabel2.Text = "Input sigma:";
            this.metroLabel2.Visible = false;
            // 
            // metroTextBox2
            // 
            this.metroTextBox2.Location = new System.Drawing.Point(518, 604);
            this.metroTextBox2.Name = "metroTextBox2";
            this.metroTextBox2.Size = new System.Drawing.Size(75, 23);
            this.metroTextBox2.TabIndex = 2;
            this.metroTextBox2.Visible = false;
            // 
            // metroTextBox3
            // 
            this.metroTextBox3.Location = new System.Drawing.Point(17, 604);
            this.metroTextBox3.Name = "metroTextBox3";
            this.metroTextBox3.Size = new System.Drawing.Size(75, 23);
            this.metroTextBox3.TabIndex = 3;
            this.metroTextBox3.Visible = false;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(506, 571);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(130, 20);
            this.metroLabel1.TabIndex = 4;
            this.metroLabel1.Text = "Input size of kernel:";
            this.metroLabel1.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(689, 568);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // imageBox1
            // 
            this.imageBox1.Location = new System.Drawing.Point(17, 19);
            this.imageBox1.Name = "imageBox1";
            this.imageBox1.Size = new System.Drawing.Size(667, 290);
            this.imageBox1.TabIndex = 2;
            this.imageBox1.TabStop = false;
            // 
            // histogramBox2
            // 
            this.histogramBox2.Location = new System.Drawing.Point(31, 315);
            this.histogramBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.histogramBox2.Name = "histogramBox2";
            this.histogramBox2.Size = new System.Drawing.Size(581, 330);
            this.histogramBox2.TabIndex = 9;
            // 
            // histogramBox1
            // 
            this.histogramBox1.Location = new System.Drawing.Point(31, 4);
            this.histogramBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.histogramBox1.Name = "histogramBox1";
            this.histogramBox1.Size = new System.Drawing.Size(581, 330);
            this.histogramBox1.TabIndex = 7;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(1021, 61);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 22);
            this.textBox1.TabIndex = 8;
            this.textBox1.Visible = false;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(1210, 61);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 22);
            this.textBox2.TabIndex = 9;
            this.textBox2.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(990, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 17);
            this.label1.TabIndex = 8;
            this.label1.Text = "T1";
            this.label1.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1179, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 17);
            this.label2.TabIndex = 9;
            this.label2.Text = "T2";
            this.label2.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1392, 782);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.ShadowType = MetroFramework.Forms.MetroForm.MetroFormShadowType.None;
            this.Text = "UI";
            this.Theme = MetroFramework.MetroThemeStyle.Light;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.imageBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Components.MetroStyleManager metroStyleManager1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem imageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.ToolStripMenuItem gaussianFilterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem startToolStripMenuItem;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox metroTextBox3;
        private MetroFramework.Controls.MetroTextBox metroTextBox2;
        private MetroFramework.Controls.MetroButton metroButton1;
        private System.Windows.Forms.ToolStripMenuItem cannyEdgeDetectorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem startToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem showToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showToolStripMenuItem1;
        private System.Windows.Forms.HelpProvider helpProvider1;
        private Emgu.CV.UI.HistogramBox histogramBox1;
        private Emgu.CV.UI.ImageBox imageBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStripMenuItem magePreparationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem binarizationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lumaSliceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lumaSlicelinearContrastToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem linearContrastStretchгToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem curveImageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem grayToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sawtoothContrastingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sawtoothContrastingзToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sawtoothContrastingToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem sawtoothContrastingToolStripMenuItem2;
        private Emgu.CV.UI.HistogramBox histogramBox2;
        private Emgu.CV.UI.ImageBox imageBox2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

