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
        public bool usr_loged = false;
        public MainMDI()
        {
            InitializeComponent();
        }

        private void MainMDI_Load(object sender, EventArgs e)
        {
            //try
            //{
                
                using(tpvCOMEDORES tpvCOMEDORES = new tpvCOMEDORES())
                {
                    this.Show_MDI(tpvCOMEDORES);
                }
                   

                /*
                if (!usr_loged)
                {
                    
                    using (var frm_login = new MainLOGIN())
                    {
                        var result = frm_login.ShowDialog();
                        if (result == DialogResult.OK)
                        {
                            this.usr_loged = true;
                        }
                    }
                }
                */

            //}
            //catch (Exception ex)
            //{
            //    new AppExeption(ex);
            //}
        }





        public void Show_MDI(Form frm)
        {
            //string MDIWidth = this.Width.ToString();
            //string MDIHeight = this.Height.ToString();
            frm.MdiParent = this;
            //frm.Width = (Convert.ToInt32(MDIWidth) - 4);
            //frm.Height = (Convert.ToInt32(MDIHeight) - 4);
            //frm.StartPosition = FormStartPosition.CenterParent;
            frm.Show();
        }
    }
}
