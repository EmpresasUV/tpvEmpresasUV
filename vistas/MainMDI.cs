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
        public MainMDI()
        {
            InitializeComponent();
        }

        private void MainMDI_Load(object sender, EventArgs e)
        {
            try
            {
                
            }
            catch (Exception ex)
            {
                new appExeption(ex);
            }
        }
    }
}
