namespace Exam_SysProcesses_WinForms_Threads_Karvatyuk
{
    partial class SysProForm
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
            numUDSeconds = new NumericUpDown();
            btnStart = new Button();
            label1 = new Label();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)numUDSeconds).BeginInit();
            SuspendLayout();
            // 
            // numUDSeconds
            // 
            numUDSeconds.Location = new Point(810, 586);
            numUDSeconds.Maximum = new decimal(new int[] { 20, 0, 0, 0 });
            numUDSeconds.Name = "numUDSeconds";
            numUDSeconds.Size = new Size(101, 29);
            numUDSeconds.TabIndex = 0;
            numUDSeconds.TextAlign = HorizontalAlignment.Right;
            numUDSeconds.ValueChanged += numUDSeconds_ValueChanged;
            // 
            // btnStart
            // 
            btnStart.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnStart.Location = new Point(917, 579);
            btnStart.Name = "btnStart";
            btnStart.Size = new Size(100, 39);
            btnStart.TabIndex = 1;
            btnStart.Text = "Start";
            btnStart.UseVisualStyleBackColor = true;
            btnStart.Click += btnStart_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(725, 588);
            label1.Name = "label1";
            label1.Size = new Size(79, 21);
            label1.TabIndex = 2;
            label1.Text = "Max secs: ";
            // 
            // label2
            // 
            label2.Dock = DockStyle.Fill;
            label2.Enabled = false;
            label2.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(0, 0);
            label2.Name = "label2";
            label2.Size = new Size(1029, 630);
            label2.TabIndex = 3;
            label2.Text = "Set the time and click on the window to add progress bars. Then press the start button.";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // SysProForm
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1029, 630);
            Controls.Add(label1);
            Controls.Add(btnStart);
            Controls.Add(numUDSeconds);
            Controls.Add(label2);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4);
            Name = "SysProForm";
            Text = "SysPro";
            MouseClick += SysProForm_MouseClick;
            ((System.ComponentModel.ISupportInitialize)numUDSeconds).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private NumericUpDown numUDSeconds;
        private Button btnStart;
        private Label label1;
        private Label label2;
    }
}