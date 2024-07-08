
namespace WinFormsApp90.Forms.HaslaInfo
{
    partial class HasloInfoUserControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HasloInfoUserControl));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dataGridViewHasla = new System.Windows.Forms.DataGridView();
            this.Column23 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column24 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStrip7 = new System.Windows.Forms.ToolStrip();
            this.toolStripButtonDodajHasloInfo = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonUsunHasloInfo = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonModyfikujHasloInfo = new System.Windows.Forms.ToolStripButton();
            this.toolStripComboBoxFirmyHasla = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripLabel3 = new System.Windows.Forms.ToolStripLabel();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewHasla)).BeginInit();
            this.toolStrip7.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(20, 20);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1241, 659);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dataGridViewHasla);
            this.tabPage1.Controls.Add(this.toolStrip7);
            this.tabPage1.Location = new System.Drawing.Point(4, 39);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1233, 616);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Lista haseł";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dataGridViewHasla
            // 
            this.dataGridViewHasla.AllowUserToAddRows = false;
            this.dataGridViewHasla.AllowUserToDeleteRows = false;
            this.dataGridViewHasla.AllowUserToResizeColumns = false;
            this.dataGridViewHasla.AllowUserToResizeRows = false;
            this.dataGridViewHasla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewHasla.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column23,
            this.Column24,
            this.Column1,
            this.Column2,
            this.Column3});
            this.dataGridViewHasla.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewHasla.Location = new System.Drawing.Point(3, 55);
            this.dataGridViewHasla.Name = "dataGridViewHasla";
            this.dataGridViewHasla.RowHeadersWidth = 72;
            this.dataGridViewHasla.RowTemplate.Height = 37;
            this.dataGridViewHasla.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewHasla.Size = new System.Drawing.Size(1227, 558);
            this.dataGridViewHasla.TabIndex = 16;
            this.dataGridViewHasla.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridViewHasla_CellMouseClick_1);
            this.dataGridViewHasla.SelectionChanged += new System.EventHandler(this.dataGridViewHasla_SelectionChanged_1);
            // 
            // Column23
            // 
            this.Column23.DataPropertyName = "HasloInfoId";
            this.Column23.HeaderText = "HasloInfoId";
            this.Column23.MinimumWidth = 9;
            this.Column23.Name = "Column23";
            this.Column23.Visible = false;
            this.Column23.Width = 175;
            // 
            // Column24
            // 
            this.Column24.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Column24.DataPropertyName = "Lp";
            this.Column24.HeaderText = "Lp";
            this.Column24.MinimumWidth = 9;
            this.Column24.Name = "Column24";
            this.Column24.Width = 76;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "Login";
            this.Column1.HeaderText = "Login";
            this.Column1.MinimumWidth = 9;
            this.Column1.Name = "Column1";
            this.Column1.Width = 175;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "Haslo";
            this.Column2.HeaderText = "Hasło";
            this.Column2.MinimumWidth = 9;
            this.Column2.Name = "Column2";
            this.Column2.Width = 175;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "Sprzet";
            this.Column3.HeaderText = "Sprzęt";
            this.Column3.MinimumWidth = 9;
            this.Column3.Name = "Column3";
            this.Column3.Width = 175;
            // 
            // toolStrip7
            // 
            this.toolStrip7.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip7.ImageScalingSize = new System.Drawing.Size(28, 28);
            this.toolStrip7.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonDodajHasloInfo,
            this.toolStripButtonUsunHasloInfo,
            this.toolStripButtonModyfikujHasloInfo,
            this.toolStripComboBoxFirmyHasla,
            this.toolStripLabel3});
            this.toolStrip7.Location = new System.Drawing.Point(3, 3);
            this.toolStrip7.Margin = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.toolStrip7.Name = "toolStrip7";
            this.toolStrip7.Padding = new System.Windows.Forms.Padding(0);
            this.toolStrip7.Size = new System.Drawing.Size(1227, 52);
            this.toolStrip7.TabIndex = 17;
            this.toolStrip7.Text = "toolStrip7";
            // 
            // toolStripButtonDodajHasloInfo
            // 
            this.toolStripButtonDodajHasloInfo.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonDodajHasloInfo.Image")));
            this.toolStripButtonDodajHasloInfo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonDodajHasloInfo.Name = "toolStripButtonDodajHasloInfo";
            this.toolStripButtonDodajHasloInfo.Padding = new System.Windows.Forms.Padding(0, 6, 0, 6);
            this.toolStripButtonDodajHasloInfo.Size = new System.Drawing.Size(100, 46);
            this.toolStripButtonDodajHasloInfo.Text = "Dodaj";
            this.toolStripButtonDodajHasloInfo.Click += new System.EventHandler(this.toolStripButtonDodajHasloInfo_Click);
            // 
            // toolStripButtonUsunHasloInfo
            // 
            this.toolStripButtonUsunHasloInfo.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonUsunHasloInfo.Image")));
            this.toolStripButtonUsunHasloInfo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonUsunHasloInfo.Name = "toolStripButtonUsunHasloInfo";
            this.toolStripButtonUsunHasloInfo.Size = new System.Drawing.Size(92, 46);
            this.toolStripButtonUsunHasloInfo.Text = "Usuń";
            this.toolStripButtonUsunHasloInfo.Click += new System.EventHandler(this.toolStripButtonUsunHasloInfo_Click);
            // 
            // toolStripButtonModyfikujHasloInfo
            // 
            this.toolStripButtonModyfikujHasloInfo.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonModyfikujHasloInfo.Image")));
            this.toolStripButtonModyfikujHasloInfo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonModyfikujHasloInfo.Name = "toolStripButtonModyfikujHasloInfo";
            this.toolStripButtonModyfikujHasloInfo.Size = new System.Drawing.Size(137, 46);
            this.toolStripButtonModyfikujHasloInfo.Text = "Modyfikuj";
            this.toolStripButtonModyfikujHasloInfo.Click += new System.EventHandler(this.toolStripButtonModyfikujHasloInfo_Click);
            // 
            // toolStripComboBoxFirmyHasla
            // 
            this.toolStripComboBoxFirmyHasla.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripComboBoxFirmyHasla.FlatStyle = System.Windows.Forms.FlatStyle.Standard;
            this.toolStripComboBoxFirmyHasla.Name = "toolStripComboBoxFirmyHasla";
            this.toolStripComboBoxFirmyHasla.Size = new System.Drawing.Size(300, 52);
            this.toolStripComboBoxFirmyHasla.SelectedIndexChanged += new System.EventHandler(this.toolStripComboBoxFirmyHasla_SelectedIndexChanged);
            // 
            // toolStripLabel3
            // 
            this.toolStripLabel3.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripLabel3.Name = "toolStripLabel3";
            this.toolStripLabel3.Size = new System.Drawing.Size(64, 46);
            this.toolStripLabel3.Text = "Firma";
            // 
            // HasloInfoUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tabControl1);
            this.Name = "HasloInfoUserControl";
            this.Padding = new System.Windows.Forms.Padding(20);
            this.Size = new System.Drawing.Size(1281, 699);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewHasla)).EndInit();
            this.toolStrip7.ResumeLayout(false);
            this.toolStrip7.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView dataGridViewHasla;
        private System.Windows.Forms.ToolStrip toolStrip7;
        private System.Windows.Forms.ToolStripButton toolStripButtonDodajHasloInfo;
        private System.Windows.Forms.ToolStripButton toolStripButtonUsunHasloInfo;
        private System.Windows.Forms.ToolStripButton toolStripButtonModyfikujHasloInfo;
        private System.Windows.Forms.ToolStripComboBox toolStripComboBoxFirmyHasla;
        private System.Windows.Forms.ToolStripLabel toolStripLabel3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column23;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column24;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
    }
}
