namespace kiemtralan1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            txtUserName = new TextBox();
            label2 = new Label();
            txtpassword = new TextBox();
            btnlogin = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(122, 66);
            label1.Name = "label1";
            label1.Size = new Size(62, 15);
            label1.TabIndex = 0;
            label1.Text = "UserName";
            // 
            // txtUserName
            // 
            txtUserName.Location = new Point(210, 62);
            txtUserName.Name = "txtUserName";
            txtUserName.Size = new Size(137, 23);
            txtUserName.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(122, 124);
            label2.Name = "label2";
            label2.Size = new Size(57, 15);
            label2.TabIndex = 2;
            label2.Text = "Password";
            label2.Click += label2_Click;
            // 
            // txtpassword
            // 
            txtpassword.Location = new Point(210, 122);
            txtpassword.Name = "txtpassword";
            txtpassword.Size = new Size(137, 23);
            txtpassword.TabIndex = 3;
            // 
            // btnlogin
            // 
            btnlogin.Location = new Point(228, 189);
            btnlogin.Name = "btnlogin";
            btnlogin.Size = new Size(75, 23);
            btnlogin.TabIndex = 4;
            btnlogin.Text = "Log in";
            btnlogin.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnlogin);
            Controls.Add(txtpassword);
            Controls.Add(label2);
            Controls.Add(txtUserName);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtUserName;
        private Label label2;
        private TextBox txtpassword;
        private Button btnlogin;
    }
}