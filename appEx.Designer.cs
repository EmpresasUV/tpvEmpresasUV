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
            cmd_ACEPTAR = new Krypton.Toolkit.KryptonButton();
            cmd_INFORMAR = new Krypton.Toolkit.KryptonButton();
            SuspendLayout();
            // 
            // cmd_ACEPTAR
            // 
            cmd_ACEPTAR.Location = new Point(12, 265);
            cmd_ACEPTAR.Name = "cmd_ACEPTAR";
            cmd_ACEPTAR.Size = new Size(90, 25);
            cmd_ACEPTAR.TabIndex = 0;
            cmd_ACEPTAR.Values.DropDownArrowColor = Color.Empty;
            cmd_ACEPTAR.Values.Image = Properties.Resources.mark;
            cmd_ACEPTAR.Values.Text = "&Aceptar";
            // 
            // cmd_INFORMAR
            // 
            cmd_INFORMAR.Location = new Point(167, 265);
            cmd_INFORMAR.Name = "cmd_INFORMAR";
            cmd_INFORMAR.Size = new Size(90, 25);
            cmd_INFORMAR.TabIndex = 1;
            cmd_INFORMAR.Values.DropDownArrowColor = Color.Empty;
            cmd_INFORMAR.Values.Image = Properties.Resources.comments_add;
            cmd_INFORMAR.Values.Text = "&Informar";
            // 
            // appException
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(269, 302);
            Controls.Add(cmd_INFORMAR);
            Controls.Add(cmd_ACEPTAR);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "appException";
            PaletteMode = Krypton.Toolkit.PaletteMode.Office2007Blue;
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "¡Problema detectado!";
            ResumeLayout(false);
        }

        #endregion

        private Krypton.Toolkit.KryptonButton cmd_ACEPTAR;
        private Krypton.Toolkit.KryptonButton cmd_INFORMAR;
    }
}