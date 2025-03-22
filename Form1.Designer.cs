namespace TaskViewer
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            processListView = new ListView();
            columnHeaderPID = new ColumnHeader();
            columnHeaderName = new ColumnHeader();
            refreshButton = new Button();
            killButton = new Button();
            checkBox1 = new CheckBox();
            SuspendLayout();
            // 
            // processListView
            // 
            processListView.Columns.AddRange(new ColumnHeader[] { columnHeaderPID, columnHeaderName });
            processListView.FullRowSelect = true;
            processListView.GridLines = true;
            processListView.Location = new Point(12, 12);
            processListView.Name = "processListView";
            processListView.Size = new Size(930, 399);
            processListView.TabIndex = 0;
            processListView.UseCompatibleStateImageBehavior = false;
            processListView.View = View.Details;
            // 
            // columnHeaderPID
            // 
            columnHeaderPID.Text = "PID";
            columnHeaderPID.Width = 120;
            // 
            // columnHeaderName
            // 
            columnHeaderName.Text = "Name";
            columnHeaderName.Width = 220;
            // 
            // refreshButton
            // 
            refreshButton.Location = new Point(582, 417);
            refreshButton.Name = "refreshButton";
            refreshButton.Size = new Size(160, 30);
            refreshButton.TabIndex = 1;
            refreshButton.Text = "Refresh";
            refreshButton.UseVisualStyleBackColor = true;
            refreshButton.Click += refreshButton_Click;
            // 
            // killButton
            // 
            killButton.Location = new Point(748, 417);
            killButton.Name = "killButton";
            killButton.Size = new Size(194, 30);
            killButton.TabIndex = 2;
            killButton.Text = "Kill Process";
            killButton.UseVisualStyleBackColor = true;
            killButton.Click += killButton_Click;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Checked = true;
            checkBox1.CheckState = CheckState.Checked;
            checkBox1.Location = new Point(30, 418);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(150, 19);
            checkBox1.TabIndex = 3;
            checkBox1.Text = "Show System Procesess";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // Form1
            // 
            ClientSize = new Size(954, 459);
            Controls.Add(checkBox1);
            Controls.Add(killButton);
            Controls.Add(refreshButton);
            Controls.Add(processListView);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            Text = "TaskView";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.ListView processListView;
        private System.Windows.Forms.ColumnHeader columnHeaderPID;
        private System.Windows.Forms.ColumnHeader columnHeaderName;
        private System.Windows.Forms.Button refreshButton;
        private System.Windows.Forms.Button killButton;
        private CheckBox checkBox1;
    }
}
