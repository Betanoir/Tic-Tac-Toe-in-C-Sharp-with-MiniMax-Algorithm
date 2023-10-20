using System.Diagnostics;

namespace Tic_Tac_Toe
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            Process.GetCurrentProcess().Kill();
        }

        private void BtnPlay_Click(object sender, EventArgs e)
        {
            Game game = new();
            this.Hide();
            game.ShowDialog();
        }
    }
}