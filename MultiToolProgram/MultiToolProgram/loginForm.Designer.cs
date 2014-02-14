namespace MultiToolProgram
{
    partial class loginForm
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.usernameField = new System.Windows.Forms.TextBox();
            this.usernameTitle = new System.Windows.Forms.Label();
            this.passwordTitle = new System.Windows.Forms.Label();
            this.passwordField = new System.Windows.Forms.MaskedTextBox();
            this.loginButton = new System.Windows.Forms.Button();
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.usernameField, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.usernameTitle, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.passwordTitle, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.passwordField, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.loginButton, 0, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(600, 177);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // usernameField
            // 
            this.usernameField.Dock = System.Windows.Forms.DockStyle.Fill;
            this.usernameField.Location = new System.Drawing.Point(306, 6);
            this.usernameField.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.usernameField.Name = "usernameField";
            this.usernameField.Size = new System.Drawing.Size(288, 31);
            this.usernameField.TabIndex = 1;
            this.usernameField.TextChanged += new System.EventHandler(this.usernameField_TextChanged);
            // 
            // usernameTitle
            // 
            this.usernameTitle.AutoSize = true;
            this.usernameTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.usernameTitle.Location = new System.Drawing.Point(6, 0);
            this.usernameTitle.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.usernameTitle.Name = "usernameTitle";
            this.usernameTitle.Size = new System.Drawing.Size(288, 59);
            this.usernameTitle.TabIndex = 0;
            this.usernameTitle.Text = "Username:";
            this.usernameTitle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // passwordTitle
            // 
            this.passwordTitle.AutoSize = true;
            this.passwordTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.passwordTitle.Location = new System.Drawing.Point(6, 59);
            this.passwordTitle.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.passwordTitle.Name = "passwordTitle";
            this.passwordTitle.Size = new System.Drawing.Size(288, 59);
            this.passwordTitle.TabIndex = 2;
            this.passwordTitle.Text = "Password:";
            this.passwordTitle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // passwordField
            // 
            this.passwordField.Dock = System.Windows.Forms.DockStyle.Fill;
            this.passwordField.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordField.Location = new System.Drawing.Point(306, 65);
            this.passwordField.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.passwordField.Name = "passwordField";
            this.passwordField.PasswordChar = '*';
            this.passwordField.Size = new System.Drawing.Size(288, 35);
            this.passwordField.TabIndex = 3;
            this.passwordField.TextChanged += new System.EventHandler(this.passwordField_TextChanged);
            // 
            // loginButton
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.loginButton, 2);
            this.loginButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.loginButton.Location = new System.Drawing.Point(6, 124);
            this.loginButton.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(588, 47);
            this.loginButton.TabIndex = 4;
            this.loginButton.Text = "Login";
            this.loginButton.UseVisualStyleBackColor = true;
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // loginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 177);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "loginForm";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.loginForm_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label usernameTitle;
        private System.Windows.Forms.TextBox usernameField;
        private System.Windows.Forms.Label passwordTitle;
        private System.Windows.Forms.MaskedTextBox passwordField;
        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private System.Windows.Forms.Button loginButton;
    }
}

