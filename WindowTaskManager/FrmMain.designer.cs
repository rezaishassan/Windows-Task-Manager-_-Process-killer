namespace WindowTaskManager
{
    partial class FrmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.BtnCloseApps = new System.Windows.Forms.Button();
            this.DtGv1 = new System.Windows.Forms.DataGridView();
            this.BtnRefresh = new System.Windows.Forms.Button();
            this.ClmnSelect = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.ClmnName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClmnNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClmnUserName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DtGv1)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnCloseApps
            // 
            this.BtnCloseApps.Location = new System.Drawing.Point(172, 12);
            this.BtnCloseApps.Name = "BtnCloseApps";
            this.BtnCloseApps.Size = new System.Drawing.Size(142, 35);
            this.BtnCloseApps.TabIndex = 0;
            this.BtnCloseApps.Text = "Close selected apps";
            this.BtnCloseApps.UseVisualStyleBackColor = true;
            this.BtnCloseApps.Click += new System.EventHandler(this.BtnCloseApps_Click);
            // 
            // DtGv1
            // 
            this.DtGv1.AllowUserToAddRows = false;
            this.DtGv1.AllowUserToDeleteRows = false;
            this.DtGv1.AllowUserToResizeRows = false;
            this.DtGv1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DtGv1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.DtGv1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DtGv1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ClmnSelect,
            this.ClmnName,
            this.ClmnNumber,
            this.ClmnUserName});
            this.DtGv1.Location = new System.Drawing.Point(5, 66);
            this.DtGv1.MultiSelect = false;
            this.DtGv1.Name = "DtGv1";
            this.DtGv1.RowHeadersVisible = false;
            this.DtGv1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DtGv1.Size = new System.Drawing.Size(445, 252);
            this.DtGv1.TabIndex = 1;
            // 
            // BtnRefresh
            // 
            this.BtnRefresh.Location = new System.Drawing.Point(12, 12);
            this.BtnRefresh.Name = "BtnRefresh";
            this.BtnRefresh.Size = new System.Drawing.Size(142, 35);
            this.BtnRefresh.TabIndex = 2;
            this.BtnRefresh.Text = "Refresh";
            this.BtnRefresh.UseVisualStyleBackColor = true;
            this.BtnRefresh.Click += new System.EventHandler(this.BtnRefresh_Click);
            // 
            // ClmnSelect
            // 
            this.ClmnSelect.HeaderText = "Select";
            this.ClmnSelect.Name = "ClmnSelect";
            this.ClmnSelect.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.ClmnSelect.Width = 62;
            // 
            // ClmnName
            // 
            this.ClmnName.HeaderText = "App. Name";
            this.ClmnName.Name = "ClmnName";
            this.ClmnName.ReadOnly = true;
            this.ClmnName.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ClmnName.Width = 85;
            // 
            // ClmnNumber
            // 
            this.ClmnNumber.HeaderText = "Number of existance";
            this.ClmnNumber.Name = "ClmnNumber";
            this.ClmnNumber.ReadOnly = true;
            this.ClmnNumber.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ClmnNumber.Width = 118;
            // 
            // ClmnUserName
            // 
            this.ClmnUserName.HeaderText = "User Name";
            this.ClmnUserName.Name = "ClmnUserName";
            this.ClmnUserName.ReadOnly = true;
            this.ClmnUserName.Visible = false;
            this.ClmnUserName.Width = 78;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(462, 324);
            this.Controls.Add(this.BtnRefresh);
            this.Controls.Add(this.DtGv1);
            this.Controls.Add(this.BtnCloseApps);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(478, 362);
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Windows process killer";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DtGv1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnCloseApps;
        private System.Windows.Forms.DataGridView DtGv1;
        private System.Windows.Forms.Button BtnRefresh;
        private System.Windows.Forms.DataGridViewCheckBoxColumn ClmnSelect;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClmnName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClmnNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClmnUserName;
    }
}

