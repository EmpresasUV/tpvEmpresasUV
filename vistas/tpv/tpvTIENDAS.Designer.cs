namespace tpvEmpresasUV
{
    partial class tpvTIENDAS
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


        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            Ribbon_TIENDAS = new Krypton.Ribbon.KryptonRibbon();
            kryptonRibbonTab1 = new Krypton.Ribbon.KryptonRibbonTab();
            kryptonRibbonGroup1 = new Krypton.Ribbon.KryptonRibbonGroup();
            kryptonRibbonGroupTriple1 = new Krypton.Ribbon.KryptonRibbonGroupTriple();
            kryptonRibbonGroupButton1 = new Krypton.Ribbon.KryptonRibbonGroupButton();
            kryptonRibbonGroupButton2 = new Krypton.Ribbon.KryptonRibbonGroupButton();
            kryptonRibbonGroupButton3 = new Krypton.Ribbon.KryptonRibbonGroupButton();
            kryptonRibbonGroupLines1 = new Krypton.Ribbon.KryptonRibbonGroupLines();
            kryptonRibbonGroupButton4 = new Krypton.Ribbon.KryptonRibbonGroupButton();
            kryptonRibbonGroupButton5 = new Krypton.Ribbon.KryptonRibbonGroupButton();
            kryptonRibbonGroup2 = new Krypton.Ribbon.KryptonRibbonGroup();
            kryptonRibbonGroupLines2 = new Krypton.Ribbon.KryptonRibbonGroupLines();
            kryptonRibbonGroupButton6 = new Krypton.Ribbon.KryptonRibbonGroupButton();
            kryptonRibbonGroupButton7 = new Krypton.Ribbon.KryptonRibbonGroupButton();
            kryptonStatusStrip1 = new Krypton.Toolkit.KryptonStatusStrip();
            ((System.ComponentModel.ISupportInitialize)Ribbon_TIENDAS).BeginInit();
            SuspendLayout();
            // 
            // Ribbon_TIENDAS
            // 
            Ribbon_TIENDAS.Name = "Ribbon_TIENDAS";
            Ribbon_TIENDAS.PaletteMode = Krypton.Toolkit.PaletteMode.Office2007Blue;
            Ribbon_TIENDAS.RibbonTabs.AddRange(new Krypton.Ribbon.KryptonRibbonTab[] { kryptonRibbonTab1 });
            Ribbon_TIENDAS.SelectedTab = kryptonRibbonTab1;
            Ribbon_TIENDAS.Size = new Size(949, 115);
            Ribbon_TIENDAS.TabIndex = 0;
            Ribbon_TIENDAS.SelectedTabChanged += Ribbon_TIENDAS_SelectedTabChanged;
            // 
            // kryptonRibbonTab1
            // 
            kryptonRibbonTab1.Groups.AddRange(new Krypton.Ribbon.KryptonRibbonGroup[] { kryptonRibbonGroup1, kryptonRibbonGroup2 });
            kryptonRibbonTab1.Text = "Ventas";
            // 
            // kryptonRibbonGroup1
            // 
            kryptonRibbonGroup1.Items.AddRange(new Krypton.Ribbon.KryptonRibbonGroupContainer[] { kryptonRibbonGroupTriple1, kryptonRibbonGroupLines1 });
            // 
            // kryptonRibbonGroupTriple1
            // 
            kryptonRibbonGroupTriple1.Items.AddRange(new Krypton.Ribbon.KryptonRibbonGroupItem[] { kryptonRibbonGroupButton1, kryptonRibbonGroupButton2, kryptonRibbonGroupButton3 });
            // 
            // kryptonRibbonGroupLines1
            // 
            kryptonRibbonGroupLines1.Items.AddRange(new Krypton.Ribbon.KryptonRibbonGroupItem[] { kryptonRibbonGroupButton4, kryptonRibbonGroupButton5 });
            // 
            // kryptonRibbonGroup2
            // 
            kryptonRibbonGroup2.Items.AddRange(new Krypton.Ribbon.KryptonRibbonGroupContainer[] { kryptonRibbonGroupLines2 });
            kryptonRibbonGroup2.TextLine1 = "Tickets";
            // 
            // kryptonRibbonGroupLines2
            // 
            kryptonRibbonGroupLines2.Items.AddRange(new Krypton.Ribbon.KryptonRibbonGroupItem[] { kryptonRibbonGroupButton6, kryptonRibbonGroupButton7 });
            // 
            // kryptonRibbonGroupButton6
            // 
            kryptonRibbonGroupButton6.TextLine1 = "Cancelación";
            // 
            // kryptonRibbonGroupButton7
            // 
            kryptonRibbonGroupButton7.TextLine1 = "Re-Impresión";
            // 
            // kryptonStatusStrip1
            // 
            kryptonStatusStrip1.Font = new Font("Segoe UI", 9F);
            kryptonStatusStrip1.Location = new Point(0, 605);
            kryptonStatusStrip1.Name = "kryptonStatusStrip1";
            kryptonStatusStrip1.ProgressBars = null;
            kryptonStatusStrip1.RenderMode = ToolStripRenderMode.ManagerRenderMode;
            kryptonStatusStrip1.Size = new Size(949, 22);
            kryptonStatusStrip1.TabIndex = 1;
            kryptonStatusStrip1.Text = "kryptonStatusStrip1";
            // 
            // tpvTIENDAS
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(949, 627);
            CloseBox = false;
            Controls.Add(kryptonStatusStrip1);
            Controls.Add(Ribbon_TIENDAS);
            Margin = new Padding(4, 3, 4, 3);
            Name = "tpvTIENDAS";
            PaletteMode = Krypton.Toolkit.PaletteMode.Office2007Blue;
            ShowIcon = false;
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterParent;
            Text = "TPV Tienda UV";
            ((System.ComponentModel.ISupportInitialize)Ribbon_TIENDAS).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private Krypton.Ribbon.KryptonRibbon Ribbon_TIENDAS;
        private Krypton.Ribbon.KryptonRibbonTab kryptonRibbonTab1;
        private Krypton.Ribbon.KryptonRibbonGroup kryptonRibbonGroup1;
        private Krypton.Ribbon.KryptonRibbonGroupTriple kryptonRibbonGroupTriple1;
        private Krypton.Ribbon.KryptonRibbonGroupButton kryptonRibbonGroupButton1;
        private Krypton.Ribbon.KryptonRibbonGroupButton kryptonRibbonGroupButton2;
        private Krypton.Ribbon.KryptonRibbonGroupButton kryptonRibbonGroupButton3;
        private Krypton.Ribbon.KryptonRibbonGroupLines kryptonRibbonGroupLines1;
        private Krypton.Ribbon.KryptonRibbonGroupButton kryptonRibbonGroupButton4;
        private Krypton.Ribbon.KryptonRibbonGroupButton kryptonRibbonGroupButton5;
        private Krypton.Ribbon.KryptonRibbonGroup kryptonRibbonGroup2;
        private Krypton.Ribbon.KryptonRibbonGroupLines kryptonRibbonGroupLines2;
        private Krypton.Ribbon.KryptonRibbonGroupButton kryptonRibbonGroupButton6;
        private Krypton.Ribbon.KryptonRibbonGroupButton kryptonRibbonGroupButton7;
        private Krypton.Toolkit.KryptonStatusStrip kryptonStatusStrip1;
    }
}