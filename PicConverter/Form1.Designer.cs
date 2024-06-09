namespace PicConverter
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
            title = new Panel();
            rightPanel = new Panel();
            label3 = new Label();
            leftPanel = new Panel();
            label2 = new Label();
            title.SuspendLayout();
            rightPanel.SuspendLayout();
            leftPanel.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = DockStyle.Top;
            label1.Font = new Font("Bizin Gothic", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 128);
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(218, 27);
            label1.TabIndex = 0;
            label1.Text = "iconかpngに変換";
            // 
            // title
            // 
            title.Controls.Add(label1);
            title.Dock = DockStyle.Top;
            title.Location = new Point(0, 0);
            title.Name = "title";
            title.Size = new Size(412, 36);
            title.TabIndex = 1;
            // 
            // rightPanel
            // 
            rightPanel.BorderStyle = BorderStyle.FixedSingle;
            rightPanel.Controls.Add(label3);
            rightPanel.Dock = DockStyle.Right;
            rightPanel.Location = new Point(212, 36);
            rightPanel.Name = "rightPanel";
            rightPanel.Size = new Size(200, 180);
            rightPanel.TabIndex = 2;
            rightPanel.DragDrop += rightPanel_DragDrop;
            rightPanel.DragEnter += rightPanel_DragEnter;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Bizin Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 128);
            label3.Location = new Point(16, 5);
            label3.Name = "label3";
            label3.Size = new Size(41, 13);
            label3.TabIndex = 1;
            label3.Text = "icoに";
            // 
            // leftPanel
            // 
            leftPanel.BorderStyle = BorderStyle.FixedSingle;
            leftPanel.Controls.Add(label2);
            leftPanel.Dock = DockStyle.Left;
            leftPanel.Location = new Point(0, 36);
            leftPanel.Name = "leftPanel";
            leftPanel.Size = new Size(198, 180);
            leftPanel.TabIndex = 3;
            leftPanel.DragDrop += leftPanel_DragDrop;
            leftPanel.DragEnter += leftPanel_DragEnter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Bizin Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 128);
            label2.Location = new Point(12, 3);
            label2.Name = "label2";
            label2.Size = new Size(41, 13);
            label2.TabIndex = 0;
            label2.Text = "pngに";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(6F, 11F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(412, 216);
            Controls.Add(leftPanel);
            Controls.Add(rightPanel);
            Controls.Add(title);
            MaximizeBox = false;
            MaximumSize = new Size(420, 247);
            MinimumSize = new Size(420, 247);
            Name = "Form1";
            ShowIcon = false;
            Text = "画像変換";
            TopMost = true;
            Load += Form1_Load;
            title.ResumeLayout(false);
            title.PerformLayout();
            rightPanel.ResumeLayout(false);
            rightPanel.PerformLayout();
            leftPanel.ResumeLayout(false);
            leftPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Panel title;
        private Panel rightPanel;
        private Label label3;
        private Panel leftPanel;
        private Label label2;
    }
}
