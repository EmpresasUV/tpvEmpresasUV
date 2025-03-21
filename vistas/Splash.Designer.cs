﻿namespace tpvEmpresasUV
{
    partial class Splash
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
            components = new System.ComponentModel.Container();
            kryptonPictureBox1 = new Krypton.Toolkit.KryptonPictureBox();
            timer_LOAD = new System.Windows.Forms.Timer(components);
            kryptonPictureBox2 = new Krypton.Toolkit.KryptonPictureBox();
            ((System.ComponentModel.ISupportInitialize)kryptonPictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)kryptonPictureBox2).BeginInit();
            SuspendLayout();
            // 
            // kryptonPictureBox1
            // 
            kryptonPictureBox1.Dock = DockStyle.Top;
            kryptonPictureBox1.Image = Properties.Resources.EmpresasUV;
            kryptonPictureBox1.Location = new Point(0, 0);
            kryptonPictureBox1.Name = "kryptonPictureBox1";
            kryptonPictureBox1.Padding = new Padding(10);
            kryptonPictureBox1.Size = new Size(236, 217);
            kryptonPictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            kryptonPictureBox1.TabIndex = 0;
            kryptonPictureBox1.TabStop = false;
            // 
            // timer_LOAD
            // 
            timer_LOAD.Interval = 1000;
            timer_LOAD.Tick += timer_LOAD_Tick;
            // 
            // kryptonPictureBox2
            // 
            kryptonPictureBox2.Image = Properties.Resources.loader;
            kryptonPictureBox2.Location = new Point(0, 222);
            kryptonPictureBox2.Name = "kryptonPictureBox2";
            kryptonPictureBox2.Padding = new Padding(10);
            kryptonPictureBox2.Size = new Size(235, 41);
            kryptonPictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            kryptonPictureBox2.TabIndex = 1;
            kryptonPictureBox2.TabStop = false;
            // 
            // Splash
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(236, 284);
            CloseBox = false;
            ControlBox = false;
            Controls.Add(kryptonPictureBox2);
            Controls.Add(kryptonPictureBox1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "Splash";
            PaletteMode = Krypton.Toolkit.PaletteMode.Office2007Blue;
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            Load += Splash_Load;
            ((System.ComponentModel.ISupportInitialize)kryptonPictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)kryptonPictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Krypton.Toolkit.KryptonPictureBox kryptonPictureBox1;
        private System.Windows.Forms.Timer timer_LOAD;
        private Krypton.Toolkit.KryptonPictureBox kryptonPictureBox2;
    }
}
