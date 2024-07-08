
namespace WinFormsApp90.Forms.Terminy
{
    partial class TerminyUserControl
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dataGridViewGwarancje = new System.Windows.Forms.DataGridView();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripComboBoxGwarancje = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dataGridViewLicencje = new System.Windows.Forms.DataGridView();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.toolStripComboBoxLicencje = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.dataGridViewNaprawy = new System.Windows.Forms.DataGridView();
            this.toolStrip4 = new System.Windows.Forms.ToolStrip();
            this.toolStripComboBoxNaprawy = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripLabel3 = new System.Windows.Forms.ToolStripLabel();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.dataGridViewUmowy = new System.Windows.Forms.DataGridView();
            this.toolStrip3 = new System.Windows.Forms.ToolStrip();
            this.toolStripComboBoxUmowy = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripLabel27 = new System.Windows.Forms.ToolStripLabel();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewGwarancje)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLicencje)).BeginInit();
            this.toolStrip2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewNaprawy)).BeginInit();
            this.toolStrip4.SuspendLayout();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUmowy)).BeginInit();
            this.toolStrip3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(20, 20);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1158, 599);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dataGridViewGwarancje);
            this.tabPage1.Controls.Add(this.toolStrip1);
            this.tabPage1.Location = new System.Drawing.Point(4, 39);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1150, 556);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Gwarancje";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dataGridViewGwarancje
            // 
            this.dataGridViewGwarancje.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewGwarancje.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewGwarancje.Location = new System.Drawing.Point(3, 41);
            this.dataGridViewGwarancje.Name = "dataGridViewGwarancje";
            this.dataGridViewGwarancje.RowHeadersWidth = 72;
            this.dataGridViewGwarancje.RowTemplate.Height = 37;
            this.dataGridViewGwarancje.Size = new System.Drawing.Size(1144, 512);
            this.dataGridViewGwarancje.TabIndex = 21;
            // 
            // toolStrip1
            // 
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(28, 28);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripComboBoxGwarancje,
            this.toolStripLabel1});
            this.toolStrip1.Location = new System.Drawing.Point(3, 3);
            this.toolStrip1.Margin = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Padding = new System.Windows.Forms.Padding(0);
            this.toolStrip1.Size = new System.Drawing.Size(1144, 38);
            this.toolStrip1.TabIndex = 20;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripComboBoxGwarancje
            // 
            this.toolStripComboBoxGwarancje.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripComboBoxGwarancje.FlatStyle = System.Windows.Forms.FlatStyle.Standard;
            this.toolStripComboBoxGwarancje.Items.AddRange(new object[] {
            "Miesiacu",
            "Tygodniu"});
            this.toolStripComboBoxGwarancje.Name = "toolStripComboBoxGwarancje";
            this.toolStripComboBoxGwarancje.Size = new System.Drawing.Size(300, 38);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(193, 32);
            this.toolStripLabel1.Text = "Kończące się w tym";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dataGridViewLicencje);
            this.tabPage2.Controls.Add(this.toolStrip2);
            this.tabPage2.Location = new System.Drawing.Point(4, 39);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1150, 556);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Licencje";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dataGridViewLicencje
            // 
            this.dataGridViewLicencje.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewLicencje.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewLicencje.Location = new System.Drawing.Point(3, 41);
            this.dataGridViewLicencje.Name = "dataGridViewLicencje";
            this.dataGridViewLicencje.RowHeadersWidth = 72;
            this.dataGridViewLicencje.RowTemplate.Height = 37;
            this.dataGridViewLicencje.Size = new System.Drawing.Size(1144, 512);
            this.dataGridViewLicencje.TabIndex = 21;
            // 
            // toolStrip2
            // 
            this.toolStrip2.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip2.ImageScalingSize = new System.Drawing.Size(28, 28);
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripComboBoxLicencje,
            this.toolStripLabel2});
            this.toolStrip2.Location = new System.Drawing.Point(3, 3);
            this.toolStrip2.Margin = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Padding = new System.Windows.Forms.Padding(0);
            this.toolStrip2.Size = new System.Drawing.Size(1144, 38);
            this.toolStrip2.TabIndex = 20;
            this.toolStrip2.Text = "toolStrip2";
            // 
            // toolStripComboBoxLicencje
            // 
            this.toolStripComboBoxLicencje.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripComboBoxLicencje.FlatStyle = System.Windows.Forms.FlatStyle.Standard;
            this.toolStripComboBoxLicencje.Items.AddRange(new object[] {
            "Miesiacu",
            "Tygodniu"});
            this.toolStripComboBoxLicencje.Name = "toolStripComboBoxLicencje";
            this.toolStripComboBoxLicencje.Size = new System.Drawing.Size(300, 38);
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(193, 32);
            this.toolStripLabel2.Text = "Kończące się w tym";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.dataGridViewNaprawy);
            this.tabPage3.Controls.Add(this.toolStrip4);
            this.tabPage3.Location = new System.Drawing.Point(4, 39);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1150, 556);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Naprawy";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // dataGridViewNaprawy
            // 
            this.dataGridViewNaprawy.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewNaprawy.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewNaprawy.Location = new System.Drawing.Point(3, 41);
            this.dataGridViewNaprawy.Name = "dataGridViewNaprawy";
            this.dataGridViewNaprawy.RowHeadersWidth = 72;
            this.dataGridViewNaprawy.RowTemplate.Height = 37;
            this.dataGridViewNaprawy.Size = new System.Drawing.Size(1144, 512);
            this.dataGridViewNaprawy.TabIndex = 21;
            // 
            // toolStrip4
            // 
            this.toolStrip4.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip4.ImageScalingSize = new System.Drawing.Size(28, 28);
            this.toolStrip4.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripComboBoxNaprawy,
            this.toolStripLabel3});
            this.toolStrip4.Location = new System.Drawing.Point(3, 3);
            this.toolStrip4.Margin = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.toolStrip4.Name = "toolStrip4";
            this.toolStrip4.Padding = new System.Windows.Forms.Padding(0);
            this.toolStrip4.Size = new System.Drawing.Size(1144, 38);
            this.toolStrip4.TabIndex = 20;
            this.toolStrip4.Text = "toolStrip4";
            // 
            // toolStripComboBoxNaprawy
            // 
            this.toolStripComboBoxNaprawy.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripComboBoxNaprawy.FlatStyle = System.Windows.Forms.FlatStyle.Standard;
            this.toolStripComboBoxNaprawy.Items.AddRange(new object[] {
            "Miesiacu",
            "Tygodniu"});
            this.toolStripComboBoxNaprawy.Name = "toolStripComboBoxNaprawy";
            this.toolStripComboBoxNaprawy.Size = new System.Drawing.Size(300, 38);
            // 
            // toolStripLabel3
            // 
            this.toolStripLabel3.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripLabel3.Name = "toolStripLabel3";
            this.toolStripLabel3.Size = new System.Drawing.Size(193, 32);
            this.toolStripLabel3.Text = "Kończące się w tym";
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.dataGridViewUmowy);
            this.tabPage4.Controls.Add(this.toolStrip3);
            this.tabPage4.Location = new System.Drawing.Point(4, 39);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(1150, 556);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Umowy";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // dataGridViewUmowy
            // 
            this.dataGridViewUmowy.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewUmowy.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewUmowy.Location = new System.Drawing.Point(3, 41);
            this.dataGridViewUmowy.Name = "dataGridViewUmowy";
            this.dataGridViewUmowy.RowHeadersWidth = 72;
            this.dataGridViewUmowy.RowTemplate.Height = 37;
            this.dataGridViewUmowy.Size = new System.Drawing.Size(1144, 512);
            this.dataGridViewUmowy.TabIndex = 20;
            // 
            // toolStrip3
            // 
            this.toolStrip3.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip3.ImageScalingSize = new System.Drawing.Size(28, 28);
            this.toolStrip3.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripComboBoxUmowy,
            this.toolStripLabel27});
            this.toolStrip3.Location = new System.Drawing.Point(3, 3);
            this.toolStrip3.Margin = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.toolStrip3.Name = "toolStrip3";
            this.toolStrip3.Padding = new System.Windows.Forms.Padding(0);
            this.toolStrip3.Size = new System.Drawing.Size(1144, 38);
            this.toolStrip3.TabIndex = 19;
            this.toolStrip3.Text = "toolStrip3";
            // 
            // toolStripComboBoxUmowy
            // 
            this.toolStripComboBoxUmowy.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripComboBoxUmowy.FlatStyle = System.Windows.Forms.FlatStyle.Standard;
            this.toolStripComboBoxUmowy.Items.AddRange(new object[] {
            "Miesiacu",
            "Tygodniu"});
            this.toolStripComboBoxUmowy.Name = "toolStripComboBoxUmowy";
            this.toolStripComboBoxUmowy.Size = new System.Drawing.Size(300, 38);
            // 
            // toolStripLabel27
            // 
            this.toolStripLabel27.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripLabel27.Name = "toolStripLabel27";
            this.toolStripLabel27.Size = new System.Drawing.Size(193, 32);
            this.toolStripLabel27.Text = "Kończące się w tym";
            // 
            // TerminyUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tabControl1);
            this.Name = "TerminyUserControl";
            this.Padding = new System.Windows.Forms.Padding(20);
            this.Size = new System.Drawing.Size(1198, 639);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewGwarancje)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLicencje)).EndInit();
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewNaprawy)).EndInit();
            this.toolStrip4.ResumeLayout(false);
            this.toolStrip4.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUmowy)).EndInit();
            this.toolStrip3.ResumeLayout(false);
            this.toolStrip3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.ToolStrip toolStrip3;
        private System.Windows.Forms.ToolStripComboBox toolStripComboBoxUmowy;
        private System.Windows.Forms.ToolStripLabel toolStripLabel27;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripComboBox toolStripComboBoxGwarancje;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripComboBox toolStripComboBoxLicencje;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.ToolStrip toolStrip4;
        private System.Windows.Forms.ToolStripComboBox toolStripComboBoxNaprawy;
        private System.Windows.Forms.ToolStripLabel toolStripLabel3;
        private System.Windows.Forms.DataGridView dataGridViewGwarancje;
        private System.Windows.Forms.DataGridView dataGridViewLicencje;
        private System.Windows.Forms.DataGridView dataGridViewNaprawy;
        private System.Windows.Forms.DataGridView dataGridViewUmowy;
    }
}
