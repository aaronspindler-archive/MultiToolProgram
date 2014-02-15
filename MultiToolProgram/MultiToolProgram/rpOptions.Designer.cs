namespace MultiToolProgram
{
    partial class rpOptions
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
            this.normalPassCheckbox = new System.Windows.Forms.CheckBox();
            this.numberPassCheckbox = new System.Windows.Forms.CheckBox();
            this.specialCharCheckBox = new System.Windows.Forms.CheckBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.normalPassCheckbox, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.numberPassCheckbox, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.specialCharCheckBox, 0, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(409, 159);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // normalPassCheckbox
            // 
            this.normalPassCheckbox.AutoSize = true;
            this.normalPassCheckbox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.normalPassCheckbox.Location = new System.Drawing.Point(3, 3);
            this.normalPassCheckbox.Name = "normalPassCheckbox";
            this.normalPassCheckbox.Size = new System.Drawing.Size(403, 47);
            this.normalPassCheckbox.TabIndex = 1;
            this.normalPassCheckbox.Text = "Upper Case and Lower Case - Least Secure";
            this.normalPassCheckbox.UseVisualStyleBackColor = true;
            this.normalPassCheckbox.CheckedChanged += new System.EventHandler(this.normalPassCheckbox_CheckedChanged);
            // 
            // numberPassCheckbox
            // 
            this.numberPassCheckbox.AutoSize = true;
            this.numberPassCheckbox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.numberPassCheckbox.Location = new System.Drawing.Point(3, 56);
            this.numberPassCheckbox.Name = "numberPassCheckbox";
            this.numberPassCheckbox.Size = new System.Drawing.Size(403, 47);
            this.numberPassCheckbox.TabIndex = 3;
            this.numberPassCheckbox.Text = "Upper Case, Lower Case, and Numbers - Secure";
            this.numberPassCheckbox.UseVisualStyleBackColor = true;
            this.numberPassCheckbox.CheckedChanged += new System.EventHandler(this.numberPassCheckbox_CheckedChanged);
            // 
            // specialCharCheckBox
            // 
            this.specialCharCheckBox.AutoSize = true;
            this.specialCharCheckBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.specialCharCheckBox.Location = new System.Drawing.Point(3, 109);
            this.specialCharCheckBox.Name = "specialCharCheckBox";
            this.specialCharCheckBox.Size = new System.Drawing.Size(403, 47);
            this.specialCharCheckBox.TabIndex = 5;
            this.specialCharCheckBox.Text = "Upper Case, Lower Case, Numbers, and Special Characters - Most Secure";
            this.specialCharCheckBox.UseVisualStyleBackColor = true;
            this.specialCharCheckBox.CheckedChanged += new System.EventHandler(this.specialCharCheckBox_CheckedChanged);
            // 
            // rpOptions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(409, 159);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "rpOptions";
            this.Text = "Random-Password Options";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.rpOptions_FormClosing);
            this.Load += new System.EventHandler(this.rpOptions_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.CheckBox normalPassCheckbox;
        private System.Windows.Forms.CheckBox numberPassCheckbox;
        private System.Windows.Forms.CheckBox specialCharCheckBox;
    }
}