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
                dbSQL MyDB = new dbSQL();
                Task<JsonArray> x;
                x = MyDB.QueryJson("SELECT TOP 1000 * FROM [dbo].[tpv_usuarios]");

            }
            catch (Exception ex)
            {
                new appExeption(ex);
            }
        }
    }
}
