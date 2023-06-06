using EternalMCLauncher.Models;

namespace EternalMCLauncher
{
    partial class FormularioInicial
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormularioInicial));
            logo = new PictureBox();
            cboPathInstall = new MaterialSkin.Controls.MaterialComboBox();
            buttonInstall = new MaterialSkin.Controls.MaterialButton();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            loader = new PictureBox();
            RedFacebook = new PictureBox();
            RedTiktok = new PictureBox();
            RedTwitter = new PictureBox();
            RedYoutube = new PictureBox();
            RedTwitch = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)logo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)loader).BeginInit();
            ((System.ComponentModel.ISupportInitialize)RedFacebook).BeginInit();
            ((System.ComponentModel.ISupportInitialize)RedTiktok).BeginInit();
            ((System.ComponentModel.ISupportInitialize)RedTwitter).BeginInit();
            ((System.ComponentModel.ISupportInitialize)RedYoutube).BeginInit();
            ((System.ComponentModel.ISupportInitialize)RedTwitch).BeginInit();
            SuspendLayout();
            // 
            // logo
            // 
            logo.BackColor = Color.Transparent;
            logo.Image = (Image)resources.GetObject("logo.Image");
            logo.Location = new Point(97, 12);
            logo.Name = "logo";
            logo.Size = new Size(341, 191);
            logo.SizeMode = PictureBoxSizeMode.StretchImage;
            logo.TabIndex = 6;
            logo.TabStop = false;
            // 
            // cboPathInstall
            // 
            cboPathInstall.AutoResize = false;
            cboPathInstall.BackColor = Color.FromArgb(255, 255, 255);
            cboPathInstall.Depth = 0;
            cboPathInstall.DrawMode = DrawMode.OwnerDrawVariable;
            cboPathInstall.DropDownHeight = 174;
            cboPathInstall.DropDownStyle = ComboBoxStyle.DropDownList;
            cboPathInstall.DropDownWidth = 121;
            cboPathInstall.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            cboPathInstall.ForeColor = Color.FromArgb(222, 0, 0, 0);
            cboPathInstall.FormattingEnabled = true;
            cboPathInstall.IntegralHeight = false;
            cboPathInstall.ItemHeight = 43;
            cboPathInstall.Items.AddRange(new object[] { "Instalar en MultiMineCraft", "Instalar el Roaming" });
            cboPathInstall.Location = new Point(57, 327);
            cboPathInstall.MaxDropDownItems = 4;
            cboPathInstall.MouseState = MaterialSkin.MouseState.OUT;
            cboPathInstall.Name = "cboPathInstall";
            cboPathInstall.Size = new Size(249, 49);
            cboPathInstall.StartIndex = 0;
            cboPathInstall.TabIndex = 7;
            // 
            // buttonInstall
            // 
            buttonInstall.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            buttonInstall.Cursor = Cursors.Hand;
            buttonInstall.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            buttonInstall.Depth = 0;
            buttonInstall.HighEmphasis = true;
            buttonInstall.Icon = null;
            buttonInstall.Location = new Point(326, 336);
            buttonInstall.Margin = new Padding(4, 6, 4, 6);
            buttonInstall.MouseState = MaterialSkin.MouseState.HOVER;
            buttonInstall.Name = "buttonInstall";
            buttonInstall.NoAccentTextColor = Color.Empty;
            buttonInstall.Size = new Size(90, 36);
            buttonInstall.TabIndex = 8;
            buttonInstall.Text = "INSTALAR  ";
            buttonInstall.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            buttonInstall.UseAccentColor = false;
            buttonInstall.UseVisualStyleBackColor = true;
            buttonInstall.Click += buttonInstall_Click;
            // 
            // backgroundWorker1
            // 
            backgroundWorker1.DoWork += backgroundWorker1_DoWork;
            backgroundWorker1.ProgressChanged += backgroundWorker1_ProgressChanged;
            backgroundWorker1.RunWorkerCompleted += backgroundWorker1_RunWorkerCompleted;
            // 
            // loader
            // 
            loader.BackColor = Color.Transparent;
            loader.Image = (Image)resources.GetObject("loader.Image");
            loader.Location = new Point(224, 196);
            loader.Name = "loader";
            loader.Size = new Size(82, 83);
            loader.SizeMode = PictureBoxSizeMode.StretchImage;
            loader.TabIndex = 10;
            loader.TabStop = false;
            loader.Visible = false;
            // 
            // RedFacebook
            // 
            RedFacebook.BackColor = Color.Transparent;
            RedFacebook.Cursor = Cursors.Hand;
            RedFacebook.Location = new Point(250, 427);
            RedFacebook.Name = "RedFacebook";
            RedFacebook.Size = new Size(50, 50);
            RedFacebook.SizeMode = PictureBoxSizeMode.StretchImage;
            RedFacebook.TabIndex = 11;
            RedFacebook.TabStop = false;
            RedFacebook.Click += RedFacebook_Click;
            // 
            // RedTiktok
            // 
            RedTiktok.BackColor = Color.Transparent;
            RedTiktok.Cursor = Cursors.Hand;
            RedTiktok.Location = new Point(310, 427);
            RedTiktok.Name = "RedTiktok";
            RedTiktok.Size = new Size(50, 50);
            RedTiktok.SizeMode = PictureBoxSizeMode.StretchImage;
            RedTiktok.TabIndex = 12;
            RedTiktok.TabStop = false;
            RedTiktok.Click += RedTiktok_Click;
            // 
            // RedTwitter
            // 
            RedTwitter.BackColor = Color.Transparent;
            RedTwitter.Cursor = Cursors.Hand;
            RedTwitter.Location = new Point(370, 427);
            RedTwitter.Name = "RedTwitter";
            RedTwitter.Size = new Size(50, 50);
            RedTwitter.SizeMode = PictureBoxSizeMode.StretchImage;
            RedTwitter.TabIndex = 13;
            RedTwitter.TabStop = false;
            RedTwitter.Click += RedTwitter_Click;
            // 
            // RedYoutube
            // 
            RedYoutube.BackColor = Color.Transparent;
            RedYoutube.Cursor = Cursors.Hand;
            RedYoutube.Location = new Point(430, 427);
            RedYoutube.Name = "RedYoutube";
            RedYoutube.Size = new Size(50, 50);
            RedYoutube.SizeMode = PictureBoxSizeMode.StretchImage;
            RedYoutube.TabIndex = 14;
            RedYoutube.TabStop = false;
            RedYoutube.Click += RedYoutube_Click;
            // 
            // RedTwitch
            // 
            RedTwitch.BackColor = Color.Transparent;
            RedTwitch.Cursor = Cursors.Hand;
            RedTwitch.Location = new Point(490, 427);
            RedTwitch.Name = "RedTwitch";
            RedTwitch.Size = new Size(50, 50);
            RedTwitch.SizeMode = PictureBoxSizeMode.StretchImage;
            RedTwitch.TabIndex = 15;
            RedTwitch.TabStop = false;
            RedTwitch.Click += RedTwitch_Click;
            // 
            // FormularioInicial
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(544, 491);
            Controls.Add(RedTwitch);
            Controls.Add(RedYoutube);
            Controls.Add(loader);
            Controls.Add(RedTwitter);
            Controls.Add(buttonInstall);
            Controls.Add(RedTiktok);
            Controls.Add(cboPathInstall);
            Controls.Add(RedFacebook);
            Controls.Add(logo);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "FormularioInicial";
            StartPosition = FormStartPosition.CenterScreen;
            Load += Form1_Load;
            Leave += FormularioInicial_Leave;
            ((System.ComponentModel.ISupportInitialize)logo).EndInit();
            ((System.ComponentModel.ISupportInitialize)loader).EndInit();
            ((System.ComponentModel.ISupportInitialize)RedFacebook).EndInit();
            ((System.ComponentModel.ISupportInitialize)RedTiktok).EndInit();
            ((System.ComponentModel.ISupportInitialize)RedTwitter).EndInit();
            ((System.ComponentModel.ISupportInitialize)RedYoutube).EndInit();
            ((System.ComponentModel.ISupportInitialize)RedTwitch).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox logo;
        private MaterialSkin.Controls.MaterialComboBox cboPathInstall;
        private MaterialSkin.Controls.MaterialButton buttonInstall;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private PictureBox loader;
        private PictureBox RedFacebook;
        private PictureBox RedTiktok;
        private PictureBox RedTwitter;
        private PictureBox RedYoutube;
        private PictureBox RedTwitch;
    }
}