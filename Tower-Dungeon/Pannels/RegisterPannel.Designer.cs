namespace Tower_Dungeon.Pannels
{
    partial class RegisterPannel
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tbxUsername = new System.Windows.Forms.TextBox();
            this.tbxFName = new System.Windows.Forms.TextBox();
            this.tbxLName = new System.Windows.Forms.TextBox();
            this.tbxEmailAddress = new System.Windows.Forms.TextBox();
            this.tbxPassword = new System.Windows.Forms.TextBox();
            this.tbxPasswordConfirm = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // tbxUsername
            // 
            this.tbxUsername.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbxUsername.Location = new System.Drawing.Point(139, 175);
            this.tbxUsername.Name = "tbxUsername";
            this.tbxUsername.Size = new System.Drawing.Size(177, 20);
            this.tbxUsername.TabIndex = 0;
            // 
            // tbxFName
            // 
            this.tbxFName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbxFName.Location = new System.Drawing.Point(139, 225);
            this.tbxFName.Name = "tbxFName";
            this.tbxFName.Size = new System.Drawing.Size(177, 20);
            this.tbxFName.TabIndex = 1;
            // 
            // tbxLName
            // 
            this.tbxLName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbxLName.Location = new System.Drawing.Point(139, 285);
            this.tbxLName.Name = "tbxLName";
            this.tbxLName.Size = new System.Drawing.Size(177, 20);
            this.tbxLName.TabIndex = 2;
            // 
            // tbxEmailAddress
            // 
            this.tbxEmailAddress.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbxEmailAddress.Location = new System.Drawing.Point(139, 356);
            this.tbxEmailAddress.Name = "tbxEmailAddress";
            this.tbxEmailAddress.Size = new System.Drawing.Size(177, 20);
            this.tbxEmailAddress.TabIndex = 3;
            // 
            // tbxPassword
            // 
            this.tbxPassword.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbxPassword.Location = new System.Drawing.Point(139, 411);
            this.tbxPassword.Name = "tbxPassword";
            this.tbxPassword.Size = new System.Drawing.Size(177, 20);
            this.tbxPassword.TabIndex = 4;
            // 
            // tbxPasswordConfirm
            // 
            this.tbxPasswordConfirm.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbxPasswordConfirm.Location = new System.Drawing.Point(139, 469);
            this.tbxPasswordConfirm.Name = "tbxPasswordConfirm";
            this.tbxPasswordConfirm.Size = new System.Drawing.Size(177, 20);
            this.tbxPasswordConfirm.TabIndex = 5;
            // 
            // RegisterPannel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tbxPasswordConfirm);
            this.Controls.Add(this.tbxPassword);
            this.Controls.Add(this.tbxEmailAddress);
            this.Controls.Add(this.tbxLName);
            this.Controls.Add(this.tbxFName);
            this.Controls.Add(this.tbxUsername);
            this.Name = "RegisterPannel";
            this.Size = new System.Drawing.Size(700, 650);
            this.AutoSizeChanged += new System.EventHandler(this.Registerpannel_Resize);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbxUsername;
        private System.Windows.Forms.TextBox tbxFName;
        private System.Windows.Forms.TextBox tbxLName;
        private System.Windows.Forms.TextBox tbxEmailAddress;
        private System.Windows.Forms.TextBox tbxPassword;
        private System.Windows.Forms.TextBox tbxPasswordConfirm;
    }
}
