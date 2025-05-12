using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;

namespace tpvEmpresasUV
{
    class AppExeption
    {
        public EventLog eventLog = new EventLog();
        public string eventLogNAME = "TPV2.0 EmpresasUV";

        public AppExeption(Exception EX)
        {
            try
            {
                if (!EventLog.SourceExists(eventLogNAME))
                {
                    EventLog.CreateEventSource(eventLogNAME, eventLogNAME);
                    eventLog.Source = eventLogNAME;
                }
                else
                {
                    eventLog.Source = eventLogNAME;
                }
            }
            catch
            {
                eventLog.Source = "Application";
            }

            using (var frm_error = new appEx())
            {
                frm_error.lbl_titulo.Text = EX.Source.ToString();
                frm_error.txt_error.Text = EX.Message.ToString();
                var result = frm_error.ShowDialog();
                if (result == DialogResult.OK)
                {
                    Registrar();
                }
            }
        }
        public AppExeption(SqlException SQLex)
        {
            try
            {
                if (!EventLog.SourceExists(eventLogNAME))
                {
                    EventLog.CreateEventSource(eventLogNAME, eventLogNAME);
                    eventLog.Source = eventLogNAME;
                }
                else
                {
                    eventLog.Source = eventLogNAME;
                }
            }
            catch
            {
                eventLog.Source = "Application";
            }

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
