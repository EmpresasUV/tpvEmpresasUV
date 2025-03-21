namespace tpvEmpresasUV
{
    partial class appEx
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(appEx));
            kryptonPictureBox1 = new Krypton.Toolkit.KryptonPictureBox();
            kryptonPanel1 = new Krypton.Toolkit.KryptonPanel();
            cmd_INFORMAR = new Krypton.Toolkit.KryptonButton();
            cmd_ACEPTAR = new Krypton.Toolkit.KryptonButton();
            lbl_titulo = new Krypton.Toolkit.KryptonLabel();
            txt_error = new Krypton.Toolkit.KryptonTextBox();
            ((System.ComponentModel.ISupportInitialize)kryptonPictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)kryptonPanel1).BeginInit();
            kryptonPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // kryptonPictureBox1
            // 
            kryptonPictureBox1.Dock = DockStyle.Top;
            kryptonPictureBox1.Image = Properties.Resources.asistente_5;
            kryptonPictureBox1.Location = new Point(0, 0);
            kryptonPictureBox1.Name = "kryptonPictureBox1";
            kryptonPictureBox1.Size = new Size(279, 159);
            kryptonPictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            kryptonPictureBox1.TabIndex = 2;
            kryptonPictureBox1.TabStop = false;
            // 
            // kryptonPanel1
            // 
            kryptonPanel1.Controls.Add(cmd_INFORMAR);
            kryptonPanel1.Controls.Add(cmd_ACEPTAR);
            kryptonPanel1.Dock = DockStyle.Bottom;
            kryptonPanel1.Location = new Point(0, 331);
            kryptonPanel1.Name = "kryptonPanel1";
            kryptonPanel1.Size = new Size(279, 45);
            kryptonPanel1.TabIndex = 3;
            // 
            // cmd_INFORMAR
            // 
            cmd_INFORMAR.DialogResult = DialogResult.Continue;
            cmd_INFORMAR.Location = new Point(181, 5);
            cmd_INFORMAR.Name = "cmd_INFORMAR";
            cmd_INFORMAR.PaletteMode = Krypton.Toolkit.PaletteMode.Office2007Blue;
            cmd_INFORMAR.Size = new Size(90, 37);
            cmd_INFORMAR.TabIndex = 2;
            cmd_INFORMAR.Values.DropDownArrowColor = Color.Empty;
            cmd_INFORMAR.Values.Image = Properties.Resources.comments_add;
            cmd_INFORMAR.Values.Text = "&Informar";
            // 
            // cmd_ACEPTAR
            // 
            cmd_ACEPTAR.DialogResult = DialogResult.OK;
            cmd_ACEPTAR.Location = new Point(6, 5);
            cmd_ACEPTAR.Name = "cmd_ACEPTAR";
            cmd_ACEPTAR.PaletteMode = Krypton.Toolkit.PaletteMode.Office2007Blue;
            cmd_ACEPTAR.Size = new Size(90, 37);
            cmd_ACEPTAR.TabIndex = 1;
            cmd_ACEPTAR.Values.DropDownArrowColor = Color.Empty;
            cmd_ACEPTAR.Values.Image = Properties.Resources.mark;
            cmd_ACEPTAR.Values.Text = "&Aceptar";
            // 
            // lbl_titulo
            // 
            lbl_titulo.AutoSize = false;
            lbl_titulo.Dock = DockStyle.Top;
            lbl_titulo.Location = new Point(0, 159);
            lbl_titulo.Name = "lbl_titulo";
            lbl_titulo.Size = new Size(279, 47);
            lbl_titulo.StateCommon.ShortText.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_titulo.StateCommon.ShortText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Center;
            lbl_titulo.StateCommon.ShortText.TextV = Krypton.Toolkit.PaletteRelativeAlign.Center;
            lbl_titulo.TabIndex = 4;
            lbl_titulo.Values.Text = ".[].";
            // 
            // txt_error
            // 
            txt_error.Dock = DockStyle.Fill;
            txt_error.Location = new Point(0, 206);
            txt_error.Multiline = true;
            txt_error.Name = "txt_error";
            txt_error.PaletteMode = Krypton.Toolkit.PaletteMode.Office2007Blue;
            txt_error.Size = new Size(279, 125);
            txt_error.TabIndex = 5;
            txt_error.TextAlign = HorizontalAlignment.Center;
            // 
            // appEx
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(244, 244, 244);
            ClientSize = new Size(279, 376);
            ControlBox = false;
            Controls.Add(txt_error);
            Controls.Add(lbl_titulo);
            Controls.Add(kryptonPanel1);
            Controls.Add(kryptonPictureBox1);
            FormTitleAlign = Krypton.Toolkit.PaletteRelativeAlign.Center;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "appEx";
            PaletteMode = Krypton.Toolkit.PaletteMode.Office2007Blue;
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "¡Problema detectado!";
            TopMost = true;
            ((System.ComponentModel.ISupportInitialize)kryptonPictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)kryptonPanel1).EndInit();
            kryptonPanel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Krypton.Toolkit.KryptonPictureBox kryptonPictureBox1;
        private Krypton.Toolkit.KryptonPanel kryptonPanel1;
        private Krypton.Toolkit.KryptonButton cmd_INFORMAR;
        private Krypton.Toolkit.KryptonButton cmd_ACEPTAR;
        public Krypton.Toolkit.KryptonLabel lbl_titulo;
        public Krypton.Toolkit.KryptonTextBox txt_error;
    }
}