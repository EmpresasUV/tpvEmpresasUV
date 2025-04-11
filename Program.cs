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
            
            
            Thread.Sleep(2000);

            var screen = Screen.PrimaryScreen;
            string screenWidth = screen.Bounds.Width.ToString();
            string screenHeight = screen.Bounds.Height.ToString();


            //Create and Show Main Form
            MyMainMDI = new MainMDI();
            MyMainMDI.Width = (Convert.ToInt32(screenWidth) - 4);
            MyMainMDI.Height = (Convert.ToInt32(screenHeight) - 48);
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

    }
}