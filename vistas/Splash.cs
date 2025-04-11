using Krypton.Toolkit;

namespace tpvEmpresasUV
{
    public partial class Splash : KryptonForm
    {
        public Splash()
        {
            InitializeComponent();
        }

        private void timer_LOAD_Tick(object sender, EventArgs e)
        {
            try
            {

            }
            catch (Exception ex)
            {
                new AppExeption(ex);
            }
        }

        private void Splash_Load(object sender, EventArgs e)
        {
            
            try
            {

            }
            catch (Exception ex)
            {
                new AppExeption(ex);
            }

        }
    }
}
