
namespace WinFormsApp90.Forms.TabliceInformacyjne
{
    partial class TablicaInformacyjnaUserControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TablicaInformacyjnaUserControl));
            this.dataGridViewTablicaInformacyjna = new System.Windows.Forms.DataGridView();
            this.Column25 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column26 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStrip6 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton4 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton5 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton6 = new System.Windows.Forms.ToolStripButton();
            this.toolStripComboBoxFirmyTablicaInformacyjna = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripLabel25 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripComboBox3 = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripLabel26 = new System.Windows.Forms.ToolStripLabel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTablicaInformacyjna)).BeginInit();
            this.toolStrip6.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewTablicaInformacyjna
            // 
            this.dataGridViewTablicaInformacyjna.AllowUserToAddRows = false;
            this.dataGridViewTablicaInformacyjna.AllowUserToDeleteRows = false;
            this.dataGridViewTablicaInformacyjna.AllowUserToResizeColumns = false;
            this.dataGridViewTablicaInformacyjna.AllowUserToResizeRows = false;
            this.dataGridViewTablicaInformacyjna.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTablicaInformacyjna.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column25,
            this.Column26});
            this.dataGridViewTablicaInformacyjna.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewTablicaInformacyjna.Location = new System.Drawing.Point(20, 72);
            this.dataGridViewTablicaInformacyjna.Name = "dataGridViewTablicaInformacyjna";
            this.dataGridViewTablicaInformacyjna.RowHeadersWidth = 72;
            this.dataGridViewTablicaInformacyjna.RowTemplate.Height = 37;
            this.dataGridViewTablicaInformacyjna.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewTablicaInformacyjna.Size = new System.Drawing.Size(1220, 600);
            this.dataGridViewTablicaInformacyjna.TabIndex = 15;
            // 
            // Column25
            // 
            this.Column25.DataPropertyName = "TablicaInformacyjnaId";
            this.Column25.HeaderText = "TablicaInformacyjnaId";
            this.Column25.MinimumWidth = 9;
            this.Column25.Name = "Column25";
            this.Column25.Visible = false;
            this.Column25.Width = 175;
            // 
            // Column26
            // 
            this.Column26.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Column26.DataPropertyName = "Lp";
            this.Column26.HeaderText = "Lp";
            this.Column26.MinimumWidth = 9;
            this.Column26.Name = "Column26";
            this.Column26.Width = 76;
            // 
            // toolStrip6
            // 
            this.toolStrip6.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip6.ImageScalingSize = new System.Drawing.Size(28, 28);
            this.toolStrip6.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton4,
            this.toolStripButton5,
            this.toolStripButton6,
            this.toolStripComboBoxFirmyTablicaInformacyjna,
            this.toolStripLabel25,
            this.toolStripComboBox3,
            this.toolStripLabel26});
            this.toolStrip6.Location = new System.Drawing.Point(20, 20);
            this.toolStrip6.Margin = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.toolStrip6.Name = "toolStrip6";
            this.toolStrip6.Padding = new System.Windows.Forms.Padding(0);
            this.toolStrip6.Size = new System.Drawing.Size(1220, 52);
            this.toolStrip6.TabIndex = 16;
            this.toolStrip6.Text = "toolStrip6";
            // 
            // toolStripButton4
            // 
            this.toolStripButton4.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton4.Image")));
            this.toolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton4.Name = "toolStripButton4";
            this.toolStripButton4.Padding = new System.Windows.Forms.Padding(0, 6, 0, 6);
            this.toolStripButton4.Size = new System.Drawing.Size(100, 46);
            this.toolStripButton4.Text = "Dodaj";
            // 
            // toolStripButton5
            // 
            this.toolStripButton5.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton5.Image")));
            this.toolStripButton5.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton5.Name = "toolStripButton5";
            this.toolStripButton5.Size = new System.Drawing.Size(92, 46);
            this.toolStripButton5.Text = "Usuń";
            // 
            // toolStripButton6
            // 
            this.toolStripButton6.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton6.Image")));
            this.toolStripButton6.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton6.Name = "toolStripButton6";
            this.toolStripButton6.Size = new System.Drawing.Size(137, 46);
            this.toolStripButton6.Text = "Modyfikuj";
            // 
            // toolStripComboBoxFirmyTablicaInformacyjna
            // 
            this.toolStripComboBoxFirmyTablicaInformacyjna.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripComboBoxFirmyTablicaInformacyjna.FlatStyle = System.Windows.Forms.FlatStyle.Standard;
            this.toolStripComboBoxFirmyTablicaInformacyjna.Name = "toolStripComboBoxFirmyTablicaInformacyjna";
            this.toolStripComboBoxFirmyTablicaInformacyjna.Size = new System.Drawing.Size(300, 52);
            // 
            // toolStripLabel25
            // 
            this.toolStripLabel25.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripLabel25.Name = "toolStripLabel25";
            this.toolStripLabel25.Size = new System.Drawing.Size(64, 46);
            this.toolStripLabel25.Text = "Firma";
            // 
            // toolStripComboBox3
            // 
            this.toolStripComboBox3.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripComboBox3.FlatStyle = System.Windows.Forms.FlatStyle.Standard;
            this.toolStripComboBox3.Name = "toolStripComboBox3";
            this.toolStripComboBox3.Size = new System.Drawing.Size(300, 52);
            // 
            // toolStripLabel26
            // 
            this.toolStripLabel26.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripLabel26.Name = "toolStripLabel26";
            this.toolStripLabel26.Size = new System.Drawing.Size(67, 46);
            this.toolStripLabel26.Text = "Pokaż";
            // 
            // TablicaInformacyjnaUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dataGridViewTablicaInformacyjna);
            this.Controls.Add(this.toolStrip6);
            this.Name = "TablicaInformacyjnaUserControl";
            this.Padding = new System.Windows.Forms.Padding(20);
            this.Size = new System.Drawing.Size(1260, 692);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTablicaInformacyjna)).EndInit();
            this.toolStrip6.ResumeLayout(false);
            this.toolStrip6.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewTablicaInformacyjna;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column25;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column26;
        private System.Windows.Forms.ToolStrip toolStrip6;
        private System.Windows.Forms.ToolStripButton toolStripButton4;
        private System.Windows.Forms.ToolStripButton toolStripButton5;
        private System.Windows.Forms.ToolStripButton toolStripButton6;
        private System.Windows.Forms.ToolStripComboBox toolStripComboBoxFirmyTablicaInformacyjna;
        private System.Windows.Forms.ToolStripLabel toolStripLabel25;
        private System.Windows.Forms.ToolStripComboBox toolStripComboBox3;
        private System.Windows.Forms.ToolStripLabel toolStripLabel26;
    }
}
