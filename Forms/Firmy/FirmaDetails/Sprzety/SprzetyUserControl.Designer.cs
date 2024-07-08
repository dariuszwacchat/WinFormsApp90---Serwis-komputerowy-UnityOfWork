
namespace WinFormsApp90.Forms.Firmy.FirmaDetails.Sprzety
{
    partial class SprzetyUserControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SprzetyUserControl));
            this.tableLayoutPanelSprzet = new System.Windows.Forms.TableLayoutPanel();
            this.tabControl4 = new System.Windows.Forms.TabControl();
            this.tabPage26 = new System.Windows.Forms.TabPage();
            this.dataGridViewSprzet = new System.Windows.Forms.DataGridView();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButtonDodaj = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonUsun = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonModyfikuj = new System.Windows.Forms.ToolStripButton();
            this.toolStripTextBoxWyszukiwarka = new System.Windows.Forms.ToolStripTextBox();
            this.tabControl6 = new System.Windows.Forms.TabControl();
            this.tabPage28 = new System.Windows.Forms.TabPage();
            this.dataGridViewPola = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableLayoutPanelSprzet.SuspendLayout();
            this.tabControl4.SuspendLayout();
            this.tabPage26.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSprzet)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.tabControl6.SuspendLayout();
            this.tabPage28.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPola)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanelSprzet
            // 
            this.tableLayoutPanelSprzet.ColumnCount = 2;
            this.tableLayoutPanelSprzet.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelSprzet.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 500F));
            this.tableLayoutPanelSprzet.Controls.Add(this.tabControl4, 0, 0);
            this.tableLayoutPanelSprzet.Controls.Add(this.tabControl6, 1, 0);
            this.tableLayoutPanelSprzet.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelSprzet.Location = new System.Drawing.Point(20, 20);
            this.tableLayoutPanelSprzet.Name = "tableLayoutPanelSprzet";
            this.tableLayoutPanelSprzet.RowCount = 1;
            this.tableLayoutPanelSprzet.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelSprzet.Size = new System.Drawing.Size(1599, 596);
            this.tableLayoutPanelSprzet.TabIndex = 1;
            // 
            // tabControl4
            // 
            this.tabControl4.Controls.Add(this.tabPage26);
            this.tabControl4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl4.Location = new System.Drawing.Point(3, 3);
            this.tabControl4.Name = "tabControl4";
            this.tabControl4.SelectedIndex = 0;
            this.tabControl4.Size = new System.Drawing.Size(1093, 590);
            this.tabControl4.TabIndex = 0;
            // 
            // tabPage26
            // 
            this.tabPage26.Controls.Add(this.dataGridViewSprzet);
            this.tabPage26.Controls.Add(this.toolStrip1);
            this.tabPage26.Location = new System.Drawing.Point(4, 39);
            this.tabPage26.Name = "tabPage26";
            this.tabPage26.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage26.Size = new System.Drawing.Size(1085, 547);
            this.tabPage26.TabIndex = 0;
            this.tabPage26.Text = "Lista sprzętów";
            this.tabPage26.UseVisualStyleBackColor = true;
            // 
            // dataGridViewSprzet
            // 
            this.dataGridViewSprzet.AllowUserToAddRows = false;
            this.dataGridViewSprzet.AllowUserToDeleteRows = false;
            this.dataGridViewSprzet.AllowUserToResizeColumns = false;
            this.dataGridViewSprzet.AllowUserToResizeRows = false;
            this.dataGridViewSprzet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSprzet.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewSprzet.Location = new System.Drawing.Point(3, 55);
            this.dataGridViewSprzet.Name = "dataGridViewSprzet";
            this.dataGridViewSprzet.RowHeadersWidth = 72;
            this.dataGridViewSprzet.RowTemplate.Height = 37;
            this.dataGridViewSprzet.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewSprzet.Size = new System.Drawing.Size(1079, 489);
            this.dataGridViewSprzet.TabIndex = 6;
            this.dataGridViewSprzet.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridViewSprzet_CellMouseClick);
            this.dataGridViewSprzet.SelectionChanged += new System.EventHandler(this.dataGridViewSprzet_SelectionChanged);
            // 
            // toolStrip1
            // 
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(28, 28);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonDodaj,
            this.toolStripButtonUsun,
            this.toolStripButtonModyfikuj,
            this.toolStripTextBoxWyszukiwarka});
            this.toolStrip1.Location = new System.Drawing.Point(3, 3);
            this.toolStrip1.Margin = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Padding = new System.Windows.Forms.Padding(0);
            this.toolStrip1.Size = new System.Drawing.Size(1079, 52);
            this.toolStrip1.TabIndex = 7;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButtonDodaj
            // 
            this.toolStripButtonDodaj.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonDodaj.Image")));
            this.toolStripButtonDodaj.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonDodaj.Name = "toolStripButtonDodaj";
            this.toolStripButtonDodaj.Padding = new System.Windows.Forms.Padding(0, 6, 0, 6);
            this.toolStripButtonDodaj.Size = new System.Drawing.Size(100, 46);
            this.toolStripButtonDodaj.Text = "Dodaj";
            // 
            // toolStripButtonUsun
            // 
            this.toolStripButtonUsun.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonUsun.Image")));
            this.toolStripButtonUsun.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonUsun.Name = "toolStripButtonUsun";
            this.toolStripButtonUsun.Size = new System.Drawing.Size(92, 46);
            this.toolStripButtonUsun.Text = "Usuń";
            // 
            // toolStripButtonModyfikuj
            // 
            this.toolStripButtonModyfikuj.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonModyfikuj.Image")));
            this.toolStripButtonModyfikuj.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonModyfikuj.Name = "toolStripButtonModyfikuj";
            this.toolStripButtonModyfikuj.Size = new System.Drawing.Size(137, 46);
            this.toolStripButtonModyfikuj.Text = "Modyfikuj";
            // 
            // toolStripTextBoxWyszukiwarka
            // 
            this.toolStripTextBoxWyszukiwarka.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripTextBoxWyszukiwarka.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.toolStripTextBoxWyszukiwarka.Name = "toolStripTextBoxWyszukiwarka";
            this.toolStripTextBoxWyszukiwarka.Size = new System.Drawing.Size(300, 52);
            // 
            // tabControl6
            // 
            this.tabControl6.Controls.Add(this.tabPage28);
            this.tabControl6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl6.Location = new System.Drawing.Point(1102, 3);
            this.tabControl6.Name = "tabControl6";
            this.tabControl6.SelectedIndex = 0;
            this.tabControl6.Size = new System.Drawing.Size(494, 590);
            this.tabControl6.TabIndex = 0;
            // 
            // tabPage28
            // 
            this.tabPage28.Controls.Add(this.dataGridViewPola);
            this.tabPage28.Location = new System.Drawing.Point(4, 39);
            this.tabPage28.Name = "tabPage28";
            this.tabPage28.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage28.Size = new System.Drawing.Size(486, 547);
            this.tabPage28.TabIndex = 0;
            this.tabPage28.Text = "Pola";
            this.tabPage28.UseVisualStyleBackColor = true;
            // 
            // dataGridViewPola
            // 
            this.dataGridViewPola.AllowUserToAddRows = false;
            this.dataGridViewPola.AllowUserToDeleteRows = false;
            this.dataGridViewPola.AllowUserToOrderColumns = true;
            this.dataGridViewPola.AllowUserToResizeColumns = false;
            this.dataGridViewPola.AllowUserToResizeRows = false;
            this.dataGridViewPola.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewPola.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewPola.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPola.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            this.dataGridViewPola.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewPola.Location = new System.Drawing.Point(3, 3);
            this.dataGridViewPola.MultiSelect = false;
            this.dataGridViewPola.Name = "dataGridViewPola";
            this.dataGridViewPola.RowHeadersVisible = false;
            this.dataGridViewPola.RowHeadersWidth = 72;
            this.dataGridViewPola.RowTemplate.Height = 37;
            this.dataGridViewPola.Size = new System.Drawing.Size(480, 541);
            this.dataGridViewPola.TabIndex = 118;
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column1.DataPropertyName = "Name";
            this.Column1.HeaderText = "Nazwa";
            this.Column1.MinimumWidth = 9;
            this.Column1.Name = "Column1";
            this.Column1.Width = 117;
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column2.DataPropertyName = "Wartosc";
            this.Column2.HeaderText = "Opis";
            this.Column2.MinimumWidth = 9;
            this.Column2.Name = "Column2";
            // 
            // SprzetyUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanelSprzet);
            this.Name = "SprzetyUserControl";
            this.Padding = new System.Windows.Forms.Padding(20);
            this.Size = new System.Drawing.Size(1639, 636);
            this.Load += new System.EventHandler(this.SprzetyUserControl_Load);
            this.tableLayoutPanelSprzet.ResumeLayout(false);
            this.tabControl4.ResumeLayout(false);
            this.tabPage26.ResumeLayout(false);
            this.tabPage26.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSprzet)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.tabControl6.ResumeLayout(false);
            this.tabPage28.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPola)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelSprzet;
        private System.Windows.Forms.TabControl tabControl4;
        private System.Windows.Forms.TabPage tabPage26;
        private System.Windows.Forms.DataGridView dataGridViewSprzet;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButtonDodaj;
        private System.Windows.Forms.ToolStripButton toolStripButtonUsun;
        private System.Windows.Forms.ToolStripButton toolStripButtonModyfikuj;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBoxWyszukiwarka;
        private System.Windows.Forms.TabControl tabControl6;
        private System.Windows.Forms.TabPage tabPage28;
        private System.Windows.Forms.DataGridView dataGridViewPola;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
    }
}
