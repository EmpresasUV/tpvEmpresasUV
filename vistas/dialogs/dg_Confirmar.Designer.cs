namespace tpvEmpresasUV
{
    partial class dg_Confirmar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(dg_Confirmar));
            cmd_AYUDA = new Krypton.Toolkit.ButtonSpecAny();
            kryptonPictureBox1 = new Krypton.Toolkit.KryptonPictureBox();
            kryptonLabel1 = new Krypton.Toolkit.KryptonLabel();
            kryptonLabel2 = new Krypton.Toolkit.KryptonLabel();
            cmd_SI = new Krypton.Toolkit.KryptonButton();
            cmd_NO = new Krypton.Toolkit.KryptonButton();
            ((System.ComponentModel.ISupportInitialize)kryptonPictureBox1).BeginInit();
            SuspendLayout();
            // 
            // cmd_AYUDA
            // 
            cmd_AYUDA.Image = Properties.Resources.help_3;
            cmd_AYUDA.UniqueName = "16a62b565414438c89d3396cab144665";
            // 
            // kryptonPictureBox1
            // 
            kryptonPictureBox1.Dock = DockStyle.Top;
            kryptonPictureBox1.Location = new Point(0, 0);
            kryptonPictureBox1.Name = "kryptonPictureBox1";
            kryptonPictureBox1.Size = new Size(293, 73);
            kryptonPictureBox1.TabIndex = 0;
            kryptonPictureBox1.TabStop = false;
            // 
            // kryptonLabel1
            // 
            kryptonLabel1.Dock = DockStyle.Top;
            kryptonLabel1.Location = new Point(0, 73);
            kryptonLabel1.Name = "kryptonLabel1";
            kryptonLabel1.PaletteMode = Krypton.Toolkit.PaletteMode.Office2007Blue;
            kryptonLabel1.Size = new Size(293, 42);
            kryptonLabel1.StateCommon.Padding = new Padding(-1, 20, -1, -1);
            kryptonLabel1.StateCommon.ShortText.Font = new Font("Cascadia Code", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            kryptonLabel1.StateCommon.ShortText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Center;
            kryptonLabel1.TabIndex = 1;
            kryptonLabel1.Values.Text = "[MyTitulo]";
            // 
            // kryptonLabel2
            // 
            kryptonLabel2.Dock = DockStyle.Top;
            kryptonLabel2.Location = new Point(0, 115);
            kryptonLabel2.Name = "kryptonLabel2";
            kryptonLabel2.Size = new Size(293, 37);
            kryptonLabel2.StateCommon.Padding = new Padding(-1, 20, -1, -1);
            kryptonLabel2.StateCommon.ShortText.Font = new Font("Cascadia Code", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            kryptonLabel2.StateCommon.ShortText.MultiLine = Krypton.Toolkit.InheritBool.True;
            kryptonLabel2.TabIndex = 2;
            kryptonLabel2.Values.Text = "[MyTexto]";
            // 
            // cmd_SI
            // 
            cmd_SI.Location = new Point(12, 232);
            cmd_SI.Name = "cmd_SI";
            cmd_SI.PaletteMode = Krypton.Toolkit.PaletteMode.Office2007Blue;
            cmd_SI.Size = new Size(66, 25);
            cmd_SI.TabIndex = 3;
            cmd_SI.Values.DropDownArrowColor = Color.Empty;
            cmd_SI.Values.Image = Properties.Resources.mark;
            cmd_SI.Values.Text = "&Sí";
            cmd_SI.Visible = false;
            // 
            // cmd_NO
            // 
            cmd_NO.Location = new Point(215, 232);
            cmd_NO.Name = "cmd_NO";
            cmd_NO.PaletteMode = Krypton.Toolkit.PaletteMode.Office2007Blue;
            cmd_NO.Size = new Size(66, 25);
            cmd_NO.TabIndex = 4;
            cmd_NO.Values.DropDownArrowColor = Color.Empty;
            cmd_NO.Values.Image = Properties.Resources.cross;
            cmd_NO.Values.Text = "&No";
            cmd_NO.Visible = false;
            // 
            // dg_Confirmar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ButtonSpecs.Add(cmd_AYUDA);
            ClientSize = new Size(293, 271);
            CloseBox = false;
            Controls.Add(cmd_NO);
            Controls.Add(cmd_SI);
            Controls.Add(kryptonLabel2);
            Controls.Add(kryptonLabel1);
            Controls.Add(kryptonPictureBox1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            FormTitleAlign = Krypton.Toolkit.PaletteRelativeAlign.Center;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "dg_Confirmar";
            PaletteMode = Krypton.Toolkit.PaletteMode.Office2007Blue;
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "¿?";
            ((System.ComponentModel.ISupportInitialize)kryptonPictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Krypton.Toolkit.ButtonSpecAny cmd_AYUDA;
        private Krypton.Toolkit.KryptonPictureBox kryptonPictureBox1;
        private Krypton.Toolkit.KryptonLabel kryptonLabel1;
        private Krypton.Toolkit.KryptonLabel kryptonLabel2;
        private Krypton.Toolkit.KryptonButton cmd_SI;
        private Krypton.Toolkit.KryptonButton cmd_NO;
    }
}