namespace MultiToolProgram
{
    partial class randomPasswordGeneratorForm
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
            this.amountOfPasswordsTitle = new System.Windows.Forms.Label();
            this.numberOfPasswordsUD = new System.Windows.Forms.NumericUpDown();
            this.savePasswordsButton = new System.Windows.Forms.Button();
            this.outputLabel = new System.Windows.Forms.Label();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numberOfPasswordsUD)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Controls.Add(this.amountOfPasswordsTitle, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.numberOfPasswordsUD, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.savePasswordsButton, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.outputLabel, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.progressBar, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.menuStrip1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15.78947F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 21.05263F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15.78947F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15.78947F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15.78947F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15.78947F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(397, 170);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // amountOfPasswordsTitle
            // 
            this.amountOfPasswordsTitle.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.amountOfPasswordsTitle, 3);
            this.amountOfPasswordsTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.amountOfPasswordsTitle.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.amountOfPasswordsTitle.Location = new System.Drawing.Point(3, 26);
            this.amountOfPasswordsTitle.Name = "amountOfPasswordsTitle";
            this.amountOfPasswordsTitle.Size = new System.Drawing.Size(391, 35);
            this.amountOfPasswordsTitle.TabIndex = 0;
            this.amountOfPasswordsTitle.Text = "Enter the amount of passwords you want";
            this.amountOfPasswordsTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // numberOfPasswordsUD
            // 
            this.numberOfPasswordsUD.Dock = System.Windows.Forms.DockStyle.Fill;
            this.numberOfPasswordsUD.Location = new System.Drawing.Point(102, 64);
            this.numberOfPasswordsUD.Name = "numberOfPasswordsUD";
            this.numberOfPasswordsUD.Size = new System.Drawing.Size(192, 20);
            this.numberOfPasswordsUD.TabIndex = 1;
            this.numberOfPasswordsUD.ValueChanged += new System.EventHandler(this.numberOfPasswordsUD_ValueChanged);
            // 
            // savePasswordsButton
            // 
            this.savePasswordsButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.savePasswordsButton.Location = new System.Drawing.Point(102, 90);
            this.savePasswordsButton.Name = "savePasswordsButton";
            this.savePasswordsButton.Size = new System.Drawing.Size(192, 20);
            this.savePasswordsButton.TabIndex = 2;
            this.savePasswordsButton.Text = "Save Passwords";
            this.savePasswordsButton.UseVisualStyleBackColor = true;
            this.savePasswordsButton.Click += new System.EventHandler(this.savePasswordsButton_Click);
            // 
            // outputLabel
            // 
            this.outputLabel.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.outputLabel, 3);
            this.outputLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.outputLabel.Location = new System.Drawing.Point(3, 113);
            this.outputLabel.Name = "outputLabel";
            this.outputLabel.Size = new System.Drawing.Size(391, 26);
            this.outputLabel.TabIndex = 3;
            this.outputLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // progressBar
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.progressBar, 3);
            this.progressBar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.progressBar.Location = new System.Drawing.Point(3, 142);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(391, 25);
            this.progressBar.TabIndex = 4;
            // 
            // menuStrip1
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.menuStrip1, 3);
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.optionsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(397, 26);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 22);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(92, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(61, 22);
            this.optionsToolStripMenuItem.Text = "Options";
            this.optionsToolStripMenuItem.Click += new System.EventHandler(this.optionsToolStripMenuItem_Click);
            // 
            // randomPasswordGeneratorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(397, 170);
            this.Controls.Add(this.tableLayoutPanel1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "randomPasswordGeneratorForm";
            this.Text = "Random Password Generator";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numberOfPasswordsUD)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label amountOfPasswordsTitle;
        private System.Windows.Forms.NumericUpDown numberOfPasswordsUD;
        private System.Windows.Forms.Button savePasswordsButton;
        private System.Windows.Forms.Label outputLabel;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
    }
}