using System;
using Krypton.Toolkit;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.Json.Nodes;
using TpvEmpresasUV.modelos;
using System.Diagnostics;
using tpvEmpresasUV.Properties;

namespace tpvEmpresasUV
{
    public partial class MainLOGIN : KryptonForm
    {
        public MainLOGIN()
        {
            InitializeComponent();
            this.Size = new Size(263, 370);
        }

        private void cmd_CANCELAR_Click(object sender, EventArgs e)
        {
            try
            {
                Application.Exit();
            }
            catch (Exception ex)
            {
                new appExeption(ex);
            }
        }

        private void cmd_ACEPTAR_Click(object sender, EventArgs e)
        {
            try
            {
                using(dbEmpresasUVContexto dbEmpresasUV = new dbEmpresasUVContexto())
                {
                    foreach (var oUsuarios in dbEmpresasUV.TpvUsuarios)
                    {
                        Debug.WriteLine(oUsuarios.Nombres);
                    }
                }

            }
            catch (Exception ex)
            {
                new appExeption(ex);
            }
        }
    }
}
