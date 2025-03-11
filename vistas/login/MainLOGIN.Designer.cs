namespace tpvEmpresasUV
{
    partial class MainLOGIN
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainLOGIN));
            cmd_AYUDA = new Krypton.Toolkit.ButtonSpecAny();
            kryptonPictureBox1 = new Krypton.Toolkit.KryptonPictureBox();
            kryptonButton1 = new Krypton.Toolkit.KryptonButton();
            kryptonButton2 = new Krypton.Toolkit.KryptonButton();
            kryptonTextBox1 = new Krypton.Toolkit.KryptonTextBox();
            kryptonLabel1 = new Krypton.Toolkit.KryptonLabel();
            kryptonLabel2 = new Krypton.Toolkit.KryptonLabel();
            kryptonTextBox2 = new Krypton.Toolkit.KryptonTextBox();
            ((System.ComponentModel.ISupportInitialize)kryptonPictureBox1).BeginInit();
            SuspendLayout();
            // 
            // cmd_AYUDA
            // 
            cmd_AYUDA.Image = Properties.Resources.help_3;
            cmd_AYUDA.UniqueName = "89fec861276d4d60abcf20d2e8749e6c";
            // 
            // kryptonPictureBox1
            // 
            kryptonPictureBox1.Dock = DockStyle.Top;
            kryptonPictureBox1.Image = Properties.Resources.lock_3;
            kryptonPictureBox1.Location = new Point(0, 0);
            kryptonPictureBox1.Name = "kryptonPictureBox1";
            kryptonPictureBox1.Size = new Size(250, 151);
            kryptonPictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            kryptonPictureBox1.TabIndex = 0;
            kryptonPictureBox1.TabStop = false;
            // 
            // kryptonButton1
            // 
            kryptonButton1.Location = new Point(127, 300);
            kryptonButton1.Name = "kryptonButton1";
            kryptonButton1.Size = new Size(111, 36);
            kryptonButton1.TabIndex = 1;
            kryptonButton1.Values.DropDownArrowColor = Color.Empty;
            kryptonButton1.Values.Image = Properties.Resources.mark;
            kryptonButton1.Values.Text = "&Acceder";
            // 
            // kryptonButton2
            // 
            kryptonButton2.Location = new Point(10, 300);
            kryptonButton2.Name = "kryptonButton2";
            kryptonButton2.Size = new Size(111, 36);
            kryptonButton2.TabIndex = 2;
            kryptonButton2.Values.DropDownArrowColor = Color.Empty;
            kryptonButton2.Values.Image = Properties.Resources.cross;
            kryptonButton2.Values.Text = "&Cancelar";
            // 
            // kryptonTextBox1
            // 
            kryptonTextBox1.Location = new Point(10, 188);
            kryptonTextBox1.Name = "kryptonTextBox1";
            kryptonTextBox1.PaletteMode = Krypton.Toolkit.PaletteMode.Office2007Blue;
            kryptonTextBox1.Size = new Size(228, 23);
            kryptonTextBox1.TabIndex = 3;
            // 
            // kryptonLabel1
            // 
            kryptonLabel1.Location = new Point(10, 164);
            kryptonLabel1.Name = "kryptonLabel1";
            kryptonLabel1.PaletteMode = Krypton.Toolkit.PaletteMode.Office2007Blue;
            kryptonLabel1.Size = new Size(229, 20);
            kryptonLabel1.TabIndex = 5;
            kryptonLabel1.Values.Text = "Nombre de usuario / Correo electrónico";
            // 
            // kryptonLabel2
            // 
            kryptonLabel2.Location = new Point(11, 228);
            kryptonLabel2.Name = "kryptonLabel2";
            kryptonLabel2.PaletteMode = Krypton.Toolkit.PaletteMode.Office2007Blue;
            kryptonLabel2.Size = new Size(124, 20);
            kryptonLabel2.TabIndex = 7;
            kryptonLabel2.Values.Text = "Contraseña asignada";
            // 
            // kryptonTextBox2
            // 
            kryptonTextBox2.Location = new Point(11, 252);
            kryptonTextBox2.Name = "kryptonTextBox2";
            kryptonTextBox2.PaletteMode = Krypton.Toolkit.PaletteMode.Office2007Blue;
            kryptonTextBox2.PasswordChar = '●';
            kryptonTextBox2.Size = new Size(228, 23);
            kryptonTextBox2.TabIndex = 6;
            kryptonTextBox2.TextAlign = HorizontalAlignment.Center;
            // 
            // MainLOGIN
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ButtonSpecs.Add(cmd_AYUDA);
            ClientSize = new Size(250, 348);
            Controls.Add(kryptonLabel2);
            Controls.Add(kryptonTextBox2);
            Controls.Add(kryptonLabel1);
            Controls.Add(kryptonTextBox1);
            Controls.Add(kryptonButton2);
            Controls.Add(kryptonButton1);
            Controls.Add(kryptonPictureBox1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "MainLOGIN";
            PaletteMode = Krypton.Toolkit.PaletteMode.Office2007Blue;
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Seguridad del acceso";
            TopMost = true;
            ((System.ComponentModel.ISupportInitialize)kryptonPictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Krypton.Toolkit.ButtonSpecAny cmd_AYUDA;
        private Krypton.Toolkit.KryptonPictureBox kryptonPictureBox1;
        private Krypton.Toolkit.KryptonButton kryptonButton1;
        private Krypton.Toolkit.KryptonButton kryptonButton2;
        private Krypton.Toolkit.KryptonTextBox kryptonTextBox1;
        private Krypton.Toolkit.KryptonLabel kryptonLabel1;
        private Krypton.Toolkit.KryptonLabel kryptonLabel2;
        private Krypton.Toolkit.KryptonTextBox kryptonTextBox2;
    }
}