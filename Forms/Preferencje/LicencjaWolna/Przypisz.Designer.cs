﻿
namespace WinFormsApp90.Forms.Preferencje.LicencjaWolna
{
    partial class Przypisz
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
            this.textBoxUwagi = new System.Windows.Forms.TextBox();
            this.label123 = new System.Windows.Forms.Label();
            this.label118 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxKlucz = new System.Windows.Forms.TextBox();
            this.textBoxNazwaProgramu = new System.Windows.Forms.TextBox();
            this.label121 = new System.Windows.Forms.Label();
            this.comboBoxSprzet = new System.Windows.Forms.ComboBox();
            this.comboBoxFirmy = new System.Windows.Forms.ComboBox();
            this.label122 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dateTimePickerDataZakonczenia = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxUwagi
            // 
            this.textBoxUwagi.Location = new System.Drawing.Point(290, 307);
            this.textBoxUwagi.Multiline = true;
            this.textBoxUwagi.Name = "textBoxUwagi";
            this.textBoxUwagi.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxUwagi.Size = new System.Drawing.Size(692, 156);
            this.textBoxUwagi.TabIndex = 119;
            // 
            // label123
            // 
            this.label123.AutoSize = true;
            this.label123.Location = new System.Drawing.Point(48, 307);
            this.label123.Name = "label123";
            this.label123.Size = new System.Drawing.Size(70, 30);
            this.label123.TabIndex = 118;
            this.label123.Text = "Uwagi";
            // 
            // label118
            // 
            this.label118.AutoSize = true;
            this.label118.Location = new System.Drawing.Point(48, 90);
            this.label118.Name = "label118";
            this.label118.Size = new System.Drawing.Size(150, 30);
            this.label118.TabIndex = 115;
            this.label118.Text = "Nazwa sprzętu";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 227);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 30);
            this.label1.TabIndex = 116;
            this.label1.Text = "Klucz";
            // 
            // textBoxKlucz
            // 
            this.textBoxKlucz.Location = new System.Drawing.Point(290, 224);
            this.textBoxKlucz.Name = "textBoxKlucz";
            this.textBoxKlucz.ReadOnly = true;
            this.textBoxKlucz.Size = new System.Drawing.Size(692, 35);
            this.textBoxKlucz.TabIndex = 117;
            // 
            // textBoxNazwaProgramu
            // 
            this.textBoxNazwaProgramu.Location = new System.Drawing.Point(290, 183);
            this.textBoxNazwaProgramu.Name = "textBoxNazwaProgramu";
            this.textBoxNazwaProgramu.Size = new System.Drawing.Size(692, 35);
            this.textBoxNazwaProgramu.TabIndex = 117;
            // 
            // label121
            // 
            this.label121.AutoSize = true;
            this.label121.Location = new System.Drawing.Point(48, 186);
            this.label121.Name = "label121";
            this.label121.Size = new System.Drawing.Size(173, 30);
            this.label121.TabIndex = 116;
            this.label121.Text = "Nazwa programu";
            // 
            // comboBoxSprzet
            // 
            this.comboBoxSprzet.FormattingEnabled = true;
            this.comboBoxSprzet.Location = new System.Drawing.Point(290, 87);
            this.comboBoxSprzet.Name = "comboBoxSprzet";
            this.comboBoxSprzet.Size = new System.Drawing.Size(692, 38);
            this.comboBoxSprzet.TabIndex = 113;
            this.comboBoxSprzet.SelectedIndexChanged += new System.EventHandler(this.comboBoxSprzet_SelectedIndexChanged);
            // 
            // comboBoxFirmy
            // 
            this.comboBoxFirmy.FormattingEnabled = true;
            this.comboBoxFirmy.Location = new System.Drawing.Point(290, 43);
            this.comboBoxFirmy.Name = "comboBoxFirmy";
            this.comboBoxFirmy.Size = new System.Drawing.Size(692, 38);
            this.comboBoxFirmy.TabIndex = 114;
            this.comboBoxFirmy.SelectedIndexChanged += new System.EventHandler(this.comboBoxFirmy_SelectedIndexChanged);
            // 
            // label122
            // 
            this.label122.AutoSize = true;
            this.label122.Location = new System.Drawing.Point(48, 46);
            this.label122.Name = "label122";
            this.label122.Size = new System.Drawing.Size(216, 30);
            this.label122.TabIndex = 112;
            this.label122.Text = "Skrócona nazwa firmy";
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel6.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel6.Location = new System.Drawing.Point(0, 95);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(1101, 5);
            this.panel6.TabIndex = 88;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(49, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(301, 38);
            this.label2.TabIndex = 87;
            this.label2.Text = "Przypisywanie licencji";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.panel5);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 641);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1101, 100);
            this.panel2.TabIndex = 141;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.button2);
            this.panel4.Controls.Add(this.button1);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel4.Location = new System.Drawing.Point(656, 5);
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
            this.panel5.Size = new System.Drawing.Size(1101, 5);
            this.panel5.TabIndex = 108;
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.dateTimePickerDataZakonczenia);
            this.panel1.Controls.Add(this.textBoxUwagi);
            this.panel1.Controls.Add(this.label123);
            this.panel1.Controls.Add(this.label118);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.textBoxKlucz);
            this.panel1.Controls.Add(this.textBoxNazwaProgramu);
            this.panel1.Controls.Add(this.label121);
            this.panel1.Controls.Add(this.comboBoxSprzet);
            this.panel1.Controls.Add(this.comboBoxFirmy);
            this.panel1.Controls.Add(this.label122);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 100);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1101, 541);
            this.panel1.TabIndex = 143;
            // 
            // dateTimePickerDataZakonczenia
            // 
            this.dateTimePickerDataZakonczenia.Enabled = false;
            this.dateTimePickerDataZakonczenia.Location = new System.Drawing.Point(290, 266);
            this.dateTimePickerDataZakonczenia.Name = "dateTimePickerDataZakonczenia";
            this.dateTimePickerDataZakonczenia.Size = new System.Drawing.Size(692, 35);
            this.dateTimePickerDataZakonczenia.TabIndex = 120;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(48, 268);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(177, 30);
            this.label3.TabIndex = 116;
            this.label3.Text = "Data zakończenia";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel3.Controls.Add(this.panel6);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1101, 100);
            this.panel3.TabIndex = 142;
            // 
            // Przypisz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1101, 741);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Name = "Przypisz";
            this.Text = "Przypisz";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Przypisz_Load);
            this.panel2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxUwagi;
        private System.Windows.Forms.Label label123;
        private System.Windows.Forms.Label label118;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxKlucz;
        private System.Windows.Forms.TextBox textBoxNazwaProgramu;
        private System.Windows.Forms.Label label121;
        private System.Windows.Forms.ComboBox comboBoxSprzet;
        private System.Windows.Forms.ComboBox comboBoxFirmy;
        private System.Windows.Forms.Label label122;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DateTimePicker dateTimePickerDataZakonczenia;
        private System.Windows.Forms.Label label3;
    }
}