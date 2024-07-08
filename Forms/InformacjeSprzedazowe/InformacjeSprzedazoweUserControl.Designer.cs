
namespace WinFormsApp90.Forms.InformacjeSprzedazowe
{
    partial class InformacjeSprzedazoweUserControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InformacjeSprzedazoweUserControl));
            this.tabControl22 = new System.Windows.Forms.TabControl();
            this.tabPage57 = new System.Windows.Forms.TabPage();
            this.dataGridViewInformacjeSprzedazowe = new System.Windows.Forms.DataGridView();
            this.toolStrip8 = new System.Windows.Forms.ToolStrip();
            this.toolStripButtonDodajInformacjeSprzedazowe = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonUsunInformacjeSprzedazowe = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonModyfikujInformacjeSprzedazowe = new System.Windows.Forms.ToolStripButton();
            this.toolStripComboBoxFirmyInformacjeSprzedazowe = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripLabel5 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripComboBoxRodzajInformacjeSprzedazowe = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripLabel6 = new System.Windows.Forms.ToolStripLabel();
            this.tabControl22.SuspendLayout();
            this.tabPage57.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInformacjeSprzedazowe)).BeginInit();
            this.toolStrip8.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl22
            // 
            this.tabControl22.Controls.Add(this.tabPage57);
            this.tabControl22.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl22.Location = new System.Drawing.Point(20, 20);
            this.tabControl22.Name = "tabControl22";
            this.tabControl22.SelectedIndex = 0;
            this.tabControl22.Size = new System.Drawing.Size(1159, 650);
            this.tabControl22.TabIndex = 7;
            // 
            // tabPage57
            // 
            this.tabPage57.Controls.Add(this.dataGridViewInformacjeSprzedazowe);
            this.tabPage57.Controls.Add(this.toolStrip8);
            this.tabPage57.Location = new System.Drawing.Point(4, 39);
            this.tabPage57.Name = "tabPage57";
            this.tabPage57.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage57.Size = new System.Drawing.Size(1151, 607);
            this.tabPage57.TabIndex = 0;
            this.tabPage57.Text = "Lista informacji sprzedażowych";
            this.tabPage57.UseVisualStyleBackColor = true;
            // 
            // dataGridViewInformacjeSprzedazowe
            // 
            this.dataGridViewInformacjeSprzedazowe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewInformacjeSprzedazowe.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewInformacjeSprzedazowe.Location = new System.Drawing.Point(3, 55);
            this.dataGridViewInformacjeSprzedazowe.Name = "dataGridViewInformacjeSprzedazowe";
            this.dataGridViewInformacjeSprzedazowe.RowHeadersWidth = 72;
            this.dataGridViewInformacjeSprzedazowe.RowTemplate.Height = 37;
            this.dataGridViewInformacjeSprzedazowe.Size = new System.Drawing.Size(1145, 549);
            this.dataGridViewInformacjeSprzedazowe.TabIndex = 14;
            // 
            // toolStrip8
            // 
            this.toolStrip8.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip8.ImageScalingSize = new System.Drawing.Size(28, 28);
            this.toolStrip8.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonDodajInformacjeSprzedazowe,
            this.toolStripButtonUsunInformacjeSprzedazowe,
            this.toolStripButtonModyfikujInformacjeSprzedazowe,
            this.toolStripComboBoxFirmyInformacjeSprzedazowe,
            this.toolStripLabel5,
            this.toolStripComboBoxRodzajInformacjeSprzedazowe,
            this.toolStripLabel6});
            this.toolStrip8.Location = new System.Drawing.Point(3, 3);
            this.toolStrip8.Margin = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.toolStrip8.Name = "toolStrip8";
            this.toolStrip8.Padding = new System.Windows.Forms.Padding(0);
            this.toolStrip8.Size = new System.Drawing.Size(1145, 52);
            this.toolStrip8.TabIndex = 13;
            this.toolStrip8.Text = "toolStrip8";
            // 
            // toolStripButtonDodajInformacjeSprzedazowe
            // 
            this.toolStripButtonDodajInformacjeSprzedazowe.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonDodajInformacjeSprzedazowe.Image")));
            this.toolStripButtonDodajInformacjeSprzedazowe.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonDodajInformacjeSprzedazowe.Name = "toolStripButtonDodajInformacjeSprzedazowe";
            this.toolStripButtonDodajInformacjeSprzedazowe.Padding = new System.Windows.Forms.Padding(0, 6, 0, 6);
            this.toolStripButtonDodajInformacjeSprzedazowe.Size = new System.Drawing.Size(100, 46);
            this.toolStripButtonDodajInformacjeSprzedazowe.Text = "Dodaj";
            this.toolStripButtonDodajInformacjeSprzedazowe.Click += new System.EventHandler(this.toolStripButtonDodajInformacjeSprzedazowe_Click);
            // 
            // toolStripButtonUsunInformacjeSprzedazowe
            // 
            this.toolStripButtonUsunInformacjeSprzedazowe.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonUsunInformacjeSprzedazowe.Image")));
            this.toolStripButtonUsunInformacjeSprzedazowe.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonUsunInformacjeSprzedazowe.Name = "toolStripButtonUsunInformacjeSprzedazowe";
            this.toolStripButtonUsunInformacjeSprzedazowe.Size = new System.Drawing.Size(92, 46);
            this.toolStripButtonUsunInformacjeSprzedazowe.Text = "Usuń";
            this.toolStripButtonUsunInformacjeSprzedazowe.Click += new System.EventHandler(this.toolStripButtonUsunInformacjeSprzedazowe_Click);
            // 
            // toolStripButtonModyfikujInformacjeSprzedazowe
            // 
            this.toolStripButtonModyfikujInformacjeSprzedazowe.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonModyfikujInformacjeSprzedazowe.Image")));
            this.toolStripButtonModyfikujInformacjeSprzedazowe.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonModyfikujInformacjeSprzedazowe.Name = "toolStripButtonModyfikujInformacjeSprzedazowe";
            this.toolStripButtonModyfikujInformacjeSprzedazowe.Size = new System.Drawing.Size(137, 46);
            this.toolStripButtonModyfikujInformacjeSprzedazowe.Text = "Modyfikuj";
            this.toolStripButtonModyfikujInformacjeSprzedazowe.Click += new System.EventHandler(this.toolStripButtonModyfikujInformacjeSprzedazowe_Click);
            // 
            // toolStripComboBoxFirmyInformacjeSprzedazowe
            // 
            this.toolStripComboBoxFirmyInformacjeSprzedazowe.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripComboBoxFirmyInformacjeSprzedazowe.FlatStyle = System.Windows.Forms.FlatStyle.Standard;
            this.toolStripComboBoxFirmyInformacjeSprzedazowe.Name = "toolStripComboBoxFirmyInformacjeSprzedazowe";
            this.toolStripComboBoxFirmyInformacjeSprzedazowe.Size = new System.Drawing.Size(300, 52);
            this.toolStripComboBoxFirmyInformacjeSprzedazowe.SelectedIndexChanged += new System.EventHandler(this.toolStripComboBoxFirmyInformacjeSprzedazowe_SelectedIndexChanged);
            // 
            // toolStripLabel5
            // 
            this.toolStripLabel5.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripLabel5.Name = "toolStripLabel5";
            this.toolStripLabel5.Size = new System.Drawing.Size(64, 46);
            this.toolStripLabel5.Text = "Firma";
            // 
            // toolStripComboBoxRodzajInformacjeSprzedazowe
            // 
            this.toolStripComboBoxRodzajInformacjeSprzedazowe.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripComboBoxRodzajInformacjeSprzedazowe.FlatStyle = System.Windows.Forms.FlatStyle.Standard;
            this.toolStripComboBoxRodzajInformacjeSprzedazowe.Items.AddRange(new object[] {
            "Przypisane",
            "Nieprzypisane"});
            this.toolStripComboBoxRodzajInformacjeSprzedazowe.Name = "toolStripComboBoxRodzajInformacjeSprzedazowe";
            this.toolStripComboBoxRodzajInformacjeSprzedazowe.Size = new System.Drawing.Size(300, 52);
            // 
            // toolStripLabel6
            // 
            this.toolStripLabel6.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripLabel6.Name = "toolStripLabel6";
            this.toolStripLabel6.Size = new System.Drawing.Size(67, 46);
            this.toolStripLabel6.Text = "Pokaż";
            // 
            // InformacjeSprzedazoweUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tabControl22);
            this.Name = "InformacjeSprzedazoweUserControl";
            this.Padding = new System.Windows.Forms.Padding(20);
            this.Size = new System.Drawing.Size(1199, 690);
            this.tabControl22.ResumeLayout(false);
            this.tabPage57.ResumeLayout(false);
            this.tabPage57.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInformacjeSprzedazowe)).EndInit();
            this.toolStrip8.ResumeLayout(false);
            this.toolStrip8.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl22;
        private System.Windows.Forms.TabPage tabPage57;
        private System.Windows.Forms.DataGridView dataGridViewInformacjeSprzedazowe;
        private System.Windows.Forms.ToolStrip toolStrip8;
        private System.Windows.Forms.ToolStripButton toolStripButtonDodajInformacjeSprzedazowe;
        private System.Windows.Forms.ToolStripButton toolStripButtonUsunInformacjeSprzedazowe;
        private System.Windows.Forms.ToolStripButton toolStripButtonModyfikujInformacjeSprzedazowe;
        private System.Windows.Forms.ToolStripComboBox toolStripComboBoxFirmyInformacjeSprzedazowe;
        private System.Windows.Forms.ToolStripLabel toolStripLabel5;
        private System.Windows.Forms.ToolStripComboBox toolStripComboBoxRodzajInformacjeSprzedazowe;
        private System.Windows.Forms.ToolStripLabel toolStripLabel6;
    }
}
