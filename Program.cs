using Krypton.Toolkit;

namespace tpvEmpresasUV
{
    
    static class Program
    {

        public static KryptonForm MySplash;
        public static KryptonForm MyMainMDI;
        
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Show Splash Form
            MySplash = new Splash();
            var splashThread = new Thread(new ThreadStart(
                () => Application.Run(MySplash)));
            splashThread.SetApartmentState(ApartmentState.STA);
            splashThread.Start();
            
            
            Thread.Sleep(5000);
            
            
            
            //Create and Show Main Form
            MyMainMDI = new MainMDI();
            MyMainMDI.Load += MainForm_LoadCompleted;
            Application.Run(MyMainMDI);
        }
        
        private static void MainForm_LoadCompleted(object sender, EventArgs e)
        {
            if (MySplash != null && !MySplash.Disposing && !MySplash.IsDisposed)
                MySplash.Invoke(new Action(() => MySplash.Close()));
            MyMainMDI.TopMost = true;
            MyMainMDI.Activate();
            MyMainMDI.TopMost = false;
            
        }














        /*
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new Splash());
        }
        */
    }
}