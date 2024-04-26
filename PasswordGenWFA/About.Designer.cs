using System.Windows.Forms;

namespace PasswordGenWFA
{
    partial class About : Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(About));
            menuStrip1 = new MenuStrip();
            toolToolStripMenuItem = new ToolStripMenuItem();
            aboutToolStripMenuItem = new ToolStripMenuItem();
            licenseBox = new RichTextBox();
            licenseTitle = new Label();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { toolToolStripMenuItem, aboutToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(648, 24);
            menuStrip1.TabIndex = 7;
            menuStrip1.Text = "menuStrip1";
            menuStrip1.ItemClicked += menuStrip1_ItemClicked;
            // 
            // toolToolStripMenuItem
            // 
            toolToolStripMenuItem.Name = "toolToolStripMenuItem";
            toolToolStripMenuItem.Size = new Size(41, 20);
            toolToolStripMenuItem.Text = "Tool";
            // 
            // aboutToolStripMenuItem
            // 
            aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            aboutToolStripMenuItem.Size = new Size(52, 20);
            aboutToolStripMenuItem.Text = "About";
            // 
            // licenseBox
            // 
            licenseBox.Location = new Point(131, 93);
            licenseBox.Name = "licenseBox";
            licenseBox.Size = new Size(415, 204);
            licenseBox.TabIndex = 8;
            licenseBox.Text = resources.GetString("licenseBox.Text");
            // 
            // licenseTitle
            // 
            licenseTitle.AutoSize = true;
            licenseTitle.Font = new Font("Segoe UI Black", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            licenseTitle.ForeColor = Color.White;
            licenseTitle.Location = new Point(288, 50);
            licenseTitle.Name = "licenseTitle";
            licenseTitle.Size = new Size(92, 28);
            licenseTitle.TabIndex = 9;
            licenseTitle.Text = "LICENSE";
            // 
            // About
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(8, 14, 44);
            ClientSize = new Size(648, 313);
            Controls.Add(licenseTitle);
            Controls.Add(licenseBox);
            Controls.Add(menuStrip1);
            Name = "About";
            Text = "About";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem toolToolStripMenuItem;
        private ToolStripMenuItem aboutToolStripMenuItem;
        private RichTextBox licenseBox;
        private Label licenseTitle;
    }
}