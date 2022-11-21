using System.Drawing;
using System.Windows.Forms;


namespace Coordinaten
{
    public partial class win_form : Form
    {
        public win_form()
        {
            InitializeComponent();
        }

        private int xPosition;
        private int yPosition;

        private void win_Load(object sender, System.EventArgs e)
        {
            this.Opacity = 0.25;
        }

        private void win_MouseMove(object sender, MouseEventArgs e)
        {
            
            lblCoorinates.Text = "X: " + e.X + " / Y: " + e.Y;
        }

        private void win_MouseDown(object sender, MouseEventArgs e)
        {
            this.MouseMove += new MouseEventHandler(win_MouseMove);
            xPosition = e.X;
            yPosition = e.Y;
        }

        private void win_form_MouseClick(object sender, MouseEventArgs e)
        {

        }
    }
}
