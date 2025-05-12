namespace tpvEmpresasUV
{
    partial class tpvCOMEDORES
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
            components = new System.ComponentModel.Container();
            Manager = new Krypton.Toolkit.KryptonManager(components);
            kryptonStatusStrip1 = new Krypton.Toolkit.KryptonStatusStrip();
            kryptonPanel1 = new Krypton.Toolkit.KryptonPanel();
            Panel_CHAT = new Krypton.Toolkit.KryptonPanel();
            Header1 = new Krypton.Toolkit.KryptonHeader();
            kryptonPanel2 = new Krypton.Toolkit.KryptonPanel();
            kryptonButton1 = new Krypton.Toolkit.KryptonButton();
            kryptonTextBox1 = new Krypton.Toolkit.KryptonTextBox();
            ((System.ComponentModel.ISupportInitialize)kryptonPanel1).BeginInit();
            kryptonPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Panel_CHAT).BeginInit();
            ((System.ComponentModel.ISupportInitialize)kryptonPanel2).BeginInit();
            kryptonPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // Manager
            // 
            Manager.GlobalPaletteMode = Krypton.Toolkit.PaletteMode.Office2007Blue;
            // 
            // kryptonStatusStrip1
            // 
            kryptonStatusStrip1.Font = new Font("Segoe UI", 9F);
            kryptonStatusStrip1.Location = new Point(0, 689);
            kryptonStatusStrip1.Name = "kryptonStatusStrip1";
            kryptonStatusStrip1.ProgressBars = null;
            kryptonStatusStrip1.RenderMode = ToolStripRenderMode.ManagerRenderMode;
            kryptonStatusStrip1.Size = new Size(1015, 22);
            kryptonStatusStrip1.TabIndex = 2;
            kryptonStatusStrip1.Text = "kryptonStatusStrip1";
            // 
            // kryptonPanel1
            // 
            kryptonPanel1.Controls.Add(Panel_CHAT);
            kryptonPanel1.Controls.Add(Header1);
            kryptonPanel1.Controls.Add(kryptonPanel2);
            kryptonPanel1.Dock = DockStyle.Right;
            kryptonPanel1.Location = new Point(794, 0);
            kryptonPanel1.Name = "kryptonPanel1";
            kryptonPanel1.Size = new Size(221, 689);
            kryptonPanel1.TabIndex = 3;
            // 
            // Panel_CHAT
            // 
            Panel_CHAT.Dock = DockStyle.Fill;
            Panel_CHAT.Location = new Point(0, 36);
            Panel_CHAT.Name = "Panel_CHAT";
            Panel_CHAT.Size = new Size(221, 586);
            Panel_CHAT.TabIndex = 4;
            // 
            // Header1
            // 
            Header1.Dock = DockStyle.Top;
            Header1.Location = new Point(0, 0);
            Header1.Name = "Header1";
            Header1.Size = new Size(221, 36);
            Header1.TabIndex = 3;
            Header1.Values.Description = "Coordinación";
            Header1.Values.Heading = "Chat";
            // 
            // kryptonPanel2
            // 
            kryptonPanel2.Controls.Add(kryptonButton1);
            kryptonPanel2.Controls.Add(kryptonTextBox1);
            kryptonPanel2.Dock = DockStyle.Bottom;
            kryptonPanel2.Location = new Point(0, 622);
            kryptonPanel2.Name = "kryptonPanel2";
            kryptonPanel2.Size = new Size(221, 67);
            kryptonPanel2.TabIndex = 2;
            // 
            // kryptonButton1
            // 
            kryptonButton1.Location = new Point(179, 2);
            kryptonButton1.Name = "kryptonButton1";
            kryptonButton1.Size = new Size(38, 63);
            kryptonButton1.TabIndex = 3;
            kryptonButton1.Values.DropDownArrowColor = Color.Empty;
            kryptonButton1.Values.Text = "";
            // 
            // kryptonTextBox1
            // 
            kryptonTextBox1.Location = new Point(2, 2);
            kryptonTextBox1.Multiline = true;
            kryptonTextBox1.Name = "kryptonTextBox1";
            kryptonTextBox1.Size = new Size(174, 63);
            kryptonTextBox1.TabIndex = 2;
            // 
            // tpvCOMEDORES
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1015, 711);
            CloseBox = false;
            Controls.Add(kryptonPanel1);
            Controls.Add(kryptonStatusStrip1);
            Margin = new Padding(4, 3, 4, 3);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "tpvCOMEDORES";
            PaletteMode = Krypton.Toolkit.PaletteMode.Office2007Blue;
            ShowIcon = false;
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.Manual;
            Text = "TPV Comedores UV";
            TransparencyKey = Color.Empty;
            ((System.ComponentModel.ISupportInitialize)kryptonPanel1).EndInit();
            kryptonPanel1.ResumeLayout(false);
            kryptonPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)Panel_CHAT).EndInit();
            ((System.ComponentModel.ISupportInitialize)kryptonPanel2).EndInit();
            kryptonPanel2.ResumeLayout(false);
            kryptonPanel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private Krypton.Toolkit.KryptonManager Manager;
        private Krypton.Toolkit.KryptonStatusStrip kryptonStatusStrip1;
        private Krypton.Toolkit.KryptonPanel kryptonPanel1;
        private Krypton.Toolkit.KryptonHeader Header1;
        private Krypton.Toolkit.KryptonPanel kryptonPanel2;
        private Krypton.Toolkit.KryptonButton kryptonButton1;
        private Krypton.Toolkit.KryptonTextBox kryptonTextBox1;
        private Krypton.Toolkit.KryptonPanel Panel_CHAT;
    }
}