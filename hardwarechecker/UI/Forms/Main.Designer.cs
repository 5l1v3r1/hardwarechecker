namespace hardwarechecker.UI.Forms
{
    partial class Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupCheckHardwareId = new System.Windows.Forms.GroupBox();
            this.buttonCheckHardwareId = new System.Windows.Forms.Button();
            this.labelServerUri = new System.Windows.Forms.Label();
            this.textServerUri = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textHardwareId = new System.Windows.Forms.TextBox();
            this.buttonExitApplication = new System.Windows.Forms.Button();
            this.groupCheckHardwareId.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupCheckHardwareId
            // 
            this.groupCheckHardwareId.Controls.Add(this.textHardwareId);
            this.groupCheckHardwareId.Controls.Add(this.label1);
            this.groupCheckHardwareId.Controls.Add(this.textServerUri);
            this.groupCheckHardwareId.Controls.Add(this.labelServerUri);
            this.groupCheckHardwareId.Controls.Add(this.buttonExitApplication);
            this.groupCheckHardwareId.Controls.Add(this.buttonCheckHardwareId);
            this.groupCheckHardwareId.Location = new System.Drawing.Point(24, 29);
            this.groupCheckHardwareId.Name = "groupCheckHardwareId";
            this.groupCheckHardwareId.Size = new System.Drawing.Size(315, 169);
            this.groupCheckHardwareId.TabIndex = 0;
            this.groupCheckHardwareId.TabStop = false;
            this.groupCheckHardwareId.Text = "Check your hardware id";
            // 
            // buttonCheckHardwareId
            // 
            this.buttonCheckHardwareId.Location = new System.Drawing.Point(209, 127);
            this.buttonCheckHardwareId.Name = "buttonCheckHardwareId";
            this.buttonCheckHardwareId.Size = new System.Drawing.Size(62, 23);
            this.buttonCheckHardwareId.TabIndex = 0;
            this.buttonCheckHardwareId.Text = "Check";
            this.buttonCheckHardwareId.UseVisualStyleBackColor = true;
            this.buttonCheckHardwareId.Click += new System.EventHandler(this.buttonCheckHardwareId_Click);
            // 
            // labelServerUri
            // 
            this.labelServerUri.AutoSize = true;
            this.labelServerUri.Location = new System.Drawing.Point(222, 43);
            this.labelServerUri.Name = "labelServerUri";
            this.labelServerUri.Size = new System.Drawing.Size(54, 13);
            this.labelServerUri.TabIndex = 1;
            this.labelServerUri.Text = "Server Uri";
            // 
            // textServerUri
            // 
            this.textServerUri.AcceptsReturn = true;
            this.textServerUri.AcceptsTab = true;
            this.textServerUri.Location = new System.Drawing.Point(39, 40);
            this.textServerUri.Name = "textServerUri";
            this.textServerUri.Size = new System.Drawing.Size(165, 20);
            this.textServerUri.TabIndex = 2;
            this.textServerUri.Text = "http://localhost/hwid.php";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(219, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Hardware Id";
            // 
            // textHardwareId
            // 
            this.textHardwareId.AcceptsReturn = true;
            this.textHardwareId.AcceptsTab = true;
            this.textHardwareId.Location = new System.Drawing.Point(39, 76);
            this.textHardwareId.Name = "textHardwareId";
            this.textHardwareId.Size = new System.Drawing.Size(165, 20);
            this.textHardwareId.TabIndex = 2;
            // 
            // buttonExitApplication
            // 
            this.buttonExitApplication.Location = new System.Drawing.Point(141, 127);
            this.buttonExitApplication.Name = "buttonExitApplication";
            this.buttonExitApplication.Size = new System.Drawing.Size(62, 23);
            this.buttonExitApplication.TabIndex = 0;
            this.buttonExitApplication.Text = "Exit";
            this.buttonExitApplication.UseVisualStyleBackColor = true;
            this.buttonExitApplication.Click += new System.EventHandler(this.buttonExitApplication_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(369, 233);
            this.Controls.Add(this.groupCheckHardwareId);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Main";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "hardwarechecker by gigajew";
            this.Load += new System.EventHandler(this.Main_Load);
            this.groupCheckHardwareId.ResumeLayout(false);
            this.groupCheckHardwareId.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupCheckHardwareId;
        private System.Windows.Forms.TextBox textHardwareId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textServerUri;
        private System.Windows.Forms.Label labelServerUri;
        private System.Windows.Forms.Button buttonExitApplication;
        private System.Windows.Forms.Button buttonCheckHardwareId;
    }
}