
namespace WinFormsApp90.Forms.Hostingi
{
    partial class HostingUserControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HostingUserControl));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dataGridViewHostingi = new System.Windows.Forms.DataGridView();
            this.Column19 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column20 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStrip9 = new System.Windows.Forms.ToolStrip();
            this.toolStripButtonDodajHosting = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonUsunHosting = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonModyfikujHosting = new System.Windows.Forms.ToolStripButton();
            this.toolStripComboBoxFirmyHosting = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripLabel7 = new System.Windows.Forms.ToolStripLabel();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewHostingi)).BeginInit();
            this.toolStrip9.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(20, 20);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1270, 644);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dataGridViewHostingi);
            this.tabPage1.Controls.Add(this.toolStrip9);
            this.tabPage1.Location = new System.Drawing.Point(4, 39);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1262, 601);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Lista hostingów";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dataGridViewHostingi
            // 
            this.dataGridViewHostingi.AllowUserToAddRows = false;
            this.dataGridViewHostingi.AllowUserToDeleteRows = false;
            this.dataGridViewHostingi.AllowUserToResizeColumns = false;
            this.dataGridViewHostingi.AllowUserToResizeRows = false;
            this.dataGridViewHostingi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewHostingi.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column19,
            this.Column20,
            this.Column1});
            this.dataGridViewHostingi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewHostingi.Location = new System.Drawing.Point(3, 55);
            this.dataGridViewHostingi.Name = "dataGridViewHostingi";
            this.dataGridViewHostingi.RowHeadersWidth = 72;
            this.dataGridViewHostingi.RowTemplate.Height = 37;
            this.dataGridViewHostingi.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewHostingi.Size = new System.Drawing.Size(1256, 543);
            this.dataGridViewHostingi.TabIndex = 16;
            this.dataGridViewHostingi.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridViewHostingi_CellMouseClick);
            this.dataGridViewHostingi.SelectionChanged += new System.EventHandler(this.dataGridViewHostingi_SelectionChanged);
            // 
            // Column19
            // 
            this.Column19.DataPropertyName = "HostingId";
            this.Column19.HeaderText = "HostingId";
            this.Column19.MinimumWidth = 9;
            this.Column19.Name = "Column19";
            this.Column19.Visible = false;
            this.Column19.Width = 175;
            // 
            // Column20
            // 
            this.Column20.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Column20.DataPropertyName = "Lp";
            this.Column20.HeaderText = "Lp";
            this.Column20.MinimumWidth = 9;
            this.Column20.Name = "Column20";
            this.Column20.Width = 76;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "Information";
            this.Column1.HeaderText = "Informacje";
            this.Column1.MinimumWidth = 9;
            this.Column1.Name = "Column1";
            this.Column1.Width = 175;
            // 
            // toolStrip9
            // 
            this.toolStrip9.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip9.ImageScalingSize = new System.Drawing.Size(28, 28);
            this.toolStrip9.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonDodajHosting,
            this.toolStripButtonUsunHosting,
            this.toolStripButtonModyfikujHosting,
            this.toolStripComboBoxFirmyHosting,
            this.toolStripLabel7});
            this.toolStrip9.Location = new System.Drawing.Point(3, 3);
            this.toolStrip9.Margin = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.toolStrip9.Name = "toolStrip9";
            this.toolStrip9.Padding = new System.Windows.Forms.Padding(0);
            this.toolStrip9.Size = new System.Drawing.Size(1256, 52);
            this.toolStrip9.TabIndex = 17;
            this.toolStrip9.Text = "toolStrip9";
            // 
            // toolStripButtonDodajHosting
            // 
            this.toolStripButtonDodajHosting.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonDodajHosting.Image")));
            this.toolStripButtonDodajHosting.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonDodajHosting.Name = "toolStripButtonDodajHosting";
            this.toolStripButtonDodajHosting.Padding = new System.Windows.Forms.Padding(0, 6, 0, 6);
            this.toolStripButtonDodajHosting.Size = new System.Drawing.Size(100, 46);
            this.toolStripButtonDodajHosting.Text = "Dodaj";
            this.toolStripButtonDodajHosting.Click += new System.EventHandler(this.toolStripButtonDodajHosting_Click);
            // 
            // toolStripButtonUsunHosting
            // 
            this.toolStripButtonUsunHosting.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonUsunHosting.Image")));
            this.toolStripButtonUsunHosting.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonUsunHosting.Name = "toolStripButtonUsunHosting";
            this.toolStripButtonUsunHosting.Size = new System.Drawing.Size(92, 46);
            this.toolStripButtonUsunHosting.Text = "Usuń";
            this.toolStripButtonUsunHosting.Click += new System.EventHandler(this.toolStripButtonUsunHosting_Click);
            // 
            // toolStripButtonModyfikujHosting
            // 
            this.toolStripButtonModyfikujHosting.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonModyfikujHosting.Image")));
            this.toolStripButtonModyfikujHosting.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonModyfikujHosting.Name = "toolStripButtonModyfikujHosting";
            this.toolStripButtonModyfikujHosting.Size = new System.Drawing.Size(137, 46);
            this.toolStripButtonModyfikujHosting.Text = "Modyfikuj";
            this.toolStripButtonModyfikujHosting.Click += new System.EventHandler(this.toolStripButtonModyfikujHosting_Click);
            // 
            // toolStripComboBoxFirmyHosting
            // 
            this.toolStripComboBoxFirmyHosting.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripComboBoxFirmyHosting.FlatStyle = System.Windows.Forms.FlatStyle.Standard;
            this.toolStripComboBoxFirmyHosting.Name = "toolStripComboBoxFirmyHosting";
            this.toolStripComboBoxFirmyHosting.Size = new System.Drawing.Size(300, 52);
            this.toolStripComboBoxFirmyHosting.SelectedIndexChanged += new System.EventHandler(this.toolStripComboBoxFirmyHosting_SelectedIndexChanged);
            // 
            // toolStripLabel7
            // 
            this.toolStripLabel7.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripLabel7.Name = "toolStripLabel7";
            this.toolStripLabel7.Size = new System.Drawing.Size(64, 46);
            this.toolStripLabel7.Text = "Firma";
            // 
            // HostingUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tabControl1);
            this.Name = "HostingUserControl";
            this.Padding = new System.Windows.Forms.Padding(20);
            this.Size = new System.Drawing.Size(1310, 684);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewHostingi)).EndInit();
            this.toolStrip9.ResumeLayout(false);
            this.toolStrip9.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView dataGridViewHostingi;
        private System.Windows.Forms.ToolStrip toolStrip9;
        private System.Windows.Forms.ToolStripButton toolStripButtonDodajHosting;
        private System.Windows.Forms.ToolStripButton toolStripButtonUsunHosting;
        private System.Windows.Forms.ToolStripButton toolStripButtonModyfikujHosting;
        private System.Windows.Forms.ToolStripComboBox toolStripComboBoxFirmyHosting;
        private System.Windows.Forms.ToolStripLabel toolStripLabel7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column19;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column20;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
    }
}
