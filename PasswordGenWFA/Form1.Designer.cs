namespace PasswordGenWFA
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            Length = new Label();
            panel1 = new Panel();
            lengthField = new NumericUpDown();
            label1 = new Label();
            outputField = new Label();
            generate = new Button();
            panel2 = new Panel();
            menuStrip1 = new MenuStrip();
            toolToolStripMenuItem = new ToolStripMenuItem();
            aboutToolStripMenuItem = new ToolStripMenuItem();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)lengthField).BeginInit();
            panel2.SuspendLayout();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // Length
            // 
            Length.Anchor = AnchorStyles.Top;
            Length.AutoSize = true;
            Length.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Length.Location = new Point(34, 23);
            Length.Name = "Length";
            Length.Size = new Size(58, 20);
            Length.TabIndex = 0;
            Length.Text = "Length";
            Length.Click += Length_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(232, 236, 241);
            panel1.Controls.Add(lengthField);
            panel1.Controls.Add(Length);
            panel1.Location = new Point(240, 118);
            panel1.Name = "panel1";
            panel1.Size = new Size(176, 67);
            panel1.TabIndex = 2;
            // 
            // lengthField
            // 
            lengthField.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lengthField.Location = new Point(98, 21);
            lengthField.Name = "lengthField";
            lengthField.Size = new Size(43, 25);
            lengthField.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Black", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(232, 236, 241);
            label1.Location = new Point(173, 49);
            label1.Name = "label1";
            label1.Size = new Size(316, 30);
            label1.TabIndex = 3;
            label1.Text = "BASIC PASSWORD GEN TOOL";
            // 
            // outputField
            // 
            outputField.AutoSize = true;
            outputField.BackColor = Color.White;
            outputField.Cursor = Cursors.IBeam;
            outputField.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            outputField.ForeColor = Color.FromArgb(8, 14, 44);
            outputField.Location = new Point(3, 6);
            outputField.Name = "outputField";
            outputField.RightToLeft = RightToLeft.No;
            outputField.Size = new Size(0, 21);
            outputField.TabIndex = 4;
            outputField.Click += outputField_Click;
            // 
            // generate
            // 
            generate.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            generate.Location = new Point(290, 200);
            generate.Name = "generate";
            generate.Size = new Size(75, 33);
            generate.TabIndex = 1;
            generate.Text = "Generate";
            generate.UseVisualStyleBackColor = true;
            generate.Click += generate_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(outputField);
            panel2.Cursor = Cursors.IBeam;
            panel2.Location = new Point(240, 250);
            panel2.Name = "panel2";
            panel2.Size = new Size(176, 34);
            panel2.TabIndex = 5;
            panel2.Paint += panel2_Paint;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { toolToolStripMenuItem, aboutToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(648, 24);
            menuStrip1.TabIndex = 6;
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
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(8, 14, 44);
            ClientSize = new Size(648, 313);
            Controls.Add(generate);
            Controls.Add(label1);
            Controls.Add(panel1);
            Controls.Add(panel2);
            Controls.Add(menuStrip1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Basic Password Gen";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)lengthField).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label Length;
        private Panel panel1;
        private Label label1;
        private NumericUpDown lengthField;
        private Label outputField;
        private Button generate;
        private Panel panel2;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem toolToolStripMenuItem;
        private ToolStripMenuItem aboutToolStripMenuItem;
    }
}
