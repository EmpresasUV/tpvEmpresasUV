namespace tpvEmpresasUV
{
    partial class MainMDI
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMDI));
            toolTip = new ToolTip(components);
            cmd_AYUDA = new Krypton.Toolkit.ButtonSpecAny();
            SuspendLayout();
            // 
            // cmd_AYUDA
            // 
            cmd_AYUDA.Image = Properties.Resources.help_3;
            cmd_AYUDA.UniqueName = "8a68c9e1ddb54d8a838db3de29539b1f";
            // 
            // MainMDI
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ButtonSpecs.Add(cmd_AYUDA);
            ClientSize = new Size(664, 608);
            CloseBox = false;
            Icon = (Icon)resources.GetObject("$this.Icon");
            IsMdiContainer = true;
            Margin = new Padding(4, 3, 4, 3);
            Name = "MainMDI";
            PaletteMode = Krypton.Toolkit.PaletteMode.Office2007Blue;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Empresas UV";
            TransparencyKey = Color.Empty;
            Load += MainMDI_Load;
            ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ToolTip toolTip;
        private Krypton.Toolkit.ButtonSpecAny cmd_AYUDA;
    }
}



