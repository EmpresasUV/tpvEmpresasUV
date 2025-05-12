using Krypton.Toolkit;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tpvEmpresasUV
{
    public partial class MainMDI : KryptonForm
    {
        /* INSTANCIANDO LOS FORMULARIOS DE LOS DIFERENTES PUNTOS DE VENTAS */
        public KryptonForm frm_tpvCOMEDORES = new tpvCOMEDORES();
        public KryptonForm frm_tpvCAFETERIAS = new tpvCAFETERIAS();
        public KryptonForm frm_tpvFARMACIAS = new tpvFARMACIAS();
        public KryptonForm frm_tpvTIENDAS = new tpvTIENDAS();

        public bool usr_loged = false;
        public MainMDI()
        {
            InitializeComponent();
        }

        private void MainMDI_Load(object sender, EventArgs e)
        {
            try
            {
                this.Visible = true;
                if (!usr_loged)
                {
                    
                    using (var frm_login = new MainLOGIN())
                    {
                        var result = frm_login.ShowDialog();
                        if (result == DialogResult.OK)
                        {
                            this.usr_loged = true;
                            frm_login.Visible = false;
                            frm_login.Close();
                            this.Show_MDI(frm_tpvCOMEDORES);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                new AppExeption(ex);
            }
        }

        public void Show_MDI(KryptonForm frm)
        {
            string MDIWidth = this.Width.ToString();
            string MDIHeight = this.Height.ToString();

            frm.MdiParent = this;           
            frm.Width = (Convert.ToInt32(MDIWidth) - 19);
            frm.Height = (Convert.ToInt32(MDIHeight) - 50);

            frm.FormBorderStyle = FormBorderStyle.FixedDialog;

            frm.WindowState = FormWindowState.Normal;
            frm.StartPosition = FormStartPosition.Manual;
            frm.Show();
        }

        public void Resize_MDI(KryptonForm frm)
        {
            if (frm.Visible == true)
            {
                string MDIWidth = this.Width.ToString();
                string MDIHeight = this.Height.ToString();

                frm.MdiParent = this;
                frm.Size = new Size((Convert.ToInt32(MDIWidth) - 19), (Convert.ToInt32(MDIHeight) - 50));
                //frm.Width = (Convert.ToInt32(MDIWidth) - 19);
                //frm.Height = (Convert.ToInt32(MDIHeight) - 50);

                frm.FormBorderStyle = FormBorderStyle.FixedDialog;

                frm.WindowState = FormWindowState.Normal;
                frm.StartPosition = FormStartPosition.Manual;
            }
        }

        private void MainMDI_Resize(object sender, EventArgs e)
        {
            this.BackgroundImage = Properties.Resources.bgEmpresas_AZUL;
            this.BackgroundImageLayout = ImageLayout.Zoom;
            this.Resize_MDI(frm_tpvCOMEDORES);
        }
    }
}
