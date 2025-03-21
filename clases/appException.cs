using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;

namespace tpvEmpresasUV
{
    class appExeption
    {
        public appExeption(Exception EX)
        {
            using (var frm_error = new appEx())
            {
                var result = frm_error.ShowDialog();
                if (result == DialogResult.OK)
                {
                    Registrar();
                }
            }
        }
        public appExeption(SqlException SQLex)
        {
            using (var frm_error = new appEx())
            {
                frm_error.lbl_titulo.Text = SQLex.Source.ToString();
                frm_error.txt_error.Text = SQLex.Message.ToString();
                var result = frm_error.ShowDialog();
                if (result == DialogResult.OK)
                {
                    Registrar();
                }
            }
        }

        public void Registrar()
        {

        }
    }
}
