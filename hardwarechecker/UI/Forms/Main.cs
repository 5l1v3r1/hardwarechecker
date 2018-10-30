using hardwarechecker.Core;
using System;
using System.Windows.Forms;

namespace hardwarechecker.UI.Forms
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void buttonExitApplication_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            textHardwareId.Text = HardwareId.GetHardwareId();
        }

        private void buttonCheckHardwareId_Click(object sender, EventArgs e)
        {
            if (AuthenticationManager.Authenticate(textServerUri.Text, textHardwareId.Text))
            {
                MessageBox.Show("Successfully authenticated!", "hardwarechecker", MessageBoxButtons.OK, MessageBoxIcon.Information );
            } else
            {
                MessageBox.Show("Failed to authenticate!", "hardwarechecker", MessageBoxButtons.OK, MessageBoxIcon.Error );

            }
        }
    }
}
