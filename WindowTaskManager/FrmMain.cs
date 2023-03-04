using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace WindowTaskManager
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        public void KillMyApp(string AppName)
        {
                var localByName = System.Diagnostics.Process.GetProcessesByName(AppName);
                foreach (System.Diagnostics.Process p in localByName)
                {
                    p.Kill();
                    p.WaitForExit(10000);
                }
        }
        // fill datagridview
        public void fill_datagridview()
        {
            DtGv1.Rows.Clear();
            var processes = System.Diagnostics.Process.GetProcesses();
            foreach (System.Diagnostics.Process p in processes)
            {
                bool selected = false;
                foreach (DataGridViewRow Dr in DtGv1.Rows)
                {
                    if (Dr.Cells["ClmnName"].Value == null)
                    {
                        continue;
                    }
                    if (Dr.Cells["ClmnName"].Value.ToString() == p.ProcessName)
                    {
                        int occ = Convert.ToInt16(Dr.Cells["ClmnNumber"].Value);
                        Dr.Cells["ClmnNumber"].Value = occ + 1;
                        selected = true;
                        break;
                    }
                }
                if (!selected)
                {
                    DtGv1.Rows.Add(false, p.ProcessName, 1,null);
                }
            }
            DtGv1.Refresh();
        }
        private void BtnCloseApps_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult res = MessageBox.Show("Do you want to close all selected applications?", "Warning", MessageBoxButtons.YesNoCancel);
                if (res == DialogResult.Yes)
                {
                    foreach (DataGridViewRow Dr in DtGv1.Rows)
                    {
                        if (Convert.ToBoolean(Dr.Cells["ClmnSelect"].Value) == true)
                        {
                            KillMyApp(Dr.Cells["ClmnName"].Value.ToString());
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            fill_datagridview();
        }

        private void BtnRefresh_Click(object sender, EventArgs e)
        {
            fill_datagridview();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            fill_datagridview();
        }
    }
}
