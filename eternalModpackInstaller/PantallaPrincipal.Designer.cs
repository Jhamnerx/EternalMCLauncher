using eternalModpackInstaller.Models;

namespace eternalModpackInstaller
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
            pictureBox1 = new PictureBox();
            cboPathInstall = new MaterialSkin.Controls.MaterialComboBox();
            buttonInstall = new MaterialSkin.Controls.MaterialButton();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            loader = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)loader).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(97, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(341, 191);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
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
            cboPathInstall.Location = new Point(57, 383);
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
            buttonInstall.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            buttonInstall.Depth = 0;
            buttonInstall.HighEmphasis = true;
            buttonInstall.Icon = null;
            buttonInstall.Location = new Point(326, 389);
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
            loader.Location = new Point(224, 204);
            loader.Name = "loader";
            loader.Size = new Size(82, 83);
            loader.SizeMode = PictureBoxSizeMode.StretchImage;
            loader.TabIndex = 10;
            loader.TabStop = false;
            loader.Visible = false;
            // 
            // FormularioInicial
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(547, 489);
            Controls.Add(loader);
            Controls.Add(buttonInstall);
            Controls.Add(cboPathInstall);
            Controls.Add(pictureBox1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "FormularioInicial";
            StartPosition = FormStartPosition.CenterScreen;
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)loader).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion


        private MaterialSkin.Controls.MaterialDrawer materialDrawer1;
        private PictureBox pictureBox1;
        private MaterialSkin.Controls.MaterialComboBox cboPathInstall;
        private MaterialSkin.Controls.MaterialButton buttonInstall;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private PictureBox loader;
    }
}