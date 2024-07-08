
namespace WinFormsApp90.Forms.Naprawy
{
    partial class NaprawaCreate
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

        #region Windows BaseForm Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent ()
        {
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label118 = new System.Windows.Forms.Label();
            this.dateTimePickerDataDokonaniaNaprawy = new System.Windows.Forms.DateTimePicker();
            this.comboBoxSprzet = new System.Windows.Forms.ComboBox();
            this.dateTimePickerDataWygasnieciaGwarancji = new System.Windows.Forms.DateTimePicker();
            this.comboBoxFirmy = new System.Windows.Forms.ComboBox();
            this.label41 = new System.Windows.Forms.Label();
            this.label122 = new System.Windows.Forms.Label();
            this.textBoxUwagi = new System.Windows.Forms.TextBox();
            this.label26 = new System.Windows.Forms.Label();
            this.label42 = new System.Windows.Forms.Label();
            this.textBoxCzasUdzielonejGwarancji = new System.Windows.Forms.TextBox();
            this.label40 = new System.Windows.Forms.Label();
            this.textBoxNumerSeryjny = new System.Windows.Forms.TextBox();
            this.label39 = new System.Windows.Forms.Label();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel3.Controls.Add(this.panel6);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1358, 100);
            this.panel3.TabIndex = 136;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel6.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel6.Location = new System.Drawing.Point(0, 95);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(1358, 5);
            this.panel6.TabIndex = 88;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(49, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(330, 38);
            this.label2.TabIndex = 87;
            this.label2.Text = "Dodawanie nowej firmy";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.panel5);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 642);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1358, 100);
            this.panel2.TabIndex = 135;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.button2);
            this.panel4.Controls.Add(this.button1);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel4.Location = new System.Drawing.Point(913, 5);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(445, 95);
            this.panel4.TabIndex = 107;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button2.Location = new System.Drawing.Point(230, 20);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(175, 52);
            this.button2.TabIndex = 93;
            this.button2.Text = "Zamknij";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(39, 20);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(175, 52);
            this.button1.TabIndex = 94;
            this.button1.Text = "Zapisz";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1358, 5);
            this.panel5.TabIndex = 108;
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.label118);
            this.panel1.Controls.Add(this.dateTimePickerDataDokonaniaNaprawy);
            this.panel1.Controls.Add(this.comboBoxSprzet);
            this.panel1.Controls.Add(this.dateTimePickerDataWygasnieciaGwarancji);
            this.panel1.Controls.Add(this.comboBoxFirmy);
            this.panel1.Controls.Add(this.label41);
            this.panel1.Controls.Add(this.label122);
            this.panel1.Controls.Add(this.textBoxUwagi);
            this.panel1.Controls.Add(this.label26);
            this.panel1.Controls.Add(this.label42);
            this.panel1.Controls.Add(this.textBoxCzasUdzielonejGwarancji);
            this.panel1.Controls.Add(this.label40);
            this.panel1.Controls.Add(this.textBoxNumerSeryjny);
            this.panel1.Controls.Add(this.label39);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 100);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1358, 542);
            this.panel1.TabIndex = 137;
            // 
            // label118
            // 
            this.label118.AutoSize = true;
            this.label118.Location = new System.Drawing.Point(49, 76);
            this.label118.Name = "label118";
            this.label118.Size = new System.Drawing.Size(150, 30);
            this.label118.TabIndex = 141;
            this.label118.Text = "Nazwa sprzętu";
            // 
            // dateTimePickerDataDokonaniaNaprawy
            // 
            this.dateTimePickerDataDokonaniaNaprawy.Location = new System.Drawing.Point(371, 190);
            this.dateTimePickerDataDokonaniaNaprawy.Name = "dateTimePickerDataDokonaniaNaprawy";
            this.dateTimePickerDataDokonaniaNaprawy.Size = new System.Drawing.Size(899, 35);
            this.dateTimePickerDataDokonaniaNaprawy.TabIndex = 88;
            // 
            // comboBoxSprzet
            // 
            this.comboBoxSprzet.FormattingEnabled = true;
            this.comboBoxSprzet.Location = new System.Drawing.Point(371, 73);
            this.comboBoxSprzet.Name = "comboBoxSprzet";
            this.comboBoxSprzet.Size = new System.Drawing.Size(899, 38);
            this.comboBoxSprzet.TabIndex = 139;
            this.comboBoxSprzet.SelectedIndexChanged += new System.EventHandler(this.comboBoxSprzet_SelectedIndexChanged);
            // 
            // dateTimePickerDataWygasnieciaGwarancji
            // 
            this.dateTimePickerDataWygasnieciaGwarancji.Enabled = false;
            this.dateTimePickerDataWygasnieciaGwarancji.Location = new System.Drawing.Point(371, 272);
            this.dateTimePickerDataWygasnieciaGwarancji.Name = "dateTimePickerDataWygasnieciaGwarancji";
            this.dateTimePickerDataWygasnieciaGwarancji.Size = new System.Drawing.Size(899, 35);
            this.dateTimePickerDataWygasnieciaGwarancji.TabIndex = 89;
            // 
            // comboBoxFirmy
            // 
            this.comboBoxFirmy.FormattingEnabled = true;
            this.comboBoxFirmy.Location = new System.Drawing.Point(371, 29);
            this.comboBoxFirmy.Name = "comboBoxFirmy";
            this.comboBoxFirmy.Size = new System.Drawing.Size(899, 38);
            this.comboBoxFirmy.TabIndex = 140;
            this.comboBoxFirmy.SelectedIndexChanged += new System.EventHandler(this.comboBoxFirmy_SelectedIndexChanged);
            // 
            // label41
            // 
            this.label41.AutoSize = true;
            this.label41.Location = new System.Drawing.Point(49, 234);
            this.label41.Name = "label41";
            this.label41.Size = new System.Drawing.Size(251, 30);
            this.label41.TabIndex = 79;
            this.label41.Text = "Czas udzielonej gwarancji";
            // 
            // label122
            // 
            this.label122.AutoSize = true;
            this.label122.Location = new System.Drawing.Point(49, 32);
            this.label122.Name = "label122";
            this.label122.Size = new System.Drawing.Size(216, 30);
            this.label122.TabIndex = 138;
            this.label122.Text = "Skrócona nazwa firmy";
            // 
            // textBoxUwagi
            // 
            this.textBoxUwagi.Location = new System.Drawing.Point(371, 313);
            this.textBoxUwagi.Multiline = true;
            this.textBoxUwagi.Name = "textBoxUwagi";
            this.textBoxUwagi.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxUwagi.Size = new System.Drawing.Size(899, 156);
            this.textBoxUwagi.TabIndex = 87;
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(49, 316);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(70, 30);
            this.label26.TabIndex = 80;
            this.label26.Text = "Uwagi";
            // 
            // label42
            // 
            this.label42.AutoSize = true;
            this.label42.Location = new System.Drawing.Point(49, 272);
            this.label42.Name = "label42";
            this.label42.Size = new System.Drawing.Size(268, 30);
            this.label42.TabIndex = 81;
            this.label42.Text = "Data wygaśnięcia gwarancji";
            // 
            // textBoxCzasUdzielonejGwarancji
            // 
            this.textBoxCzasUdzielonejGwarancji.Location = new System.Drawing.Point(371, 231);
            this.textBoxCzasUdzielonejGwarancji.Name = "textBoxCzasUdzielonejGwarancji";
            this.textBoxCzasUdzielonejGwarancji.Size = new System.Drawing.Size(899, 35);
            this.textBoxCzasUdzielonejGwarancji.TabIndex = 85;
            this.textBoxCzasUdzielonejGwarancji.TextChanged += new System.EventHandler(this.textBoxCzasUdzielonejGwarancji_TextChanged);
            // 
            // label40
            // 
            this.label40.AutoSize = true;
            this.label40.Location = new System.Drawing.Point(49, 193);
            this.label40.Name = "label40";
            this.label40.Size = new System.Drawing.Size(244, 30);
            this.label40.TabIndex = 82;
            this.label40.Text = "Data dokonania naprawy";
            // 
            // textBoxNumerSeryjny
            // 
            this.textBoxNumerSeryjny.Location = new System.Drawing.Point(371, 149);
            this.textBoxNumerSeryjny.Name = "textBoxNumerSeryjny";
            this.textBoxNumerSeryjny.ReadOnly = true;
            this.textBoxNumerSeryjny.Size = new System.Drawing.Size(899, 35);
            this.textBoxNumerSeryjny.TabIndex = 86;
            // 
            // label39
            // 
            this.label39.AutoSize = true;
            this.label39.Location = new System.Drawing.Point(49, 152);
            this.label39.Name = "label39";
            this.label39.Size = new System.Drawing.Size(147, 30);
            this.label39.TabIndex = 83;
            this.label39.Text = "Numer seryjny";
            // 
            // NaprawaCreate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1358, 742);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Name = "NaprawaCreate";
            this.Text = "NaprawaCreate";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.NaprawaCreate_Load);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DateTimePicker dateTimePickerDataDokonaniaNaprawy;
        private System.Windows.Forms.DateTimePicker dateTimePickerDataWygasnieciaGwarancji;
        private System.Windows.Forms.Label label41;
        private System.Windows.Forms.TextBox textBoxUwagi;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label label42;
        private System.Windows.Forms.TextBox textBoxCzasUdzielonejGwarancji;
        private System.Windows.Forms.Label label40;
        private System.Windows.Forms.TextBox textBoxNumerSeryjny;
        private System.Windows.Forms.Label label39;
        private System.Windows.Forms.Label label118;
        private System.Windows.Forms.ComboBox comboBoxSprzet;
        private System.Windows.Forms.ComboBox comboBoxFirmy;
        private System.Windows.Forms.Label label122;
    }
}