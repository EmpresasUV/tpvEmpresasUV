using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZkTecoFingerPrint;

namespace tpvEmpresasUV.clases
{
    internal class appBiometricos
    {
        public appBiometricos() //Constructor de clase
        {
            if (ZkTecoFingerHost.GetDeviceCount() < 1)
            {
                //No hay lector biometrico conectado al usb

            }
            else
            {
                ZkTecoFingerHost.Initialize();
            }
        }

    }
}
