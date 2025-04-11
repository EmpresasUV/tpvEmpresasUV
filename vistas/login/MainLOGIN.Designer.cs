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
            Cmd_ACEPTAR = new Krypton.Toolkit.KryptonButton();
            Cmd_CANCELAR = new Krypton.Toolkit.KryptonButton();
            Txt_ID = new Krypton.Toolkit.KryptonTextBox();
            kryptonLabel1 = new Krypton.Toolkit.KryptonLabel();
            kryptonLabel2 = new Krypton.Toolkit.KryptonLabel();
            Txt_PASS = new Krypton.Toolkit.KryptonTextBox();
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
            kryptonPictureBox1.Size = new Size(251, 151);
            kryptonPictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            kryptonPictureBox1.TabIndex = 0;
            kryptonPictureBox1.TabStop = false;
            // 
            // Cmd_ACEPTAR
            // 
            Cmd_ACEPTAR.Location = new Point(127, 280);
            Cmd_ACEPTAR.Name = "Cmd_ACEPTAR";
            Cmd_ACEPTAR.Size = new Size(111, 36);
            Cmd_ACEPTAR.TabIndex = 1;
            Cmd_ACEPTAR.Values.DropDownArrowColor = Color.Empty;
            Cmd_ACEPTAR.Values.Image = Properties.Resources.mark;
            Cmd_ACEPTAR.Values.Text = "&Acceder";
            Cmd_ACEPTAR.Click += Cmd_ACEPTAR_Click;
            // 
            // Cmd_CANCELAR
            // 
            Cmd_CANCELAR.Location = new Point(10, 280);
            Cmd_CANCELAR.Name = "Cmd_CANCELAR";
            Cmd_CANCELAR.Size = new Size(111, 36);
            Cmd_CANCELAR.TabIndex = 2;
            Cmd_CANCELAR.Values.DropDownArrowColor = Color.Empty;
            Cmd_CANCELAR.Values.Image = Properties.Resources.cross;
            Cmd_CANCELAR.Values.Text = "&Cancelar";
            Cmd_CANCELAR.Click += Cmd_CANCELAR_Click;
            // 
            // Txt_ID
            // 
            Txt_ID.Location = new Point(10, 188);
            Txt_ID.Name = "Txt_ID";
            Txt_ID.PaletteMode = Krypton.Toolkit.PaletteMode.Office2007Blue;
            Txt_ID.Size = new Size(228, 23);
            Txt_ID.TabIndex = 3;
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
            kryptonLabel2.Location = new Point(11, 217);
            kryptonLabel2.Name = "kryptonLabel2";
            kryptonLabel2.PaletteMode = Krypton.Toolkit.PaletteMode.Office2007Blue;
            kryptonLabel2.Size = new Size(124, 20);
            kryptonLabel2.TabIndex = 7;
            kryptonLabel2.Values.Text = "Contraseña asignada";
            // 
            // Txt_PASS
            // 
            Txt_PASS.Location = new Point(11, 241);
            Txt_PASS.Name = "Txt_PASS";
            Txt_PASS.PaletteMode = Krypton.Toolkit.PaletteMode.Office2007Blue;
            Txt_PASS.PasswordChar = '●';
            Txt_PASS.Size = new Size(228, 23);
            Txt_PASS.TabIndex = 6;
            Txt_PASS.TextAlign = HorizontalAlignment.Center;
            // 
            // MainLOGIN
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ButtonSpecs.Add(cmd_AYUDA);
            ClientSize = new Size(251, 319);
            CloseBox = false;
            ControlBox = false;
            Controls.Add(kryptonLabel2);
            Controls.Add(Txt_PASS);
            Controls.Add(kryptonLabel1);
            Controls.Add(Txt_ID);
            Controls.Add(Cmd_CANCELAR);
            Controls.Add(Cmd_ACEPTAR);
            Controls.Add(kryptonPictureBox1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            FormTitleAlign = Krypton.Toolkit.PaletteRelativeAlign.Center;
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
        private Krypton.Toolkit.KryptonButton Cmd_ACEPTAR;
        private Krypton.Toolkit.KryptonButton Cmd_CANCELAR;
        private Krypton.Toolkit.KryptonTextBox Txt_ID;
        private Krypton.Toolkit.KryptonLabel kryptonLabel1;
        private Krypton.Toolkit.KryptonLabel kryptonLabel2;
        private Krypton.Toolkit.KryptonTextBox Txt_PASS;
    }
}