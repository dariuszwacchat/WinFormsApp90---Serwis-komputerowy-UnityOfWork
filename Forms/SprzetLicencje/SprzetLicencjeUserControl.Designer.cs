
namespace WinFormsApp90.Forms.SprzetLicencje
{
    partial class SprzetLicencjeUserControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SprzetLicencjeUserControl));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dataGridViewLicencje = new System.Windows.Forms.DataGridView();
            this.toolStrip12 = new System.Windows.Forms.ToolStrip();
            this.toolStripButtonDodajLicencje = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonUsunLicencje = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonLicencje = new System.Windows.Forms.ToolStripButton();
            this.toolStripComboBoxFirmyLicencje = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripLabel13 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripComboBoxStatusyLicencji = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripLabel14 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripButton10 = new System.Windows.Forms.ToolStripButton();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLicencje)).BeginInit();
            this.toolStrip12.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(20, 20);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1187, 641);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dataGridViewLicencje);
            this.tabPage1.Controls.Add(this.toolStrip12);
            this.tabPage1.Location = new System.Drawing.Point(4, 39);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1179, 598);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Lista licencji";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dataGridViewLicencje
            // 
            this.dataGridViewLicencje.AllowUserToAddRows = false;
            this.dataGridViewLicencje.AllowUserToDeleteRows = false;
            this.dataGridViewLicencje.AllowUserToResizeColumns = false;
            this.dataGridViewLicencje.AllowUserToResizeRows = false;
            this.dataGridViewLicencje.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewLicencje.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewLicencje.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewLicencje.Location = new System.Drawing.Point(3, 55);
            this.dataGridViewLicencje.Name = "dataGridViewLicencje";
            this.dataGridViewLicencje.RowHeadersWidth = 72;
            this.dataGridViewLicencje.RowTemplate.Height = 37;
            this.dataGridViewLicencje.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewLicencje.Size = new System.Drawing.Size(1173, 540);
            this.dataGridViewLicencje.TabIndex = 16;
            this.dataGridViewLicencje.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridViewLicencje_CellMouseClick);
            this.dataGridViewLicencje.SelectionChanged += new System.EventHandler(this.dataGridViewLicencje_SelectionChanged);
            // 
            // toolStrip12
            // 
            this.toolStrip12.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip12.ImageScalingSize = new System.Drawing.Size(28, 28);
            this.toolStrip12.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonDodajLicencje,
            this.toolStripButtonUsunLicencje,
            this.toolStripButtonLicencje,
            this.toolStripComboBoxFirmyLicencje,
            this.toolStripLabel13,
            this.toolStripComboBoxStatusyLicencji,
            this.toolStripLabel14,
            this.toolStripButton10});
            this.toolStrip12.Location = new System.Drawing.Point(3, 3);
            this.toolStrip12.Margin = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.toolStrip12.Name = "toolStrip12";
            this.toolStrip12.Padding = new System.Windows.Forms.Padding(0);
            this.toolStrip12.Size = new System.Drawing.Size(1173, 52);
            this.toolStrip12.TabIndex = 17;
            this.toolStrip12.Text = "toolStrip12";
            // 
            // toolStripButtonDodajLicencje
            // 
            this.toolStripButtonDodajLicencje.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonDodajLicencje.Image")));
            this.toolStripButtonDodajLicencje.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonDodajLicencje.Name = "toolStripButtonDodajLicencje";
            this.toolStripButtonDodajLicencje.Padding = new System.Windows.Forms.Padding(0, 6, 0, 6);
            this.toolStripButtonDodajLicencje.Size = new System.Drawing.Size(100, 46);
            this.toolStripButtonDodajLicencje.Text = "Dodaj";
            this.toolStripButtonDodajLicencje.Click += new System.EventHandler(this.toolStripButtonDodajLicencje_Click);
            // 
            // toolStripButtonUsunLicencje
            // 
            this.toolStripButtonUsunLicencje.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonUsunLicencje.Image")));
            this.toolStripButtonUsunLicencje.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonUsunLicencje.Name = "toolStripButtonUsunLicencje";
            this.toolStripButtonUsunLicencje.Size = new System.Drawing.Size(92, 46);
            this.toolStripButtonUsunLicencje.Text = "Usuń";
            this.toolStripButtonUsunLicencje.Click += new System.EventHandler(this.toolStripButtonUsunLicencje_Click);
            // 
            // toolStripButtonLicencje
            // 
            this.toolStripButtonLicencje.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonLicencje.Image")));
            this.toolStripButtonLicencje.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonLicencje.Name = "toolStripButtonLicencje";
            this.toolStripButtonLicencje.Size = new System.Drawing.Size(137, 46);
            this.toolStripButtonLicencje.Text = "Modyfikuj";
            this.toolStripButtonLicencje.Click += new System.EventHandler(this.toolStripButtonLicencje_Click);
            // 
            // toolStripComboBoxFirmyLicencje
            // 
            this.toolStripComboBoxFirmyLicencje.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripComboBoxFirmyLicencje.FlatStyle = System.Windows.Forms.FlatStyle.Standard;
            this.toolStripComboBoxFirmyLicencje.Name = "toolStripComboBoxFirmyLicencje";
            this.toolStripComboBoxFirmyLicencje.Size = new System.Drawing.Size(300, 52);
            this.toolStripComboBoxFirmyLicencje.SelectedIndexChanged += new System.EventHandler(this.toolStripComboBoxFirmyLicencje_SelectedIndexChanged);
            // 
            // toolStripLabel13
            // 
            this.toolStripLabel13.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripLabel13.Name = "toolStripLabel13";
            this.toolStripLabel13.Size = new System.Drawing.Size(64, 46);
            this.toolStripLabel13.Text = "Firma";
            // 
            // toolStripComboBoxStatusyLicencji
            // 
            this.toolStripComboBoxStatusyLicencji.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripComboBoxStatusyLicencji.FlatStyle = System.Windows.Forms.FlatStyle.Standard;
            this.toolStripComboBoxStatusyLicencji.Name = "toolStripComboBoxStatusyLicencji";
            this.toolStripComboBoxStatusyLicencji.Size = new System.Drawing.Size(300, 52);
            // 
            // toolStripLabel14
            // 
            this.toolStripLabel14.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripLabel14.Name = "toolStripLabel14";
            this.toolStripLabel14.Size = new System.Drawing.Size(67, 46);
            this.toolStripLabel14.Text = "Pokaż";
            // 
            // toolStripButton10
            // 
            this.toolStripButton10.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton10.Image")));
            this.toolStripButton10.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton10.Name = "toolStripButton10";
            this.toolStripButton10.Size = new System.Drawing.Size(120, 34);
            this.toolStripButton10.Text = "Przypisz";
            // 
            // SprzetLicencjeUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tabControl1);
            this.Name = "SprzetLicencjeUserControl";
            this.Padding = new System.Windows.Forms.Padding(20);
            this.Size = new System.Drawing.Size(1227, 681);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLicencje)).EndInit();
            this.toolStrip12.ResumeLayout(false);
            this.toolStrip12.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView dataGridViewLicencje;
        private System.Windows.Forms.ToolStrip toolStrip12;
        private System.Windows.Forms.ToolStripButton toolStripButtonDodajLicencje;
        private System.Windows.Forms.ToolStripButton toolStripButtonUsunLicencje;
        private System.Windows.Forms.ToolStripButton toolStripButtonLicencje;
        private System.Windows.Forms.ToolStripComboBox toolStripComboBoxFirmyLicencje;
        private System.Windows.Forms.ToolStripLabel toolStripLabel13;
        private System.Windows.Forms.ToolStripComboBox toolStripComboBoxStatusyLicencji;
        private System.Windows.Forms.ToolStripLabel toolStripLabel14;
        private System.Windows.Forms.ToolStripButton toolStripButton10;
    }
}
