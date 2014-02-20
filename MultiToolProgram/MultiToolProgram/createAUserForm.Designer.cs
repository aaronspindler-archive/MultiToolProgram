namespace MultiToolProgram
{
    partial class createAUserForm
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
            this.usernameTitleLabel = new System.Windows.Forms.Label();
            this.passwordTitleLabel = new System.Windows.Forms.Label();
            this.usernameField = new System.Windows.Forms.TextBox();
            this.passwordField = new System.Windows.Forms.TextBox();
            this.createUserButton = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Controls.Add(this.usernameTitleLabel, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.passwordTitleLabel, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.usernameField, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.passwordField, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.createUserButton, 1, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(336, 78);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // usernameTitleLabel
            // 
            this.usernameTitleLabel.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.usernameTitleLabel, 2);
            this.usernameTitleLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.usernameTitleLabel.Location = new System.Drawing.Point(3, 0);
            this.usernameTitleLabel.Name = "usernameTitleLabel";
            this.usernameTitleLabel.Size = new System.Drawing.Size(162, 26);
            this.usernameTitleLabel.TabIndex = 1;
            this.usernameTitleLabel.Text = "Enter a Username";
            this.usernameTitleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // passwordTitleLabel
            // 
            this.passwordTitleLabel.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.passwordTitleLabel, 2);
            this.passwordTitleLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.passwordTitleLabel.Location = new System.Drawing.Point(3, 26);
            this.passwordTitleLabel.Name = "passwordTitleLabel";
            this.passwordTitleLabel.Size = new System.Drawing.Size(162, 26);
            this.passwordTitleLabel.TabIndex = 2;
            this.passwordTitleLabel.Text = "Enter a Password";
            this.passwordTitleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // usernameField
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.usernameField, 2);
            this.usernameField.Dock = System.Windows.Forms.DockStyle.Fill;
            this.usernameField.Location = new System.Drawing.Point(171, 3);
            this.usernameField.Name = "usernameField";
            this.usernameField.Size = new System.Drawing.Size(162, 20);
            this.usernameField.TabIndex = 3;
            this.usernameField.TextChanged += new System.EventHandler(this.usernameField_TextChanged);
            // 
            // passwordField
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.passwordField, 2);
            this.passwordField.Dock = System.Windows.Forms.DockStyle.Fill;
            this.passwordField.Location = new System.Drawing.Point(171, 29);
            this.passwordField.Name = "passwordField";
            this.passwordField.PasswordChar = '*';
            this.passwordField.Size = new System.Drawing.Size(162, 20);
            this.passwordField.TabIndex = 4;
            this.passwordField.TextChanged += new System.EventHandler(this.passwordField_TextChanged);
            // 
            // createUserButton
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.createUserButton, 2);
            this.createUserButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.createUserButton.Location = new System.Drawing.Point(87, 55);
            this.createUserButton.Name = "createUserButton";
            this.createUserButton.Size = new System.Drawing.Size(162, 20);
            this.createUserButton.TabIndex = 5;
            this.createUserButton.Text = "Create User";
            this.createUserButton.UseVisualStyleBackColor = true;
            this.createUserButton.Click += new System.EventHandler(this.createUserButton_Click);
            // 
            // createAUserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(336, 78);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "createAUserForm";
            this.Text = "Create a User";
            this.Load += new System.EventHandler(this.createAUserForm_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label usernameTitleLabel;
        private System.Windows.Forms.Label passwordTitleLabel;
        private System.Windows.Forms.TextBox usernameField;
        private System.Windows.Forms.TextBox passwordField;
        private System.Windows.Forms.Button createUserButton;
    }
}