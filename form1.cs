using System;
using System.Diagnostics;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace TaskViewer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void refreshButton_Click(object sender, EventArgs e)
        {
            RefreshProcessList();
        }

        private void RefreshProcessList()
        {
            processListView.Items.Clear();

            Process[] processes = Process.GetProcesses();

            foreach (Process process in processes)
            {
                try
                {
                    if (!checkBox1.Checked && IsSystemProcess(process))
                    {
                        continue;
                    }

                    var item = new ListViewItem(process.Id.ToString());
                    item.SubItems.Add(process.ProcessName);
                    processListView.Items.Add(item);
                }
                catch (Exception)
                { 
                    continue;
                }
            }
        }
        private bool IsSystemProcess(Process process)
        {
            try
            {
                // Add conditions to identify system processes (e.g., "System", "svchost", etc.)
                return process.ProcessName.Equals("System", StringComparison.OrdinalIgnoreCase) ||
                       process.ProcessName.StartsWith("svchost", StringComparison.OrdinalIgnoreCase);
            }
            catch
            {
                return false;
            }
        }



        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            RefreshProcessList();
        }

        private void killButton_Click(object sender, EventArgs e)
        {
            if (processListView.SelectedItems.Count > 0)
            {
                var selectedItem = processListView.SelectedItems[0];
                int pid = int.Parse(selectedItem.Text); 

                try
                {

                    Process processToKill = Process.GetProcessById(pid);
                    processToKill.Kill();
                    MessageBox.Show("Process killed successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    RefreshProcessList();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Please select a process to kill.", "No Process Selected", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            RefreshProcessList();
        }
    }
}
