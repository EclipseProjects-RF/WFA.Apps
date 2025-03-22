namespace SysMonitor
{
    partial class Form1
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
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            label1 = new Label();
            progressBar1 = new ProgressBar();
            lblCpuUsage = new Label();
            label2 = new Label();
            lblRamUsage = new Label();
            progressBar2 = new ProgressBar();
            label3 = new Label();
            progressBar3 = new ProgressBar();
            lblDiskUsage = new Label();
            checkBox1 = new CheckBox();
            label4 = new Label();
            trackBar1 = new TrackBar();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            numericUpDown1 = new NumericUpDown();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            ((System.ComponentModel.ISupportInitialize)trackBar1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(1, 9);
            label1.Name = "label1";
            label1.Size = new Size(90, 40);
            label1.TabIndex = 0;
            label1.Text = "CPU :";
            // 
            // progressBar1
            // 
            progressBar1.Location = new Point(12, 52);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(194, 23);
            progressBar1.TabIndex = 1;
            // 
            // lblCpuUsage
            // 
            lblCpuUsage.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblCpuUsage.Location = new Point(212, 46);
            lblCpuUsage.Name = "lblCpuUsage";
            lblCpuUsage.Size = new Size(114, 29);
            lblCpuUsage.TabIndex = 2;
            lblCpuUsage.Text = "%";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 21F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(3, 78);
            label2.Name = "label2";
            label2.Size = new Size(98, 38);
            label2.TabIndex = 3;
            label2.Text = "RAM :";
            // 
            // lblRamUsage
            // 
            lblRamUsage.Font = new Font("Segoe UI Semibold", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblRamUsage.Location = new Point(212, 113);
            lblRamUsage.Name = "lblRamUsage";
            lblRamUsage.Size = new Size(100, 29);
            lblRamUsage.TabIndex = 4;
            lblRamUsage.Text = "%";
            // 
            // progressBar2
            // 
            progressBar2.Location = new Point(12, 119);
            progressBar2.Name = "progressBar2";
            progressBar2.Size = new Size(194, 23);
            progressBar2.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 21F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(3, 145);
            label3.Name = "label3";
            label3.Size = new Size(88, 38);
            label3.TabIndex = 6;
            label3.Text = "DSK :";
            // 
            // progressBar3
            // 
            progressBar3.Location = new Point(12, 186);
            progressBar3.Name = "progressBar3";
            progressBar3.Size = new Size(194, 23);
            progressBar3.TabIndex = 7;
            // 
            // lblDiskUsage
            // 
            lblDiskUsage.Font = new Font("Segoe UI Semibold", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDiskUsage.Location = new Point(212, 180);
            lblDiskUsage.Name = "lblDiskUsage";
            lblDiskUsage.Size = new Size(100, 29);
            lblDiskUsage.TabIndex = 8;
            lblDiskUsage.Text = "%";
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(12, 277);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(89, 19);
            checkBox1.TabIndex = 9;
            checkBox1.Text = "Stay On Top";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // label4
            // 
            label4.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(3, 232);
            label4.Name = "label4";
            label4.Size = new Size(170, 42);
            label4.TabIndex = 10;
            label4.Text = "SETTINGS :";
            label4.Click += label4_Click;
            // 
            // trackBar1
            // 
            trackBar1.Location = new Point(12, 322);
            trackBar1.Maximum = 100;
            trackBar1.Minimum = 50;
            trackBar1.Name = "trackBar1";
            trackBar1.Size = new Size(314, 45);
            trackBar1.TabIndex = 11;
            trackBar1.Value = 100;
            trackBar1.Scroll += trackBar1_Scroll;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 299);
            label5.Name = "label5";
            label5.Size = new Size(54, 15);
            label5.TabIndex = 12;
            label5.Text = "Opacity :";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(85, 164);
            label6.Name = "label6";
            label6.Size = new Size(54, 15);
            label6.TabIndex = 14;
            label6.Text = "(storage)";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(12, 361);
            label7.Name = "label7";
            label7.Size = new Size(242, 15);
            label7.TabIndex = 15;
            label7.Text = "Timer to update the measures (1sec = 1000) :";
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(257, 360);
            numericUpDown1.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            numericUpDown1.Minimum = new decimal(new int[] { 100, 0, 0, 0 });
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(58, 23);
            numericUpDown1.TabIndex = 16;
            numericUpDown1.Tag = "";
            numericUpDown1.Value = new decimal(new int[] { 1000, 0, 0, 0 });
            numericUpDown1.ValueChanged += numericUpDown1_ValueChanged;
            // 
            // button2
            // 
            button2.Location = new Point(141, 238);
            button2.Name = "button2";
            button2.Size = new Size(75, 30);
            button2.TabIndex = 17;
            button2.Text = "Open";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.AccessibleDescription = "Shows info";
            button3.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button3.Location = new Point(295, 9);
            button3.Name = "button3";
            button3.Size = new Size(23, 23);
            button3.TabIndex = 18;
            button3.Text = "ℹ";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(295, 52);
            button4.Name = "button4";
            button4.Size = new Size(23, 87);
            button4.TabIndex = 19;
            button4.Text = "TASKS";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(330, 272);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(numericUpDown1);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(trackBar1);
            Controls.Add(label4);
            Controls.Add(checkBox1);
            Controls.Add(lblDiskUsage);
            Controls.Add(progressBar3);
            Controls.Add(label3);
            Controls.Add(progressBar2);
            Controls.Add(lblRamUsage);
            Controls.Add(label2);
            Controls.Add(lblCpuUsage);
            Controls.Add(progressBar1);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "System Monitor";
            TransparencyKey = Color.FromArgb(224, 224, 224);
            ((System.ComponentModel.ISupportInitialize)trackBar1).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ProgressBar progressBar1;
        private Label lblCpuUsage;
        private Label label2;
        private Label lblRamUsage;
        private ProgressBar progressBar2;
        private Label label3;
        private ProgressBar progressBar3;
        private Label lblDiskUsage;
        private CheckBox checkBox1;
        private Label label4;
        private TrackBar trackBar1;
        private Label label5;
        private Label label6;
        private Label label7;
        private NumericUpDown numericUpDown1;
        private Button button2;
        private Button button3;
        private Button button4;
    }
}
