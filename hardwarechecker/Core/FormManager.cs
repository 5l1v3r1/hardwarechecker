using hardwarechecker.UI.Forms;
using System;
using System.Windows.Forms;

namespace hardwarechecker.Core
{
    public class FormManager : ApplicationContext
    {
        public Form CurrentForm;
        public Form PreviousForm;

        private Main FrmMain;

        public FormManager() : base()
        {
            InitializeForms();
            SetCurrentForm(FrmMain);
        }

        private void InitializeForms()
        {
            FrmMain = new Main();
            FrmMain.FormClosed  += OnFormClosed;
        }

        private void SetCurrentForm(Form form)
        {
            if (CurrentForm != null)
            {
                PreviousForm = CurrentForm;
                
                if (PreviousForm.Visible )
                {
                    PreviousForm.Close();
                }
            }
          
            CurrentForm = form;
            CurrentForm.Show();
        }

        private void OnFormClosed(object sender, EventArgs e)
        {
            if (sender == FrmMain )
            {
                MessageBox.Show("Please come again!", "hardwarechecker", MessageBoxButtons.OK, MessageBoxIcon.Information );
                ExitApplication();
            }

            PreviousForm = (Form)sender;
        }

        private void ExitApplication()
        {
            if (Application.MessageLoop )
            {
                Application.Exit();
            } else
            {
                Environment.Exit(0);
            }
        }
        
        protected override void Dispose(bool disposing)
        {
            // unsubscribe from events
            FrmMain.FormClosed -= OnFormClosed;

            // dispose forms
            FrmMain.Dispose();

            base.Dispose(disposing);
        }
    }
}
