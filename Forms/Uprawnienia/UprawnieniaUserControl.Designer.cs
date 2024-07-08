
namespace WinFormsApp90.Forms.Uprawnienia
{
    partial class UprawnieniaUserControl
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose (bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent ()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UprawnieniaUserControl));
            this.tabControl28 = new System.Windows.Forms.TabControl();
            this.tabPage63 = new System.Windows.Forms.TabPage();
            this.dataGridViewRoles = new System.Windows.Forms.DataGridView();
            this.Column27 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column28 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStrip15 = new System.Windows.Forms.ToolStrip();
            this.toolStripButtonDodajUprawnienie = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonUsunUprawnienie = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonModyfikujUprawnienie = new System.Windows.Forms.ToolStripButton();
            this.tabControl28.SuspendLayout();
            this.tabPage63.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRoles)).BeginInit();
            this.toolStrip15.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl28
            // 
            this.tabControl28.Controls.Add(this.tabPage63);
            this.tabControl28.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl28.Location = new System.Drawing.Point(20, 20);
            this.tabControl28.Name = "tabControl28";
            this.tabControl28.SelectedIndex = 0;
            this.tabControl28.Size = new System.Drawing.Size(1118, 608);
            this.tabControl28.TabIndex = 9;
            // 
            // tabPage63
            // 
            this.tabPage63.Controls.Add(this.dataGridViewRoles);
            this.tabPage63.Controls.Add(this.toolStrip15);
            this.tabPage63.Location = new System.Drawing.Point(4, 39);
            this.tabPage63.Name = "tabPage63";
            this.tabPage63.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage63.Size = new System.Drawing.Size(1110, 565);
            this.tabPage63.TabIndex = 0;
            this.tabPage63.Text = "Lista uprawnień";
            this.tabPage63.UseVisualStyleBackColor = true;
            // 
            // dataGridViewRoles
            // 
            this.dataGridViewRoles.AllowUserToAddRows = false;
            this.dataGridViewRoles.AllowUserToDeleteRows = false;
            this.dataGridViewRoles.AllowUserToResizeColumns = false;
            this.dataGridViewRoles.AllowUserToResizeRows = false;
            this.dataGridViewRoles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewRoles.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column27,
            this.Column28});
            this.dataGridViewRoles.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewRoles.Location = new System.Drawing.Point(3, 55);
            this.dataGridViewRoles.Name = "dataGridViewRoles";
            this.dataGridViewRoles.RowHeadersWidth = 72;
            this.dataGridViewRoles.RowTemplate.Height = 37;
            this.dataGridViewRoles.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewRoles.Size = new System.Drawing.Size(1104, 507);
            this.dataGridViewRoles.TabIndex = 12;
            // 
            // Column27
            // 
            this.Column27.DataPropertyName = "Id";
            this.Column27.HeaderText = "Id";
            this.Column27.MinimumWidth = 9;
            this.Column27.Name = "Column27";
            this.Column27.Visible = false;
            this.Column27.Width = 175;
            // 
            // Column28
            // 
            this.Column28.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Column28.DataPropertyName = "Lp";
            this.Column28.HeaderText = "Lp";
            this.Column28.MinimumWidth = 9;
            this.Column28.Name = "Column28";
            this.Column28.Width = 76;
            // 
            // toolStrip15
            // 
            this.toolStrip15.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip15.ImageScalingSize = new System.Drawing.Size(28, 28);
            this.toolStrip15.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonDodajUprawnienie,
            this.toolStripButtonUsunUprawnienie,
            this.toolStripButtonModyfikujUprawnienie});
            this.toolStrip15.Location = new System.Drawing.Point(3, 3);
            this.toolStrip15.Margin = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.toolStrip15.Name = "toolStrip15";
            this.toolStrip15.Padding = new System.Windows.Forms.Padding(0);
            this.toolStrip15.Size = new System.Drawing.Size(1104, 52);
            this.toolStrip15.TabIndex = 13;
            this.toolStrip15.Text = "toolStrip15";
            // 
            // toolStripButtonDodajUprawnienie
            // 
            this.toolStripButtonDodajUprawnienie.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonDodajUprawnienie.Image")));
            this.toolStripButtonDodajUprawnienie.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonDodajUprawnienie.Name = "toolStripButtonDodajUprawnienie";
            this.toolStripButtonDodajUprawnienie.Padding = new System.Windows.Forms.Padding(0, 6, 0, 6);
            this.toolStripButtonDodajUprawnienie.Size = new System.Drawing.Size(100, 46);
            this.toolStripButtonDodajUprawnienie.Text = "Dodaj";
            this.toolStripButtonDodajUprawnienie.Click += new System.EventHandler(this.toolStripButtonDodajUprawnienie_Click);
            // 
            // toolStripButtonUsunUprawnienie
            // 
            this.toolStripButtonUsunUprawnienie.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonUsunUprawnienie.Image")));
            this.toolStripButtonUsunUprawnienie.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonUsunUprawnienie.Name = "toolStripButtonUsunUprawnienie";
            this.toolStripButtonUsunUprawnienie.Size = new System.Drawing.Size(92, 46);
            this.toolStripButtonUsunUprawnienie.Text = "Usuń";
            this.toolStripButtonUsunUprawnienie.Click += new System.EventHandler(this.toolStripButtonUsunUprawnienie_Click);
            // 
            // toolStripButtonModyfikujUprawnienie
            // 
            this.toolStripButtonModyfikujUprawnienie.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonModyfikujUprawnienie.Image")));
            this.toolStripButtonModyfikujUprawnienie.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonModyfikujUprawnienie.Name = "toolStripButtonModyfikujUprawnienie";
            this.toolStripButtonModyfikujUprawnienie.Size = new System.Drawing.Size(137, 46);
            this.toolStripButtonModyfikujUprawnienie.Text = "Modyfikuj";
            // 
            // UprawnieniaUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tabControl28);
            this.Name = "UprawnieniaUserControl";
            this.Padding = new System.Windows.Forms.Padding(20);
            this.Size = new System.Drawing.Size(1158, 648);
            this.tabControl28.ResumeLayout(false);
            this.tabPage63.ResumeLayout(false);
            this.tabPage63.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRoles)).EndInit();
            this.toolStrip15.ResumeLayout(false);
            this.toolStrip15.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl28;
        private System.Windows.Forms.TabPage tabPage63;
        private System.Windows.Forms.DataGridView dataGridViewRoles;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column27;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column28;
        private System.Windows.Forms.ToolStrip toolStrip15;
        private System.Windows.Forms.ToolStripButton toolStripButtonDodajUprawnienie;
        private System.Windows.Forms.ToolStripButton toolStripButtonUsunUprawnienie;
        private System.Windows.Forms.ToolStripButton toolStripButtonModyfikujUprawnienie;
    }
}
