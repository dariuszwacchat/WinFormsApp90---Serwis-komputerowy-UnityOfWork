
namespace WinFormsApp90.Forms.Pracownicy
{
    partial class PracownikCreate
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
            this.label11 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelUprawnienia = new System.Windows.Forms.Panel();
            this.dateTimePickerDataUrodzenia = new System.Windows.Forms.DateTimePicker();
            this.listBoxZalaczniki = new System.Windows.Forms.ListBox();
            this.panel7 = new System.Windows.Forms.Panel();
            this.buttonUsun = new System.Windows.Forms.Button();
            this.buttonDodaj = new System.Windows.Forms.Button();
            this.textBoxNumerGG = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.textBoxAdresEmailSluzbowy = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxTelefonSluzbowy = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxPrywatnyTelefon = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxUwagi = new System.Windows.Forms.TextBox();
            this.textBoxAdresZamieszkania = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxNazwisko = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxImie = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
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
            this.panel3.Controls.Add(this.label11);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1230, 100);
            this.panel3.TabIndex = 136;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel6.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel6.Location = new System.Drawing.Point(0, 95);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(1230, 5);
            this.panel6.TabIndex = 88;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(49, 30);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(330, 38);
            this.label11.TabIndex = 87;
            this.label11.Text = "Dodawanie nowej firmy";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.panel5);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 714);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1230, 100);
            this.panel2.TabIndex = 135;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.button2);
            this.panel4.Controls.Add(this.button3);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel4.Location = new System.Drawing.Point(785, 5);
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
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button3.Location = new System.Drawing.Point(39, 20);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(175, 52);
            this.button3.TabIndex = 94;
            this.button3.Text = "Zapisz";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1230, 5);
            this.panel5.TabIndex = 108;
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.panelUprawnienia);
            this.panel1.Controls.Add(this.dateTimePickerDataUrodzenia);
            this.panel1.Controls.Add(this.listBoxZalaczniki);
            this.panel1.Controls.Add(this.panel7);
            this.panel1.Controls.Add(this.buttonUsun);
            this.panel1.Controls.Add(this.buttonDodaj);
            this.panel1.Controls.Add(this.textBoxNumerGG);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.textBoxAdresEmailSluzbowy);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.textBoxTelefonSluzbowy);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.textBoxPrywatnyTelefon);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.textBoxUwagi);
            this.panel1.Controls.Add(this.textBoxAdresZamieszkania);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.textBoxNazwisko);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.textBoxImie);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 100);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1230, 614);
            this.panel1.TabIndex = 137;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // panelUprawnienia
            // 
            this.panelUprawnienia.AutoScroll = true;
            this.panelUprawnienia.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelUprawnienia.Location = new System.Drawing.Point(314, 929);
            this.panelUprawnienia.Name = "panelUprawnienia";
            this.panelUprawnienia.Size = new System.Drawing.Size(813, 175);
            this.panelUprawnienia.TabIndex = 69;
            // 
            // dateTimePickerDataUrodzenia
            // 
            this.dateTimePickerDataUrodzenia.Location = new System.Drawing.Point(314, 127);
            this.dateTimePickerDataUrodzenia.Name = "dateTimePickerDataUrodzenia";
            this.dateTimePickerDataUrodzenia.Size = new System.Drawing.Size(813, 35);
            this.dateTimePickerDataUrodzenia.TabIndex = 68;
            // 
            // listBoxZalaczniki
            // 
            this.listBoxZalaczniki.FormattingEnabled = true;
            this.listBoxZalaczniki.ItemHeight = 30;
            this.listBoxZalaczniki.Location = new System.Drawing.Point(314, 658);
            this.listBoxZalaczniki.Name = "listBoxZalaczniki";
            this.listBoxZalaczniki.Size = new System.Drawing.Size(813, 154);
            this.listBoxZalaczniki.TabIndex = 67;
            // 
            // panel7
            // 
            this.panel7.Location = new System.Drawing.Point(12, 929);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(35, 235);
            this.panel7.TabIndex = 66;
            // 
            // buttonUsun
            // 
            this.buttonUsun.Location = new System.Drawing.Point(996, 818);
            this.buttonUsun.Name = "buttonUsun";
            this.buttonUsun.Size = new System.Drawing.Size(131, 40);
            this.buttonUsun.TabIndex = 65;
            this.buttonUsun.Text = "Usuń";
            this.buttonUsun.UseVisualStyleBackColor = true;
            this.buttonUsun.Click += new System.EventHandler(this.buttonUsun_Click);
            // 
            // buttonDodaj
            // 
            this.buttonDodaj.Location = new System.Drawing.Point(859, 818);
            this.buttonDodaj.Name = "buttonDodaj";
            this.buttonDodaj.Size = new System.Drawing.Size(131, 40);
            this.buttonDodaj.TabIndex = 65;
            this.buttonDodaj.Text = "Dodaj";
            this.buttonDodaj.UseVisualStyleBackColor = true;
            this.buttonDodaj.Click += new System.EventHandler(this.buttonDodaj_Click);
            // 
            // textBoxNumerGG
            // 
            this.textBoxNumerGG.Location = new System.Drawing.Point(314, 455);
            this.textBoxNumerGG.Name = "textBoxNumerGG";
            this.textBoxNumerGG.Size = new System.Drawing.Size(813, 35);
            this.textBoxNumerGG.TabIndex = 62;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(314, 870);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(128, 30);
            this.label12.TabIndex = 53;
            this.label12.Text = "Uprawnienia";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(49, 658);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(142, 30);
            this.label10.TabIndex = 53;
            this.label10.Text = "Dokument CV";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(49, 455);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(111, 30);
            this.label8.TabIndex = 52;
            this.label8.Text = "Numer GG";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(49, 496);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(70, 30);
            this.label9.TabIndex = 54;
            this.label9.Text = "Uwagi";
            // 
            // textBoxAdresEmailSluzbowy
            // 
            this.textBoxAdresEmailSluzbowy.Location = new System.Drawing.Point(314, 414);
            this.textBoxAdresEmailSluzbowy.Name = "textBoxAdresEmailSluzbowy";
            this.textBoxAdresEmailSluzbowy.Size = new System.Drawing.Size(813, 35);
            this.textBoxAdresEmailSluzbowy.TabIndex = 55;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(49, 414);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(214, 30);
            this.label7.TabIndex = 50;
            this.label7.Text = "Adres email służbowy";
            // 
            // textBoxTelefonSluzbowy
            // 
            this.textBoxTelefonSluzbowy.Location = new System.Drawing.Point(314, 373);
            this.textBoxTelefonSluzbowy.Name = "textBoxTelefonSluzbowy";
            this.textBoxTelefonSluzbowy.Size = new System.Drawing.Size(813, 35);
            this.textBoxTelefonSluzbowy.TabIndex = 57;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(49, 373);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(172, 30);
            this.label6.TabIndex = 45;
            this.label6.Text = "Telefon służbowy";
            // 
            // textBoxPrywatnyTelefon
            // 
            this.textBoxPrywatnyTelefon.Location = new System.Drawing.Point(314, 332);
            this.textBoxPrywatnyTelefon.Name = "textBoxPrywatnyTelefon";
            this.textBoxPrywatnyTelefon.Size = new System.Drawing.Size(813, 35);
            this.textBoxPrywatnyTelefon.TabIndex = 59;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(49, 332);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(168, 30);
            this.label5.TabIndex = 49;
            this.label5.Text = "Prywatny telefon";
            // 
            // textBoxUwagi
            // 
            this.textBoxUwagi.Location = new System.Drawing.Point(314, 496);
            this.textBoxUwagi.Multiline = true;
            this.textBoxUwagi.Name = "textBoxUwagi";
            this.textBoxUwagi.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxUwagi.Size = new System.Drawing.Size(813, 156);
            this.textBoxUwagi.TabIndex = 60;
            // 
            // textBoxAdresZamieszkania
            // 
            this.textBoxAdresZamieszkania.Location = new System.Drawing.Point(314, 168);
            this.textBoxAdresZamieszkania.Multiline = true;
            this.textBoxAdresZamieszkania.Name = "textBoxAdresZamieszkania";
            this.textBoxAdresZamieszkania.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxAdresZamieszkania.Size = new System.Drawing.Size(813, 156);
            this.textBoxAdresZamieszkania.TabIndex = 60;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(49, 168);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(195, 30);
            this.label4.TabIndex = 48;
            this.label4.Text = "Adres zamieszkania";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(49, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(155, 30);
            this.label3.TabIndex = 47;
            this.label3.Text = "Data urodzenia";
            // 
            // textBoxNazwisko
            // 
            this.textBoxNazwisko.Location = new System.Drawing.Point(314, 86);
            this.textBoxNazwisko.Name = "textBoxNazwisko";
            this.textBoxNazwisko.Size = new System.Drawing.Size(813, 35);
            this.textBoxNazwisko.TabIndex = 63;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(49, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 30);
            this.label2.TabIndex = 46;
            this.label2.Text = "Nazwisko";
            // 
            // textBoxImie
            // 
            this.textBoxImie.Location = new System.Drawing.Point(314, 45);
            this.textBoxImie.Name = "textBoxImie";
            this.textBoxImie.Size = new System.Drawing.Size(813, 35);
            this.textBoxImie.TabIndex = 58;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 30);
            this.label1.TabIndex = 51;
            this.label1.Text = "Imię";
            // 
            // PracownikCreate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1230, 814);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Name = "PracownikCreate";
            this.Text = "PracownikCreate";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.PracownikCreate_Load);
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
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListBox listBoxZalaczniki;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Button buttonUsun;
        private System.Windows.Forms.Button buttonDodaj;
        private System.Windows.Forms.TextBox textBoxNumerGG;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBoxAdresEmailSluzbowy;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxTelefonSluzbowy;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxPrywatnyTelefon;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxAdresZamieszkania;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxNazwisko;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxImie;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxUwagi;
        private System.Windows.Forms.DateTimePicker dateTimePickerDataUrodzenia;
        private System.Windows.Forms.Panel panelUprawnienia;
        private System.Windows.Forms.Label label12;
    }
}