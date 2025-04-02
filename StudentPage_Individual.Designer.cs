namespace labexamipt
{
    partial class StudentPage_Individual
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label studentIdLabel;
        private System.Windows.Forms.Label fullNameLabel;
        private System.Windows.Forms.Label addressLabel;
        private System.Windows.Forms.Label contactLabel;
        private System.Windows.Forms.Label emailLabel;
        private System.Windows.Forms.Label guardianLabel;
        private System.Windows.Forms.Label hobbiesLabel;
        private System.Windows.Forms.Button closeBtn;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.studentIdLabel = new System.Windows.Forms.Label();
            this.fullNameLabel = new System.Windows.Forms.Label();
            this.addressLabel = new System.Windows.Forms.Label();
            this.contactLabel = new System.Windows.Forms.Label();
            this.emailLabel = new System.Windows.Forms.Label();
            this.guardianLabel = new System.Windows.Forms.Label();
            this.hobbiesLabel = new System.Windows.Forms.Label();
            this.closeBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // studentIdLabel
            // 
            this.studentIdLabel.AutoSize = true;
            this.studentIdLabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.studentIdLabel.Location = new System.Drawing.Point(15, 16);
            this.studentIdLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.studentIdLabel.Name = "studentIdLabel";
            this.studentIdLabel.Size = new System.Drawing.Size(89, 19);
            this.studentIdLabel.TabIndex = 0;
            this.studentIdLabel.Text = "Student ID:";
            // 
            // fullNameLabel
            // 
            this.fullNameLabel.AutoSize = true;
            this.fullNameLabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fullNameLabel.Location = new System.Drawing.Point(16, 53);
            this.fullNameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.fullNameLabel.Name = "fullNameLabel";
            this.fullNameLabel.Size = new System.Drawing.Size(92, 19);
            this.fullNameLabel.TabIndex = 1;
            this.fullNameLabel.Text = "Full Name:";
            // 
            // addressLabel
            // 
            this.addressLabel.AutoSize = true;
            this.addressLabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addressLabel.Location = new System.Drawing.Point(15, 88);
            this.addressLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.addressLabel.Name = "addressLabel";
            this.addressLabel.Size = new System.Drawing.Size(74, 19);
            this.addressLabel.TabIndex = 2;
            this.addressLabel.Text = "Address:";
            // 
            // contactLabel
            // 
            this.contactLabel.AutoSize = true;
            this.contactLabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contactLabel.Location = new System.Drawing.Point(16, 123);
            this.contactLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.contactLabel.Name = "contactLabel";
            this.contactLabel.Size = new System.Drawing.Size(142, 19);
            this.contactLabel.TabIndex = 3;
            this.contactLabel.Text = "Contact Number:";
            // 
            // emailLabel
            // 
            this.emailLabel.AutoSize = true;
            this.emailLabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailLabel.Location = new System.Drawing.Point(16, 161);
            this.emailLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(56, 19);
            this.emailLabel.TabIndex = 4;
            this.emailLabel.Text = "Email:";
            // 
            // guardianLabel
            // 
            this.guardianLabel.AutoSize = true;
            this.guardianLabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guardianLabel.Location = new System.Drawing.Point(15, 196);
            this.guardianLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.guardianLabel.Name = "guardianLabel";
            this.guardianLabel.Size = new System.Drawing.Size(141, 19);
            this.guardianLabel.TabIndex = 5;
            this.guardianLabel.Text = "Guardian Name:";
            // 
            // hobbiesLabel
            // 
            this.hobbiesLabel.AutoSize = true;
            this.hobbiesLabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hobbiesLabel.Location = new System.Drawing.Point(15, 237);
            this.hobbiesLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.hobbiesLabel.Name = "hobbiesLabel";
            this.hobbiesLabel.Size = new System.Drawing.Size(76, 19);
            this.hobbiesLabel.TabIndex = 6;
            this.hobbiesLabel.Text = "Hobbies:";
            // 
            // closeBtn
            // 
            this.closeBtn.BackColor = System.Drawing.Color.PaleVioletRed;
            this.closeBtn.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closeBtn.ForeColor = System.Drawing.Color.White;
            this.closeBtn.Location = new System.Drawing.Point(21, 289);
            this.closeBtn.Margin = new System.Windows.Forms.Padding(2);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(78, 32);
            this.closeBtn.TabIndex = 7;
            this.closeBtn.Text = "Close";
            this.closeBtn.UseVisualStyleBackColor = false;
            this.closeBtn.Click += new System.EventHandler(this.CloseBtn);
            // 
            // StudentPage_Individual
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(482, 377);
            this.Controls.Add(this.studentIdLabel);
            this.Controls.Add(this.fullNameLabel);
            this.Controls.Add(this.addressLabel);
            this.Controls.Add(this.contactLabel);
            this.Controls.Add(this.emailLabel);
            this.Controls.Add(this.guardianLabel);
            this.Controls.Add(this.hobbiesLabel);
            this.Controls.Add(this.closeBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "StudentPage_Individual";
            this.Text = "Student Details";
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
